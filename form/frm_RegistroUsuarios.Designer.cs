namespace Lab4_inventario.form
{
    partial class frm_RegistroUsuarios
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.lb_Rol = new System.Windows.Forms.Label();
            this.Lb_Usuario = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.tx_Nombre = new System.Windows.Forms.TextBox();
            this.tx_Apellido = new System.Windows.Forms.TextBox();
            this.tx_Usuario = new System.Windows.Forms.TextBox();
            this.tx_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Correo = new System.Windows.Forms.Label();
            this.tx_Correo = new System.Windows.Forms.TextBox();
            this.lb_Pass_Confirm = new System.Windows.Forms.Label();
            this.tx_Pass_Confirm = new System.Windows.Forms.TextBox();
            this.cbox_rol = new System.Windows.Forms.ComboBox();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_inventarioDataSet = new Lab4_inventario.Lab4_inventarioDataSet();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new Lab4_inventario.Lab4_inventarioDataSetTableAdapters.rolTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(482, 370);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(672, 370);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(102, 102);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(56, 16);
            this.lb_nombre.TabIndex = 2;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Location = new System.Drawing.Point(101, 137);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(57, 16);
            this.lb_Apellido.TabIndex = 3;
            this.lb_Apellido.Text = "Apellido";
            // 
            // lb_Rol
            // 
            this.lb_Rol.AutoSize = true;
            this.lb_Rol.Location = new System.Drawing.Point(102, 188);
            this.lb_Rol.Name = "lb_Rol";
            this.lb_Rol.Size = new System.Drawing.Size(31, 16);
            this.lb_Rol.TabIndex = 4;
            this.lb_Rol.Text = "Rol:";
            // 
            // Lb_Usuario
            // 
            this.Lb_Usuario.AutoSize = true;
            this.Lb_Usuario.Location = new System.Drawing.Point(102, 258);
            this.Lb_Usuario.Name = "Lb_Usuario";
            this.Lb_Usuario.Size = new System.Drawing.Size(57, 16);
            this.Lb_Usuario.TabIndex = 5;
            this.Lb_Usuario.Text = "Usuario:";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(102, 311);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(70, 16);
            this.Lb_Password.TabIndex = 6;
            this.Lb_Password.Text = "Password:";
            // 
            // tx_Nombre
            // 
            this.tx_Nombre.Location = new System.Drawing.Point(241, 96);
            this.tx_Nombre.Name = "tx_Nombre";
            this.tx_Nombre.Size = new System.Drawing.Size(195, 22);
            this.tx_Nombre.TabIndex = 7;
            // 
            // tx_Apellido
            // 
            this.tx_Apellido.Location = new System.Drawing.Point(241, 131);
            this.tx_Apellido.Name = "tx_Apellido";
            this.tx_Apellido.Size = new System.Drawing.Size(195, 22);
            this.tx_Apellido.TabIndex = 8;
            // 
            // tx_Usuario
            // 
            this.tx_Usuario.Location = new System.Drawing.Point(241, 252);
            this.tx_Usuario.Name = "tx_Usuario";
            this.tx_Usuario.Size = new System.Drawing.Size(195, 22);
            this.tx_Usuario.TabIndex = 10;
            // 
            // tx_Password
            // 
            this.tx_Password.Location = new System.Drawing.Point(241, 305);
            this.tx_Password.Name = "tx_Password";
            this.tx_Password.Size = new System.Drawing.Size(195, 22);
            this.tx_Password.TabIndex = 11;
            this.tx_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de usuario:";
            // 
            // lb_Correo
            // 
            this.lb_Correo.AutoSize = true;
            this.lb_Correo.Location = new System.Drawing.Point(102, 216);
            this.lb_Correo.Name = "lb_Correo";
            this.lb_Correo.Size = new System.Drawing.Size(48, 16);
            this.lb_Correo.TabIndex = 14;
            this.lb_Correo.Text = "Correo";
            // 
            // tx_Correo
            // 
            this.tx_Correo.Location = new System.Drawing.Point(241, 210);
            this.tx_Correo.Name = "tx_Correo";
            this.tx_Correo.Size = new System.Drawing.Size(195, 22);
            this.tx_Correo.TabIndex = 15;
            // 
            // lb_Pass_Confirm
            // 
            this.lb_Pass_Confirm.AutoSize = true;
            this.lb_Pass_Confirm.Location = new System.Drawing.Point(104, 352);
            this.lb_Pass_Confirm.Name = "lb_Pass_Confirm";
            this.lb_Pass_Confirm.Size = new System.Drawing.Size(123, 16);
            this.lb_Pass_Confirm.TabIndex = 16;
            this.lb_Pass_Confirm.Text = "Confirme Password";
            // 
            // tx_Pass_Confirm
            // 
            this.tx_Pass_Confirm.Location = new System.Drawing.Point(241, 349);
            this.tx_Pass_Confirm.Name = "tx_Pass_Confirm";
            this.tx_Pass_Confirm.Size = new System.Drawing.Size(195, 22);
            this.tx_Pass_Confirm.TabIndex = 17;
            this.tx_Pass_Confirm.UseSystemPasswordChar = true;
            // 
            // cbox_rol
            // 
            this.cbox_rol.DataSource = this.rolBindingSource1;
            this.cbox_rol.DisplayMember = "nombre";
            this.cbox_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_rol.FormattingEnabled = true;
            this.cbox_rol.Location = new System.Drawing.Point(241, 179);
            this.cbox_rol.Name = "cbox_rol";
            this.cbox_rol.Size = new System.Drawing.Size(121, 24);
            this.cbox_rol.TabIndex = 18;
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "rol";
            this.rolBindingSource1.DataSource = this.lab4_inventarioDataSet;
            // 
            // lab4_inventarioDataSet
            // 
            this.lab4_inventarioDataSet.DataSetName = "Lab4_inventarioDataSet";
            this.lab4_inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "rol";
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_rol);
            this.Controls.Add(this.tx_Pass_Confirm);
            this.Controls.Add(this.lb_Pass_Confirm);
            this.Controls.Add(this.tx_Correo);
            this.Controls.Add(this.lb_Correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_Password);
            this.Controls.Add(this.tx_Usuario);
            this.Controls.Add(this.tx_Apellido);
            this.Controls.Add(this.tx_Nombre);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_Usuario);
            this.Controls.Add(this.lb_Rol);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "frm_RegistroUsuarios";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.frm_RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.Label lb_Rol;
        private System.Windows.Forms.Label Lb_Usuario;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox tx_Nombre;
        private System.Windows.Forms.TextBox tx_Apellido;
        private System.Windows.Forms.TextBox tx_Usuario;
        private System.Windows.Forms.TextBox tx_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Correo;
        private System.Windows.Forms.TextBox tx_Correo;
        private System.Windows.Forms.Label lb_Pass_Confirm;
        private System.Windows.Forms.TextBox tx_Pass_Confirm;
        private System.Windows.Forms.ComboBox cbox_rol;
       // private Lab4_inventarioDataSet lab4_inventarioDataSet;
      //  private System.Windows.Forms.BindingSource lab4inventarioDataSetBindingSource;
      //  private Lab4_inventarioDataSet1 lab4_inventarioDataSet1;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private Lab4_inventarioDataSet lab4_inventarioDataSet;
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private Lab4_inventarioDataSetTableAdapters.rolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Button button1;
        //  private Lab4_inventarioDataSet1TableAdapters.rolTableAdapter rolTableAdapter;
    }
}