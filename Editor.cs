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
            this.Close();
        }
        #endregion

        private Dictionary<string, string[]> temporal = new Dictionary<string, string[]>();
        private string[] idTemporal = new string[] { "tematicas", "dialogos", "nombre", "saludos", "error", "aleatorio" };
        public string anteriorSeleccion;
        public Timer highlightTimer = new Timer();
        private ConfigEditor configEditor = new ConfigEditor();

        public Editor()
        {
            InitializeComponent();
            CargarSeleccionBots();
            CargarSeleccionArchivos();
            ResetTemporal();
            LoadFontsList();
            CargarConfig();

            //Set highlightTimer
            highlightTimer.Interval = 650;
            highlightTimer.Tick += HighlightTimer_Tick;
            highlightTimer.Start();
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
            CrearBot();
        }
        private async void CrearBot()
        {
            string path = $"./Bots/{CrearBotTxtbox.Text}";
            CrearBotTxtbox.Text = null;
            await Task.Run(() => Directory.CreateDirectory(path));
            string[] archivos = new string[] { "tematicas.csv", "dialogos.csv", "nombre.csv", "saludos.csv", "error.txt", "aleatorio.txt" };
            foreach (string a in archivos)
            {
                await Task.Run(() => File.Create($"{path}/{a}"));
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
        private void HighlightTimer_Tick(object sender, EventArgs e)
        {
            //Start highlight
            int s = RichTextbox.SelectionStart;

            HighlightWord(";", Color.FromArgb(183, 153, 212));
            HighlightWord("$nombre", Color.FromArgb(141, 220, 234));
            HighlightWord("$res_nombre", Color.FromArgb(141, 220, 234));
            HighlightWord("$preg_nombre", Color.FromArgb(141, 220, 234));
            HighlightWord("$mañana", Color.FromArgb(141, 220, 234));
            HighlightWord("$tarde", Color.FromArgb(141, 220, 234));
            HighlightWord("$mediodia", Color.FromArgb(141, 220, 234));
            HighlightWord("$noche", Color.FromArgb(141, 220, 234));

            //End highlight
            RichTextbox.DeselectAll();
            RichTextbox.SelectionColor = RichTextbox.ForeColor;
            RichTextbox.SelectionStart = s;
        }

        private void HighlightWord(string word, Color color)
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
                start_index += word.Length;
            }
        }

        private void ColoresSintxCB_CheckedChanged(object sender, EventArgs e)
        {
            configEditor.ColoresSintaxis = ColoresSintxCB.Checked;
            highlightTimer.Enabled = ColoresSintxCB.Checked;
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
                var configEditor = ConfigLoader.Cargar();
                Console.WriteLine($"Tamaño: {configEditor.Tamaño}, Fuente: {configEditor.Fuente}");
                RichTextbox.Font = new Font(configEditor.Fuente, configEditor.Tamaño, FontStyle.Regular);
                ColoresSintxCB.Checked = configEditor.ColoresSintaxis;
                FontsCBox.SelectedItem = configEditor.Fuente;
                FontSizeUpDown.Value = configEditor.Tamaño;
                RichTextbox.BackColor = ColorJson.ToColor(configEditor.ColorFondo);
                RichTextbox.ForeColor = ColorJson.ToColor(configEditor.ColorTexto);
            }
            catch
            {
                configEditor.Fuente = RichTextbox.Font.FontFamily.Name;
                configEditor.Tamaño = 13;
                configEditor.ColoresSintaxis = ColoresSintxCB.Checked;
            }
        }

        private void FontSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            configEditor.Tamaño = Convert.ToInt32(FontSizeUpDown.Value);
            RichTextbox.Font = new Font(configEditor.Fuente, configEditor.Tamaño, FontStyle.Regular);
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            configEditor.Guardar();
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
    }
}