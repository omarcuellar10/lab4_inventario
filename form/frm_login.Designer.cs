namespace Lab4_inventario
{
    partial class frm_login
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btn_Ingreso = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.tx_usuario = new System.Windows.Forms.TextBox();
            this.tx_Password = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(47, 152);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(54, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(50, 254);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(76, 16);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Contraseña";
            // 
            // btn_Ingreso
            // 
            this.btn_Ingreso.Location = new System.Drawing.Point(53, 319);
            this.btn_Ingreso.Name = "btn_Ingreso";
            this.btn_Ingreso.Size = new System.Drawing.Size(90, 55);
            this.btn_Ingreso.TabIndex = 2;
            this.btn_Ingreso.Text = "Ingresar";
            this.btn_Ingreso.UseVisualStyleBackColor = true;
            this.btn_Ingreso.Click += new System.EventHandler(this.btn_Ingreso_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(198, 319);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 55);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // tx_usuario
            // 
            this.tx_usuario.Location = new System.Drawing.Point(157, 145);
            this.tx_usuario.Name = "tx_usuario";
            this.tx_usuario.Size = new System.Drawing.Size(100, 22);
            this.tx_usuario.TabIndex = 4;
            // 
            // tx_Password
            // 
            this.tx_Password.Location = new System.Drawing.Point(157, 247);
            this.tx_Password.Name = "tx_Password";
            this.tx_Password.Size = new System.Drawing.Size(100, 22);
            this.tx_Password.TabIndex = 5;
            this.tx_Password.UseSystemPasswordChar = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(117, 87);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(85, 16);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Iniciar sesion";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tx_Password);
            this.Controls.Add(this.tx_usuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingreso);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Name = "frm_login";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btn_Ingreso;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox tx_usuario;
        private System.Windows.Forms.TextBox tx_Password;
        private System.Windows.Forms.Label lbTitulo;
    }
}

