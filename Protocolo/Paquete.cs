using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// -------------------------- // Estructura del Paquete // --------------------------
// Descripcion ->     |idDato|longitud|long del mensaje| nombre | mensaje | 
// Tamaño en bytes -> |   4  |    4   |        4       |

// Definición del espacio de nombres "Protocolo"
namespace Protocolo
{
    // Enumeración que define los posibles identificadores de datos en el paquete
    public enum IdentificadorDato
    {
        Mensaje,
        Conectado,
        Desconectado,
        Null
    }

    // Clase que representa un paquete de datos
    public class Paquete
    {
        private IdentificadorDato idDato;
        private string nombre;
        private string mensaje;

        // Propiedad para acceder al identificador del paquete
        public IdentificadorDato IdentificadorChat
        {
            get { return idDato; }
            set { idDato = value; }
        }

        // Propiedad para acceder al nombre del paquete
        public string NombreChat
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Propiedad para acceder al mensaje del paquete
        public string MensajeChat
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        // Constructor predeterminado que inicializa las propiedades del paquete como nulas o valores por defecto
        public Paquete()
        {
            this.idDato = IdentificadorDato.Null;
            this.mensaje = null;
            this.nombre = null;
        }

        // Constructor que crea un paquete a partir de un arreglo de bytes
        public Paquete(byte[] arregloBytes)
        {
            // Se extraen los valores del arreglo de bytes y se asignan a las propiedades del paquete
            this.idDato = (IdentificadorDato)BitConverter.ToInt32(arregloBytes, 0);
            int longitudNombre = BitConverter.ToInt32(arregloBytes, 4);
            int longitudMensaje = BitConverter.ToInt32(arregloBytes, 8);

            // Se verifica la longitud del nombre y del mensaje para evitar errores
            if (longitudNombre > 0)
                this.nombre = Encoding.UTF8.GetString(arregloBytes, 12, longitudNombre);
            else
                this.nombre = null;

            if (longitudMensaje > 0)
                this.mensaje = Encoding.UTF8.GetString(arregloBytes, 12 + longitudNombre, longitudMensaje);
            else
                this.mensaje = null;
        }

        // Método que convierte el paquete en un arreglo de bytes
        public byte[] ObtenerArregloBytes()
        {
            List<Byte> arregloBytes = new List<Byte>();

            // Se agrega el identificador del paquete al arreglo de bytes
            arregloBytes.AddRange(BitConverter.GetBytes((int)this.idDato));

            // Se agrega la longitud del nombre al arreglo de bytes
            if (this.nombre != null)
                arregloBytes.AddRange(BitConverter.GetBytes(this.nombre.Length));
            else
                arregloBytes.AddRange(BitConverter.GetBytes(0));

            // Se agrega la longitud del mensaje al arreglo de bytes
            if (this.mensaje != null)
                arregloBytes.AddRange(BitConverter.GetBytes(this.mensaje.Length));
            else
                arregloBytes.AddRange(BitConverter.GetBytes(0));

            // Se agrega el nombre y el mensaje al arreglo de bytes
            if (this.nombre != null)
                arregloBytes.AddRange(Encoding.UTF8.GetBytes(this.nombre));

            if (this.mensaje != null)
                arregloBytes.AddRange(Encoding.UTF8.GetBytes(this.mensaje));

            // Se convierte la lista de bytes en un arreglo y se devuelve
            return arregloBytes.ToArray();
        }

    }
}
