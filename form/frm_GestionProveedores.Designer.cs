namespace Lab4_inventario.form
{
    partial class frm_GestionProveedores
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
            this.btn_AgregarProovedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarProovedor
            // 
            this.btn_AgregarProovedor.Location = new System.Drawing.Point(132, 179);
            this.btn_AgregarProovedor.Name = "btn_AgregarProovedor";
            this.btn_AgregarProovedor.Size = new System.Drawing.Size(97, 90);
            this.btn_AgregarProovedor.TabIndex = 0;
            this.btn_AgregarProovedor.Text = "Registrar Proveedor";
            this.btn_AgregarProovedor.UseVisualStyleBackColor = true;
            this.btn_AgregarProovedor.Click += new System.EventHandler(this.btn_AgregarProovedor_Click);
            // 
            // frm_GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AgregarProovedor);
            this.Name = "frm_GestionProveedores";
            this.Text = "frm_GestionProveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProovedor;
    }
}