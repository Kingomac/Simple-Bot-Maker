using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bot.NET
{
    public static class GestorGuion
    {
        public static Dictionary<string, List<string>> CargarCSV(string archivo)
        {
            Dictionary<string, List<string>> resultado = new Dictionary<string, List<string>>();

            string[] lines = File.ReadAllLines(archivo);
            foreach (string l in lines)
            {
                string[] fila = l.Split(';');
                string pregunta = Texto.FormatearTexto(fila[0]);
                List<string> respuestas = new List<string>();
                for(int i = 1; i<fila.Length; i++)
                {
                    respuestas.Add(fila[i]);
                }
                resultado.Add(pregunta, respuestas);
            }
            return resultado;
        }
    }
}
