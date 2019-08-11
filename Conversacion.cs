using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.NET
{
    class Conversacion
    {
        public string Usuario;
        public string Bot = "Loli";
        public Dictionary<string, List<string>> QandA;
        public Dictionary<string, List<string>> Saludos;

        public Conversacion(string user)
        {
            Usuario = user;
            QandA = GestorGuion.CargarCSV("./dialogos.csv");
            Saludos = GestorGuion.CargarCSV("./saludos.csv");
        }

        public string Responder(string pregunta)
        {
            try
            {
                Random random = new Random();
                return QandA[pregunta][random.Next(QandA[pregunta].Count)];
            }
            catch
            {
                return "Non sei";
            }
        }

        public string Saludo()
        {
            string momentoDia = "mañana";
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16) momentoDia = "mediodia";
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12) momentoDia = "mañana";
            if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 24) momentoDia = "mañana";
        }

    }
    public static class Texto
    {
        public static string FormatearTexto(string text)
        {
            text = text.ToLowerInvariant();
            text = text.Replace("á", "a");
            text = text.Replace("é", "e");
            text = text.Replace("í", "i");
            text = text.Replace("ó", "o");
            text = text.Replace("ú", "u");

            text = text.Replace("¿", "");
            text = text.Replace("?", "");
            text = text.Replace("¡", "");
            text = text.Replace("!", "");

            text = text.Replace("'", "");
            return text;
        }
    }
}
