// ************************************************************************
// Practica 04 - Parte 2
// Carlos León - José Montero - Joel Del Hierro
// Fecha de realización: 16/12/2022
// Fecha de entrega: 23/12/2022
// Resultados, conclusiones y Recomendaciones en el Program de la clase Servidor
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Codificador;

namespace Cliente
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Porción del código original (De la hoja guía)
            //Console.WriteLine("Cliente \n");
            Thread.Sleep(500);
            IPAddress servidor = IPAddress.Parse("127.0.0.1");
            int puerto = 8080;
            IPEndPoint extremo = new IPEndPoint(servidor, puerto);
            TcpClient cliente = new TcpClient();
            cliente.Connect(extremo);
            NetworkStream flujoRed = cliente.GetStream();
            Elemento elemento = new Elemento(1234567890987654L, "Cadena de Bicicleta", 18,
            1000, true, false);
            //Modificación de la descripción del elemento para efectos de pruebas y comentar resultados (punto 2)
            //Elemento elemento = new Elemento(1234567890987654L, "Cadena de Pruebas - Aplicaciones Distribuidas", 18,
            //1000, true, false);
            CodificadorTexto codificador = new CodificadorTexto();
            byte[] datosCodificados = codificador.Codificar(elemento);
            Console.WriteLine("Enviando elemento codificado en texto (" +
            datosCodificados.Length + " bytes): ");
            Console.WriteLine(elemento);
            flujoRed.Write(datosCodificados, 0, datosCodificados.Length);

            DecodificadorBinario decodificador = new DecodificadorBinario(); 
            Elemento elementoRecibido = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un elemento codificado en formato binario:");
            Console.WriteLine(elementoRecibido);

            //Modificación para enviar y recibir un segundo elemento
            Elemento elemento2 = new Elemento(1234567890987654L, "Segunda Cadena de Bicicleta", 20,
            1000, true, false);
            byte[] datosCodificados2 = codificador.Codificar(elemento2);
            Console.WriteLine("Enviando un segundo elemento codificado en texto (" +
            datosCodificados2.Length + " bytes): ");
            Console.WriteLine(elemento2);
            flujoRed.Write(datosCodificados2, 0, datosCodificados2.Length);
            Elemento elementoRecibido2 = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un segundo elemento codificado en formato binario:");
            Console.WriteLine(elementoRecibido2);
            */

            //Modificación para enviar dos elementos y recibir dos elementos
            //Console.WriteLine("Cliente \n");
            Thread.Sleep(500);
            IPAddress servidor = IPAddress.Parse("127.0.0.1");
            int puerto = 8080;
            IPEndPoint extremo = new IPEndPoint(servidor, puerto);
            TcpClient cliente = new TcpClient();
            cliente.Connect(extremo);
            NetworkStream flujoRed = cliente.GetStream();
            //Primer Elemento a enviar
            Elemento elemento = new Elemento(1234567890987654L, "Cadena de Bicicleta", 18,
            1000, true, false);
            //Segundo Elemento a enviar
            Elemento elemento2 = new Elemento(1234567890987654L, "Segunda Cadena de Bicicleta", 20,
            1000, true, false);

            CodificadorTexto codificador = new CodificadorTexto();
            //Codificar en texto el primer elemento que se va a enviar al servidor
            byte[] datosCodificados = codificador.Codificar(elemento);
            Console.WriteLine("Enviando el Primer elemento codificado en texto (" +
            datosCodificados.Length + " bytes): ");
            Console.WriteLine(elemento);
            //Enviar los datos codificados en texto del primer elemento
            flujoRed.Write(datosCodificados, 0, datosCodificados.Length);

            //Codificar en texto el segundo elemento que se va a enviar al servidor
            byte[] datosCodificados2 = codificador.Codificar(elemento2);
            Console.WriteLine("Enviando el Segundo elemento codificado en texto (" +
            datosCodificados2.Length + " bytes): ");
            Console.WriteLine(elemento2);
            //Enviar los datos codificados en texto del segundo elemento
            flujoRed.Write(datosCodificados2, 0, datosCodificados2.Length);

            DecodificadorBinario decodificador = new DecodificadorBinario();
            //Decodificar el Primer Elemento enviado por el servidor (que estaba codificado en binario)
            Elemento elementoRecibido = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un elemento codificado en formato binario:");
            Console.WriteLine(elementoRecibido);

            //Decodificar el Segundo Elemento enviado por el servidor (que estaba codificado en binario)
            Elemento elementoRecibido2 = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un segundo elemento codificado en formato binario:");
            Console.WriteLine(elementoRecibido2);
            Console.ReadLine();
            flujoRed.Close();
            cliente.Close();

        }
    }
}
