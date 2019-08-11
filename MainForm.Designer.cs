namespace Bot.NET
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MensajeTxtBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.MensajesRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MensajeTxtBox
            // 
            this.MensajeTxtBox.Location = new System.Drawing.Point(13, 410);
            this.MensajeTxtBox.Name = "MensajeTxtBox";
            this.MensajeTxtBox.Size = new System.Drawing.Size(650, 20);
            this.MensajeTxtBox.TabIndex = 0;
            this.MensajeTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MensajeTxtBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(670, 410);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(102, 20);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(59, 12);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(100, 20);
            this.UserTxt.TabIndex = 2;
            // 
            // MensajesRTB
            // 
            this.MensajesRTB.Location = new System.Drawing.Point(12, 38);
            this.MensajesRTB.Name = "MensajesRTB";
            this.MensajesRTB.ReadOnly = true;
            this.MensajesRTB.Size = new System.Drawing.Size(760, 352);
            this.MensajesRTB.TabIndex = 3;
            this.MensajesRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MensajesRTB);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MensajeTxtBox);
            this.Name = "MainForm";
            this.Text = "Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MensajeTxtBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.RichTextBox MensajesRTB;
        private System.Windows.Forms.Label label1;
    }
}

