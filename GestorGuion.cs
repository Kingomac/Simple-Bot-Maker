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
        public static Dictionary<string, List<string>> CargarDiccionarioCsvSync(string archivo)
        {
            Dictionary<string, List<string>> resultado = new Dictionary<string, List<string>>();

            string[] lines = File.ReadAllLines(archivo);
            foreach (string l in lines)
            {
                string[] fila = l.Split(';');
                string pregunta = Texto.FormatearTexto(fila[0]);
                List<string> respuestas = new List<string>();
                for (int i = 1; i < fila.Length; i++)
                {
                    respuestas.Add(fila[i]);
                }
                resultado.Add(pregunta, respuestas);
            }
            Console.WriteLine("Sync loaded: " + archivo);
            return resultado;
        }
        public static Task<Dictionary<string, List<string>>> CargarDiccionarioCSV(string archivo)
        {
            return CargarDiccionarioCsvAsync(archivo);
        }
        public static async Task<Dictionary<string, List<string>>> CargarDiccionarioCsvAsync(string archivo)
        {
            Dictionary<string, List<string>> resultado = new Dictionary<string, List<string>>();

            using(var reader = new StreamReader(archivo))
            {
                string line;
                string question = null;
                List<string> answers = new List<string>();
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    string[] filas = line.Split(';');
                    question = Texto.FormatearTexto(filas[0]);
                    for (int i = 1; i<filas.Length; i++)
                    {
                        answers.Add(filas[i]);
                    }
                    resultado.Add(question, answers);
                }
                
            }
            Console.WriteLine($"Async loaded: {archivo}");
            return resultado;
        }
        public static Task<List<string>> CargarTxt(string archivo)
        {
            /*List<string> resultado = File.ReadAllLines(archivo).ToList<string>();
            return resultado;*/
            return CargarTxtAsync(archivo);
        }
        public static async Task<List<string>> CargarTxtAsync(string archivo)
        {
            List<string> Result = new List<string>();
            using (var reader = new StreamReader(archivo))
            {
                string line;
                while((line = await reader.ReadLineAsync()) != null)
                {
                    Result.Add(line);
                }
            }
            Console.WriteLine($"Async loaded: {archivo}");
            return Result;
        }
    }
}