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
            this.MensajesRTB = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MensajeTxtBox
            // 
            this.MensajeTxtBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeTxtBox.Location = new System.Drawing.Point(28, 480);
            this.MensajeTxtBox.Name = "MensajeTxtBox";
            this.MensajeTxtBox.Size = new System.Drawing.Size(650, 25);
            this.MensajeTxtBox.TabIndex = 0;
            this.MensajeTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MensajeTxtBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(686, 479);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(102, 25);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MensajesRTB
            // 
            this.MensajesRTB.BackColor = System.Drawing.Color.White;
            this.MensajesRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MensajesRTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.MensajesRTB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajesRTB.Location = new System.Drawing.Point(28, 71);
            this.MensajesRTB.Name = "MensajesRTB";
            this.MensajesRTB.ReadOnly = true;
            this.MensajesRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MensajesRTB.Size = new System.Drawing.Size(760, 402);
            this.MensajesRTB.TabIndex = 3;
            this.MensajesRTB.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelectComboBox);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 54);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Creador de Bots";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowPanel_MouseMove);
            // 
            // SelectComboBox
            // 
            this.SelectComboBox.BackColor = System.Drawing.Color.White;
            this.SelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectComboBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectComboBox.FormattingEnabled = true;
            this.SelectComboBox.Location = new System.Drawing.Point(552, 17);
            this.SelectComboBox.Name = "SelectComboBox";
            this.SelectComboBox.Size = new System.Drawing.Size(121, 24);
            this.SelectComboBox.TabIndex = 7;
            this.SelectComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectComboBox_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditButton.Location = new System.Drawing.Point(679, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(84, 54);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Editor";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.Image = global::Bot.NET.Properties.Resources.baseline_close_black_18dp;
            this.CloseButton.Location = new System.Drawing.Point(763, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(61, 54);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MensajesRTB);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MensajeTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Creador de Bots";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MensajeTxtBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox MensajesRTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox SelectComboBox;
        private System.Windows.Forms.Label label1;
    }
}

