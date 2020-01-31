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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.LibroYNotaGroupBox = new System.Windows.Forms.GroupBox();
            this.principalDataGridView = new System.Windows.Forms.DataGridView();
            this.NotaNombreLabel = new System.Windows.Forms.Label();
            this.BuscarLibroTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.VisualizacionNotasLabel = new System.Windows.Forms.Label();
            this.HojaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PanelExtra3 = new System.Windows.Forms.Panel();
            this.NotaCrearButton = new System.Windows.Forms.Button();
            this.VerNotasButton = new System.Windows.Forms.Button();
            this.LibroCrearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LibroYNotaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.PanelExtra3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibroYNotaGroupBox
            // 
            this.LibroYNotaGroupBox.Controls.Add(this.principalDataGridView);
            this.LibroYNotaGroupBox.Controls.Add(this.NotaNombreLabel);
            this.LibroYNotaGroupBox.Controls.Add(this.BuscarLibroTextBox);
            this.LibroYNotaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroYNotaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroYNotaGroupBox.Location = new System.Drawing.Point(29, 21);
            this.LibroYNotaGroupBox.Name = "LibroYNotaGroupBox";
            this.LibroYNotaGroupBox.Size = new System.Drawing.Size(447, 424);
            this.LibroYNotaGroupBox.TabIndex = 18;
            this.LibroYNotaGroupBox.TabStop = false;
            this.LibroYNotaGroupBox.Text = "Lista de libros y notas";
            // 
            // principalDataGridView
            // 
            this.principalDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.principalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.principalDataGridView.GridColor = System.Drawing.Color.DarkTurquoise;
            this.principalDataGridView.Location = new System.Drawing.Point(16, 90);
            this.principalDataGridView.Name = "principalDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.principalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.principalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.principalDataGridView.Size = new System.Drawing.Size(414, 319);
            this.principalDataGridView.TabIndex = 10;
            this.principalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.principalDataGridView_CellContentClick);
            // 
            // NotaNombreLabel
            // 
            this.NotaNombreLabel.AutoSize = true;
            this.NotaNombreLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaNombreLabel.Location = new System.Drawing.Point(23, 38);
            this.NotaNombreLabel.Name = "NotaNombreLabel";
            this.NotaNombreLabel.Size = new System.Drawing.Size(105, 21);
            this.NotaNombreLabel.TabIndex = 8;
            this.NotaNombreLabel.Text = "Buscar Libro:";
            // 
            // BuscarLibroTextBox
            // 
            this.BuscarLibroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BuscarLibroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarLibroTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLibroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ErrorProvider.SetIconPadding(this.BuscarLibroTextBox, 10);
            this.BuscarLibroTextBox.Location = new System.Drawing.Point(134, 39);
            this.BuscarLibroTextBox.Name = "BuscarLibroTextBox";
            this.BuscarLibroTextBox.Size = new System.Drawing.Size(270, 20);
            this.BuscarLibroTextBox.TabIndex = 1;
            this.BuscarLibroTextBox.TextChanged += new System.EventHandler(this.BuscarLibroTextBox_TextChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(11, 673);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(1109, 6);
            this.PanelExtra2.TabIndex = 31;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(11, 655);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(1109, 12);
            this.PanelExtra1.TabIndex = 30;
            // 
            // VisualizacionNotasLabel
            // 
            this.VisualizacionNotasLabel.AutoSize = true;
            this.VisualizacionNotasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizacionNotasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.VisualizacionNotasLabel.Location = new System.Drawing.Point(495, 21);
            this.VisualizacionNotasLabel.Name = "VisualizacionNotasLabel";
            this.VisualizacionNotasLabel.Size = new System.Drawing.Size(179, 21);
            this.VisualizacionNotasLabel.TabIndex = 32;
            this.VisualizacionNotasLabel.Text = "Visualizacion de nota:";
            // 
            // HojaRichTextBox
            // 
            this.HojaRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HojaRichTextBox.ForeColor = System.Drawing.Color.White;
            this.HojaRichTextBox.Location = new System.Drawing.Point(499, 59);
            this.HojaRichTextBox.Name = "HojaRichTextBox";
            this.HojaRichTextBox.Size = new System.Drawing.Size(606, 581);
            this.HojaRichTextBox.TabIndex = 33;
            this.HojaRichTextBox.Text = "";
            // 
            // PanelExtra3
            // 
            this.PanelExtra3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra3.Controls.Add(this.NotaCrearButton);
            this.PanelExtra3.Controls.Add(this.VerNotasButton);
            this.PanelExtra3.Location = new System.Drawing.Point(29, 451);
            this.PanelExtra3.Name = "PanelExtra3";
            this.PanelExtra3.Size = new System.Drawing.Size(447, 117);
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
            this.NotaCrearButton.Location = new System.Drawing.Point(105, 65);
            this.NotaCrearButton.Name = "NotaCrearButton";
            this.NotaCrearButton.Size = new System.Drawing.Size(237, 37);
            this.NotaCrearButton.TabIndex = 6;
            this.NotaCrearButton.Text = "Agregar Notas";
            this.NotaCrearButton.UseVisualStyleBackColor = false;
            this.NotaCrearButton.Click += new System.EventHandler(this.NotaCrearButton_Click);
            // 
            // VerNotasButton
            // 
            this.VerNotasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VerNotasButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.VerNotasButton.FlatAppearance.BorderSize = 2;
            this.VerNotasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.VerNotasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VerNotasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerNotasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerNotasButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.VerNotasButton.Location = new System.Drawing.Point(105, 14);
            this.VerNotasButton.Name = "VerNotasButton";
            this.VerNotasButton.Size = new System.Drawing.Size(237, 36);
            this.VerNotasButton.TabIndex = 2;
            this.VerNotasButton.Text = "Ver Notas";
            this.VerNotasButton.UseVisualStyleBackColor = false;
            this.VerNotasButton.Click += new System.EventHandler(this.VerNotasButton_Click);
            // 
            // LibroCrearButton
            // 
            this.LibroCrearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LibroCrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LibroCrearButton.FlatAppearance.BorderSize = 3;
            this.LibroCrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.LibroCrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LibroCrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibroCrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroCrearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroCrearButton.Location = new System.Drawing.Point(46, 14);
            this.LibroCrearButton.Name = "LibroCrearButton";
            this.LibroCrearButton.Size = new System.Drawing.Size(358, 37);
            this.LibroCrearButton.TabIndex = 5;
            this.LibroCrearButton.Text = "Crear Libro";
            this.LibroCrearButton.UseVisualStyleBackColor = false;
            this.LibroCrearButton.Click += new System.EventHandler(this.LibroCrearButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.LibroCrearButton);
            this.panel1.Location = new System.Drawing.Point(29, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 66);
            this.panel1.TabIndex = 33;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1133, 693);
            this.Controls.Add(this.PanelExtra3);
            this.Controls.Add(this.HojaRichTextBox);
            this.Controls.Add(this.VisualizacionNotasLabel);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.PanelExtra1);
            this.Controls.Add(this.LibroYNotaGroupBox);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.PanelExtra3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox LibroYNotaGroupBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PanelExtra1;
        private System.Windows.Forms.Label VisualizacionNotasLabel;
        private System.Windows.Forms.RichTextBox HojaRichTextBox;
        private System.Windows.Forms.Panel PanelExtra3;
        private System.Windows.Forms.Button NotaCrearButton;
        private System.Windows.Forms.Button LibroCrearButton;
        private System.Windows.Forms.TextBox BuscarLibroTextBox;
        private System.Windows.Forms.Label NotaNombreLabel;
        private System.Windows.Forms.DataGridView principalDataGridView;
        private System.Windows.Forms.Button VerNotasButton;
        private System.Windows.Forms.Panel panel1;
    }
}