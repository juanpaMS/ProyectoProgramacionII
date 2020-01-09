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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.ColorFuenteComboBox = new System.Windows.Forms.ComboBox();
            this.FuenteComboBox = new System.Windows.Forms.ComboBox();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.contenidoTextBox = new System.Windows.Forms.RichTextBox();
            this.AplicarButton = new System.Windows.Forms.Button();
            this.NombreLibro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.PrivacidadComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrivacidadComboBox);
            this.groupBox1.Controls.Add(this.ColorComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TituloTextBox);
            this.groupBox1.Controls.Add(this.ColorFuenteComboBox);
            this.groupBox1.Controls.Add(this.FuenteComboBox);
            this.groupBox1.Controls.Add(this.CerrarButton);
            this.groupBox1.Controls.Add(this.contenidoTextBox);
            this.groupBox1.Controls.Add(this.AplicarButton);
            this.groupBox1.Controls.Add(this.NombreLibro);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Color de Fuente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fuente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Privacidad:";
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(72, 89);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(670, 20);
            this.TituloTextBox.TabIndex = 13;
            // 
            // ColorFuenteComboBox
            // 
            this.ColorFuenteComboBox.FormattingEnabled = true;
            this.ColorFuenteComboBox.Location = new System.Drawing.Point(318, 50);
            this.ColorFuenteComboBox.Name = "ColorFuenteComboBox";
            this.ColorFuenteComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorFuenteComboBox.TabIndex = 12;
            // 
            // FuenteComboBox
            // 
            this.FuenteComboBox.FormattingEnabled = true;
            this.FuenteComboBox.Location = new System.Drawing.Point(162, 50);
            this.FuenteComboBox.Name = "FuenteComboBox";
            this.FuenteComboBox.Size = new System.Drawing.Size(121, 21);
            this.FuenteComboBox.TabIndex = 10;
            // 
            // CerrarButton
            // 
            this.CerrarButton.ForeColor = System.Drawing.Color.Teal;
            this.CerrarButton.Location = new System.Drawing.Point(640, 525);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(102, 34);
            this.CerrarButton.TabIndex = 9;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // contenidoTextBox
            // 
            this.contenidoTextBox.Location = new System.Drawing.Point(33, 120);
            this.contenidoTextBox.Name = "contenidoTextBox";
            this.contenidoTextBox.Size = new System.Drawing.Size(709, 399);
            this.contenidoTextBox.TabIndex = 7;
            this.contenidoTextBox.Text = "";
            // 
            // AplicarButton
            // 
            this.AplicarButton.ForeColor = System.Drawing.Color.Teal;
            this.AplicarButton.Location = new System.Drawing.Point(649, 31);
            this.AplicarButton.Name = "AplicarButton";
            this.AplicarButton.Size = new System.Drawing.Size(93, 40);
            this.AplicarButton.TabIndex = 6;
            this.AplicarButton.Text = "Aplicar Cambios";
            this.AplicarButton.UseVisualStyleBackColor = true;
            // 
            // NombreLibro
            // 
            this.NombreLibro.AutoSize = true;
            this.NombreLibro.Location = new System.Drawing.Point(30, 92);
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Size = new System.Drawing.Size(36, 13);
            this.NombreLibro.TabIndex = 0;
            this.NombreLibro.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Color:";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(482, 50);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 18;
            // 
            // PrivacidadComboBox
            // 
            this.PrivacidadComboBox.FormattingEnabled = true;
            this.PrivacidadComboBox.Location = new System.Drawing.Point(6, 50);
            this.PrivacidadComboBox.Name = "PrivacidadComboBox";
            this.PrivacidadComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrivacidadComboBox.TabIndex = 19;
            // 
            // EditarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarNotaForm";
            this.Text = "Editar documento - NOTEez";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.RichTextBox contenidoTextBox;
        private System.Windows.Forms.Button AplicarButton;
        private System.Windows.Forms.Label NombreLibro;
        private System.Windows.Forms.ComboBox FuenteComboBox;
        private System.Windows.Forms.ComboBox ColorFuenteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrivacidadComboBox;
    }
}