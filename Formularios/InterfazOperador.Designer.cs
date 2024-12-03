namespace ProyectoFinal2.Formularios
{
    partial class InterfazOperador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazOperador));
            this.tbOperadorUI = new System.Windows.Forms.TabControl();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tbpProveedores = new System.Windows.Forms.TabPage();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.gpbProveedores = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.cmsOperadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEliminarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantInicial = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCantInicial = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtProveedorId = new System.Windows.Forms.TextBox();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpbProductosComprados = new System.Windows.Forms.GroupBox();
            this.chartProductosComprados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtNuevaCant = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtIdProductoActualizar = new System.Windows.Forms.TextBox();
            this.lblIdComprobante = new System.Windows.Forms.Label();
            this.tbOperadorUI.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tbpProveedores.SuspendLayout();
            this.gpbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.cmsOperadores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbProductosComprados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosComprados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOperadorUI
            // 
            this.tbOperadorUI.Controls.Add(this.tbpProductos);
            this.tbOperadorUI.Controls.Add(this.tbpProveedores);
            this.tbOperadorUI.Controls.Add(this.tabPage1);
            this.tbOperadorUI.Location = new System.Drawing.Point(3, -2);
            this.tbOperadorUI.Name = "tbOperadorUI";
            this.tbOperadorUI.SelectedIndex = 0;
            this.tbOperadorUI.Size = new System.Drawing.Size(834, 456);
            this.tbOperadorUI.TabIndex = 0;
            // 
            // tbpProductos
            // 
            this.tbpProductos.Controls.Add(this.gpbProductos);
            this.tbpProductos.Location = new System.Drawing.Point(4, 25);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProductos.Size = new System.Drawing.Size(826, 427);
            this.tbpProductos.TabIndex = 0;
            this.tbpProductos.Text = "Productos";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // gpbProductos
            // 
            this.gpbProductos.Controls.Add(this.panel1);
            this.gpbProductos.Controls.Add(this.dgvProductos);
            this.gpbProductos.Location = new System.Drawing.Point(6, 6);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(806, 408);
            this.gpbProductos.TabIndex = 0;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "groupBox1";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 21);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(449, 384);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
            // 
            // tbpProveedores
            // 
            this.tbpProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpProveedores.BackgroundImage")));
            this.tbpProveedores.Controls.Add(this.btnVaciarCampos);
            this.tbpProveedores.Controls.Add(this.gpbProveedores);
            this.tbpProveedores.Controls.Add(this.lstProductos);
            this.tbpProveedores.Controls.Add(this.btnAgregarProducto);
            this.tbpProveedores.Controls.Add(this.txtCantInicial);
            this.tbpProveedores.Controls.Add(this.txtPrecio);
            this.tbpProveedores.Controls.Add(this.txtProductoId);
            this.tbpProveedores.Controls.Add(this.txtNombreProducto);
            this.tbpProveedores.Controls.Add(this.lblCantInicial);
            this.tbpProveedores.Controls.Add(this.lblIdProducto);
            this.tbpProveedores.Controls.Add(this.lblPrecio);
            this.tbpProveedores.Controls.Add(this.lblNombreProducto);
            this.tbpProveedores.Controls.Add(this.lblNombre);
            this.tbpProveedores.Controls.Add(this.lblCorreo);
            this.tbpProveedores.Controls.Add(this.txtCorreoProveedor);
            this.tbpProveedores.Controls.Add(this.txtNombreProveedor);
            this.tbpProveedores.Controls.Add(this.txtProveedorId);
            this.tbpProveedores.Controls.Add(this.btnAgregarProveedor);
            this.tbpProveedores.Controls.Add(this.lblId);
            this.tbpProveedores.Location = new System.Drawing.Point(4, 25);
            this.tbpProveedores.Name = "tbpProveedores";
            this.tbpProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProveedores.Size = new System.Drawing.Size(826, 427);
            this.tbpProveedores.TabIndex = 1;
            this.tbpProveedores.Text = "Proveedores";
            this.tbpProveedores.UseVisualStyleBackColor = true;
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVaciarCampos.BackgroundImage")));
            this.btnVaciarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVaciarCampos.Location = new System.Drawing.Point(85, 165);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(137, 28);
            this.btnVaciarCampos.TabIndex = 34;
            this.btnVaciarCampos.Text = "Vaciar campos";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
            // 
            // gpbProveedores
            // 
            this.gpbProveedores.Controls.Add(this.btnEliminar);
            this.gpbProveedores.Controls.Add(this.btnActualizar);
            this.gpbProveedores.Controls.Add(this.dgvProveedores);
            this.gpbProveedores.Location = new System.Drawing.Point(483, 37);
            this.gpbProveedores.Name = "gpbProveedores";
            this.gpbProveedores.Size = new System.Drawing.Size(283, 324);
            this.gpbProveedores.TabIndex = 33;
            this.gpbProveedores.TabStop = false;
            this.gpbProveedores.Text = "Proveedores registrados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Location = new System.Drawing.Point(153, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Location = new System.Drawing.Point(24, 286);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 23);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.ContextMenuStrip = this.cmsOperadores;
            this.dgvProveedores.Location = new System.Drawing.Point(7, 21);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(270, 249);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellMouseClick);
            // 
            // cmsOperadores
            // 
            this.cmsOperadores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOperadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEliminarProveedor});
            this.cmsOperadores.Name = "cmsOperadores";
            this.cmsOperadores.Size = new System.Drawing.Size(133, 28);
            // 
            // tsmiEliminarProveedor
            // 
            this.tsmiEliminarProveedor.Name = "tsmiEliminarProveedor";
            this.tsmiEliminarProveedor.Size = new System.Drawing.Size(132, 24);
            this.tsmiEliminarProveedor.Text = "Eliminar";
            this.tsmiEliminarProveedor.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(324, 37);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(153, 340);
            this.lstProductos.TabIndex = 32;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.BackgroundImage")));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(85, 338);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(137, 39);
            this.btnAgregarProducto.TabIndex = 31;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantInicial
            // 
            this.txtCantInicial.Location = new System.Drawing.Point(184, 288);
            this.txtCantInicial.Name = "txtCantInicial";
            this.txtCantInicial.Size = new System.Drawing.Size(100, 22);
            this.txtCantInicial.TabIndex = 30;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(184, 256);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 29;
            // 
            // txtProductoId
            // 
            this.txtProductoId.Location = new System.Drawing.Point(184, 227);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(100, 22);
            this.txtProductoId.TabIndex = 28;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(184, 199);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 27;
            // 
            // lblCantInicial
            // 
            this.lblCantInicial.AutoSize = true;
            this.lblCantInicial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantInicial.Location = new System.Drawing.Point(29, 291);
            this.lblCantInicial.Name = "lblCantInicial";
            this.lblCantInicial.Size = new System.Drawing.Size(98, 16);
            this.lblCantInicial.TabIndex = 26;
            this.lblCantInicial.Text = "Cantidad inicial";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProducto.Location = new System.Drawing.Point(29, 230);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(101, 16);
            this.lblIdProducto.TabIndex = 25;
            this.lblIdProducto.Text = "ID del producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Location = new System.Drawing.Point(29, 259);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreProducto.Location = new System.Drawing.Point(29, 202);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(135, 16);
            this.lblNombreProducto.TabIndex = 23;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(29, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 16);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre del proveedor:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorreo.Location = new System.Drawing.Point(29, 96);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 16);
            this.lblCorreo.TabIndex = 21;
            this.lblCorreo.Text = "Correo del proveedor:";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(184, 93);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtCorreoProveedor.TabIndex = 20;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(184, 65);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProveedor.TabIndex = 19;
            // 
            // txtProveedorId
            // 
            this.txtProveedorId.Location = new System.Drawing.Point(184, 37);
            this.txtProveedorId.Name = "txtProveedorId";
            this.txtProveedorId.Size = new System.Drawing.Size(100, 22);
            this.txtProveedorId.TabIndex = 18;
            this.txtProveedorId.TextChanged += new System.EventHandler(this.txtProveedorId_TextChanged);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProveedor.BackgroundImage")));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(85, 131);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(137, 28);
            this.btnAgregarProveedor.TabIndex = 17;
            this.btnAgregarProveedor.Text = "Registrar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Location = new System.Drawing.Point(29, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 16);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID del proveedor:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.txtCorreoCliente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.gpbProductosComprados);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 427);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(568, 166);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCorreoCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(428, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo del cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(578, 227);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpbProductosComprados
            // 
            this.gpbProductosComprados.Controls.Add(this.chartProductosComprados);
            this.gpbProductosComprados.Location = new System.Drawing.Point(53, 69);
            this.gpbProductosComprados.Name = "gpbProductosComprados";
            this.gpbProductosComprados.Size = new System.Drawing.Size(271, 248);
            this.gpbProductosComprados.TabIndex = 0;
            this.gpbProductosComprados.TabStop = false;
            this.gpbProductosComprados.Text = "groupBox1";
            // 
            // chartProductosComprados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductosComprados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductosComprados.Legends.Add(legend1);
            this.chartProductosComprados.Location = new System.Drawing.Point(6, 21);
            this.chartProductosComprados.Name = "chartProductosComprados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProductosComprados.Series.Add(series1);
            this.chartProductosComprados.Size = new System.Drawing.Size(259, 221);
            this.chartProductosComprados.TabIndex = 0;
            this.chartProductosComprados.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Controls.Add(this.btnActualizarProducto);
            this.panel1.Controls.Add(this.btnResta);
            this.panel1.Controls.Add(this.btnSuma);
            this.panel1.Controls.Add(this.txtNuevaCant);
            this.panel1.Controls.Add(this.txtNuevoPrecio);
            this.panel1.Controls.Add(this.txtNuevoNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNuevoPrecio);
            this.panel1.Controls.Add(this.lblNuevoNombre);
            this.panel1.Controls.Add(this.txtIdProductoActualizar);
            this.panel1.Controls.Add(this.lblIdComprobante);
            this.panel1.Location = new System.Drawing.Point(455, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 384);
            this.panel1.TabIndex = 13;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.BackgroundImage")));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.Location = new System.Drawing.Point(178, 285);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarProducto.BackgroundImage")));
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProducto.Location = new System.Drawing.Point(72, 285);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarProducto.TabIndex = 23;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Location = new System.Drawing.Point(298, 207);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(22, 22);
            this.btnResta.TabIndex = 22;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Location = new System.Drawing.Point(259, 207);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(22, 22);
            this.btnSuma.TabIndex = 21;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // txtNuevaCant
            // 
            this.txtNuevaCant.Location = new System.Drawing.Point(153, 204);
            this.txtNuevaCant.Name = "txtNuevaCant";
            this.txtNuevaCant.Size = new System.Drawing.Size(100, 22);
            this.txtNuevaCant.TabIndex = 20;
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(153, 160);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtNuevoPrecio.TabIndex = 19;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(153, 117);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNuevoNombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(31, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad en Stock";
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(31, 163);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(89, 16);
            this.lblNuevoPrecio.TabIndex = 16;
            this.lblNuevoPrecio.Text = "Nuevo Precio";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoNombre.Location = new System.Drawing.Point(31, 120);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(99, 16);
            this.lblNuevoNombre.TabIndex = 15;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // txtIdProductoActualizar
            // 
            this.txtIdProductoActualizar.Location = new System.Drawing.Point(153, 77);
            this.txtIdProductoActualizar.Name = "txtIdProductoActualizar";
            this.txtIdProductoActualizar.Size = new System.Drawing.Size(100, 22);
            this.txtIdProductoActualizar.TabIndex = 14;
            // 
            // lblIdComprobante
            // 
            this.lblIdComprobante.AutoSize = true;
            this.lblIdComprobante.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdComprobante.Location = new System.Drawing.Point(31, 80);
            this.lblIdComprobante.Name = "lblIdComprobante";
            this.lblIdComprobante.Size = new System.Drawing.Size(77, 16);
            this.lblIdComprobante.TabIndex = 13;
            this.lblIdComprobante.Text = "Producto ID";
            // 
            // InterfazOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 462);
            this.Controls.Add(this.tbOperadorUI);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazOperador";
            this.Text = "InterfazOperador";
            this.tbOperadorUI.ResumeLayout(false);
            this.tbpProductos.ResumeLayout(false);
            this.gpbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tbpProveedores.ResumeLayout(false);
            this.tbpProveedores.PerformLayout();
            this.gpbProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.cmsOperadores.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpbProductosComprados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosComprados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbOperadorUI;
        private System.Windows.Forms.TabPage tbpProductos;
        private System.Windows.Forms.TabPage tbpProveedores;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtCantInicial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCantInicial;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtProveedorId;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gpbProveedores;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ContextMenuStrip cmsOperadores;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarProveedor;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.GroupBox gpbProductosComprados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosComprados;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtNuevaCant;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtIdProductoActualizar;
        private System.Windows.Forms.Label lblIdComprobante;
        private System.Windows.Forms.TabPage tabPage1;
    }
}