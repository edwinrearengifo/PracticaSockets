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
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexionCliente gestor = new ConexionCliente(new frmCliente());
            ((frmCliente)gestor.ObtenerVista()).EstablecerGestorCliente(gestor);
            gestor.EspecificarLog(((frmCliente)gestor.ObtenerVista()).ManejoLog);
            Application.Run(gestor.ObtenerVista());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmCliente());
        }
    }

    public enum estadoConexion
    {
        ok = 0,
        problemaDns = 1,
        problemaConSocket = 2,
        problemaConDns_y_Socket = 3,
        errorDeRedOInalcanzable = 4
    }

    public class ConexionCliente
    {
        IPAddress direccionServidor;
        int puerto = 0;
        IPEndPoint sitioRemoto;
        TcpClient cliente;
        Form formularioCliente = null;
        private ManejoLog log;

        public ConexionCliente(Form formularioCliente)
        {
            this.formularioCliente = formularioCliente;
        }
        ~ConexionCliente()
        {
            if (cliente != null)
            {
                if (cliente.Connected)
                    cliente.Close();
            }
        }

        public void EspecificarLog(ManejoLog log)
        {
            this.log = log;
        }

        public void Traza(string msg)
        {
            StackTrace traza = new StackTrace(false);
            string metodoUsado = traza.GetFrame(1).GetMethod().Name;
            log(metodoUsado + " : " + msg + "\r\n");
        }

        public Form ObtenerVista()
        {
            return formularioCliente;
        }

        private estadoConexion ObtenerError(estadoConexion actual, estadoConexion siguiente)
        {
            Traza("Error Detectado");
            if (actual == estadoConexion.ok)
                return siguiente;
            if (actual == estadoConexion.problemaDns)
            {
                if (siguiente == estadoConexion.problemaConSocket)
                {
                    return estadoConexion.problemaConDns_y_Socket;
                }
                else
                {
                    return siguiente;
                }
            }
            return siguiente;
        }

        public String ObtenerResultadoPruebaConexion()
        {
            return PruebaConexion().ToString();
        }
        private estadoConexion PruebaConexion()
        {
            Traza("Prueba de Conexión de Cliente");
            estadoConexion resultado = estadoConexion.ok;
            String testHttp = "GET /index.html HTTP/1.0\n\n";
            //String testHttp = "47 45 54 20 2f 69 6e 64 65 78 2e 68 74 6d 6c 20 48 54 54 50 2f 31 2e 30 20 a a";
            String httpDoc = null;
            int cantRecibida = 0;
            Byte[] bytesParaEnviar = Encoding.ASCII.GetBytes(testHttp);
            Byte[] bytesParaRecibir = new Byte[1024];
            string nombre = "";
            IPAddress IPPrueba = null;
            IPEndPoint extremoPrueba = null;
            TcpClient clientePrueba = null;
            try
            {
                IPPrueba = Dns.GetHostEntry("www.epn.edu.ec").AddressList[0];
                extremoPrueba = new IPEndPoint(IPPrueba, 80);
            }
            catch (Exception)
            {
                Traza("Parece que el DNS no funciona...");
                resultado = ObtenerError(resultado, estadoConexion.problemaDns);
            }
            try
            {
                nombre = ((IPHostEntry)Dns.GetHostEntry("163.117.139.128")).HostName;
                cliente = new TcpClient();
            }
            catch (Exception)
            {
                Traza("Problemas con los sockets...");
                return ObtenerError(resultado, estadoConexion.problemaConSocket);
            }
            try
            {
                cliente.Connect(extremoPrueba);
                NetworkStream flujo = cliente.GetStream();
                flujo.Write(bytesParaEnviar, 0, bytesParaEnviar.Length);
                cantRecibida = flujo.Read(bytesParaRecibir, 0, bytesParaRecibir.Length);
            }
            catch (Exception)
            {
                Traza("Error en la conexión...");
                return ObtenerError(resultado, estadoConexion.errorDeRedOInalcanzable);
            }
            httpDoc = Encoding.ASCII.GetString(bytesParaRecibir, 0, cantRecibida);
            Traza("Prueba finalizada");
            return resultado;
        }

        public void EspecificarServidor(String direccionIP)
        {
            direccionServidor = Dns.GetHostEntry(direccionIP).AddressList[0];
        }
        public void EspecificarPuertoServidor(String puerto)
        {
            int resultado = 0;
            try
            {
                int.TryParse(puerto, out resultado);
                this.puerto = resultado;
            }
            catch (Exception)
            {
                Traza("Está correcto el puerto?");
            }
        }
        public IPAddress ObtenerDireccionIP(String nombreEquipo)
        {
            return Dns.GetHostEntry(nombreEquipo).AddressList[0];
        }

        public void Conectar()
        {
            try
            {
                if (cliente != null)
                    if (cliente.Connected)
                    {
                        Traza("Cerrando conexiones...");
                        cliente.Client.Disconnect(true);
                    }
                Traza("Creando un endpoint...");
                sitioRemoto = new IPEndPoint(direccionServidor, puerto);
                Traza("Creando el socket...");
                cliente = new TcpClient();
                Traza("Conectando...");
                cliente.Connect(sitioRemoto);
            }
            catch (Exception ex)
            {
                Traza("Error en la conexión" + ex.Message);
            }
        }

        public int EnviarRecibir(byte[] buferTx, ref byte[] buferRx)
        {
            try
            {
                int bytes_obtenidos = 0;
                NetworkStream flujo = cliente.GetStream();
                flujo.Write(buferTx, 0, buferTx.Length);
                bytes_obtenidos = flujo.Read(buferRx, 0, buferRx.Length);
                return bytes_obtenidos;
            }
            catch (SocketException sExec)
            {
                Traza("Error: " + sExec.Message);
            }
            return 0;
        }

    }
}
