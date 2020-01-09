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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nota 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nota 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Libro 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nota 1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Libro 2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoriaButton = new System.Windows.Forms.Button();
            this.CrearCategoriaLabel = new System.Windows.Forms.Label();
            this.CrearCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdminTreeView = new System.Windows.Forms.TreeView();
            this.ListaLibrosYNotasGroupBox = new System.Windows.Forms.GroupBox();
            this.CrearNotaButton = new System.Windows.Forms.Button();
            this.PanelIniciarSesionFormExtra2 = new System.Windows.Forms.Panel();
            this.PanelIniciarSesionFormExtra1 = new System.Windows.Forms.Panel();
            this.UsuarioStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EditarNotaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ListaLibrosYNotasGroupBox.SuspendLayout();
            this.UsuarioStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LimpiarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LimpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(19, 261);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(380, 37);
            this.LimpiarButton.TabIndex = 6;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CrearButton.FlatAppearance.BorderSize = 2;
            this.CrearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.CrearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CrearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearButton.Location = new System.Drawing.Point(19, 194);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(380, 61);
            this.CrearButton.TabIndex = 5;
            this.CrearButton.Text = "Crear";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nombreTextBox.Location = new System.Drawing.Point(99, 23);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(279, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color:";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ColorComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.ColorComboBox.Location = new System.Drawing.Point(98, 57);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(280, 29);
            this.ColorComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CategoriaComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Items.AddRange(new object[] {
            "Predeterminada"});
            this.CategoriaComboBox.Location = new System.Drawing.Point(98, 138);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(280, 29);
            this.CategoriaComboBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 323);
            this.panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.comboBox1.Location = new System.Drawing.Point(98, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // PrioridadLabel
            // 
            this.PrioridadLabel.AutoSize = true;
            this.PrioridadLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioridadLabel.Location = new System.Drawing.Point(16, 106);
            this.PrioridadLabel.Name = "PrioridadLabel";
            this.PrioridadLabel.Size = new System.Drawing.Size(70, 17);
            this.PrioridadLabel.TabIndex = 13;
            this.PrioridadLabel.Text = "Prioridad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.CategoriaButton);
            this.panel2.Controls.Add(this.CrearCategoriaLabel);
            this.panel2.Controls.Add(this.CrearCategoriaTextBox);
            this.panel2.Location = new System.Drawing.Point(6, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 121);
            this.panel2.TabIndex = 14;
            // 
            // CategoriaButton
            // 
            this.CategoriaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CategoriaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.CategoriaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CategoriaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaButton.Location = new System.Drawing.Point(19, 68);
            this.CategoriaButton.Name = "CategoriaButton";
            this.CategoriaButton.Size = new System.Drawing.Size(380, 37);
            this.CategoriaButton.TabIndex = 8;
            this.CategoriaButton.Text = "Crear categoria";
            this.CategoriaButton.UseVisualStyleBackColor = true;
            this.CategoriaButton.Click += new System.EventHandler(this.CategoriaButton_Click);
            // 
            // CrearCategoriaLabel
            // 
            this.CrearCategoriaLabel.AutoSize = true;
            this.CrearCategoriaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCategoriaLabel.Location = new System.Drawing.Point(16, 13);
            this.CrearCategoriaLabel.Name = "CrearCategoriaLabel";
            this.CrearCategoriaLabel.Size = new System.Drawing.Size(161, 17);
            this.CrearCategoriaLabel.TabIndex = 1;
            this.CrearCategoriaLabel.Text = "Crear categoria nueva:";
            // 
            // CrearCategoriaTextBox
            // 
            this.CrearCategoriaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CrearCategoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CrearCategoriaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCategoriaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CrearCategoriaTextBox.Location = new System.Drawing.Point(19, 39);
            this.CrearCategoriaTextBox.Name = "CrearCategoriaTextBox";
            this.CrearCategoriaTextBox.Size = new System.Drawing.Size(359, 20);
            this.CrearCategoriaTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 477);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación de libro";
            // 
            // AdminTreeView
            // 
            this.AdminTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdminTreeView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AdminTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AdminTreeView.Location = new System.Drawing.Point(6, 21);
            this.AdminTreeView.Name = "AdminTreeView";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Nota 1";
            treeNode2.Name = "Nodo6";
            treeNode2.Text = "Nota 2";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Libro 1";
            treeNode4.Name = "Nodo7";
            treeNode4.Text = "Nota 1";
            treeNode5.Name = "Nodo1";
            treeNode5.Text = "Libro 2";
            this.AdminTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.AdminTreeView.Size = new System.Drawing.Size(245, 330);
            this.AdminTreeView.TabIndex = 17;
            // 
            // ListaLibrosYNotasGroupBox
            // 
            this.ListaLibrosYNotasGroupBox.Controls.Add(this.button1);
            this.ListaLibrosYNotasGroupBox.Controls.Add(this.button2);
            this.ListaLibrosYNotasGroupBox.Controls.Add(this.EditarNotaButton);
            this.ListaLibrosYNotasGroupBox.Controls.Add(this.CrearNotaButton);
            this.ListaLibrosYNotasGroupBox.Controls.Add(this.AdminTreeView);
            this.ListaLibrosYNotasGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaLibrosYNotasGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ListaLibrosYNotasGroupBox.Location = new System.Drawing.Point(501, 35);
            this.ListaLibrosYNotasGroupBox.Name = "ListaLibrosYNotasGroupBox";
            this.ListaLibrosYNotasGroupBox.Size = new System.Drawing.Size(357, 477);
            this.ListaLibrosYNotasGroupBox.TabIndex = 18;
            this.ListaLibrosYNotasGroupBox.TabStop = false;
            this.ListaLibrosYNotasGroupBox.Text = "Lista de libros y notas";
            // 
            // CrearNotaButton
            // 
            this.CrearNotaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CrearNotaButton.FlatAppearance.BorderSize = 2;
            this.CrearNotaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.CrearNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CrearNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearNotaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearNotaButton.Location = new System.Drawing.Point(21, 372);
            this.CrearNotaButton.Name = "CrearNotaButton";
            this.CrearNotaButton.Size = new System.Drawing.Size(230, 37);
            this.CrearNotaButton.TabIndex = 14;
            this.CrearNotaButton.Text = "Crear nota";
            this.CrearNotaButton.UseVisualStyleBackColor = true;
            // 
            // PanelIniciarSesionFormExtra2
            // 
            this.PanelIniciarSesionFormExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelIniciarSesionFormExtra2.Location = new System.Drawing.Point(22, 545);
            this.PanelIniciarSesionFormExtra2.Name = "PanelIniciarSesionFormExtra2";
            this.PanelIniciarSesionFormExtra2.Size = new System.Drawing.Size(836, 6);
            this.PanelIniciarSesionFormExtra2.TabIndex = 20;
            // 
            // PanelIniciarSesionFormExtra1
            // 
            this.PanelIniciarSesionFormExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelIniciarSesionFormExtra1.Location = new System.Drawing.Point(22, 527);
            this.PanelIniciarSesionFormExtra1.Name = "PanelIniciarSesionFormExtra1";
            this.PanelIniciarSesionFormExtra1.Size = new System.Drawing.Size(836, 12);
            this.PanelIniciarSesionFormExtra1.TabIndex = 19;
            // 
            // UsuarioStatusStrip
            // 
            this.UsuarioStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuarioStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.UsuarioStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.UsuarioStatusStrip.Name = "UsuarioStatusStrip";
            this.UsuarioStatusStrip.Size = new System.Drawing.Size(880, 22);
            this.UsuarioStatusStrip.TabIndex = 21;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "nada aun";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // EditarNotaButton
            // 
            this.EditarNotaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.EditarNotaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.EditarNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EditarNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarNotaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarNotaButton.Location = new System.Drawing.Point(21, 415);
            this.EditarNotaButton.Name = "EditarNotaButton";
            this.EditarNotaButton.Size = new System.Drawing.Size(230, 37);
            this.EditarNotaButton.TabIndex = 18;
            this.EditarNotaButton.Text = "Editar nota";
            this.EditarNotaButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 153);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ordenar libros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 153);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ordenar Notas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(880, 567);
            this.Controls.Add(this.UsuarioStatusStrip);
            this.Controls.Add(this.PanelIniciarSesionFormExtra2);
            this.Controls.Add(this.PanelIniciarSesionFormExtra1);
            this.Controls.Add(this.ListaLibrosYNotasGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "NOTEez";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ListaLibrosYNotasGroupBox.ResumeLayout(false);
            this.UsuarioStatusStrip.ResumeLayout(false);
            this.UsuarioStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PrioridadLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CrearCategoriaLabel;
        private System.Windows.Forms.TextBox CrearCategoriaTextBox;
        private System.Windows.Forms.Button CategoriaButton;
        private System.Windows.Forms.TreeView AdminTreeView;
        private System.Windows.Forms.GroupBox ListaLibrosYNotasGroupBox;
        private System.Windows.Forms.Button CrearNotaButton;
        private System.Windows.Forms.Panel PanelIniciarSesionFormExtra2;
        private System.Windows.Forms.Panel PanelIniciarSesionFormExtra1;
        private System.Windows.Forms.StatusStrip UsuarioStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button EditarNotaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}