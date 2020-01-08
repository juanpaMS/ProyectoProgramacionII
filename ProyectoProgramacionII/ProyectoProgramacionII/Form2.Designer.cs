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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Grupo 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Grupo 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "aaa",
            "rrrrr",
            "tttttt"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("ssss");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("dddd");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("ento");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.LibrosColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.CrearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PrioridadLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LibrosColumnHeader});
            listViewGroup1.Header = "Grupo 1";
            listViewGroup1.Name = "1ListViewGroup";
            listViewGroup2.Header = "Grupo 2";
            listViewGroup2.Name = "2ListViewGroup";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.IndentCount = 1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(583, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(414, 471);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LibrosColumnHeader
            // 
            this.LibrosColumnHeader.Text = "Libros";
            this.LibrosColumnHeader.Width = 410;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(258, 61);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 3;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Location = new System.Drawing.Point(258, 112);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(75, 23);
            this.CrearButton.TabIndex = 4;
            this.CrearButton.Text = "Crear";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(79, 32);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color:";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(79, 71);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(79, 152);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriaComboBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.PrioridadLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CategoriaComboBox);
            this.panel1.Controls.Add(this.CrearButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LimpiarButton);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(this.ColorComboBox);
            this.panel1.Location = new System.Drawing.Point(30, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 205);
            this.panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // PrioridadLabel
            // 
            this.PrioridadLabel.AutoSize = true;
            this.PrioridadLabel.Location = new System.Drawing.Point(13, 112);
            this.PrioridadLabel.Name = "PrioridadLabel";
            this.PrioridadLabel.Size = new System.Drawing.Size(51, 13);
            this.PrioridadLabel.TabIndex = 13;
            this.PrioridadLabel.Text = "Prioridad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(30, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 75);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Crear categoria nueva:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(59, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 382);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación de libro";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.UsuarioToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.Text = "NOTEez";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LibrosColumnHeader;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PrioridadLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
    }
}