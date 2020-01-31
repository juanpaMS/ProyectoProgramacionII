namespace ProyectoProgramacionII
{
    partial class NotaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaForm));
            this.NotaGroupBox = new System.Windows.Forms.GroupBox();
            this.NotaPanel1 = new System.Windows.Forms.Panel();
            this.NotaPrivacidadComboBox = new System.Windows.Forms.ComboBox();
            this.NotaPrioridadLabel = new System.Windows.Forms.Label();
            this.NotaNombreLabel = new System.Windows.Forms.Label();
            this.NotaCategoriaLabel = new System.Windows.Forms.Label();
            this.NotaCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.NotaCrearButton = new System.Windows.Forms.Button();
            this.NotaColorLabel = new System.Windows.Forms.Label();
            this.NotaLimpiarButton = new System.Windows.Forms.Button();
            this.NotaNombreTextBox = new System.Windows.Forms.TextBox();
            this.NotaColorComboBox = new System.Windows.Forms.ComboBox();
            this.NotaPanel2 = new System.Windows.Forms.Panel();
            this.NotaEliminarButton = new System.Windows.Forms.Button();
            this.BuscarNotaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarNotaLabel = new System.Windows.Forms.Label();
            this.NotaDataGridView = new System.Windows.Forms.DataGridView();
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.NotaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NotaGroupBox.SuspendLayout();
            this.NotaPanel1.SuspendLayout();
            this.NotaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NotaGroupBox
            // 
            this.NotaGroupBox.Controls.Add(this.NotaPanel1);
            this.NotaGroupBox.Controls.Add(this.NotaPanel2);
            this.NotaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaGroupBox.Location = new System.Drawing.Point(31, 29);
            this.NotaGroupBox.Name = "NotaGroupBox";
            this.NotaGroupBox.Size = new System.Drawing.Size(522, 638);
            this.NotaGroupBox.TabIndex = 16;
            this.NotaGroupBox.TabStop = false;
            this.NotaGroupBox.Text = "NOTA";
            // 
            // NotaPanel1
            // 
            this.NotaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaPanel1.Controls.Add(this.NotaPrivacidadComboBox);
            this.NotaPanel1.Controls.Add(this.NotaPrioridadLabel);
            this.NotaPanel1.Controls.Add(this.NotaNombreLabel);
            this.NotaPanel1.Controls.Add(this.NotaCategoriaLabel);
            this.NotaPanel1.Controls.Add(this.NotaCategoriaComboBox);
            this.NotaPanel1.Controls.Add(this.NotaCrearButton);
            this.NotaPanel1.Controls.Add(this.NotaColorLabel);
            this.NotaPanel1.Controls.Add(this.NotaLimpiarButton);
            this.NotaPanel1.Controls.Add(this.NotaNombreTextBox);
            this.NotaPanel1.Controls.Add(this.NotaColorComboBox);
            this.NotaPanel1.Location = new System.Drawing.Point(6, 27);
            this.NotaPanel1.Name = "NotaPanel1";
            this.NotaPanel1.Size = new System.Drawing.Size(510, 226);
            this.NotaPanel1.TabIndex = 13;
            // 
            // NotaPrivacidadComboBox
            // 
            this.NotaPrivacidadComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaPrivacidadComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaPrivacidadComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaPrivacidadComboBox.FormattingEnabled = true;
            this.NotaPrivacidadComboBox.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.NotaPrivacidadComboBox.Location = new System.Drawing.Point(161, 80);
            this.NotaPrivacidadComboBox.Name = "NotaPrivacidadComboBox";
            this.NotaPrivacidadComboBox.Size = new System.Drawing.Size(280, 29);
            this.NotaPrivacidadComboBox.TabIndex = 3;
            this.NotaPrivacidadComboBox.Text = "Elija tipo de privacidad";
            // 
            // NotaPrioridadLabel
            // 
            this.NotaPrioridadLabel.AutoSize = true;
            this.NotaPrioridadLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaPrioridadLabel.Location = new System.Drawing.Point(60, 87);
            this.NotaPrioridadLabel.Name = "NotaPrioridadLabel";
            this.NotaPrioridadLabel.Size = new System.Drawing.Size(82, 17);
            this.NotaPrioridadLabel.TabIndex = 13;
            this.NotaPrioridadLabel.Text = "Privacidad:";
            // 
            // NotaNombreLabel
            // 
            this.NotaNombreLabel.AutoSize = true;
            this.NotaNombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaNombreLabel.Location = new System.Drawing.Point(60, 17);
            this.NotaNombreLabel.Name = "NotaNombreLabel";
            this.NotaNombreLabel.Size = new System.Drawing.Size(65, 17);
            this.NotaNombreLabel.TabIndex = 7;
            this.NotaNombreLabel.Text = "Nombre:";
            // 
            // NotaCategoriaLabel
            // 
            this.NotaCategoriaLabel.AutoSize = true;
            this.NotaCategoriaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaCategoriaLabel.Location = new System.Drawing.Point(60, 125);
            this.NotaCategoriaLabel.Name = "NotaCategoriaLabel";
            this.NotaCategoriaLabel.Size = new System.Drawing.Size(79, 17);
            this.NotaCategoriaLabel.TabIndex = 11;
            this.NotaCategoriaLabel.Text = "Categoría:";
            // 
            // NotaCategoriaComboBox
            // 
            this.NotaCategoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaCategoriaComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaCategoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaCategoriaComboBox.FormattingEnabled = true;
            this.NotaCategoriaComboBox.Items.AddRange(new object[] {
            "Trabajo\t",
            "Familia",
            "Estudios",
            "Temas de Interes"});
            this.NotaCategoriaComboBox.Location = new System.Drawing.Point(161, 118);
            this.NotaCategoriaComboBox.Name = "NotaCategoriaComboBox";
            this.NotaCategoriaComboBox.Size = new System.Drawing.Size(280, 29);
            this.NotaCategoriaComboBox.TabIndex = 4;
            this.NotaCategoriaComboBox.Text = "Elija una categoría";
            // 
            // NotaCrearButton
            // 
            this.NotaCrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.NotaCrearButton.FlatAppearance.BorderSize = 2;
            this.NotaCrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.NotaCrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaCrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotaCrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaCrearButton.Location = new System.Drawing.Point(272, 171);
            this.NotaCrearButton.Name = "NotaCrearButton";
            this.NotaCrearButton.Size = new System.Drawing.Size(169, 37);
            this.NotaCrearButton.TabIndex = 5;
            this.NotaCrearButton.Text = "Crear Nota";
            this.NotaCrearButton.UseVisualStyleBackColor = true;
            this.NotaCrearButton.Click += new System.EventHandler(this.NotaCrearButton_Click);
            // 
            // NotaColorLabel
            // 
            this.NotaColorLabel.AutoSize = true;
            this.NotaColorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaColorLabel.Location = new System.Drawing.Point(60, 50);
            this.NotaColorLabel.Name = "NotaColorLabel";
            this.NotaColorLabel.Size = new System.Drawing.Size(48, 17);
            this.NotaColorLabel.TabIndex = 9;
            this.NotaColorLabel.Text = "Color:";
            // 
            // NotaLimpiarButton
            // 
            this.NotaLimpiarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaLimpiarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaLimpiarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaLimpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotaLimpiarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaLimpiarButton.Location = new System.Drawing.Point(63, 171);
            this.NotaLimpiarButton.Name = "NotaLimpiarButton";
            this.NotaLimpiarButton.Size = new System.Drawing.Size(169, 37);
            this.NotaLimpiarButton.TabIndex = 6;
            this.NotaLimpiarButton.TabStop = false;
            this.NotaLimpiarButton.Text = "Limpiar Campos";
            this.NotaLimpiarButton.UseVisualStyleBackColor = true;
            this.NotaLimpiarButton.Click += new System.EventHandler(this.NotaLimpiarButton_Click);
            // 
            // NotaNombreTextBox
            // 
            this.NotaNombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaNombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotaNombreTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaNombreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaNombreTextBox.Location = new System.Drawing.Point(161, 13);
            this.NotaNombreTextBox.Name = "NotaNombreTextBox";
            this.NotaNombreTextBox.Size = new System.Drawing.Size(280, 20);
            this.NotaNombreTextBox.TabIndex = 1;
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
            "Azul"});
            this.NotaColorComboBox.Location = new System.Drawing.Point(161, 43);
            this.NotaColorComboBox.Name = "NotaColorComboBox";
            this.NotaColorComboBox.Size = new System.Drawing.Size(280, 29);
            this.NotaColorComboBox.TabIndex = 2;
            this.NotaColorComboBox.Text = "Elija un color";
            // 
            // NotaPanel2
            // 
            this.NotaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotaPanel2.Controls.Add(this.NotaEliminarButton);
            this.NotaPanel2.Controls.Add(this.BuscarNotaTextBox);
            this.NotaPanel2.Controls.Add(this.BuscarNotaLabel);
            this.NotaPanel2.Controls.Add(this.NotaDataGridView);
            this.NotaPanel2.Location = new System.Drawing.Point(6, 259);
            this.NotaPanel2.Name = "NotaPanel2";
            this.NotaPanel2.Size = new System.Drawing.Size(510, 373);
            this.NotaPanel2.TabIndex = 30;
            // 
            // NotaEliminarButton
            // 
            this.NotaEliminarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaEliminarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaEliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NotaEliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotaEliminarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaEliminarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NotaEliminarButton.Location = new System.Drawing.Point(161, 324);
            this.NotaEliminarButton.Name = "NotaEliminarButton";
            this.NotaEliminarButton.Size = new System.Drawing.Size(169, 36);
            this.NotaEliminarButton.TabIndex = 31;
            this.NotaEliminarButton.Text = "Eliminar";
            this.NotaEliminarButton.UseVisualStyleBackColor = true;
            this.NotaEliminarButton.Click += new System.EventHandler(this.NotaEliminarButton_Click);
            // 
            // BuscarNotaTextBox
            // 
            this.BuscarNotaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BuscarNotaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarNotaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarNotaTextBox.Location = new System.Drawing.Point(138, 19);
            this.BuscarNotaTextBox.Name = "BuscarNotaTextBox";
            this.BuscarNotaTextBox.Size = new System.Drawing.Size(303, 20);
            this.BuscarNotaTextBox.TabIndex = 29;
            this.BuscarNotaTextBox.TextChanged += new System.EventHandler(this.BuscarNotaTextBox_TextChanged);
            // 
            // BuscarNotaLabel
            // 
            this.BuscarNotaLabel.AutoSize = true;
            this.BuscarNotaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarNotaLabel.Location = new System.Drawing.Point(79, 22);
            this.BuscarNotaLabel.Name = "BuscarNotaLabel";
            this.BuscarNotaLabel.Size = new System.Drawing.Size(53, 17);
            this.BuscarNotaLabel.TabIndex = 30;
            this.BuscarNotaLabel.Text = "Buscar:";
            // 
            // NotaDataGridView
            // 
            this.NotaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotaDataGridView.Location = new System.Drawing.Point(0, 61);
            this.NotaDataGridView.Name = "NotaDataGridView";
            this.NotaDataGridView.ReadOnly = true;
            this.NotaDataGridView.RowHeadersWidth = 5;
            this.NotaDataGridView.Size = new System.Drawing.Size(510, 245);
            this.NotaDataGridView.TabIndex = 28;
            this.NotaDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotaDataGridView_CellContentDoubleClick);
            this.NotaDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NotaDataGridView_CellMouseClick);
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(31, 700);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(522, 6);
            this.PanelExtra2.TabIndex = 32;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(31, 682);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(522, 12);
            this.PanelExtra1.TabIndex = 31;
            // 
            // NotaErrorProvider
            // 
            this.NotaErrorProvider.ContainerControl = this;
            // 
            // NotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(585, 730);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.NotaGroupBox);
            this.Controls.Add(this.PanelExtra1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NotaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotaForm";
            this.Load += new System.EventHandler(this.NotaForm_Load);
            this.NotaGroupBox.ResumeLayout(false);
            this.NotaPanel1.ResumeLayout(false);
            this.NotaPanel1.PerformLayout();
            this.NotaPanel2.ResumeLayout(false);
            this.NotaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NotaGroupBox;
        private System.Windows.Forms.Panel NotaPanel1;
        private System.Windows.Forms.ComboBox NotaPrivacidadComboBox;
        private System.Windows.Forms.Label NotaPrioridadLabel;
        private System.Windows.Forms.Label NotaNombreLabel;
        private System.Windows.Forms.Label NotaCategoriaLabel;
        private System.Windows.Forms.ComboBox NotaCategoriaComboBox;
        private System.Windows.Forms.Button NotaCrearButton;
        private System.Windows.Forms.Label NotaColorLabel;
        private System.Windows.Forms.Button NotaLimpiarButton;
        private System.Windows.Forms.TextBox NotaNombreTextBox;
        private System.Windows.Forms.ComboBox NotaColorComboBox;
        private System.Windows.Forms.Panel NotaPanel2;
        private System.Windows.Forms.DataGridView NotaDataGridView;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PanelExtra1;
        private System.Windows.Forms.ErrorProvider NotaErrorProvider;
        private System.Windows.Forms.TextBox BuscarNotaTextBox;
        private System.Windows.Forms.Label BuscarNotaLabel;
        private System.Windows.Forms.Button NotaEliminarButton;
    }
}