using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.NET
{
    class Conversacion
    {
        public string KeyUsuario = "$nombre";
        public static string Usuario;
        public string Bot = "Loli";
        public Dictionary<string, List<string>> QandA;
        public Dictionary<string, List<string>> Saludos;
        public Dictionary<string, List<string>> Tematicas;
        public Dictionary<string, List<string>> Nombre;
        public List<string> Error;
        public List<string> Aleatorios;
        public bool CargaFinalizada = false;

        public Conversacion(string pathDialogos, string pathSaludos, string pathTematicas, string pathNombre, string pathError, string pathAleatorio)
        {
            CargarArchivos(pathDialogos, pathSaludos, pathTematicas, pathNombre, pathError, pathAleatorio);
        }
        public async void CargarArchivos(string pathDialogos, string pathSaludos, string pathTematicas, string pathNombre, string pathError, string pathAleatorio)
        {
            Saludos = GestorGuion.CargarDiccionarioCsvSync(pathSaludos);
            Nombre = await GestorGuion.CargarDiccionarioCSV(pathNombre);
            QandA = await GestorGuion.CargarDiccionarioCSV(pathDialogos);
            Tematicas = await GestorGuion.CargarDiccionarioCSV(pathTematicas);
            Error = await GestorGuion.CargarTxt(pathError);
            Aleatorios = await GestorGuion.CargarTxt(pathAleatorio);
            CargaFinalizada = true;
        }

        public string Responder(string pregunta)
        {
            try
            {
                try
                {
                    return QandA[pregunta][new Random().Next(QandA[pregunta].Count)];
                }
                catch
                {
                    foreach(KeyValuePair<string, List<string>> elemento in Tematicas)
                    {
                        if (pregunta.Contains(elemento.Key))
                        {
                            return elemento.Value[new Random().Next(elemento.Value.Count)];
                        }
                    }
                    throw new Exception();
                }
            }
            catch
            {
                return Error[new Random().Next(0, Error.Count)];
            }
        }
        public string Aleatorio()
        {
            return Aleatorios[new Random().Next(0, Aleatorios.Count)];
        }

        public string Saludo()
        {
            string momentoDia;
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16) momentoDia = "$mediodia";
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12) momentoDia = "$mañana";
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 20) momentoDia = "$tarde";
            else momentoDia = "$noche";
            Random random = new Random();
            return Saludos[momentoDia][random.Next(Saludos[momentoDia].Count)];
        }
        public async Task<string> PreguntarNombre()
        {
            while(Nombre == null)
            {
                await Task.Yield();
            }
            return Nombre["$preg_nombre"][new Random().Next(0, Nombre["$preg_nombre"].Count)];
        }
        private async void ReemplazarNombre()
        {
            await Task.Yield();
            Tematicas = await ReemplazarNombreAsync(Tematicas);
            QandA = await ReemplazarNombreAsync(QandA);
            Saludos = await ReemplazarNombreAsync(Saludos);
            Nombre = await ReemplazarNombreAsync(Nombre);
        }

        private async Task<Dictionary<string, List<string>>> ReemplazarNombreAsync(Dictionary<string, List<string>> diccionario)
        {
            await Task.Yield();
            Dictionary<string, List<string>> resultado = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<string, List<string>> elemento in diccionario)
            {
                string[] valores = elemento.Value.ToArray();
                for(int i = 0; i<valores.Length; i++)
                {
                    valores[i] = valores[i].Replace(KeyUsuario, Usuario);
                }
                resultado.Add(elemento.Key, valores.ToList());
            }
            return resultado;
        }
        public string AsignarNombre(string nombre)
        {
            nombre = Texto.FormatearTexto(nombre);
            nombre = nombre.Replace("me llamo ", "").Replace("soy ", "");
            var letras = nombre.ToCharArray();
            letras[0] = letras[0].ToString().ToUpper().ToCharArray()[0];
            nombre = new string(letras);
            Usuario = nombre;

            foreach(KeyValuePair<string,List<string>> s in Nombre)
            {
                Console.WriteLine($"Nombre[{s.Key}]");
            }

            ReemplazarNombre();
            return Nombre["$res_nombre"][new Random().Next(Nombre["$res_nombre"].Count)];
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