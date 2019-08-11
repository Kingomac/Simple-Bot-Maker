using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot.NET
{
    public partial class MainForm : Form
    {
        private Conversacion conversacion;
        public MainForm()
        {
            InitializeComponent();
            conversacion = new Conversacion(UserTxt.Text);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
        }

        private void MensajeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarMensaje();
                e.SuppressKeyPress = true;
            }
        }

        private async void EnviarMensaje()
        {
            string pregunta = MensajeTxtBox.Text;
            MensajesRTB.AppendText(pregunta + Environment.NewLine);
            MensajeTxtBox.Text = null;
            pregunta = Texto.FormatearTexto(pregunta);
            await Task.Delay(200);
            MensajesRTB.AppendText(conversacion.Responder(pregunta) + Environment.NewLine);
        }
        
    }
}
