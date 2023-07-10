// ************************************************************************
// Practica 04 - Parte 2
// Carlos León - José Montero - Joel Del Hierro
// Fecha de realización: 16/12/2022
// Fecha de entrega: 23/12/2022
// Resultados:
// 1. Ejecutando el código tal cual está en la hoja guía de la práctica se observa que
//    enviar el elemento en codificación binaria representa una reducción de 10 bytes
//    con respecto a enviar la información con codificación en texto.
// 2. Cambiando la descripción del elemento enviado desde el cliente, aumentan o disminuyen
//    los bytes a enviarse con respecto a si aumento o disminuyo el contenido de la descripción,
//    pero se sigue manteniendo la reducción de 10 bytes en la codificación binaria con
//    respecto a la codificación en texto.
// 3. Se pudo enviar dos elementos del cliente al servidor y que este lo reciba correctamente
//    y en orden del que fueron enviados. Además, el cliente tambien recepta los dos elementos
//    en orden y sin problema alguno.
// Conclusiones:
// * De la forma en que están codificadas las funciones Codificar() y Decodificar() se pudo
//   realizar el envio de los elementos desde el cliente y estos fueron receptados por el
//   servidor correctamente y en orden en el que fueron enviados.
// * Se podría realizar para el envío de más de dos paquetes desde el cliente y que estos
//   sean recibidos en el servidor en orden y sin inconvenientes pero se tendría que considerar
//   el uso de un bucle para evitar reescritura de código de forma innecesaria.
// Recomendaciones:
// * Para la realización de esta práctica se recomienda que se pida modificar el contenido o
//   descripción del Elemento para así ver la cantidad de  bytes que se envian y la diferencia
//   que se tiene cuando se codifica en binario y en texto.
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Codificador;

namespace Servidor
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Porción del código original (De la hoja guía)
            int puerto = 8080;
            TcpListener socketEscucha = new TcpListener(IPAddress.Any, puerto);
            socketEscucha.Start();
            TcpClient cliente = socketEscucha.AcceptTcpClient();
            DecodificadorTexto decodificador = new DecodificadorTexto();
            Elemento elemento = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un elemento codificado en texto:");
            Console.WriteLine(elemento);
            CodificadorBinario codificador = new CodificadorBinario();
            elemento.precio += 10;
            Console.Write("Enviando elemento en binario...");
            byte[] bytesParaEnviar = codificador.Codificar(elemento);
            Console.WriteLine("(" + bytesParaEnviar.Length + " bytes): ");
            cliente.GetStream().Write(bytesParaEnviar, 0, bytesParaEnviar.Length);

            //Modificación para enviar y recibir un segundo elemento
            Elemento elemento2 = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un segundo elemento codificado en texto:");
            Console.WriteLine(elemento2);
            elemento2.precio += 10;
            Console.Write("Enviando el segundo elemento en binario...");
            byte[] bytesParaEnviar2 = codificador.Codificar(elemento2);
            Console.WriteLine("(" + bytesParaEnviar2.Length + " bytes): ");
            cliente.GetStream().Write(bytesParaEnviar2, 0, bytesParaEnviar2.Length);
            */

            ///*
            //Modificación para enviar dos elementos y recibir dos elementos
            int puerto = 8080;
            TcpListener socketEscucha = new TcpListener(IPAddress.Any, puerto);
            socketEscucha.Start();
            TcpClient cliente = socketEscucha.AcceptTcpClient();
            DecodificadorTexto decodificador = new DecodificadorTexto();
            //Decodificar el Primer Elemento enviado por el cliente (que estaba codificado en texto)
            Elemento elemento = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un elemento codificado en texto:");
            Console.WriteLine(elemento);

            //Decodificar el Segundo Elemento enviado por el cliente (que estaba codificado en texto)
            Elemento elemento2 = decodificador.Decodificar(cliente.GetStream());
            Console.WriteLine("Se recibio un Segundo elemento codificado en texto:");
            Console.WriteLine(elemento2);

            CodificadorBinario codificador = new CodificadorBinario();
            //Se suma 10 al precio del elemento para distinguirlo del primer elemento que recibí del cliente
            //y no mandarle de regreso un elemento exactamente igual al que previamente mandó.
            elemento.precio += 10; 
            Console.Write("\tEnviando el primer elemento en binario...");
            //Codificar en binario el Primer elemento a enviar al cliente 
            byte[] bytesParaEnviar = codificador.Codificar(elemento);
            Console.WriteLine("(" + bytesParaEnviar.Length + " bytes): ");
            //Enviar el primer elemento al cliente (que está codificado en binario)
            cliente.GetStream().Write(bytesParaEnviar, 0, bytesParaEnviar.Length);

            //Se suma 10 al precio del elemento para distinguirlo del segundo elemento que recibí del cliente
            //y no mandarle de regreso un elemento exactamente igual al que previamente mandó.
            elemento2.precio += 10;
            Console.Write("\n\tEnviando el Segundo elemento en binario...");
            //Codificar en binario el Segundo elemento a enviar al cliente
            byte[] bytesParaEnviar2 = codificador.Codificar(elemento2);
            Console.WriteLine("(" + bytesParaEnviar2.Length + " bytes): ");
            //Enviar el segundo elemento al cliente (que está codificado en binario)
            cliente.GetStream().Write(bytesParaEnviar2, 0, bytesParaEnviar2.Length);
            //*/
            Console.ReadLine();
            cliente.Close();
            socketEscucha.Stop();
        }
    }
}
