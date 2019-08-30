using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace Bot.NET
{
    public partial class Editor : Form
    {
        #region Movimiento ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void WindowPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            configEditor.Guardar();
            this.Close();
        }
        #endregion

        private Dictionary<string, string[]> temporal = new Dictionary<string, string[]>();
        public string anteriorSeleccion;
        public Timer highlightTimer = new Timer();
        private ConfigEditor configEditor;

        public Editor()
        {
            
            InitializeComponent();
            
            CargarSeleccionBots();
            CargarSeleccionArchivos();
            ResetTemporal();
            LoadFontsList();
            CargarConfig();
            if (configEditor.SintaxisActivada)
            {
                //Set highlightTimer
                highlightTimer.Interval = 3000;
                highlightTimer.Tick += HighlightTimer_Tick;
                highlightTimer.Start();
            }
        }

        

        private void ResetTemporal()
        {
            string[] archivos = new string[] { "tematicas", "dialogos", "nombre", "saludos", "error", "aleatorio" };
            foreach (string a in archivos)
            {
                temporal.Add(a, null);
            }
        }
        public async void CargarSeleccionBots()
        {
            BotCBox.Items.Clear();
            string[] directorios = await Task.Run(() => Directory.GetDirectories("./Bots/"));
            foreach (string d in directorios)
            {
                int correcto = 0; //Todo correcto => 6
                var files = await Task.Run(() => Directory.GetFiles(d));
                foreach (string f in files)
                {
                    string fname = f.Replace(@"\", "/");
                    if (fname == $"{d}/tematicas.csv" || fname == $"{d}/dialogos.csv" || fname == $"{d}/nombre.csv" || fname == $"{d}/error.txt" || fname == $"{d}/saludos.csv" || fname == $"{d}/aleatorio.txt")
                    {
                        correcto++;
                    }
                    if (correcto == 6) BotCBox.Items.Add(Path.GetFileNameWithoutExtension(d));
                }
            }
        }
        public void CargarSeleccionArchivos()
        {
            string[] archivos = new string[] { "Temáticas", "Diálogos", "Nombre", "Saludos", "Error", "Aleatorio" };
            FileCBox.Items.Clear();
            foreach (string a in archivos)
            {
                FileCBox.Items.Add(a);
            }
        }
        public async void CargarArchivo()
        {
            switch (FileCBox.SelectedItem)
            {
                case "Temáticas":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/tematicas.csv");
                    break;
                case "Diálogos":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/dialogos.csv");
                    break;
                case "Nombre":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/nombre.csv");
                    break;
                case "Saludos":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/saludos.csv");
                    break;
                case "Error":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/error.txt");
                    break;
                case "Aleatorio":
                    RichTextbox.Lines = await LeerArchivo($"./Bots/{BotCBox.SelectedItem}/aleatorio.txt");
                    break;
            }
        }
        public async Task<string[]> LeerArchivo(string path)
        {
            return await Task.Run(() => File.ReadAllLines(path));
        }

        private void FileCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BotCBox.SelectedItem != null) CargarArchivo();
            else MessageBox.Show("Selecciona un Bot para editar", "Error 403", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CrearBotButt_Click(object sender, EventArgs e)
        {
            try
            {
                CrearBot();
            }
            catch
            {
                MessageBox.Show("Revisa tu conexión a Internet, la plantilla del bot se descarga de Internet así que si no puedes conectarte solo tienes que duplicar un bot", "No se ha podido crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Queue<string[]> cola = new Queue<string[]>();
        private async void CrearBot()
        {
            string path = $"./Bots/{CrearBotTxtbox.Text}";
            CrearBotTxtbox.Text = null;
            await Task.Run(() => Directory.CreateDirectory(path));

            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/aleatorio.txt?alt=media&token=e39d2b1c-d003-4922-b998-649bff016810", "aleatorio.txt" });
            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/error.txt?alt=media&token=4259eba8-9d48-4f6a-8c8e-f0d96676595f", "error.txt" });
            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/nombre.csv?alt=media&token=1d47a750-918e-4375-8a92-cbda21d06cad", "nombre.csv" });
            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/saludos.csv?alt=media&token=e72365c8-a1c2-4a68-9a13-b1f53cb78400", "saludos.csv" });
            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/tematicas.csv?alt=media&token=32aa67ad-20ad-463c-bfa9-24bd4da37bac", "tematicas.csv" });
            cola.Enqueue(new string[] { "https://firebasestorage.googleapis.com/v0/b/simplebot-1e742.appspot.com/o/dialogos.csv?alt=media&token=b9d3be51-cfbb-47bb-a3ed-917fa3ab3574", "dialogos.csv" });

            foreach(string[] item in cola)
            {
                using(WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(item[0]), $"{path}/{item[1]}");
                }
            }
            CargarSeleccionBots();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private async void GuardarArchivo()
        {
            string archivo;
            switch (FileCBox.SelectedItem)
            {
                case "Temáticas":
                    archivo = "tematicas.csv";
                    break;
                case "Diálogos":
                    archivo = "dialogos.csv";
                    break;
                case "Nombre":
                    archivo = "nombre.csv";
                    break;
                case "Saludos":
                    archivo = "saludos.csv";
                    break;
                case "Error":
                    archivo = "error.txt";
                    break;
                case "Aleatorio":
                    archivo = "aleatorio.txt";
                    break;
                default:
                    archivo = null;
                    break;
            }
            using (var writer = new StreamWriter($"./Bots/{BotCBox.SelectedItem}/{archivo}"))
            {
                foreach (string line in RichTextbox.Lines)
                {
                    await writer.WriteLineAsync(line);
                }
            }

        }

        private void BotCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temporal[Texto.FormatearTexto(FileCBox.SelectedItem.ToString())] = RichTextbox.Lines.ToArray();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RichTextbox.Text = temporal["dialogos"][1];
        }
        private string[] constantes = { "$nombre", "$res_nombre", "$preg_nombre", "$mañana", "$tarde", "$mediodia", "$noche" };
        private void HighlightTimer_Tick(object sender, EventArgs e)
        {
            //Start highlight
            int s = RichTextbox.SelectionStart;

            HighlightWord(";", Color.FromArgb(255 - RichTextbox.ForeColor.R, 255 - RichTextbox.ForeColor.G, 255 - RichTextbox.ForeColor.B) , FontStyle.Bold);
            foreach(string c in constantes)
            {
                HighlightWord(c, Color.FromArgb(255 - configEditor.ColorTexto.R, 255 - configEditor.ColorTexto.G, 255 - configEditor.ColorTexto.B), FontStyle.Italic);
            }

            //End highlight
            RichTextbox.DeselectAll();
            RichTextbox.SelectionColor = RichTextbox.ForeColor;
            RichTextbox.SelectionStart = s;
        }

        private void HighlightWord(string word, Color color, FontStyle style)
        {
            /*int i = RichTextbox.Find(";");
            RichTextbox.Select(i, 1);
            RichTextbox.SelectionColor = Color.Red;*/
            int index;
            int start_index = 0;
            while ((index = RichTextbox.Text.IndexOf(word, start_index)) != -1)
            {
                RichTextbox.Select(index, word.Length);
                RichTextbox.SelectionColor = color;
                RichTextbox.SelectionFont = new Font(RichTextbox.Font, style);
                start_index += word.Length;
            }
        }
        private void LoadFontsList()
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                FontsCBox.Items.Add(font.Name);
            }
        }

        private void FontsCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (FontFamily font in FontFamily.Families)
            {
                if(font.Name == FontsCBox.SelectedItem.ToString())
                {
                    configEditor.Fuente = font.Name;
                }
            }
            RichTextbox.Font = new Font(configEditor.Fuente, 13, FontStyle.Regular);
        }

        private void CargarConfig()
        {
            try
            {
                configEditor = ConfigLoader.Cargar();
                ApplyConfig();
            }
            catch
            {
                MessageBox.Show("Creando nuevo archivo de configuración del editor", "No se ha encontrado o es incorrecta la configuración del editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                configEditor = new ConfigEditor();
                configEditor.Fuente = RichTextbox.Font.FontFamily.Name;
                configEditor.Tamaño = 13;
                configEditor.SintaxisActivada = true;
            }
        }
        private void ApplyConfig()
        {
            RichTextbox.Font = new Font(configEditor.Fuente, configEditor.Tamaño, FontStyle.Regular);
            FontsCBox.SelectedItem = configEditor.Fuente;
            FontSizeUpDown.Value = configEditor.Tamaño;
            RichTextbox.BackColor = ColorJson.ToColor(configEditor.ColorFondo);
            RichTextbox.ForeColor = ColorJson.ToColor(configEditor.ColorTexto);
            ColoresSintxCheckBox.Checked = configEditor.SintaxisActivada;
        }

        private void FontSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            configEditor.Tamaño = Convert.ToInt32(FontSizeUpDown.Value);
            RichTextbox.Font = new Font(configEditor.Fuente, configEditor.Tamaño, FontStyle.Regular);
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BgColorBut_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            configEditor.ColorFondo = ColorJson.FromColor(colorDialog.Color);
            RichTextbox.BackColor = colorDialog.Color;
        }

        private void TextColorBut_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            configEditor.ColorTexto = ColorJson.FromColor(colorDialog.Color);
            RichTextbox.ForeColor = colorDialog.Color;
        }

        private void RichTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            highlightTimer.Enabled = false;
        }

        private void RichTextbox_MouseUp(object sender, MouseEventArgs e)
        {
            highlightTimer.Enabled = true;
        }

        private void DuplicarBotBut_Click(object sender, EventArgs e)
        {
            string dir = $"./Bots/{BotCBox.SelectedItem}";
            string dir_duplicado = $"./Bots/{BotCBox.SelectedItem} - Duplicado";
            Directory.CreateDirectory(dir_duplicado);
            string[] archivos = new string[] { "tematicas.csv", "dialogos.csv", "nombre.csv", "saludos.csv", "error.txt", "aleatorio.txt" };
            foreach(string a in archivos)
            {
                try
                {
                    File.Copy($"{dir}/{a}", $"{dir_duplicado}/{a}");
                }
                catch
                {
                    MessageBox.Show("Error duplicando el bot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarSeleccionBots();
        }

        private void EliminarBotBut_Click(object sender, EventArgs e)
        {
            if(BotCBox.SelectedItem == null)
            {
                MessageBox.Show("No puedes eliminar el contacto de un amigo que no existe 😭😭😭😭😭😭😿😿😿😿😿o((⊙﹏⊙))o.", "Selecciona un bot");
            }
            else
            {
                Directory.Delete($"./Bots/{BotCBox.SelectedItem}");
                CargarSeleccionBots();
            }
        }

        private void RenombrarBut_Click(object sender, EventArgs e)
        {
            if (BotCBox.SelectedItem == null)
            {
                MessageBox.Show("No puedes ponerle un mote gracioso a un amigo que no tienes 😱😖😓", "Selecciona un bot");
            }
            else
            {
                Directory.Move($"./Bots/{BotCBox.SelectedItem}", $"./Bots/{CrearBotTxtbox.Text}");
                CargarSeleccionBots();
            }
            
        }

        private void ColoresSintxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            configEditor.SintaxisActivada = ColoresSintxCheckBox.Checked;
        }

        private async void Button2_Click_1(object sender, EventArgs e)
        {
            string[] links = await Task.Run(() => File.ReadAllLines("./abrelo.NoEsUnVirus"));
            System.Diagnostics.Process.Start(links[new Random().Next(0, links.Length)]);
        }
    }
}