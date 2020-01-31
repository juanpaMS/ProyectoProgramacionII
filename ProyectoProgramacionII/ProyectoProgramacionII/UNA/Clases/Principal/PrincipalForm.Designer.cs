namespace ProyectoProgramacionII
{
    partial class PrincipalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.LibrosYNotasImageList = new System.Windows.Forms.ImageList(this.components);
            this.LibroYNotaGroupBox = new System.Windows.Forms.GroupBox();
            this.UsuarioStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.VisualizacionNotasLabel = new System.Windows.Forms.Label();
            this.HojaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PanelExtra3 = new System.Windows.Forms.Panel();
            this.NotaCrearButton = new System.Windows.Forms.Button();
            this.LibroCrearButton = new System.Windows.Forms.Button();
            this.BuscarLibroTextBox = new System.Windows.Forms.TextBox();
            this.NotaNombreLabel = new System.Windows.Forms.Label();
            this.VerNotasButton = new System.Windows.Forms.Button();
            this.principalDataGridView = new System.Windows.Forms.DataGridView();
            this.LibroYNotaGroupBox.SuspendLayout();
            this.UsuarioStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.PanelExtra3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibrosYNotasImageList
            // 
            this.LibrosYNotasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LibrosYNotasImageList.ImageStream")));
            this.LibrosYNotasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.LibrosYNotasImageList.Images.SetKeyName(0, "ICONO LIBRO.png");
            this.LibrosYNotasImageList.Images.SetKeyName(1, "ICONO HOJA.png");
            // 
            // LibroYNotaGroupBox
            // 
            this.LibroYNotaGroupBox.Controls.Add(this.principalDataGridView);
            this.LibroYNotaGroupBox.Controls.Add(this.NotaNombreLabel);
            this.LibroYNotaGroupBox.Controls.Add(this.BuscarLibroTextBox);
            this.LibroYNotaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroYNotaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroYNotaGroupBox.Location = new System.Drawing.Point(30, 44);
            this.LibroYNotaGroupBox.Name = "LibroYNotaGroupBox";
            this.LibroYNotaGroupBox.Size = new System.Drawing.Size(417, 358);
            this.LibroYNotaGroupBox.TabIndex = 18;
            this.LibroYNotaGroupBox.TabStop = false;
            this.LibroYNotaGroupBox.Text = "Lista de libros y notas";
            // 
            // UsuarioStatusStrip
            // 
            this.UsuarioStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuarioStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel});
            this.UsuarioStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.UsuarioStatusStrip.Name = "UsuarioStatusStrip";
            this.UsuarioStatusStrip.Size = new System.Drawing.Size(1056, 22);
            this.UsuarioStatusStrip.TabIndex = 21;
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(93, 17);
            this.UsuarioToolStripStatusLabel.Text = "@Usuario actual";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(12, 708);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(1032, 6);
            this.PanelExtra2.TabIndex = 31;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(12, 690);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(1032, 12);
            this.PanelExtra1.TabIndex = 30;
            // 
            // VisualizacionNotasLabel
            // 
            this.VisualizacionNotasLabel.AutoSize = true;
            this.VisualizacionNotasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizacionNotasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.VisualizacionNotasLabel.Location = new System.Drawing.Point(496, 44);
            this.VisualizacionNotasLabel.Name = "VisualizacionNotasLabel";
            this.VisualizacionNotasLabel.Size = new System.Drawing.Size(179, 21);
            this.VisualizacionNotasLabel.TabIndex = 32;
            this.VisualizacionNotasLabel.Text = "Visualizacion de nota:";
            // 
            // HojaRichTextBox
            // 
            this.HojaRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HojaRichTextBox.ForeColor = System.Drawing.Color.White;
            this.HojaRichTextBox.Location = new System.Drawing.Point(500, 82);
            this.HojaRichTextBox.Name = "HojaRichTextBox";
            this.HojaRichTextBox.Size = new System.Drawing.Size(525, 509);
            this.HojaRichTextBox.TabIndex = 33;
            this.HojaRichTextBox.Text = "";
            // 
            // PanelExtra3
            // 
            this.PanelExtra3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra3.Controls.Add(this.NotaCrearButton);
            this.PanelExtra3.Controls.Add(this.VerNotasButton);
            this.PanelExtra3.Location = new System.Drawing.Point(30, 430);
            this.PanelExtra3.Name = "PanelExtra3";
            this.PanelExtra3.Size = new System.Drawing.Size(417, 161);
            this.PanelExtra3.TabIndex = 32;
            // 
            // NotaCrearButton
            // 
            this.NotaCrearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NotaCrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.NotaCrearButton.FlatAppearance.BorderSize = 3;
            this.NotaCrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.NotaCrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaCrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotaCrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaCrearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaCrearButton.Location = new System.Drawing.Point(90, 103);
            this.NotaCrearButton.Name = "NotaCrearButton";
            this.NotaCrearButton.Size = new System.Drawing.Size(237, 37);
            this.NotaCrearButton.TabIndex = 6;
            this.NotaCrearButton.Text = "Agregar Notas";
            this.NotaCrearButton.UseVisualStyleBackColor = false;
            this.NotaCrearButton.Click += new System.EventHandler(this.NotaCrearButton_Click);
            // 
            // LibroCrearButton
            // 
            this.LibroCrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LibroCrearButton.FlatAppearance.BorderSize = 3;
            this.LibroCrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.LibroCrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LibroCrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibroCrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroCrearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroCrearButton.Location = new System.Drawing.Point(48, 632);
            this.LibroCrearButton.Name = "LibroCrearButton";
            this.LibroCrearButton.Size = new System.Drawing.Size(371, 37);
            this.LibroCrearButton.TabIndex = 5;
            this.LibroCrearButton.Text = "Crear Libro";
            this.LibroCrearButton.UseVisualStyleBackColor = true;
            this.LibroCrearButton.Click += new System.EventHandler(this.LibroCrearButton_Click);
            // 
            // BuscarLibroTextBox
            // 
            this.BuscarLibroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BuscarLibroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarLibroTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLibroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BuscarLibroTextBox.Location = new System.Drawing.Point(103, 53);
            this.BuscarLibroTextBox.Name = "BuscarLibroTextBox";
            this.BuscarLibroTextBox.Size = new System.Drawing.Size(286, 20);
            this.BuscarLibroTextBox.TabIndex = 2;
            this.BuscarLibroTextBox.TextChanged += new System.EventHandler(this.BuscarLibroTextBox_TextChanged);
            // 
            // NotaNombreLabel
            // 
            this.NotaNombreLabel.AutoSize = true;
            this.NotaNombreLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaNombreLabel.Location = new System.Drawing.Point(27, 52);
            this.NotaNombreLabel.Name = "NotaNombreLabel";
            this.NotaNombreLabel.Size = new System.Drawing.Size(50, 21);
            this.NotaNombreLabel.TabIndex = 8;
            this.NotaNombreLabel.Text = "Libro:";
            // 
            // VerNotasButton
            // 
            this.VerNotasButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.VerNotasButton.FlatAppearance.BorderSize = 2;
            this.VerNotasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.VerNotasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VerNotasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerNotasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerNotasButton.Location = new System.Drawing.Point(90, 21);
            this.VerNotasButton.Name = "VerNotasButton";
            this.VerNotasButton.Size = new System.Drawing.Size(237, 36);
            this.VerNotasButton.TabIndex = 9;
            this.VerNotasButton.Text = "VerNotas";
            this.VerNotasButton.UseVisualStyleBackColor = true;
            this.VerNotasButton.Click += new System.EventHandler(this.VerNotasButton_Click);
            // 
            // principalDataGridView
            // 
            this.principalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.principalDataGridView.Location = new System.Drawing.Point(31, 104);
            this.principalDataGridView.Name = "principalDataGridView";
            this.principalDataGridView.Size = new System.Drawing.Size(358, 230);
            this.principalDataGridView.TabIndex = 10;
            this.principalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.principalDataGridView_CellContentClick);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1056, 732);
            this.Controls.Add(this.LibroCrearButton);
            this.Controls.Add(this.PanelExtra3);
            this.Controls.Add(this.HojaRichTextBox);
            this.Controls.Add(this.VisualizacionNotasLabel);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.PanelExtra1);
            this.Controls.Add(this.UsuarioStatusStrip);
            this.Controls.Add(this.LibroYNotaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTEez";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.LibroYNotaGroupBox.ResumeLayout(false);
            this.LibroYNotaGroupBox.PerformLayout();
            this.UsuarioStatusStrip.ResumeLayout(false);
            this.UsuarioStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.PanelExtra3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox LibroYNotaGroupBox;
        private System.Windows.Forms.StatusStrip UsuarioStatusStrip;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PanelExtra1;
        private System.Windows.Forms.ImageList LibrosYNotasImageList;
        private System.Windows.Forms.Label VisualizacionNotasLabel;
        private System.Windows.Forms.RichTextBox HojaRichTextBox;
        public System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.Panel PanelExtra3;
        private System.Windows.Forms.Button NotaCrearButton;
        private System.Windows.Forms.Button LibroCrearButton;
        private System.Windows.Forms.TextBox BuscarLibroTextBox;
        private System.Windows.Forms.Label NotaNombreLabel;
        private System.Windows.Forms.DataGridView principalDataGridView;
        private System.Windows.Forms.Button VerNotasButton;
    }
}