namespace ProyectoFinal2.Formularios
{
    partial class ClienteInterfaz
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
            this.tbOperadorUI = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tbpCarrito = new System.Windows.Forms.TabPage();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.gpbCarrito = new System.Windows.Forms.GroupBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.chkReporte = new System.Windows.Forms.CheckBox();
            this.tbOperadorUI.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tbpCarrito.SuspendLayout();
            this.gpbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOperadorUI
            // 
            this.tbOperadorUI.Controls.Add(this.tbpProductos);
            this.tbOperadorUI.Controls.Add(this.tbpCarrito);
            this.tbOperadorUI.Location = new System.Drawing.Point(0, 0);
            this.tbOperadorUI.Name = "tbOperadorUI";
            this.tbOperadorUI.SelectedIndex = 0;
            this.tbOperadorUI.Size = new System.Drawing.Size(797, 451);
            this.tbOperadorUI.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.Controls.Add(this.btnComprar);
            this.tbpProductos.Controls.Add(this.btnAgregarCarrito);
            this.tbpProductos.Controls.Add(this.gpbProductos);
            this.tbpProductos.Location = new System.Drawing.Point(4, 25);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProductos.Size = new System.Drawing.Size(789, 422);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Tienda";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(576, 244);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(147, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(576, 134);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarCarrito.TabIndex = 2;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // gpbProductos
            // 
            this.gpbProductos.Controls.Add(this.dgvProductos);
            this.gpbProductos.Location = new System.Drawing.Point(8, 6);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(441, 407);
            this.gpbProductos.TabIndex = 1;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 21);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(429, 380);
            this.dgvProductos.TabIndex = 0;
            // 
            // tbpCarrito
            // 
            this.tbpCarrito.Controls.Add(this.chkReporte);
            this.tbpCarrito.Controls.Add(this.btnEliminarProducto);
            this.tbpCarrito.Controls.Add(this.btnConfirmarCompra);
            this.tbpCarrito.Controls.Add(this.gpbCarrito);
            this.tbpCarrito.Location = new System.Drawing.Point(4, 25);
            this.tbpCarrito.Name = "tbpCarrito";
            this.tbpCarrito.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCarrito.Size = new System.Drawing.Size(789, 422);
            this.tbpCarrito.TabIndex = 1;
            this.tbpCarrito.Text = "Carrito";
            this.tbpCarrito.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(496, 218);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(496, 142);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmarCompra.TabIndex = 2;
            this.btnConfirmarCompra.Text = "Confirmar compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // gpbCarrito
            // 
            this.gpbCarrito.Controls.Add(this.dgvCarrito);
            this.gpbCarrito.Location = new System.Drawing.Point(3, 6);
            this.gpbCarrito.Name = "gpbCarrito";
            this.gpbCarrito.Size = new System.Drawing.Size(292, 407);
            this.gpbCarrito.TabIndex = 1;
            this.gpbCarrito.TabStop = false;
            this.gpbCarrito.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(6, 21);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(280, 380);
            this.dgvCarrito.TabIndex = 0;
            // 
            // chkReporte
            // 
            this.chkReporte.AutoSize = true;
            this.chkReporte.Location = new System.Drawing.Point(496, 294);
            this.chkReporte.Name = "chkReporte";
            this.chkReporte.Size = new System.Drawing.Size(124, 20);
            this.chkReporte.TabIndex = 4;
            this.chkReporte.Text = "Generar reporte";
            this.chkReporte.UseVisualStyleBackColor = true;
            // 
            // ClienteInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOperadorUI);
            this.Name = "ClienteInterfaz";
            this.Text = "Cliente Interfaz";
            this.tbOperadorUI.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.gpbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tbpCarrito.ResumeLayout(false);
            this.tbpCarrito.PerformLayout();
            this.gpbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbOperadorUI;
        private System.Windows.Forms.TabPage tbpProductos;
        private System.Windows.Forms.TabPage tbpCarrito;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.GroupBox gpbCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.CheckBox chkReporte;
    }
}