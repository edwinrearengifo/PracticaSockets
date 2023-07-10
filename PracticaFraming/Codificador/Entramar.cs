// ************************************************************************
// Practica 04 - Parte 2
// Carlos León - José Montero - Joel Del Hierro
// Fecha de realización: 16/12/2022
// Fecha de entrega: 23/12/2022
// Resultados, conclusiones y Recomendaciones en el Program de la clase Servidor
// ************************************************************************
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codificador
{
    public class Entramar
    {
        public static byte[] SiguienteToken(Stream datosEntrada, byte[] delimitador)
        {
            int siguienteByte;
            if ((siguienteByte = datosEntrada.ReadByte()) == -1)
                return null;
            MemoryStream bufer = new MemoryStream();
            do
            {
                bufer.WriteByte((byte)siguienteByte);
                byte[] tokenActual = bufer.ToArray();
                if (TerminaCon(tokenActual, delimitador))
                {
                    int longitudToken = tokenActual.Length - delimitador.Length;
                    byte[] token = new byte[longitudToken];
                    Array.Copy(tokenActual, 0, token, 0, longitudToken);
                    return token;
                }
            } while ((siguienteByte = datosEntrada.ReadByte()) != -1);
            return bufer.ToArray();
        }
        private static Boolean TerminaCon(byte[] valor, byte[] sufijo)
        {
            if (valor.Length < sufijo.Length)
                return false;
            for (int offset = 1; offset <= sufijo.Length; offset++)
                if (valor[valor.Length - offset] != sufijo[sufijo.Length - offset])
                    return false;
            return true;
        }
    }
}
