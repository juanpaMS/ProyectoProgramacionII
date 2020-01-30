namespace ProyectoProgramacionII
{
    partial class LibroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroForm));
            this.LibroGroupBox = new System.Windows.Forms.GroupBox();
            this.LibroPanel2 = new System.Windows.Forms.Panel();
            this.LibroOrdenLabel = new System.Windows.Forms.Label();
            this.LibroDataGridView = new System.Windows.Forms.DataGridView();
            this.LibroPanel1 = new System.Windows.Forms.Panel();
            this.LibroLimpiarButton = new System.Windows.Forms.Button();
            this.LibroCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.LibroCrearButton = new System.Windows.Forms.Button();
            this.LibroCategoriaLabel = new System.Windows.Forms.Label();
            this.LibroColorComboBox = new System.Windows.Forms.ComboBox();
            this.LibroColorLabel = new System.Windows.Forms.Label();
            this.LibroNombreLabel = new System.Windows.Forms.Label();
            this.LibroNombreTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.LibroGroupBox.SuspendLayout();
            this.LibroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibroDataGridView)).BeginInit();
            this.LibroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LibroGroupBox
            // 
            this.LibroGroupBox.Controls.Add(this.LibroPanel2);
            this.LibroGroupBox.Controls.Add(this.LibroPanel1);
            this.LibroGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroGroupBox.Location = new System.Drawing.Point(30, 26);
            this.LibroGroupBox.Name = "LibroGroupBox";
            this.LibroGroupBox.Size = new System.Drawing.Size(521, 638);
            this.LibroGroupBox.TabIndex = 34;
            this.LibroGroupBox.TabStop = false;
            this.LibroGroupBox.Text = "LIBRO";
            // 
            // LibroPanel2
            // 
            this.LibroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LibroPanel2.Controls.Add(this.LibroOrdenLabel);
            this.LibroPanel2.Controls.Add(this.LibroDataGridView);
            this.LibroPanel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroPanel2.Location = new System.Drawing.Point(6, 243);
            this.LibroPanel2.Name = "LibroPanel2";
            this.LibroPanel2.Size = new System.Drawing.Size(509, 389);
            this.LibroPanel2.TabIndex = 23;
            // 
            // LibroOrdenLabel
            // 
            this.LibroOrdenLabel.AutoSize = true;
            this.LibroOrdenLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroOrdenLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LibroOrdenLabel.Location = new System.Drawing.Point(12, 18);
            this.LibroOrdenLabel.Name = "LibroOrdenLabel";
            this.LibroOrdenLabel.Size = new System.Drawing.Size(110, 17);
            this.LibroOrdenLabel.TabIndex = 23;
            this.LibroOrdenLabel.Text = "Orden de libros:";
            // 
            // LibroDataGridView
            // 
            this.LibroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibroDataGridView.Location = new System.Drawing.Point(15, 42);
            this.LibroDataGridView.Name = "LibroDataGridView";
            this.LibroDataGridView.ReadOnly = true;
            this.LibroDataGridView.RowHeadersWidth = 5;
            this.LibroDataGridView.Size = new System.Drawing.Size(479, 334);
            this.LibroDataGridView.TabIndex = 22;
            this.LibroDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibroDataGridView_CellContentClick);
            // 
            // LibroPanel1
            // 
            this.LibroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LibroPanel1.Controls.Add(this.LibroLimpiarButton);
            this.LibroPanel1.Controls.Add(this.LibroCategoriaComboBox);
            this.LibroPanel1.Controls.Add(this.LibroCrearButton);
            this.LibroPanel1.Controls.Add(this.LibroCategoriaLabel);
            this.LibroPanel1.Controls.Add(this.LibroColorComboBox);
            this.LibroPanel1.Controls.Add(this.LibroColorLabel);
            this.LibroPanel1.Controls.Add(this.LibroNombreLabel);
            this.LibroPanel1.Controls.Add(this.LibroNombreTextBox);
            this.LibroPanel1.Location = new System.Drawing.Point(6, 27);
            this.LibroPanel1.Name = "LibroPanel1";
            this.LibroPanel1.Size = new System.Drawing.Size(509, 210);
            this.LibroPanel1.TabIndex = 14;
            // 
            // LibroLimpiarButton
            // 
            this.LibroLimpiarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LibroLimpiarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LibroLimpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibroLimpiarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroLimpiarButton.Location = new System.Drawing.Point(78, 157);
            this.LibroLimpiarButton.Name = "LibroLimpiarButton";
            this.LibroLimpiarButton.Size = new System.Drawing.Size(162, 37);
            this.LibroLimpiarButton.TabIndex = 14;
            this.LibroLimpiarButton.TabStop = false;
            this.LibroLimpiarButton.Text = "Limpiar Campos";
            this.LibroLimpiarButton.UseVisualStyleBackColor = true;
            // 
            // LibroCategoriaComboBox
            // 
            this.LibroCategoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LibroCategoriaComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroCategoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroCategoriaComboBox.FormattingEnabled = true;
            this.LibroCategoriaComboBox.Items.AddRange(new object[] {
            "Trabajo",
            "Familia",
            "Estudios",
            "Temas de Interes"});
            this.LibroCategoriaComboBox.Location = new System.Drawing.Point(160, 93);
            this.LibroCategoriaComboBox.Name = "LibroCategoriaComboBox";
            this.LibroCategoriaComboBox.Size = new System.Drawing.Size(274, 29);
            this.LibroCategoriaComboBox.TabIndex = 3;
            this.LibroCategoriaComboBox.Text = "Elija una categoría";
            // 
            // LibroCrearButton
            // 
            this.LibroCrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LibroCrearButton.FlatAppearance.BorderSize = 2;
            this.LibroCrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.LibroCrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LibroCrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibroCrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroCrearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroCrearButton.Location = new System.Drawing.Point(272, 157);
            this.LibroCrearButton.Name = "LibroCrearButton";
            this.LibroCrearButton.Size = new System.Drawing.Size(162, 37);
            this.LibroCrearButton.TabIndex = 4;
            this.LibroCrearButton.Text = "Crear Libro";
            this.LibroCrearButton.UseVisualStyleBackColor = true;
            this.LibroCrearButton.Click += new System.EventHandler(this.LibroCrearButton_Click);
            // 
            // LibroCategoriaLabel
            // 
            this.LibroCategoriaLabel.AutoSize = true;
            this.LibroCategoriaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroCategoriaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroCategoriaLabel.Location = new System.Drawing.Point(75, 100);
            this.LibroCategoriaLabel.Name = "LibroCategoriaLabel";
            this.LibroCategoriaLabel.Size = new System.Drawing.Size(79, 17);
            this.LibroCategoriaLabel.TabIndex = 14;
            this.LibroCategoriaLabel.Text = "Categoría:";
            // 
            // LibroColorComboBox
            // 
            this.LibroColorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LibroColorComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroColorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroColorComboBox.FormattingEnabled = true;
            this.LibroColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.LibroColorComboBox.Location = new System.Drawing.Point(160, 50);
            this.LibroColorComboBox.Name = "LibroColorComboBox";
            this.LibroColorComboBox.Size = new System.Drawing.Size(274, 29);
            this.LibroColorComboBox.TabIndex = 2;
            this.LibroColorComboBox.Text = "Elija un color";
            // 
            // LibroColorLabel
            // 
            this.LibroColorLabel.AutoSize = true;
            this.LibroColorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroColorLabel.Location = new System.Drawing.Point(75, 57);
            this.LibroColorLabel.Name = "LibroColorLabel";
            this.LibroColorLabel.Size = new System.Drawing.Size(48, 17);
            this.LibroColorLabel.TabIndex = 14;
            this.LibroColorLabel.Text = "Color:";
            // 
            // LibroNombreLabel
            // 
            this.LibroNombreLabel.AutoSize = true;
            this.LibroNombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroNombreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroNombreLabel.Location = new System.Drawing.Point(75, 16);
            this.LibroNombreLabel.Name = "LibroNombreLabel";
            this.LibroNombreLabel.Size = new System.Drawing.Size(65, 17);
            this.LibroNombreLabel.TabIndex = 1;
            this.LibroNombreLabel.Text = "Nombre:";
            // 
            // LibroNombreTextBox
            // 
            this.LibroNombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LibroNombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibroNombreTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroNombreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroNombreTextBox.Location = new System.Drawing.Point(160, 16);
            this.LibroNombreTextBox.Name = "LibroNombreTextBox";
            this.LibroNombreTextBox.Size = new System.Drawing.Size(274, 20);
            this.LibroNombreTextBox.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(30, 697);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(521, 6);
            this.PanelExtra2.TabIndex = 36;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(30, 679);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(521, 12);
            this.PanelExtra1.TabIndex = 35;
            // 
            // LibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(581, 731);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.PanelExtra1);
            this.Controls.Add(this.LibroGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LibroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de libros - NOTEez";
            this.Load += new System.EventHandler(this.LibroForm_Load);
            this.LibroGroupBox.ResumeLayout(false);
            this.LibroPanel2.ResumeLayout(false);
            this.LibroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibroDataGridView)).EndInit();
            this.LibroPanel1.ResumeLayout(false);
            this.LibroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LibroGroupBox;
        private System.Windows.Forms.Panel LibroPanel2;
        private System.Windows.Forms.Label LibroOrdenLabel;
        private System.Windows.Forms.DataGridView LibroDataGridView;
        private System.Windows.Forms.Panel LibroPanel1;
        private System.Windows.Forms.Button LibroLimpiarButton;
        private System.Windows.Forms.ComboBox LibroCategoriaComboBox;
        private System.Windows.Forms.Button LibroCrearButton;
        private System.Windows.Forms.Label LibroCategoriaLabel;
        private System.Windows.Forms.ComboBox LibroColorComboBox;
        private System.Windows.Forms.Label LibroColorLabel;
        private System.Windows.Forms.Label LibroNombreLabel;
        private System.Windows.Forms.TextBox LibroNombreTextBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PanelExtra1;
    }
}