namespace Bot.NET
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ManualButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FileCBox = new System.Windows.Forms.ComboBox();
            this.BotCBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CrearBotTxtbox = new System.Windows.Forms.TextBox();
            this.CrearBotButt = new System.Windows.Forms.Button();
            this.DuplicarBotBut = new System.Windows.Forms.Button();
            this.EliminarBotBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RenombrarBut = new System.Windows.Forms.Button();
            this.RichTextbox = new System.Windows.Forms.RichTextBox();
            this.FontsCBox = new System.Windows.Forms.ComboBox();
            this.FontSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.BgColorBut = new System.Windows.Forms.Button();
            this.TextColorBut = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ColoresSintxCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.GuardarButton);
            this.panel1.Controls.Add(this.ManualButt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 54);
            this.panel1.TabIndex = 5;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowPanel_MouseMove);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GuardarButton.Image = global::Bot.NET.Properties.Resources.baseline_save_black_18dp2;
            this.GuardarButton.Location = new System.Drawing.Point(624, 0);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(61, 54);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ManualButt
            // 
            this.ManualButt.BackColor = System.Drawing.Color.White;
            this.ManualButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.ManualButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualButt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualButt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ManualButt.Image = global::Bot.NET.Properties.Resources.baseline_help_outline_black_18dp3;
            this.ManualButt.Location = new System.Drawing.Point(685, 0);
            this.ManualButt.Name = "ManualButt";
            this.ManualButt.Size = new System.Drawing.Size(61, 54);
            this.ManualButt.TabIndex = 9;
            this.ManualButt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editor de Bots";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.Image = global::Bot.NET.Properties.Resources.baseline_close_black_18dp;
            this.CloseButton.Location = new System.Drawing.Point(746, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(61, 54);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FileCBox
            // 
            this.FileCBox.BackColor = System.Drawing.Color.White;
            this.FileCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileCBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileCBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FileCBox.FormattingEnabled = true;
            this.FileCBox.Location = new System.Drawing.Point(3, 3);
            this.FileCBox.Name = "FileCBox";
            this.FileCBox.Size = new System.Drawing.Size(184, 24);
            this.FileCBox.TabIndex = 9;
            this.FileCBox.SelectedIndexChanged += new System.EventHandler(this.FileCBox_SelectedIndexChanged);
            // 
            // BotCBox
            // 
            this.BotCBox.BackColor = System.Drawing.Color.White;
            this.BotCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BotCBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotCBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BotCBox.FormattingEnabled = true;
            this.BotCBox.Location = new System.Drawing.Point(193, 3);
            this.BotCBox.Name = "BotCBox";
            this.BotCBox.Size = new System.Drawing.Size(184, 24);
            this.BotCBox.TabIndex = 7;
            this.BotCBox.SelectedIndexChanged += new System.EventHandler(this.BotCBox_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.FileCBox);
            this.flowLayoutPanel1.Controls.Add(this.BotCBox);
            this.flowLayoutPanel1.Controls.Add(this.CrearBotTxtbox);
            this.flowLayoutPanel1.Controls.Add(this.CrearBotButt);
            this.flowLayoutPanel1.Controls.Add(this.DuplicarBotBut);
            this.flowLayoutPanel1.Controls.Add(this.EliminarBotBut);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.RenombrarBut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(807, 55);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // CrearBotTxtbox
            // 
            this.CrearBotTxtbox.BackColor = System.Drawing.Color.White;
            this.CrearBotTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrearBotTxtbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBotTxtbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CrearBotTxtbox.Location = new System.Drawing.Point(383, 3);
            this.CrearBotTxtbox.Name = "CrearBotTxtbox";
            this.CrearBotTxtbox.Size = new System.Drawing.Size(211, 22);
            this.CrearBotTxtbox.TabIndex = 10;
            // 
            // CrearBotButt
            // 
            this.CrearBotButt.BackColor = System.Drawing.Color.DodgerBlue;
            this.CrearBotButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearBotButt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBotButt.ForeColor = System.Drawing.Color.White;
            this.CrearBotButt.Location = new System.Drawing.Point(600, 3);
            this.CrearBotButt.Name = "CrearBotButt";
            this.CrearBotButt.Size = new System.Drawing.Size(195, 24);
            this.CrearBotButt.TabIndex = 11;
            this.CrearBotButt.Text = "Crear bot";
            this.CrearBotButt.UseVisualStyleBackColor = false;
            this.CrearBotButt.Click += new System.EventHandler(this.CrearBotButt_Click);
            // 
            // DuplicarBotBut
            // 
            this.DuplicarBotBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.DuplicarBotBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuplicarBotBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuplicarBotBut.ForeColor = System.Drawing.Color.White;
            this.DuplicarBotBut.Location = new System.Drawing.Point(3, 33);
            this.DuplicarBotBut.Name = "DuplicarBotBut";
            this.DuplicarBotBut.Size = new System.Drawing.Size(184, 24);
            this.DuplicarBotBut.TabIndex = 12;
            this.DuplicarBotBut.Text = "Duplicar bot";
            this.DuplicarBotBut.UseVisualStyleBackColor = false;
            this.DuplicarBotBut.Click += new System.EventHandler(this.DuplicarBotBut_Click);
            // 
            // EliminarBotBut
            // 
            this.EliminarBotBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.EliminarBotBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBotBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBotBut.ForeColor = System.Drawing.Color.White;
            this.EliminarBotBut.Location = new System.Drawing.Point(193, 33);
            this.EliminarBotBut.Name = "EliminarBotBut";
            this.EliminarBotBut.Size = new System.Drawing.Size(184, 24);
            this.EliminarBotBut.TabIndex = 13;
            this.EliminarBotBut.Text = "Eliminar bot";
            this.EliminarBotBut.UseVisualStyleBackColor = false;
            this.EliminarBotBut.Click += new System.EventHandler(this.EliminarBotBut_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(383, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "NO PULSAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // RenombrarBut
            // 
            this.RenombrarBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.RenombrarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenombrarBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenombrarBut.ForeColor = System.Drawing.Color.White;
            this.RenombrarBut.Location = new System.Drawing.Point(600, 33);
            this.RenombrarBut.Name = "RenombrarBut";
            this.RenombrarBut.Size = new System.Drawing.Size(195, 24);
            this.RenombrarBut.TabIndex = 15;
            this.RenombrarBut.Text = "Renombrar";
            this.RenombrarBut.UseVisualStyleBackColor = false;
            this.RenombrarBut.Click += new System.EventHandler(this.RenombrarBut_Click);
            // 
            // RichTextbox
            // 
            this.RichTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RichTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextbox.ForeColor = System.Drawing.Color.White;
            this.RichTextbox.Location = new System.Drawing.Point(12, 115);
            this.RichTextbox.Name = "RichTextbox";
            this.RichTextbox.Size = new System.Drawing.Size(786, 417);
            this.RichTextbox.TabIndex = 8;
            this.RichTextbox.Text = "";
            this.RichTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextbox_KeyDown);
            this.RichTextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextbox_MouseDown);
            this.RichTextbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RichTextbox_MouseUp);
            // 
            // FontsCBox
            // 
            this.FontsCBox.BackColor = System.Drawing.Color.White;
            this.FontsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontsCBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontsCBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FontsCBox.FormattingEnabled = true;
            this.FontsCBox.Location = new System.Drawing.Point(3, 3);
            this.FontsCBox.Name = "FontsCBox";
            this.FontsCBox.Size = new System.Drawing.Size(187, 24);
            this.FontsCBox.TabIndex = 12;
            this.FontsCBox.SelectedIndexChanged += new System.EventHandler(this.FontsCBox_SelectedIndexChanged);
            // 
            // FontSizeUpDown
            // 
            this.FontSizeUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontSizeUpDown.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSizeUpDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FontSizeUpDown.Location = new System.Drawing.Point(196, 3);
            this.FontSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeUpDown.Name = "FontSizeUpDown";
            this.FontSizeUpDown.Size = new System.Drawing.Size(120, 22);
            this.FontSizeUpDown.TabIndex = 13;
            this.FontSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FontSizeUpDown.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.FontSizeUpDown.ValueChanged += new System.EventHandler(this.FontSizeUpDown_ValueChanged);
            // 
            // BgColorBut
            // 
            this.BgColorBut.BackColor = System.Drawing.Color.White;
            this.BgColorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BgColorBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BgColorBut.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BgColorBut.Location = new System.Drawing.Point(322, 3);
            this.BgColorBut.Name = "BgColorBut";
            this.BgColorBut.Size = new System.Drawing.Size(121, 24);
            this.BgColorBut.TabIndex = 14;
            this.BgColorBut.Text = "Color de fondo";
            this.BgColorBut.UseVisualStyleBackColor = false;
            this.BgColorBut.Click += new System.EventHandler(this.BgColorBut_Click);
            // 
            // TextColorBut
            // 
            this.TextColorBut.BackColor = System.Drawing.Color.White;
            this.TextColorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextColorBut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColorBut.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TextColorBut.Location = new System.Drawing.Point(449, 3);
            this.TextColorBut.Name = "TextColorBut";
            this.TextColorBut.Size = new System.Drawing.Size(121, 24);
            this.TextColorBut.TabIndex = 15;
            this.TextColorBut.Text = "Color del texto";
            this.TextColorBut.UseVisualStyleBackColor = false;
            this.TextColorBut.Click += new System.EventHandler(this.TextColorBut_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel2.Controls.Add(this.FontsCBox);
            this.flowLayoutPanel2.Controls.Add(this.FontSizeUpDown);
            this.flowLayoutPanel2.Controls.Add(this.BgColorBut);
            this.flowLayoutPanel2.Controls.Add(this.TextColorBut);
            this.flowLayoutPanel2.Controls.Add(this.ColoresSintxCheckBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 544);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(807, 33);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // ColoresSintxCheckBox
            // 
            this.ColoresSintxCheckBox.AutoSize = true;
            this.ColoresSintxCheckBox.Checked = true;
            this.ColoresSintxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColoresSintxCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoresSintxCheckBox.ForeColor = System.Drawing.Color.White;
            this.ColoresSintxCheckBox.Location = new System.Drawing.Point(576, 3);
            this.ColoresSintxCheckBox.Name = "ColoresSintxCheckBox";
            this.ColoresSintxCheckBox.Size = new System.Drawing.Size(151, 21);
            this.ColoresSintxCheckBox.TabIndex = 16;
            this.ColoresSintxCheckBox.Text = "Colores de sintaxis";
            this.ColoresSintxCheckBox.UseVisualStyleBackColor = true;
            this.ColoresSintxCheckBox.CheckedChanged += new System.EventHandler(this.ColoresSintxCheckBox_CheckedChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 577);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.RichTextbox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BotCBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox FileCBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox CrearBotTxtbox;
        private System.Windows.Forms.Button CrearBotButt;
        private System.Windows.Forms.RichTextBox RichTextbox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ManualButt;
        private System.Windows.Forms.ComboBox FontsCBox;
        private System.Windows.Forms.NumericUpDown FontSizeUpDown;
        private System.Windows.Forms.Button BgColorBut;
        private System.Windows.Forms.Button TextColorBut;
        private System.Windows.Forms.Button DuplicarBotBut;
        private System.Windows.Forms.Button EliminarBotBut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RenombrarBut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox ColoresSintxCheckBox;
    }
}