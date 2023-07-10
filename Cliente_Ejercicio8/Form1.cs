// ************************************************************************
// Practica 4
// Edwin Rea - Mario Vela
// Fecha de realización: 12/06/2023
// Fecha de entrega: 19/06/2023
// Resultados:
// * El programa permite mostrar la comunicación entre dos equipos haciendo uso de sockets y protocolos UDP y TCP
// Conclusiones:
// * Edwin Rea
// 1. Al realizar los programas detallados para este documento, se puede describir una de las
// funciones principales de un socket, el cual, para la comunicación en una red, permite establecer
// una conexión entre diferentes dispositivos en una red, mediante Internet o una red local. Además,
// proporciona una forma estandarizada y flexible de intercambiar datos entre cliente y servidor.
// 2. La importancia del uso de sockets se ve asociado también al uso de protocolos de transporte
// como UDP y TCP, al desarrollar programas de conexión junto a estos protocolos, estos garantizan
// la entrega de los datos de manera fiable y rápida dependiendo de las características de cada
// protocolo. Y queda detallado que al generar esta comunicación entre equipos, la conexión es de
// punto a punto entre dos hosts, pero inmediatamente uno actúa como servidor a la espera de solicitudes
// de conexión y el otro actúa como cliente que inicia la conexión.
// * Mario Vela
// 1. 
// 2.
// Recomendaciones:
// * Edwin Rea
// 1. Es necesario configurar el orden del inicio de ejecución de los programas de acuerdo con lo
// que se requiera realizar, por ejemplo, si se ejecutan estos programas en distintas computadoras,
// el primer requisito es que estén en la misma red, luego se debe decidir previamente a la conexión,
// cuál de ellos actúa como servidor y cliente, para que se pueda ejecutar el programa adecuado en cada equipo.
// 2. Si se requiere hacer un proyecto completo en donde a medida que se van implementando las
// funcionalidades del programa, es necesario agregar las suficientes clases dentro de una biblioteca
// de clases en donde se detalle y describan los elementos necesarios junto con los atributos y métodos
// que serán usados recursivamente por el resto del proyecto. Esto también es de gran utilidad para tener
// un programa bien estructurado y sea fácil de ubicar cada estructura del código.
// * Mario Vela
// 1. 
// 2. 
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Protocolo;
using System.Net.Sockets;
using System.Net;

namespace Cliente_Ejercicio8
{
    // Clase parcial Form1 que representa la ventana principal del cliente
    public partial class Form1 : Form
    {
        // Declaración de variables miembro
        public Form1()
        {
            InitializeComponent();
        }
        private Socket socketCliente; // Objeto Socket utilizado para la comunicación
        private string nombre; // Nombre del cliente
        private EndPoint epServidor; // Punto de conexión con el servidor
        private byte[] buferRx = new byte[1024]; // Búfer para recibir datos
        // Delegado utilizado para actualizar el mensaje en el formulario
        private delegate void DelegadoMensajeActualizacion(string mensaje);
        // Instancia del delegado
        private DelegadoMensajeActualizacion delegadoActualizacion = null;

        // Método de evento para el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Método de evento para el formulario "Cliente_Load"
        private void Cliente_Load(object sender, EventArgs e)
        {
            delegadoActualizacion = new DelegadoMensajeActualizacion(DesplegarMensaje);
        }
        // Método de evento para el botón "Enviar"
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto Paquete con los datos a enviar
                Paquete paqueteParaEnviar = new Paquete();
                paqueteParaEnviar.NombreChat = nombre;
                paqueteParaEnviar.MensajeChat = txtMensajeParaEnviar.Text.Trim();
                paqueteParaEnviar.IdentificadorChat = IdentificadorDato.Mensaje;
                // Convertir el paquete en un arreglo de bytes
                byte[] arregloBytes = paqueteParaEnviar.ObtenerArregloBytes();
                // Iniciar el envío de datos asincrónico utilizando el socketCliente
                socketCliente.BeginSendTo(arregloBytes, 0, arregloBytes.Length, SocketFlags.None, epServidor, new AsyncCallback(ProcesarEnviar), null);
                // Limpiar el cuadro de texto para enviar mensajes
                txtMensajeParaEnviar.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar: " + ex.Message, "Cliente UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método de evento para el botón "Conectar"
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre del cliente desde el cuadro de texto
                nombre = txtNombre.Text.Trim();
                // Crear un paquete de inicio para conectarse al servidor
                Paquete paqueteInicio = new Paquete();
                paqueteInicio.NombreChat = nombre;
                paqueteInicio.MensajeChat = null;
                paqueteInicio.IdentificadorChat = IdentificadorDato.Conectado;
                // Crear un objeto Socket para la comunicación UDP
                socketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                // Obtener la dirección IP del servidor desde el cuadro de texto
                IPAddress servidorIP = IPAddress.Parse(txtServidor.Text.Trim());
                // Crear un punto remoto (servidor) con la dirección IP y el puerto
                IPEndPoint puntoRemoto = new IPEndPoint(servidorIP, 30000);
                epServidor = (EndPoint)puntoRemoto;
                // Convertir el paquete de inicio en un arreglo de bytes
                byte[] buferTx = paqueteInicio.ObtenerArregloBytes();

                // Iniciar el envío de datos asincrónico utilizando el socketCliente
                socketCliente.BeginSendTo(buferTx, 0, buferTx.Length, SocketFlags.None, epServidor, new AsyncCallback(ProcesarEnviar), null);

                // Reiniciar el búfer de recepción
                buferRx = new byte[1024];

                // Iniciar la recepción de datos asincrónica utilizando el socketCliente
                socketCliente.BeginReceiveFrom(buferRx, 0, buferRx.Length, SocketFlags.None, ref epServidor, new AsyncCallback(this.ProcesarRecibir), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse: " + ex.Message, "Cliente UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método que procesa la finalización del envío de datos asincrónico
        private void ProcesarEnviar(IAsyncResult res)
        {
            try
            {
                socketCliente.EndSend(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enviar Datos: " + ex.Message, "Cliente UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que procesa la finalización de la recepción de datos asincrónica
        private void ProcesarRecibir(IAsyncResult res)
        {
            try
            {
                socketCliente.EndReceive(res);

                // Crear un objeto Paquete a partir del búfer recibido
                Paquete paqueteRecibido = new Paquete(buferRx);

                // Si el paquete contiene un mensaje, invocar el delegado para actualizar el mensaje en el formulario
                if (paqueteRecibido.MensajeChat != null)
                    Invoke(delegadoActualizacion, new object[] { paqueteRecibido.MensajeChat });

                // Reiniciar el búfer de recepción
                buferRx = new byte[1024];

                // Iniciar la recepción de datos asincrónica utilizando el socketCliente
                socketCliente.BeginReceiveFrom(buferRx, 0, buferRx.Length, SocketFlags.None, ref epServidor, new AsyncCallback(ProcesarRecibir), null);
            }
            catch (ObjectDisposedException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Recibidos: " + ex.Message, "Cliente UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para desplegar un mensaje en el cuadro de texto rxtMensajes
        private void DesplegarMensaje(string mensaje)
        {
            rxtMensajes.Text += mensaje + Environment.NewLine;
        }

        // Método de evento para el formulario "Form1_FormClosing_1"
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.socketCliente != null)
                {
                    // Crear un paquete de salida para indicar que el cliente se desconecta
                    Paquete paqueteSalida = new Paquete();
                    paqueteSalida.IdentificadorChat = IdentificadorDato.Desconectado;
                    paqueteSalida.NombreChat = nombre;
                    paqueteSalida.MensajeChat = null;

                    // Convertir el paquete de salida en un arreglo de bytes
                    byte[] buferTx = paqueteSalida.ObtenerArregloBytes();

                    // Enviar el paquete de salida al servidor
                    socketCliente.SendTo(buferTx, 0, buferTx.Length, SocketFlags.None, epServidor);

                    // Cerrar el socketCliente
                    socketCliente.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar: " + ex.Message, "Cliente UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método de evento para el formulario "Form1_Load_1"
        private void Form1_Load_1(object sender, EventArgs e)
        {
            delegadoActualizacion = new DelegadoMensajeActualizacion(DesplegarMensaje);
        }

        // Método de evento para el cambio en el cuadro de texto rxtMensajes
        private void rxtMensajes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}