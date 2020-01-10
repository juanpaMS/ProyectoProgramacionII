namespace ProyectoProgramacionII
{
    partial class IniciarSesionForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionForm));
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.ContrasenaLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.ContrasenaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsuarioPanel = new System.Windows.Forms.Panel();
            this.ContrasenaPanel = new System.Windows.Forms.Panel();
            this.PanelExtra1 = new System.Windows.Forms.Panel();
            this.PanelExtra2 = new System.Windows.Forms.Panel();
            this.UsuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContrasenaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegistrarLabel = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.UsuarioPanel.SuspendLayout();
            this.ContrasenaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.UsuarioLabel.Location = new System.Drawing.Point(10, 9);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(58, 17);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // ContrasenaLabel
            // 
            this.ContrasenaLabel.AutoSize = true;
            this.ContrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ContrasenaLabel.Location = new System.Drawing.Point(10, 9);
            this.ContrasenaLabel.Name = "ContrasenaLabel";
            this.ContrasenaLabel.Size = new System.Drawing.Size(88, 17);
            this.ContrasenaLabel.TabIndex = 1;
            this.ContrasenaLabel.Text = "Contraseña:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.White;
            this.UsuarioErrorProvider.SetIconPadding(this.UsuarioTextBox, 10);
            this.UsuarioTextBox.Location = new System.Drawing.Point(13, 41);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(379, 20);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaTextBox.ForeColor = System.Drawing.Color.White;
            this.ContrasenaErrorProvider.SetIconPadding(this.ContrasenaTextBox, 10);
            this.ContrasenaTextBox.Location = new System.Drawing.Point(13, 38);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.PasswordChar = '●';
            this.ContrasenaTextBox.Size = new System.Drawing.Size(379, 20);
            this.ContrasenaTextBox.TabIndex = 3;
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
            this.SalirButton.Location = new System.Drawing.Point(12, 233);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(429, 38);
            this.SalirButton.TabIndex = 6;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // IngresarButton
            // 
            this.IngresarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.IngresarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.IngresarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.IngresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.IngresarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IngresarButton.Location = new System.Drawing.Point(12, 189);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(429, 38);
            this.IngresarButton.TabIndex = 5;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = false;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // ContrasenaLinkLabel
            // 
            this.ContrasenaLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ContrasenaLinkLabel.AutoSize = true;
            this.ContrasenaLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ContrasenaLinkLabel.Location = new System.Drawing.Point(293, 169);
            this.ContrasenaLinkLabel.Name = "ContrasenaLinkLabel";
            this.ContrasenaLinkLabel.Size = new System.Drawing.Size(148, 17);
            this.ContrasenaLinkLabel.TabIndex = 4;
            this.ContrasenaLinkLabel.TabStop = true;
            this.ContrasenaLinkLabel.Text = "¿Olvidó su contraseña?";
            // 
            // UsuarioPanel
            // 
            this.UsuarioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioPanel.Controls.Add(this.UsuarioLabel);
            this.UsuarioPanel.Controls.Add(this.UsuarioTextBox);
            this.UsuarioPanel.Location = new System.Drawing.Point(12, 12);
            this.UsuarioPanel.Name = "UsuarioPanel";
            this.UsuarioPanel.Size = new System.Drawing.Size(429, 75);
            this.UsuarioPanel.TabIndex = 0;
            // 
            // ContrasenaPanel
            // 
            this.ContrasenaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContrasenaPanel.Controls.Add(this.ContrasenaLabel);
            this.ContrasenaPanel.Controls.Add(this.ContrasenaTextBox);
            this.ContrasenaPanel.Location = new System.Drawing.Point(12, 93);
            this.ContrasenaPanel.Name = "ContrasenaPanel";
            this.ContrasenaPanel.Size = new System.Drawing.Size(429, 73);
            this.ContrasenaPanel.TabIndex = 2;
            // 
            // PanelExtra1
            // 
            this.PanelExtra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelExtra1.Location = new System.Drawing.Point(13, 376);
            this.PanelExtra1.Name = "PanelExtra1";
            this.PanelExtra1.Size = new System.Drawing.Size(429, 12);
            this.PanelExtra1.TabIndex = 13;
            // 
            // PanelExtra2
            // 
            this.PanelExtra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelExtra2.Location = new System.Drawing.Point(13, 394);
            this.PanelExtra2.Name = "PanelExtra2";
            this.PanelExtra2.Size = new System.Drawing.Size(429, 6);
            this.PanelExtra2.TabIndex = 14;
            // 
            // UsuarioErrorProvider
            // 
            this.UsuarioErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.UsuarioErrorProvider.ContainerControl = this;
            this.UsuarioErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("UsuarioErrorProvider.Icon")));
            // 
            // ContrasenaErrorProvider
            // 
            this.ContrasenaErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ContrasenaErrorProvider.ContainerControl = this;
            this.ContrasenaErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ContrasenaErrorProvider.Icon")));
            // 
            // RegistrarLabel
            // 
            this.RegistrarLabel.AutoSize = true;
            this.RegistrarLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RegistrarLabel.Location = new System.Drawing.Point(106, 287);
            this.RegistrarLabel.Name = "RegistrarLabel";
            this.RegistrarLabel.Size = new System.Drawing.Size(236, 17);
            this.RegistrarLabel.TabIndex = 10;
            this.RegistrarLabel.Text = "O presione aquí para crear cuenta:";
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RegistrarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.RegistrarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.RegistrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RegistrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RegistrarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RegistrarButton.Location = new System.Drawing.Point(109, 321);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(231, 38);
            this.RegistrarButton.TabIndex = 7;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = false;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // IniciarSesionForm
            // 
            this.AcceptButton = this.IngresarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CancelButton = this.SalirButton;
            this.ClientSize = new System.Drawing.Size(454, 413);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.RegistrarLabel);
            this.Controls.Add(this.PanelExtra2);
            this.Controls.Add(this.PanelExtra1);
            this.Controls.Add(this.ContrasenaLinkLabel);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.UsuarioPanel);
            this.Controls.Add(this.ContrasenaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IniciarSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IniciarSesionForm_FormClosing);
            this.Load += new System.EventHandler(this.IniciarSesionForm_Load);
            this.UsuarioPanel.ResumeLayout(false);
            this.UsuarioPanel.PerformLayout();
            this.ContrasenaPanel.ResumeLayout(false);
            this.ContrasenaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label ContrasenaLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.LinkLabel ContrasenaLinkLabel;
        private System.Windows.Forms.Panel UsuarioPanel;
        private System.Windows.Forms.Panel ContrasenaPanel;
        private System.Windows.Forms.Panel PanelExtra1;
        private System.Windows.Forms.Panel PanelExtra2;
        private System.Windows.Forms.ErrorProvider UsuarioErrorProvider;
        private System.Windows.Forms.ErrorProvider ContrasenaErrorProvider;
        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Label RegistrarLabel;
    }
}

