namespace ProyectoProgramacionII
{
    partial class RegistrarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarForm));
            this.UsuarioRegistrarPanel = new System.Windows.Forms.Panel();
            this.UsuarioRegistrarLabel = new System.Windows.Forms.Label();
            this.UsuarioRegistrarTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaRegistrarPanel = new System.Windows.Forms.Panel();
            this.ContrasenaRegistrarLabel = new System.Windows.Forms.Label();
            this.ContrasenaRegistrarTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.PaneñExtra1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioRegistrarPanel.SuspendLayout();
            this.ContrasenaRegistrarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioRegistrarPanel
            // 
            this.UsuarioRegistrarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioRegistrarPanel.Controls.Add(this.UsuarioRegistrarLabel);
            this.UsuarioRegistrarPanel.Controls.Add(this.UsuarioRegistrarTextBox);
            this.UsuarioRegistrarPanel.Location = new System.Drawing.Point(12, 12);
            this.UsuarioRegistrarPanel.Name = "UsuarioRegistrarPanel";
            this.UsuarioRegistrarPanel.Size = new System.Drawing.Size(429, 75);
            this.UsuarioRegistrarPanel.TabIndex = 3;
            // 
            // UsuarioRegistrarLabel
            // 
            this.UsuarioRegistrarLabel.AutoSize = true;
            this.UsuarioRegistrarLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioRegistrarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.UsuarioRegistrarLabel.Location = new System.Drawing.Point(10, 9);
            this.UsuarioRegistrarLabel.Name = "UsuarioRegistrarLabel";
            this.UsuarioRegistrarLabel.Size = new System.Drawing.Size(200, 17);
            this.UsuarioRegistrarLabel.TabIndex = 0;
            this.UsuarioRegistrarLabel.Text = "Ingrese su nombre de usuario:";
            // 
            // UsuarioRegistrarTextBox
            // 
            this.UsuarioRegistrarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioRegistrarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioRegistrarTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioRegistrarTextBox.ForeColor = System.Drawing.Color.White;
            this.UsuarioRegistrarTextBox.Location = new System.Drawing.Point(13, 41);
            this.UsuarioRegistrarTextBox.Name = "UsuarioRegistrarTextBox";
            this.UsuarioRegistrarTextBox.Size = new System.Drawing.Size(367, 20);
            this.UsuarioRegistrarTextBox.TabIndex = 1;
            // 
            // ContrasenaRegistrarPanel
            // 
            this.ContrasenaRegistrarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContrasenaRegistrarPanel.Controls.Add(this.ContrasenaRegistrarLabel);
            this.ContrasenaRegistrarPanel.Controls.Add(this.ContrasenaRegistrarTextBox);
            this.ContrasenaRegistrarPanel.Location = new System.Drawing.Point(12, 93);
            this.ContrasenaRegistrarPanel.Name = "ContrasenaRegistrarPanel";
            this.ContrasenaRegistrarPanel.Size = new System.Drawing.Size(429, 73);
            this.ContrasenaRegistrarPanel.TabIndex = 4;
            // 
            // ContrasenaRegistrarLabel
            // 
            this.ContrasenaRegistrarLabel.AutoSize = true;
            this.ContrasenaRegistrarLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaRegistrarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ContrasenaRegistrarLabel.Location = new System.Drawing.Point(10, 9);
            this.ContrasenaRegistrarLabel.Name = "ContrasenaRegistrarLabel";
            this.ContrasenaRegistrarLabel.Size = new System.Drawing.Size(151, 17);
            this.ContrasenaRegistrarLabel.TabIndex = 1;
            this.ContrasenaRegistrarLabel.Text = "Ingrese su contraseña:";
            // 
            // ContrasenaRegistrarTextBox
            // 
            this.ContrasenaRegistrarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContrasenaRegistrarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaRegistrarTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaRegistrarTextBox.ForeColor = System.Drawing.Color.White;
            this.ContrasenaRegistrarTextBox.Location = new System.Drawing.Point(13, 38);
            this.ContrasenaRegistrarTextBox.Name = "ContrasenaRegistrarTextBox";
            this.ContrasenaRegistrarTextBox.PasswordChar = '●';
            this.ContrasenaRegistrarTextBox.Size = new System.Drawing.Size(367, 20);
            this.ContrasenaRegistrarTextBox.TabIndex = 2;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ConfirmarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ConfirmarButton.FlatAppearance.BorderSize = 2;
            this.ConfirmarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ConfirmarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ConfirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConfirmarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConfirmarButton.Location = new System.Drawing.Point(12, 184);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(429, 38);
            this.ConfirmarButton.TabIndex = 3;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = false;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SalirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalirButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SalirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SalirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SalirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SalirButton.Location = new System.Drawing.Point(12, 228);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(429, 38);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(12, 303);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(429, 6);
            this.PanelExtra2.TabIndex = 16;
            // 
            // PaneñExtra1
            // 
            this.PaneñExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PaneñExtra1.Location = new System.Drawing.Point(12, 285);
            this.PaneñExtra1.Name = "PaneñExtra1";
            this.PaneñExtra1.Size = new System.Drawing.Size(429, 12);
            this.PaneñExtra1.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(452, 322);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.PaneñExtra1);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.UsuarioRegistrarPanel);
            this.Controls.Add(this.ContrasenaRegistrarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarForm";
            this.Text = "Registrarse - NOTEez";
            this.UsuarioRegistrarPanel.ResumeLayout(false);
            this.UsuarioRegistrarPanel.PerformLayout();
            this.ContrasenaRegistrarPanel.ResumeLayout(false);
            this.ContrasenaRegistrarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UsuarioRegistrarPanel;
        private System.Windows.Forms.Label UsuarioRegistrarLabel;
        private System.Windows.Forms.TextBox UsuarioRegistrarTextBox;
        private System.Windows.Forms.Panel ContrasenaRegistrarPanel;
        private System.Windows.Forms.Label ContrasenaRegistrarLabel;
        private System.Windows.Forms.TextBox ContrasenaRegistrarTextBox;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.Panel PaneñExtra1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}