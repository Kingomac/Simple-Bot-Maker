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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FileCBox = new System.Windows.Forms.ComboBox();
            this.BotCBox = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CrearBotTxtbox = new System.Windows.Forms.TextBox();
            this.CrearBotButt = new System.Windows.Forms.Button();
            this.RichTextbox = new System.Windows.Forms.RichTextBox();
            this.ColoresSintxCB = new System.Windows.Forms.CheckBox();
            this.FontsCBox = new System.Windows.Forms.ComboBox();
            this.FontSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.BgColorBut = new System.Windows.Forms.Button();
            this.TextColorBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.GuardarButton);
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = global::Bot.NET.Properties.Resources.baseline_help_outline_black_18dp3;
            this.button1.Location = new System.Drawing.Point(685, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 54);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 491);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.FileCBox);
            this.flowLayoutPanel1.Controls.Add(this.BotCBox);
            this.flowLayoutPanel1.Controls.Add(this.CrearBotTxtbox);
            this.flowLayoutPanel1.Controls.Add(this.CrearBotButt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 36);
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
            this.CrearBotButt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBotButt.ForeColor = System.Drawing.Color.White;
            this.CrearBotButt.Location = new System.Drawing.Point(600, 3);
            this.CrearBotButt.Name = "CrearBotButt";
            this.CrearBotButt.Size = new System.Drawing.Size(195, 24);
            this.CrearBotButt.TabIndex = 11;
            this.CrearBotButt.Text = "Crear bot";
            this.CrearBotButt.UseVisualStyleBackColor = false;
            this.CrearBotButt.Click += new System.EventHandler(this.CrearBotButt_Click);
            // 
            // RichTextbox
            // 
            this.RichTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RichTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextbox.ForeColor = System.Drawing.Color.White;
            this.RichTextbox.Location = new System.Drawing.Point(12, 96);
            this.RichTextbox.Name = "RichTextbox";
            this.RichTextbox.Size = new System.Drawing.Size(786, 403);
            this.RichTextbox.TabIndex = 8;
            this.RichTextbox.Text = "";
            this.RichTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextbox_KeyDown);
            this.RichTextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextbox_MouseDown);
            this.RichTextbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RichTextbox_MouseUp);
            // 
            // ColoresSintxCB
            // 
            this.ColoresSintxCB.AutoSize = true;
            this.ColoresSintxCB.Checked = true;
            this.ColoresSintxCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColoresSintxCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColoresSintxCB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoresSintxCB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ColoresSintxCB.Location = new System.Drawing.Point(17, 508);
            this.ColoresSintxCB.Name = "ColoresSintxCB";
            this.ColoresSintxCB.Size = new System.Drawing.Size(148, 21);
            this.ColoresSintxCB.TabIndex = 11;
            this.ColoresSintxCB.Text = "Colores de sintaxis";
            this.ColoresSintxCB.UseVisualStyleBackColor = true;
            this.ColoresSintxCB.CheckedChanged += new System.EventHandler(this.ColoresSintxCB_CheckedChanged);
            // 
            // FontsCBox
            // 
            this.FontsCBox.BackColor = System.Drawing.Color.White;
            this.FontsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontsCBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontsCBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FontsCBox.FormattingEnabled = true;
            this.FontsCBox.Location = new System.Drawing.Point(171, 505);
            this.FontsCBox.Name = "FontsCBox";
            this.FontsCBox.Size = new System.Drawing.Size(156, 24);
            this.FontsCBox.TabIndex = 12;
            this.FontsCBox.SelectedIndexChanged += new System.EventHandler(this.FontsCBox_SelectedIndexChanged);
            // 
            // FontSizeUpDown
            // 
            this.FontSizeUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FontSizeUpDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSizeUpDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FontSizeUpDown.Location = new System.Drawing.Point(333, 510);
            this.FontSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeUpDown.Name = "FontSizeUpDown";
            this.FontSizeUpDown.Size = new System.Drawing.Size(120, 17);
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
            this.BgColorBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.BgColorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BgColorBut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BgColorBut.ForeColor = System.Drawing.Color.White;
            this.BgColorBut.Location = new System.Drawing.Point(459, 505);
            this.BgColorBut.Name = "BgColorBut";
            this.BgColorBut.Size = new System.Drawing.Size(121, 24);
            this.BgColorBut.TabIndex = 14;
            this.BgColorBut.Text = "Color de fondo";
            this.BgColorBut.UseVisualStyleBackColor = false;
            this.BgColorBut.Click += new System.EventHandler(this.BgColorBut_Click);
            // 
            // TextColorBut
            // 
            this.TextColorBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.TextColorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextColorBut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColorBut.ForeColor = System.Drawing.Color.White;
            this.TextColorBut.Location = new System.Drawing.Point(586, 505);
            this.TextColorBut.Name = "TextColorBut";
            this.TextColorBut.Size = new System.Drawing.Size(121, 24);
            this.TextColorBut.TabIndex = 15;
            this.TextColorBut.Text = "Color del texto";
            this.TextColorBut.UseVisualStyleBackColor = false;
            this.TextColorBut.Click += new System.EventHandler(this.TextColorBut_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 545);
            this.Controls.Add(this.TextColorBut);
            this.Controls.Add(this.BgColorBut);
            this.Controls.Add(this.FontSizeUpDown);
            this.Controls.Add(this.ColoresSintxCB);
            this.Controls.Add(this.RichTextbox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.FontsCBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BotCBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox FileCBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox CrearBotTxtbox;
        private System.Windows.Forms.Button CrearBotButt;
        private System.Windows.Forms.RichTextBox RichTextbox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ColoresSintxCB;
        private System.Windows.Forms.ComboBox FontsCBox;
        private System.Windows.Forms.NumericUpDown FontSizeUpDown;
        private System.Windows.Forms.Button BgColorBut;
        private System.Windows.Forms.Button TextColorBut;
    }
}