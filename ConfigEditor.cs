using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;

namespace Bot.NET
{
    class ConfigEditor
    {
        public string Fuente { get; set; }
        public ColorJson ColorFondo { get; set; }
        public ColorJson ColorTexto { get; set; }
        public int Tamaño { get; set; }
        public bool ColoresSintaxis { get; set; }
        public static string RutaGuardar { get; } = "./config_editor.json";

        public async void Guardar()
        {
            using (StreamWriter writer = new StreamWriter(RutaGuardar))
            {
                await writer.WriteAsync(JsonConvert.SerializeObject(this));
                Console.WriteLine(JsonConvert.SerializeObject(this));
            };
        }
    }
    class ColorJson
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }
        public ColorJson(int red, int green, int blue, int alpha = 255)
        {
            R = red;
            G = green;
            B = blue;
            A = alpha;
        }
        public static ColorJson FromColor(Color color)
        {
            return new ColorJson(color.R, color.G, color.B, color.A);
        }
        public static Color ToColor(ColorJson json)
        {
            return Color.FromArgb(json.A, json.R, json.G, json.B);
        }
    }
    class ConfigLoader
    {
        public static ConfigEditor Cargar()
        {
            ConfigEditor result;
            using (StreamReader reader = new StreamReader(ConfigEditor.RutaGuardar))
            {
                result = JsonConvert.DeserializeObject<ConfigEditor>(reader.ReadToEnd());
            }
            return result;
        }
    }
}
