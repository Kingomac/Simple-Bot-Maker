using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Bot.NET
{
    public partial class MainForm : Form
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

        private int numeroEnviados = 0;
        private Conversacion conversacion;
        private Timer ultimaAccion = new Timer();
        public MainForm()
        {
            InitializeComponent();
            CargarBots();
            SelectComboBox.SelectedIndex = 0;

            ultimaAccion.Interval = 30000;
            ultimaAccion.Start();
            ultimaAccion.Tick += UltimaAccion_Tick;
        }
        public async void Empezar()
        {
            string s;
            try
            {
                s = await conversacion.PreguntarNombre();
            }
            catch
            {
                s = "Error 0";
            }
            MensajesRTB.AppendText(s + "\n");
        }
        public void CargarBots()
        {
            List<string> BotsAptos = new List<string>();
            string[] directorios = Directory.GetDirectories("./Bots/");
            foreach(string d in directorios)
            {
                int correcto = 0; //Todo correcto => 6
                var files = Directory.GetFiles(d);
                foreach(string f in files)
                {
                    string fname = f.Replace(@"\" , "/");
                    if(fname == $"{d}/tematicas.csv" || fname == $"{d}/dialogos.csv" || fname == $"{d}/nombre.csv" || fname == $"{d}/error.txt" || fname == $"{d}/saludos.csv" || fname == $"{d}/aleatorio.txt")
                    {
                        correcto++;
                    }
                    if (correcto == 6) BotsAptos.Add(Path.GetFileNameWithoutExtension(d));
                }
            }
            foreach(string bot in BotsAptos)
            {
                SelectComboBox.Items.Add(bot);
            }
        }

        private void UltimaAccion_Tick(object sender, EventArgs e)
        {
            MensajesRTB.AppendText(conversacion.Aleatorio() + Environment.NewLine);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(MensajeTxtBox.Text != "") EnviarMensaje();
        }

        private void MensajeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && MensajeTxtBox.Text != "")
            {
                EnviarMensaje();
                e.SuppressKeyPress = true;
            }
        }

        private async void EnviarMensaje()
        {
            ultimaAccion.Stop();
            numeroEnviados++;
            if (numeroEnviados == 1)
            {
                MensajesRTB.AppendText(MensajeTxtBox.Text + "\n");
                await Task.Delay(200);
                MensajesRTB.AppendText(conversacion.AsignarNombre(MensajeTxtBox.Text) + Environment.NewLine);
                MensajeTxtBox.Text = null;
            }
            else
            {
                string pregunta = MensajeTxtBox.Text;
                MensajesRTB.AppendText(pregunta + Environment.NewLine);
                MensajeTxtBox.Text = null;
                pregunta = Texto.FormatearTexto(pregunta);
                await Task.Delay(400);
                string m = conversacion.Responder(pregunta);
                MensajesRTB.AppendText(m + Environment.NewLine);
            }
            ultimaAccion.Start();
            MensajesRTB.ScrollToCaret();
        }
        private async void Saludar()
        {
            MensajesRTB.AppendText($"{conversacion.Saludo()}\n");
            await Task.Delay(200);
            MensajesRTB.AppendText($"{await conversacion.PreguntarNombre()}\n");
        }

        private void SelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroEnviados = 0;
            conversacion = new Conversacion(Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*dialogos.csv")[0],
                Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*saludos.csv")[0],
                Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*tematicas.csv")[0],
                Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*nombre.csv")[0],
                Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*error.txt")[0],
                Directory.GetFiles(@".\Bots\" + SelectComboBox.SelectedItem, "*aleatorio.txt")[0]);
            Saludar();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.ShowDialog();
        }
    }
}