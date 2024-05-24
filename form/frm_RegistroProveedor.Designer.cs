namespace Lab4_inventario.form
{
    partial class frm_RegistroProveedor
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
            this.tx_NombreProveedor = new System.Windows.Forms.TextBox();
            this.tx_Nit = new System.Windows.Forms.TextBox();
            this.tx_PersonaDeContacto = new System.Windows.Forms.TextBox();
            this.lb_NombreProveedor = new System.Windows.Forms.Label();
            this.lb_PersonaDeContacto = new System.Windows.Forms.Label();
            this.lb_ncr = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_Nit = new System.Windows.Forms.Label();
            this.lb_Giro = new System.Windows.Forms.Label();
            this.cbox_categoria = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.tx_Giro = new System.Windows.Forms.TextBox();
            this.tx_NCR = new System.Windows.Forms.TextBox();
            this.tx_CategoriaDeContribuyente = new System.Windows.Forms.TextBox();
            this.lb_TipoContribuyente = new System.Windows.Forms.Label();
            this.lb_Pais = new System.Windows.Forms.Label();
            this.tx_Direccion = new System.Windows.Forms.TextBox();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.tx_Tel1 = new System.Windows.Forms.TextBox();
            this.lb_Tel1 = new System.Windows.Forms.Label();
            this.tx_Tel2 = new System.Windows.Forms.TextBox();
            this.lb_Tel2 = new System.Windows.Forms.Label();
            this.tx_NombreRepresentante = new System.Windows.Forms.TextBox();
            this.lb_NombreRepresentante = new System.Windows.Forms.Label();
            this.tx_CorreoProveedor = new System.Windows.Forms.TextBox();
            this.lb_Correo = new System.Windows.Forms.Label();
            this.cbox_Pais = new System.Windows.Forms.ComboBox();
            this.lab4_inventarioDataSet6 = new Lab4_inventario.Lab4_inventarioDataSet6();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Lab4_inventario.Lab4_inventarioDataSet6TableAdapters.CategoriasTableAdapter();
            this.lab4_inventarioDataSet7 = new Lab4_inventario.Lab4_inventarioDataSet7();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter = new Lab4_inventario.Lab4_inventarioDataSet7TableAdapters.PaisesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_NombreProveedor
            // 
            this.tx_NombreProveedor.Location = new System.Drawing.Point(240, 52);
            this.tx_NombreProveedor.Name = "tx_NombreProveedor";
            this.tx_NombreProveedor.Size = new System.Drawing.Size(121, 22);
            this.tx_NombreProveedor.TabIndex = 29;
            // 
            // tx_Nit
            // 
            this.tx_Nit.Location = new System.Drawing.Point(240, 92);
            this.tx_Nit.Name = "tx_Nit";
            this.tx_Nit.Size = new System.Drawing.Size(121, 22);
            this.tx_Nit.TabIndex = 28;
            // 
            // tx_PersonaDeContacto
            // 
            this.tx_PersonaDeContacto.Location = new System.Drawing.Point(586, 242);
            this.tx_PersonaDeContacto.Name = "tx_PersonaDeContacto";
            this.tx_PersonaDeContacto.Size = new System.Drawing.Size(121, 22);
            this.tx_PersonaDeContacto.TabIndex = 27;
            // 
            // lb_NombreProveedor
            // 
            this.lb_NombreProveedor.AutoSize = true;
            this.lb_NombreProveedor.Location = new System.Drawing.Point(93, 55);
            this.lb_NombreProveedor.Name = "lb_NombreProveedor";
            this.lb_NombreProveedor.Size = new System.Drawing.Size(123, 16);
            this.lb_NombreProveedor.TabIndex = 26;
            this.lb_NombreProveedor.Text = "Nombre Proveedor";
            // 
            // lb_PersonaDeContacto
            // 
            this.lb_PersonaDeContacto.AutoSize = true;
            this.lb_PersonaDeContacto.Location = new System.Drawing.Point(439, 242);
            this.lb_PersonaDeContacto.Name = "lb_PersonaDeContacto";
            this.lb_PersonaDeContacto.Size = new System.Drawing.Size(133, 16);
            this.lb_PersonaDeContacto.TabIndex = 25;
            this.lb_PersonaDeContacto.Text = "Persona de Contacto";
            // 
            // lb_ncr
            // 
            this.lb_ncr.AutoSize = true;
            this.lb_ncr.Location = new System.Drawing.Point(93, 217);
            this.lb_ncr.Name = "lb_ncr";
            this.lb_ncr.Size = new System.Drawing.Size(36, 16);
            this.lb_ncr.TabIndex = 24;
            this.lb_ncr.Text = "NCR";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Location = new System.Drawing.Point(93, 160);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(66, 16);
            this.lb_categoria.TabIndex = 23;
            this.lb_categoria.Text = "Categoria";
            // 
            // lb_Nit
            // 
            this.lb_Nit.AutoSize = true;
            this.lb_Nit.Location = new System.Drawing.Point(93, 98);
            this.lb_Nit.Name = "lb_Nit";
            this.lb_Nit.Size = new System.Drawing.Size(90, 16);
            this.lb_Nit.TabIndex = 22;
            this.lb_Nit.Text = "Nit Proveedor";
            // 
            // lb_Giro
            // 
            this.lb_Giro.AutoSize = true;
            this.lb_Giro.Location = new System.Drawing.Point(93, 269);
            this.lb_Giro.Name = "lb_Giro";
            this.lb_Giro.Size = new System.Drawing.Size(101, 16);
            this.lb_Giro.TabIndex = 21;
            this.lb_Giro.Text = "Giro o actividad";
            // 
            // cbox_categoria
            // 
            this.cbox_categoria.DataSource = this.categoriasBindingSource;
            this.cbox_categoria.DisplayMember = "nombre";
            this.cbox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_categoria.FormattingEnabled = true;
            this.cbox_categoria.Location = new System.Drawing.Point(240, 152);
            this.cbox_categoria.Name = "cbox_categoria";
            this.cbox_categoria.Size = new System.Drawing.Size(121, 24);
            this.cbox_categoria.TabIndex = 18;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(415, 375);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(527, 375);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(632, 375);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 15;
            this.btn_Salir.Text = "salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // tx_Giro
            // 
            this.tx_Giro.Location = new System.Drawing.Point(240, 263);
            this.tx_Giro.Name = "tx_Giro";
            this.tx_Giro.Size = new System.Drawing.Size(121, 22);
            this.tx_Giro.TabIndex = 30;
            // 
            // tx_NCR
            // 
            this.tx_NCR.Location = new System.Drawing.Point(240, 211);
            this.tx_NCR.Name = "tx_NCR";
            this.tx_NCR.Size = new System.Drawing.Size(121, 22);
            this.tx_NCR.TabIndex = 31;
            // 
            // tx_CategoriaDeContribuyente
            // 
            this.tx_CategoriaDeContribuyente.Location = new System.Drawing.Point(240, 305);
            this.tx_CategoriaDeContribuyente.Name = "tx_CategoriaDeContribuyente";
            this.tx_CategoriaDeContribuyente.Size = new System.Drawing.Size(121, 22);
            this.tx_CategoriaDeContribuyente.TabIndex = 33;
            // 
            // lb_TipoContribuyente
            // 
            this.lb_TipoContribuyente.AutoSize = true;
            this.lb_TipoContribuyente.Location = new System.Drawing.Point(66, 311);
            this.lb_TipoContribuyente.Name = "lb_TipoContribuyente";
            this.lb_TipoContribuyente.Size = new System.Drawing.Size(168, 16);
            this.lb_TipoContribuyente.TabIndex = 32;
            this.lb_TipoContribuyente.Text = "Categoria de contribuyente";
            // 
            // lb_Pais
            // 
            this.lb_Pais.AutoSize = true;
            this.lb_Pais.Location = new System.Drawing.Point(439, 45);
            this.lb_Pais.Name = "lb_Pais";
            this.lb_Pais.Size = new System.Drawing.Size(34, 16);
            this.lb_Pais.TabIndex = 34;
            this.lb_Pais.Text = "Pais";
            // 
            // tx_Direccion
            // 
            this.tx_Direccion.Location = new System.Drawing.Point(586, 81);
            this.tx_Direccion.Name = "tx_Direccion";
            this.tx_Direccion.Size = new System.Drawing.Size(121, 22);
            this.tx_Direccion.TabIndex = 37;
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(439, 87);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(64, 16);
            this.lb_Direccion.TabIndex = 36;
            this.lb_Direccion.Text = "Direccion";
            // 
            // tx_Tel1
            // 
            this.tx_Tel1.Location = new System.Drawing.Point(586, 122);
            this.tx_Tel1.Name = "tx_Tel1";
            this.tx_Tel1.Size = new System.Drawing.Size(121, 22);
            this.tx_Tel1.TabIndex = 39;
            // 
            // lb_Tel1
            // 
            this.lb_Tel1.AutoSize = true;
            this.lb_Tel1.Location = new System.Drawing.Point(439, 128);
            this.lb_Tel1.Name = "lb_Tel1";
            this.lb_Tel1.Size = new System.Drawing.Size(71, 16);
            this.lb_Tel1.TabIndex = 38;
            this.lb_Tel1.Text = "Telefono 1";
            // 
            // tx_Tel2
            // 
            this.tx_Tel2.Location = new System.Drawing.Point(586, 160);
            this.tx_Tel2.Name = "tx_Tel2";
            this.tx_Tel2.Size = new System.Drawing.Size(121, 22);
            this.tx_Tel2.TabIndex = 41;
            // 
            // lb_Tel2
            // 
            this.lb_Tel2.AutoSize = true;
            this.lb_Tel2.Location = new System.Drawing.Point(439, 166);
            this.lb_Tel2.Name = "lb_Tel2";
            this.lb_Tel2.Size = new System.Drawing.Size(71, 16);
            this.lb_Tel2.TabIndex = 40;
            this.lb_Tel2.Text = "Telefono 2";
            // 
            // tx_NombreRepresentante
            // 
            this.tx_NombreRepresentante.Location = new System.Drawing.Point(586, 201);
            this.tx_NombreRepresentante.Name = "tx_NombreRepresentante";
            this.tx_NombreRepresentante.Size = new System.Drawing.Size(121, 22);
            this.tx_NombreRepresentante.TabIndex = 43;
            // 
            // lb_NombreRepresentante
            // 
            this.lb_NombreRepresentante.AutoSize = true;
            this.lb_NombreRepresentante.Location = new System.Drawing.Point(395, 204);
            this.lb_NombreRepresentante.Name = "lb_NombreRepresentante";
            this.lb_NombreRepresentante.Size = new System.Drawing.Size(185, 16);
            this.lb_NombreRepresentante.TabIndex = 42;
            this.lb_NombreRepresentante.Text = "Nombre Representante Legal";
            // 
            // tx_CorreoProveedor
            // 
            this.tx_CorreoProveedor.Location = new System.Drawing.Point(586, 289);
            this.tx_CorreoProveedor.Name = "tx_CorreoProveedor";
            this.tx_CorreoProveedor.Size = new System.Drawing.Size(121, 22);
            this.tx_CorreoProveedor.TabIndex = 45;
            // 
            // lb_Correo
            // 
            this.lb_Correo.AutoSize = true;
            this.lb_Correo.Location = new System.Drawing.Point(439, 289);
            this.lb_Correo.Name = "lb_Correo";
            this.lb_Correo.Size = new System.Drawing.Size(115, 16);
            this.lb_Correo.TabIndex = 44;
            this.lb_Correo.Text = "Correo Proveedor";
            // 
            // cbox_Pais
            // 
            this.cbox_Pais.DataSource = this.paisesBindingSource;
            this.cbox_Pais.DisplayMember = "nombre";
            this.cbox_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Pais.FormattingEnabled = true;
            this.cbox_Pais.Location = new System.Drawing.Point(586, 42);
            this.cbox_Pais.Name = "cbox_Pais";
            this.cbox_Pais.Size = new System.Drawing.Size(121, 24);
            this.cbox_Pais.TabIndex = 46;
            // 
            // lab4_inventarioDataSet6
            // 
            this.lab4_inventarioDataSet6.DataSetName = "Lab4_inventarioDataSet6";
            this.lab4_inventarioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.lab4_inventarioDataSet6;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // lab4_inventarioDataSet7
            // 
            this.lab4_inventarioDataSet7.DataSetName = "Lab4_inventarioDataSet7";
            this.lab4_inventarioDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.lab4_inventarioDataSet7;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbox_Pais);
            this.Controls.Add(this.tx_CorreoProveedor);
            this.Controls.Add(this.lb_Correo);
            this.Controls.Add(this.tx_NombreRepresentante);
            this.Controls.Add(this.lb_NombreRepresentante);
            this.Controls.Add(this.tx_Tel2);
            this.Controls.Add(this.lb_Tel2);
            this.Controls.Add(this.tx_Tel1);
            this.Controls.Add(this.lb_Tel1);
            this.Controls.Add(this.tx_Direccion);
            this.Controls.Add(this.lb_Direccion);
            this.Controls.Add(this.lb_Pais);
            this.Controls.Add(this.tx_CategoriaDeContribuyente);
            this.Controls.Add(this.lb_TipoContribuyente);
            this.Controls.Add(this.tx_NCR);
            this.Controls.Add(this.tx_Giro);
            this.Controls.Add(this.tx_NombreProveedor);
            this.Controls.Add(this.tx_Nit);
            this.Controls.Add(this.tx_PersonaDeContacto);
            this.Controls.Add(this.lb_NombreProveedor);
            this.Controls.Add(this.lb_PersonaDeContacto);
            this.Controls.Add(this.lb_ncr);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.lb_Nit);
            this.Controls.Add(this.lb_Giro);
            this.Controls.Add(this.cbox_categoria);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salir);
            this.Name = "frm_RegistroProveedor";
            this.Text = "frm_RegistroProveedor";
            this.Load += new System.EventHandler(this.frm_RegistroProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_inventarioDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_NombreProveedor;
        private System.Windows.Forms.TextBox tx_Nit;
        private System.Windows.Forms.TextBox tx_PersonaDeContacto;
        private System.Windows.Forms.Label lb_NombreProveedor;
        private System.Windows.Forms.Label lb_PersonaDeContacto;
        private System.Windows.Forms.Label lb_ncr;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_Nit;
        private System.Windows.Forms.Label lb_Giro;
        private System.Windows.Forms.ComboBox cbox_categoria;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox tx_Giro;
        private System.Windows.Forms.TextBox tx_NCR;
        private System.Windows.Forms.TextBox tx_CategoriaDeContribuyente;
        private System.Windows.Forms.Label lb_TipoContribuyente;
        private System.Windows.Forms.Label lb_Pais;
        private System.Windows.Forms.TextBox tx_Direccion;
        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.TextBox tx_Tel1;
        private System.Windows.Forms.Label lb_Tel1;
        private System.Windows.Forms.TextBox tx_Tel2;
        private System.Windows.Forms.Label lb_Tel2;
        private System.Windows.Forms.TextBox tx_NombreRepresentante;
        private System.Windows.Forms.Label lb_NombreRepresentante;
        private System.Windows.Forms.TextBox tx_CorreoProveedor;
        private System.Windows.Forms.Label lb_Correo;
        private System.Windows.Forms.ComboBox cbox_Pais;
        private Lab4_inventarioDataSet6 lab4_inventarioDataSet6;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private Lab4_inventarioDataSet6TableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private Lab4_inventarioDataSet7 lab4_inventarioDataSet7;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private Lab4_inventarioDataSet7TableAdapters.PaisesTableAdapter paisesTableAdapter;
    }
}