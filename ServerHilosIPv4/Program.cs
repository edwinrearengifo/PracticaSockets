using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ServerHilosIPv4
{
    class Program
    {
        Socket socketEscucha = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketCliente;

        static void Main(string[] args)
        {
            new Program();
            Console.Read();
        }

        public Program()
        {
            IPAddress[] direccionesIP = Dns.GetHostAddresses(Dns.GetHostName());
            IPAddress direccionServidor = direccionesIP[0];
            Console.WriteLine("Direcciones IP: ");
            foreach (IPAddress ip in direccionesIP)
            {
                Console.WriteLine(" * {0}", ip);
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    if (!ip.Equals("127.0.01"))
                        direccionServidor = ip;
                    Console.WriteLine("El servidor está escuchando en la dirección {0}, puerto 8080 ", ip);
                }
            }

            IPEndPoint ipServidor = new IPEndPoint(direccionServidor, 8080);
            socketEscucha.Bind(ipServidor);
            Console.WriteLine("El servidor enlazó el socket...");
            Thread hiloEscucha = new Thread(new ThreadStart(Escuchar));
            hiloEscucha.IsBackground = true;
            hiloEscucha.Start();
        }
        private void Escuchar()
        {
            while (true)
            {

                socketEscucha.Listen(-1);
                Console.WriteLine("El servidor entra en espéra de conexiones...");
                socketCliente = socketEscucha.Accept();
                Console.WriteLine("El servidor ha recibido a un cliente...");
                if (socketCliente.Connected)
                {

                    Thread hiloCliente = new Thread(new ThreadStart(Recibir));
                    hiloCliente.IsBackground = true;
                    hiloCliente.Start();
                }
            }
        }

        private void Recibir()
        {
            Socket socketC = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
            lock (this)
            {
                socketC = socketCliente;
            }
            Console.WriteLine("Recibiendo datos...");
            while (true)
            {
                int cantidadBytesRecibidos = 0;
                byte[] bytesRecibidos = new byte[50];
                try
                {
                    cantidadBytesRecibidos = socketC.Receive(bytesRecibidos);
                    if (cantidadBytesRecibidos != 0)
                    {
                        Console.WriteLine(Encoding.ASCII.GetString(bytesRecibidos));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                if (!socketC.Connected)
                    break;
            }
        }
    }
}

