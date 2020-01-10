namespace ProyectoProgramacionII
{
    partial class EditarNotaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarNotaForm));
            this.NotaNombreLabel = new System.Windows.Forms.Label();
            this.NotaAplicarCambiosButton = new System.Windows.Forms.Button();
            this.ContenidoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NotaNombreTextBox = new System.Windows.Forms.TextBox();
            this.NotaPrivacidadLabel = new System.Windows.Forms.Label();
            this.NotaColoLabel = new System.Windows.Forms.Label();
            this.NotaColorComboBox = new System.Windows.Forms.ComboBox();
            this.NotaPrivacidadComboBox = new System.Windows.Forms.ComboBox();
            this.EditarNotaGroupBox = new System.Windows.Forms.GroupBox();
            this.EdiciónMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NotaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditarNotaGroupBox.SuspendLayout();
            this.EdiciónMenuStrip.SuspendLayout();
            this.NotaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotaNombreLabel
            // 
            this.NotaNombreLabel.AutoSize = true;
            this.NotaNombreLabel.Location = new System.Drawing.Point(19, 22);
            this.NotaNombreLabel.Name = "NotaNombreLabel";
            this.NotaNombreLabel.Size = new System.Drawing.Size(45, 17);
            this.NotaNombreLabel.TabIndex = 0;
            this.NotaNombreLabel.Text = "Titulo:";
            // 
            // NotaAplicarCambiosButton
            // 
            this.NotaAplicarCambiosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaAplicarCambiosButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.NotaAplicarCambiosButton.FlatAppearance.BorderSize = 2;
            this.NotaAplicarCambiosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.NotaAplicarCambiosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaAplicarCambiosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotaAplicarCambiosButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaAplicarCambiosButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaAplicarCambiosButton.Location = new System.Drawing.Point(584, 40);
            this.NotaAplicarCambiosButton.Name = "NotaAplicarCambiosButton";
            this.NotaAplicarCambiosButton.Size = new System.Drawing.Size(141, 29);
            this.NotaAplicarCambiosButton.TabIndex = 6;
            this.NotaAplicarCambiosButton.Text = "Aplicar Cambios";
            this.NotaAplicarCambiosButton.UseVisualStyleBackColor = false;
            this.NotaAplicarCambiosButton.Click += new System.EventHandler(this.AplicarButton_Click);
            // 
            // ContenidoRichTextBox
            // 
            this.ContenidoRichTextBox.Location = new System.Drawing.Point(16, 88);
            this.ContenidoRichTextBox.Name = "ContenidoRichTextBox";
            this.ContenidoRichTextBox.Size = new System.Drawing.Size(709, 421);
            this.ContenidoRichTextBox.TabIndex = 7;
            this.ContenidoRichTextBox.Text = "";
            // 
            // NotaNombreTextBox
            // 
            this.NotaNombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaNombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotaNombreTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaNombreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaNombreTextBox.Location = new System.Drawing.Point(22, 44);
            this.NotaNombreTextBox.Name = "NotaNombreTextBox";
            this.NotaNombreTextBox.Size = new System.Drawing.Size(221, 20);
            this.NotaNombreTextBox.TabIndex = 13;
            // 
            // NotaPrivacidadLabel
            // 
            this.NotaPrivacidadLabel.AutoSize = true;
            this.NotaPrivacidadLabel.Location = new System.Drawing.Point(266, 20);
            this.NotaPrivacidadLabel.Name = "NotaPrivacidadLabel";
            this.NotaPrivacidadLabel.Size = new System.Drawing.Size(82, 17);
            this.NotaPrivacidadLabel.TabIndex = 14;
            this.NotaPrivacidadLabel.Text = "Privacidad:";
            // 
            // NotaColoLabel
            // 
            this.NotaColoLabel.AutoSize = true;
            this.NotaColoLabel.Location = new System.Drawing.Point(424, 20);
            this.NotaColoLabel.Name = "NotaColoLabel";
            this.NotaColoLabel.Size = new System.Drawing.Size(48, 17);
            this.NotaColoLabel.TabIndex = 17;
            this.NotaColoLabel.Text = "Color:";
            // 
            // NotaColorComboBox
            // 
            this.NotaColorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaColorComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaColorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaColorComboBox.FormattingEnabled = true;
            this.NotaColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Negro"});
            this.NotaColorComboBox.Location = new System.Drawing.Point(427, 41);
            this.NotaColorComboBox.Name = "NotaColorComboBox";
            this.NotaColorComboBox.Size = new System.Drawing.Size(135, 29);
            this.NotaColorComboBox.TabIndex = 18;
            // 
            // NotaPrivacidadComboBox
            // 
            this.NotaPrivacidadComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaPrivacidadComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaPrivacidadComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaPrivacidadComboBox.FormattingEnabled = true;
            this.NotaPrivacidadComboBox.Location = new System.Drawing.Point(269, 40);
            this.NotaPrivacidadComboBox.Name = "NotaPrivacidadComboBox";
            this.NotaPrivacidadComboBox.Size = new System.Drawing.Size(135, 29);
            this.NotaPrivacidadComboBox.TabIndex = 19;
            // 
            // EditarNotaGroupBox
            // 
            this.EditarNotaGroupBox.Controls.Add(this.NotaPanel);
            this.EditarNotaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarNotaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EditarNotaGroupBox.Location = new System.Drawing.Point(12, 42);
            this.EditarNotaGroupBox.Name = "EditarNotaGroupBox";
            this.EditarNotaGroupBox.Size = new System.Drawing.Size(752, 565);
            this.EditarNotaGroupBox.TabIndex = 0;
            this.EditarNotaGroupBox.TabStop = false;
            this.EditarNotaGroupBox.Text = "Edición de NOTA";
            // 
            // EdiciónMenuStrip
            // 
            this.EdiciónMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EdiciónMenuStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdiciónMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem});
            this.EdiciónMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EdiciónMenuStrip.Name = "EdiciónMenuStrip";
            this.EdiciónMenuStrip.Size = new System.Drawing.Size(777, 29);
            this.EdiciónMenuStrip.TabIndex = 1;
            this.EdiciónMenuStrip.Text = "Menú";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Rich Text (*.rtf)|*.rtf";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "Rich Text (*.rtf)|*.rtf";
            // 
            // NotaPanel
            // 
            this.NotaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaPanel.Controls.Add(this.NotaPrivacidadComboBox);
            this.NotaPanel.Controls.Add(this.ContenidoRichTextBox);
            this.NotaPanel.Controls.Add(this.NotaColorComboBox);
            this.NotaPanel.Controls.Add(this.NotaNombreLabel);
            this.NotaPanel.Controls.Add(this.NotaColoLabel);
            this.NotaPanel.Controls.Add(this.NotaAplicarCambiosButton);
            this.NotaPanel.Controls.Add(this.NotaPrivacidadLabel);
            this.NotaPanel.Controls.Add(this.NotaNombreTextBox);
            this.NotaPanel.Location = new System.Drawing.Point(6, 22);
            this.NotaPanel.Name = "NotaPanel";
            this.NotaPanel.Size = new System.Drawing.Size(741, 536);
            this.NotaPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Location = new System.Drawing.Point(12, 623);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 12);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Location = new System.Drawing.Point(12, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 6);
            this.panel3.TabIndex = 3;
            // 
            // EditarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(777, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditarNotaGroupBox);
            this.Controls.Add(this.EdiciónMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.EdiciónMenuStrip;
            this.MaximizeBox = false;
            this.Name = "EditarNotaForm";
            this.Text = "Editar documento - NOTEez";
            this.Load += new System.EventHandler(this.EditarNotaForm_Load);
            this.EditarNotaGroupBox.ResumeLayout(false);
            this.EdiciónMenuStrip.ResumeLayout(false);
            this.EdiciónMenuStrip.PerformLayout();
            this.NotaPanel.ResumeLayout(false);
            this.NotaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NotaNombreLabel;
        private System.Windows.Forms.Button NotaAplicarCambiosButton;
        private System.Windows.Forms.RichTextBox ContenidoRichTextBox;
        private System.Windows.Forms.TextBox NotaNombreTextBox;
        private System.Windows.Forms.Label NotaPrivacidadLabel;
        private System.Windows.Forms.Label NotaColoLabel;
        private System.Windows.Forms.ComboBox NotaColorComboBox;
        private System.Windows.Forms.ComboBox NotaPrivacidadComboBox;
        private System.Windows.Forms.GroupBox EditarNotaGroupBox;
        private System.Windows.Forms.MenuStrip EdiciónMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel NotaPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}