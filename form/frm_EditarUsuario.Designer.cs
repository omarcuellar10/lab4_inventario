namespace Lab4_inventario.form
{
    partial class frm_EditarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.chkbx_Habilitado = new System.Windows.Forms.CheckBox();
            this.lb_IdUsuario = new System.Windows.Forms.Label();
            this.txb_idUsuario = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.txb_Correo = new System.Windows.Forms.TextBox();
            this.lb_Correo = new System.Windows.Forms.Label();
            this.txb_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.lb_usuarioLogin = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.txtb_confirmPass = new System.Windows.Forms.TextBox();
            this.lb_confirmPass = new System.Windows.Forms.Label();
            this.lb_Rol = new System.Windows.Forms.Label();
            this.cbox_Rol = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_inventarioDataSet4 = new Lab4_inventario.Lab4_inventarioDataSet4();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgv_carga_vista = new System.Windows.Forms.DataGridView();
            this.viewusuarios2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_inventarioDataSet3 = new Lab4_inventario.Lab4_inventarioDataSet3();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.view_usuarios2TableAdapter = new Lab4_inventario.Lab4_inventarioDataSet3TableAdapters.view_usuarios2TableAdapter();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.rolTableAdapter = new Lab4_inventario.Lab4_inventarioDataSet4TableAdapters.rolTableAdapter();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carga_vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewusuarios2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(703, 310);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // chkbx_Habilitado
            // 
            this.chkbx_Habilitado.AutoSize = true;
            this.chkbx_Habilitado.Location = new System.Drawing.Point(631, 91);
            this.chkbx_Habilitado.Name = "chkbx_Habilitado";
            this.chkbx_Habilitado.Size = new System.Drawing.Size(127, 20);
            this.chkbx_Habilitado.TabIndex = 1;
            this.chkbx_Habilitado.Text = "Login Habilitado";
            this.chkbx_Habilitado.UseVisualStyleBackColor = true;
            // 
            // lb_IdUsuario
            // 
            this.lb_IdUsuario.AutoSize = true;
            this.lb_IdUsuario.Location = new System.Drawing.Point(590, 18);
            this.lb_IdUsuario.Name = "lb_IdUsuario";
            this.lb_IdUsuario.Size = new System.Drawing.Size(65, 16);
            this.lb_IdUsuario.TabIndex = 2;
            this.lb_IdUsuario.Text = "Id usuario";
            // 
            // txb_idUsuario
            // 
            this.txb_idUsuario.Enabled = false;
            this.txb_idUsuario.Location = new System.Drawing.Point(658, 12);
            this.txb_idUsuario.Name = "txb_idUsuario";
            this.txb_idUsuario.Size = new System.Drawing.Size(100, 22);
            this.txb_idUsuario.TabIndex = 3;
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.Location = new System.Drawing.Point(154, 89);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(100, 22);
            this.txb_Apellido.TabIndex = 5;
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Location = new System.Drawing.Point(66, 95);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(57, 16);
            this.lb_Apellido.TabIndex = 4;
            this.lb_Apellido.Text = "Apellido";
            // 
            // txb_Correo
            // 
            this.txb_Correo.Location = new System.Drawing.Point(154, 126);
            this.txb_Correo.Name = "txb_Correo";
            this.txb_Correo.Size = new System.Drawing.Size(100, 22);
            this.txb_Correo.TabIndex = 7;
            // 
            // lb_Correo
            // 
            this.lb_Correo.AutoSize = true;
            this.lb_Correo.Location = new System.Drawing.Point(66, 132);
            this.lb_Correo.Name = "lb_Correo";
            this.lb_Correo.Size = new System.Drawing.Size(48, 16);
            this.lb_Correo.TabIndex = 6;
            this.lb_Correo.Text = "Correo";
            // 
            // txb_UsuarioLogin
            // 
            this.txb_UsuarioLogin.Location = new System.Drawing.Point(434, 44);
            this.txb_UsuarioLogin.Name = "txb_UsuarioLogin";
            this.txb_UsuarioLogin.Size = new System.Drawing.Size(100, 22);
            this.txb_UsuarioLogin.TabIndex = 9;
            // 
            // lb_usuarioLogin
            // 
            this.lb_usuarioLogin.AutoSize = true;
            this.lb_usuarioLogin.Location = new System.Drawing.Point(294, 44);
            this.lb_usuarioLogin.Name = "lb_usuarioLogin";
            this.lb_usuarioLogin.Size = new System.Drawing.Size(90, 16);
            this.lb_usuarioLogin.TabIndex = 8;
            this.lb_usuarioLogin.Text = "Usuario Login";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(154, 43);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txb_Nombre.TabIndex = 11;
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(434, 83);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.Size = new System.Drawing.Size(100, 22);
            this.txtb_Password.TabIndex = 13;
            this.txtb_Password.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(294, 83);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(74, 16);
            this.lb_password.TabIndex = 12;
            this.lb_password.Text = "contraseña";
            // 
            // txtb_confirmPass
            // 
            this.txtb_confirmPass.Location = new System.Drawing.Point(434, 123);
            this.txtb_confirmPass.Name = "txtb_confirmPass";
            this.txtb_confirmPass.Size = new System.Drawing.Size(100, 22);
            this.txtb_confirmPass.TabIndex = 15;
            this.txtb_confirmPass.UseSystemPasswordChar = true;
            // 
            // lb_confirmPass
            // 
            this.lb_confirmPass.AutoSize = true;
            this.lb_confirmPass.Location = new System.Drawing.Point(294, 123);
            this.lb_confirmPass.Name = "lb_confirmPass";
            this.lb_confirmPass.Size = new System.Drawing.Size(134, 16);
            this.lb_confirmPass.TabIndex = 14;
            this.lb_confirmPass.Text = "Confirmar contraseña";
            // 
            // lb_Rol
            // 
            this.lb_Rol.AutoSize = true;
            this.lb_Rol.Location = new System.Drawing.Point(590, 50);
            this.lb_Rol.Name = "lb_Rol";
            this.lb_Rol.Size = new System.Drawing.Size(28, 16);
            this.lb_Rol.TabIndex = 16;
            this.lb_Rol.Text = "Rol";
            // 
            // cbox_Rol
            // 
            this.cbox_Rol.DataSource = this.rolBindingSource;
            this.cbox_Rol.DisplayMember = "nombre";
            this.cbox_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Rol.FormattingEnabled = true;
            this.cbox_Rol.Location = new System.Drawing.Point(637, 47);
            this.cbox_Rol.Name = "cbox_Rol";
            this.cbox_Rol.Size = new System.Drawing.Size(121, 24);
            this.cbox_Rol.TabIndex = 17;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "rol";
            this.rolBindingSource.DataSource = this.lab4_inventarioDataSet4;
            // 
            // lab4_inventarioDataSet4
            // 
            this.lab4_inventarioDataSet4.DataSetName = "Lab4_inventarioDataSet4";
            this.lab4_inventarioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(66, 49);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lb_Nombre.TabIndex = 18;
            this.lb_Nombre.Text = "Nombre";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(703, 217);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 20;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dgv_carga_vista
            // 
            this.dgv_carga_vista.AllowUserToAddRows = false;
            this.dgv_carga_vista.AutoGenerateColumns = false;
            this.dgv_carga_vista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_carga_vista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_carga_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carga_vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.dgv_carga_vista.DataSource = this.viewusuarios2BindingSource;
            this.dgv_carga_vista.Location = new System.Drawing.Point(12, 170);
            this.dgv_carga_vista.Name = "dgv_carga_vista";
            this.dgv_carga_vista.ReadOnly = true;
            this.dgv_carga_vista.RowHeadersWidth = 51;
            this.dgv_carga_vista.RowTemplate.Height = 24;
            this.dgv_carga_vista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_carga_vista.Size = new System.Drawing.Size(662, 235);
            this.dgv_carga_vista.TabIndex = 21;
            this.dgv_carga_vista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_carga_vista_CellClick);
            // 
            // viewusuarios2BindingSource
            // 
            this.viewusuarios2BindingSource.DataMember = "view_usuarios2";
            this.viewusuarios2BindingSource.DataSource = this.lab4_inventarioDataSet3;
            // 
            // lab4_inventarioDataSet3
            // 
            this.lab4_inventarioDataSet3.DataSetName = "Lab4_inventarioDataSet3";
            this.lab4_inventarioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(703, 267);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 22;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(703, 415);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 23;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // view_usuarios2TableAdapter
            // 
            this.view_usuarios2TableAdapter.ClearBeforeFill = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(703, 170);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 24;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id Usuario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idUsuarioDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.NullValue = false;
            this.habilitadoDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.habilitadoDataGridViewCheckBoxColumn.FillWeight = 110.6188F;
            this.habilitadoDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            this.habilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.habilitadoDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.FillWeight = 110.6188F;
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.FillWeight = 25.66845F;
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contraseñaDataGridViewTextBoxColumn.Visible = false;
            this.contraseñaDataGridViewTextBoxColumn.Width = 2;
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_carga_vista);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.cbox_Rol);
            this.Controls.Add(this.lb_Rol);
            this.Controls.Add(this.txtb_confirmPass);
            this.Controls.Add(this.lb_confirmPass);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.txb_UsuarioLogin);
            this.Controls.Add(this.lb_usuarioLogin);
            this.Controls.Add(this.txb_Correo);
            this.Controls.Add(this.lb_Correo);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.txb_idUsuario);
            this.Controls.Add(this.lb_IdUsuario);
            this.Controls.Add(this.chkbx_Habilitado);
            this.Controls.Add(this.btn_Cancelar);
            this.Name = "frm_EditarUsuario";
            this.Text = "Edicion de Usuarios";
            this.Load += new System.EventHandler(this.frm_EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carga_vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewusuarios2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.CheckBox chkbx_Habilitado;
        private System.Windows.Forms.Label lb_IdUsuario;
        private System.Windows.Forms.TextBox txb_idUsuario;
        private System.Windows.Forms.TextBox txb_Apellido;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.TextBox txb_Correo;
        private System.Windows.Forms.Label lb_Correo;
        private System.Windows.Forms.TextBox txb_UsuarioLogin;
        private System.Windows.Forms.Label lb_usuarioLogin;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txtb_confirmPass;
        private System.Windows.Forms.Label lb_confirmPass;
        private System.Windows.Forms.Label lb_Rol;
        private System.Windows.Forms.ComboBox cbox_Rol;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgv_carga_vista;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Atras;
        private Lab4_inventarioDataSet3 lab4_inventarioDataSet3;
        private System.Windows.Forms.BindingSource viewusuarios2BindingSource;
        private Lab4_inventarioDataSet3TableAdapters.view_usuarios2TableAdapter view_usuarios2TableAdapter;
        private System.Windows.Forms.Button btn_Editar;
        private Lab4_inventarioDataSet4 lab4_inventarioDataSet4;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private Lab4_inventarioDataSet4TableAdapters.rolTableAdapter rolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
    }
}