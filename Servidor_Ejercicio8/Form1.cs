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
using System.Net;
using System.Collections;
using System.Net.Sockets;


namespace Servidor_Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList listaClientes;
        private Socket socketServidor;
        private byte[] buferRx = new byte[1024];
        private delegate void DelegadoActualizarEstado(string estado);
        private DelegadoActualizarEstado delegadoActualizarEstado = null;
        private struct Cliente
        {
            public EndPoint puntoExtremo;
            public string nombre;
        }

        private void ProcesarRecibir(IAsyncResult resultadoAsync)
        {
            try
            {
                //byte[] data;
                Paquete datoRecibido = new Paquete(buferRx);
                Paquete datoParaEnviar = new Paquete();
                IPEndPoint puntoExtremoCliente = new IPEndPoint(IPAddress.Any, 0);
                EndPoint extremoEP = (EndPoint)puntoExtremoCliente;
                socketServidor.EndReceiveFrom(resultadoAsync, ref extremoEP);
                datoParaEnviar.IdentificadorChat = datoRecibido.IdentificadorChat;
                datoParaEnviar.NombreChat = datoRecibido.NombreChat;
                switch (datoRecibido.IdentificadorChat)
                {
                    case IdentificadorDato.Mensaje:
                        datoParaEnviar.MensajeChat = string.Format("{0}: {1}", datoRecibido.NombreChat, datoRecibido.MensajeChat);
                        break;
                    case IdentificadorDato.Conectado:
                        Cliente nuevoCliente = new Cliente();
                        nuevoCliente.puntoExtremo = extremoEP;
                        nuevoCliente.nombre = datoRecibido.NombreChat;
                        listaClientes.Add(nuevoCliente);
                        datoParaEnviar.MensajeChat = string.Format("-- {0} está conectado --", datoRecibido.NombreChat);
                        break;
                    case IdentificadorDato.Desconectado:
                        foreach (Cliente c in listaClientes)
                        {
                            if (c.puntoExtremo.Equals(extremoEP))
                            {
                                listaClientes.Remove(c);
                                break;
                            }
                        }
                        datoParaEnviar.MensajeChat = string.Format("-- {0} se ha desconectado -- ", datoRecibido.NombreChat);
                        break;
                }
                socketServidor.BeginReceiveFrom(buferRx, 0, buferRx.Length, SocketFlags.None, ref extremoEP, new AsyncCallback(ProcesarRecibir), extremoEP);
                Invoke(delegadoActualizarEstado, new object[] { datoParaEnviar.MensajeChat });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la recepción: " + ex.Message, "Servidor UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProcesarEnviar(IAsyncResult resultadoAsync)
        {
            try
            {
                socketServidor.EndSend(resultadoAsync);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos: " + ex.Message, "Servidor UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            socketServidor.Close();
            Close();
        }
        private void ActualizarEstado(string estado)
        {
            rxtInformación.Text += estado + Environment.NewLine;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                listaClientes = new ArrayList();
                delegadoActualizarEstado = new DelegadoActualizarEstado(ActualizarEstado);
                socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint servidorExtremo = new IPEndPoint(IPAddress.Any, 30000);
                socketServidor.Bind(servidorExtremo);
                IPEndPoint clienteExtremo = new IPEndPoint(IPAddress.Any, 0);
                EndPoint extremoEP = (EndPoint)clienteExtremo;
                socketServidor.BeginReceiveFrom(buferRx, 0, buferRx.Length, SocketFlags.None, ref extremoEP, new AsyncCallback(ProcesarRecibir), extremoEP);
                lblEstado.Text = "Escuchando";
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error";
                MessageBox.Show("Cargando Error: " + ex.Message, "Servidor UDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
