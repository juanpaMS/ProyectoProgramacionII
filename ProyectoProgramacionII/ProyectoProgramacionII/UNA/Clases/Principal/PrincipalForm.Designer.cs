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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.ListaLibroYNotaTreeView = new System.Windows.Forms.TreeView();
            this.LibrosYNotasImageList = new System.Windows.Forms.ImageList(this.components);
            this.LibroYNotaGroupBox = new System.Windows.Forms.GroupBox();
            this.UsuarioStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.VisualizacionNotasLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LibroYNotaGroupBox.SuspendLayout();
            this.UsuarioStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaLibroYNotaTreeView
            // 
            this.ListaLibroYNotaTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListaLibroYNotaTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaLibroYNotaTreeView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaLibroYNotaTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ListaLibroYNotaTreeView.ImageIndex = 0;
            this.ListaLibroYNotaTreeView.ImageList = this.LibrosYNotasImageList;
            this.ListaLibroYNotaTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ListaLibroYNotaTreeView.Location = new System.Drawing.Point(36, 21);
            this.ListaLibroYNotaTreeView.Name = "ListaLibroYNotaTreeView";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Nodo1";
            treeNode2.Name = "Nodo0";
            treeNode2.Text = "Nodo0";
            this.ListaLibroYNotaTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.ListaLibroYNotaTreeView.SelectedImageIndex = 0;
            this.ListaLibroYNotaTreeView.Size = new System.Drawing.Size(202, 597);
            this.ListaLibroYNotaTreeView.TabIndex = 17;
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
            this.LibroYNotaGroupBox.Controls.Add(this.ListaLibroYNotaTreeView);
            this.LibroYNotaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibroYNotaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LibroYNotaGroupBox.Location = new System.Drawing.Point(30, 44);
            this.LibroYNotaGroupBox.Name = "LibroYNotaGroupBox";
            this.LibroYNotaGroupBox.Size = new System.Drawing.Size(276, 631);
            this.LibroYNotaGroupBox.TabIndex = 18;
            this.LibroYNotaGroupBox.TabStop = false;
            this.LibroYNotaGroupBox.Text = "Lista de libros y notas";
            // 
            // UsuarioStatusStrip
            // 
            this.UsuarioStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuarioStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.UsuarioStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.UsuarioStatusStrip.Name = "UsuarioStatusStrip";
            this.UsuarioStatusStrip.Size = new System.Drawing.Size(1113, 22);
            this.UsuarioStatusStrip.TabIndex = 21;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "@Usuario actual";
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
            this.PanelExtra2.Size = new System.Drawing.Size(1089, 6);
            this.PanelExtra2.TabIndex = 31;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(12, 690);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(1089, 12);
            this.PanelExtra1.TabIndex = 30;
            // 
            // VisualizacionNotasLabel
            // 
            this.VisualizacionNotasLabel.AutoSize = true;
            this.VisualizacionNotasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizacionNotasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.VisualizacionNotasLabel.Location = new System.Drawing.Point(360, 44);
            this.VisualizacionNotasLabel.Name = "VisualizacionNotasLabel";
            this.VisualizacionNotasLabel.Size = new System.Drawing.Size(179, 21);
            this.VisualizacionNotasLabel.TabIndex = 32;
            this.VisualizacionNotasLabel.Text = "Visualizacion de nota:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(364, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(717, 522);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1113, 732);
            this.Controls.Add(this.richTextBox1);
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
            this.UsuarioStatusStrip.ResumeLayout(false);
            this.UsuarioStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView ListaLibroYNotaTreeView;
        private System.Windows.Forms.GroupBox LibroYNotaGroupBox;
        private System.Windows.Forms.StatusStrip UsuarioStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PanelExtra1;
        private System.Windows.Forms.ImageList LibrosYNotasImageList;
        private System.Windows.Forms.Label VisualizacionNotasLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}