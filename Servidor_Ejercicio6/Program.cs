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
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Codificador;

namespace Servidor_Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Se define el puerto en el que el servidor escuchará las conexiones
            int puerto = 8080;

            // Se crea un TcpListener para escuchar en cualquier dirección IP disponible en el puerto especificado
            TcpListener socketEscucha = new TcpListener(IPAddress.Any, puerto);

            // Se inicia la escucha en el socket
            socketEscucha.Start();

            // Se acepta una conexión TCP entrante y se obtiene el TcpClient correspondiente al cliente conectado
            TcpClient cliente = socketEscucha.AcceptTcpClient();

            // Se crea un decodificador de texto para decodificar el elemento recibido del cliente
            DecodificadorTexto decodificador = new DecodificadorTexto();

            // Se decodifica el elemento recibido del cliente utilizando el decodificador de texto
            Elemento elemento = decodificador.Decodificar(cliente.GetStream());

            // Se muestra en la consola el elemento decodificado recibido del cliente
            Console.WriteLine("Cambio realizado para prueba de Github:");
            Console.WriteLine(elemento);

            // Se crea un codificador binario para codificar el elemento modificado
            CodificadorBinario codificador = new CodificadorBinario();

            // Se incrementa el precio del elemento en 10
            elemento.precio += 10;

            // Se envía el elemento codificado en binario al cliente
            Console.Write("Enviando elemento en binario...");
            byte[] bytesParaEnviar = codificador.Codificar(elemento);
            Console.WriteLine("(" + bytesParaEnviar.Length + " bytes): ");
            cliente.GetStream().Write(bytesParaEnviar, 0, bytesParaEnviar.Length);

            // Se espera a que se presione una tecla antes de finalizar el programa
            Console.ReadLine();

            // Se cierra la conexión con el cliente y se detiene la escucha en el socket
            cliente.Close();
            socketEscucha.Stop();
        }
    }
}
