namespace Lab4_inventario.form
{
    partial class frm_MenuPrincipal
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
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.btn_salida = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Configuracion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.brn_CerrrarSesion = new System.Windows.Forms.Button();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_rol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_idsesion = new System.Windows.Forms.Label();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.Location = new System.Drawing.Point(83, 211);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrada.TabIndex = 1;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = true;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // btn_salida
            // 
            this.btn_salida.Location = new System.Drawing.Point(251, 211);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(75, 23);
            this.btn_salida.TabIndex = 2;
            this.btn_salida.Text = "Salida";
            this.btn_salida.UseVisualStyleBackColor = true;
            this.btn_salida.Click += new System.EventHandler(this.btn_salida_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Location = new System.Drawing.Point(382, 211);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(75, 23);
            this.btn_Inventario.TabIndex = 3;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = true;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btn_Configuracion
            // 
            this.btn_Configuracion.Location = new System.Drawing.Point(642, 22);
            this.btn_Configuracion.Name = "btn_Configuracion";
            this.btn_Configuracion.Size = new System.Drawing.Size(107, 23);
            this.btn_Configuracion.TabIndex = 5;
            this.btn_Configuracion.Text = "Configuracion";
            this.btn_Configuracion.UseVisualStyleBackColor = true;
            this.btn_Configuracion.Click += new System.EventHandler(this.btn_Configuracion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu Principal";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Location = new System.Drawing.Point(509, 211);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(75, 23);
            this.btn_Reportes.TabIndex = 7;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // brn_CerrrarSesion
            // 
            this.brn_CerrrarSesion.Location = new System.Drawing.Point(624, 386);
            this.brn_CerrrarSesion.Name = "brn_CerrrarSesion";
            this.brn_CerrrarSesion.Size = new System.Drawing.Size(145, 23);
            this.brn_CerrrarSesion.TabIndex = 8;
            this.brn_CerrrarSesion.Text = "Cerrar Sesion";
            this.brn_CerrrarSesion.UseVisualStyleBackColor = true;
            this.brn_CerrrarSesion.Click += new System.EventHandler(this.brn_CerrrarSesion_Click);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(3, 425);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(43, 16);
            this.lb_Login.TabIndex = 9;
            this.lb_Login.Text = "Login:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(42, 425);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(54, 16);
            this.lb_usuario.TabIndex = 10;
            this.lb_usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rol:";
            // 
            // lb_rol
            // 
            this.lb_rol.AutoSize = true;
            this.lb_rol.Location = new System.Drawing.Point(57, 406);
            this.lb_rol.Name = "lb_rol";
            this.lb_rol.Size = new System.Drawing.Size(44, 16);
            this.lb_rol.TabIndex = 12;
            this.lb_rol.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "sesion id:";
            // 
            // lb_idsesion
            // 
            this.lb_idsesion.AutoSize = true;
            this.lb_idsesion.Location = new System.Drawing.Point(217, 425);
            this.lb_idsesion.Name = "lb_idsesion";
            this.lb_idsesion.Size = new System.Drawing.Size(44, 16);
            this.lb_idsesion.TabIndex = 14;
            this.lb_idsesion.Text = "label4";
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.Location = new System.Drawing.Point(655, 211);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_proveedores.TabIndex = 15;
            this.btn_proveedores.Text = "proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = true;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_proveedores);
            this.Controls.Add(this.lb_idsesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_rol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.brn_CerrrarSesion);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Configuracion);
            this.Controls.Add(this.btn_Inventario);
            this.Controls.Add(this.btn_salida);
            this.Controls.Add(this.btn_Entrada);
            this.Name = "frm_MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Configuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button brn_CerrrarSesion;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_idsesion;
        private System.Windows.Forms.Button btn_proveedores;
    }
}