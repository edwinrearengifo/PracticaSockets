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

namespace Client
{
    public delegate void ManejoLog(string msg);

    public partial class frmCliente : Form
    {
        ConexionCliente gestorCliente = null;
        byte[] bufferTx;
        byte[] bufferRx = new byte[2048];

        public frmCliente()
        {
            InitializeComponent();
        }

        public void EstablecerGestorCliente(ConexionCliente gestor)
        {
            this.gestorCliente = gestor;
        }
        public void ManejoLog(string msg)
        {
            txtLog.AppendText(msg);
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = gestorCliente.ObtenerResultadoPruebaConexion();
        }

        private void btnActualizarBinario_Click(object sender, EventArgs e)
        {
            bufferTx = null;
            txtBinarioEnviar.Text = "";
            String datosAEnviar = "";
            int posicion = -1;
            if (chkTexto.Checked && txtTextoAEnviar.Text.Length != 0)
            {
                if (txtTextoAEnviar.Text.IndexOf("\\n") != -1)
                {
                    String[] subs = txtTextoAEnviar.Text.Split(new String[] { "\\n" },
                                                               StringSplitOptions.None);
                    for (int i = 0; i < subs.Length; i++)
                    {
                        if (subs[i].Equals(""))
                            datosAEnviar += "\n";
                        else
                            datosAEnviar += subs[i];
                    }
                }
                else
                    datosAEnviar = txtTextoAEnviar.Text;
                bufferTx = Encoding.ASCII.GetBytes(datosAEnviar);
            }
            else
            {
                if (txtTextoAEnviar.Text.Length >= 2)
                {
                    string delimitador = " ";
                    byte resultado = 0x00;
                    char[] numero;
                    string[] cadenaDeDatos = txtTextoAEnviar.Text.Split(delimitador.ToCharArray());
                    bufferTx = new byte[cadenaDeDatos.Length];
                    for (int i = 0; i < cadenaDeDatos.Length; i++)
                    {
                        try
                        {
                            numero = cadenaDeDatos[i].ToCharArray();
                            if (numero.Length != 2)
                                throw new Exception("");
                            byte.TryParse(numero[0].ToString(), out resultado);
                            bufferTx[i] = (byte)(resultado << 4);
                            byte.TryParse(numero[1].ToString(), out resultado);
                            bufferTx[i] |= (byte)resultado;
                        }
                        catch (Exception)
                        {
                            gestorCliente.Traza("Hay un error en el formato, recuerda: si es binario, debes escribir, 12 34 AB, siendo estos numeros hexadecimales");
                        }
                    }
                }
            }
            if (bufferTx != null)
                for (int i = 0; i < bufferTx.Length; i++)
                {
                    txtBinarioEnviar.AppendText(bufferTx[i].ToString("x") + " ");
                }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text.Length > 0)
            {
                txtIPServidor.Text = gestorCliente.ObtenerDireccionIP(txtServidor.Text).ToString();
            }
            else
                gestorCliente.Traza("Por favor incluye el nombre del servidor");
        }

        private void bntConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIPServidor.Text.Length != 0 && txtServidor.Text.Length != 0 && txtPuerto.Text.Length != 0)
                {
                    gestorCliente.EspecificarServidor(txtServidor.Text);
                    gestorCliente.EspecificarPuertoServidor(txtPuerto.Text);
                    gestorCliente.Conectar();
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                gestorCliente.Traza("Por favor comprueba la dirección IP o el nombre de servidor");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int recibidos = gestorCliente.EnviarRecibir(bufferTx, ref bufferRx);
            gestorCliente.Traza("Recibidos: " + recibidos + " bytes");
            txtRecibidoBinario.Text = "";
            for (int i = 0; i < recibidos; i++)
            {
                txtRecibidoBinario.AppendText(bufferRx[i].ToString("X"));
            }
            String respuesta = Encoding.ASCII.GetString(bufferRx, 0, recibidos);
            txtRespuesta.Text = "";
            txtRespuesta.AppendText(respuesta);

        }
    }
}
