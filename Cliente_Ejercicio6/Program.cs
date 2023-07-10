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
using System.Threading;
using System.Threading.Tasks;
using Codificador;

namespace Cliente_Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Se detiene la ejecución del programa durante 500 milisegundos
            Thread.Sleep(500);

            // Se especifica la dirección IP del servidor al que se conectará el cliente
            IPAddress servidor = IPAddress.Parse("127.0.0.1");

            // Se especifica el puerto en el que el servidor está escuchando
            int puerto = 8080;

            // Se crea un objeto IPEndPoint que representa el extremo remoto al que se conectará el cliente
            IPEndPoint extremo = new IPEndPoint(servidor, puerto);

            // Se crea una instancia de TcpClient y se conecta al servidor en el extremo especificado
            TcpClient cliente = new TcpClient();
            cliente.Connect(extremo);

            // Se obtiene el flujo de red asociado al cliente para enviar y recibir datos
            NetworkStream flujoRed = cliente.GetStream();

            // Se crea un nuevo objeto Elemento con datos específicos
            Elemento elemento = new Elemento(1234567890987654L, "Cambio de Cadena de Bicicleta para github", 18, 1000, true, false);

            // Se crea un codificadorCambiadoPorGithub de texto para codificar el elemento en texto
            //CodificadorTexto codificadorCambiadoPorGithub = new CodificadorTexto();
            CodificadorTexto codificadorCambiadoPorGithub = new CodificadorTexto();

            // Se codifica el elemento en texto y se obtienen los datos codificados en forma de arreglo de bytes
            byte[] datosCodificados = codificadorCambiadoPorGithub.Codificar(elemento);

            // Se muestra en la consola el elemento codificado en texto y su longitud en bytes
            Console.WriteLine("Cambio de mensaje por github - Enviando elemento codificado en texto (" + datosCodificados.Length + " bytes): ");
            Console.WriteLine(elemento);

            // Se envían los datos codificados al servidor a través del flujo de red
            flujoRed.Write(datosCodificados, 0, datosCodificados.Length);

            // Se crea un decodificador binario para decodificar el elemento recibido del servidor
            DecodificadorBinario decodificador = new DecodificadorBinario();

            // Se decodifica el elemento recibido del servidor utilizando el decodificador binario
            Elemento elementoRecibido = decodificador.Decodificar(cliente.GetStream());

            // Se muestra en la consola el elemento decodificado recibido del servidor
            Console.WriteLine("Se recibio un elemento codificado en formato binario:");
            Console.WriteLine(elementoRecibido);

            // Se lee una línea de texto desde la consola antes de finalizar el programa
            Console.ReadLine();

            // Se cierra el flujo de red y se desconecta el cliente del servidor
            flujoRed.Close();
            cliente.Close();
        }
    }
}
