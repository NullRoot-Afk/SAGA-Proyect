namespace SAGA_EV3
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_nuevo_prod = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_agregar_existente = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_eliminar_producto = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_eliminar_existencias = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_gestion_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_agregar_nuevo = new System.Windows.Forms.Panel();
            this.Txb_producto_nuevo = new System.Windows.Forms.TextBox();
            this.Btn_Agregar_prod_nuevo = new System.Windows.Forms.Button();
            this.Cbx_tipo = new System.Windows.Forms.ComboBox();
            this.Lbl_tipo = new System.Windows.Forms.Label();
            this.Txb_cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.DGV_inventario = new System.Windows.Forms.DataGridView();
            this.Pnl_agregar_existente = new System.Windows.Forms.Panel();
            this.BTN_agregar_existencias = new System.Windows.Forms.Button();
            this.CBX_existencia = new System.Windows.Forms.ComboBox();
            this.TXB_agregar_cantidad_existencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PNL_eliminacion_producto = new System.Windows.Forms.Panel();
            this.Pnl_adm_users = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Nombre_users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_agregacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBX_producto_eliminacion = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PNL_eliminacion_cantidad = new System.Windows.Forms.Panel();
            this.TXB_Eliminacion_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBX_eliminacion = new System.Windows.Forms.ComboBox();
            this.BTN_eliminar_cantidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_gestionUsuarios = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_nombre_usuario = new System.Windows.Forms.TextBox();
            this.Cbx_filtro_tipo_usuario = new System.Windows.Forms.ComboBox();
            this.Btn_filtrar = new System.Windows.Forms.Button();
            this.Dgv_gestionUsuarios = new System.Windows.Forms.DataGridView();
            this.Lbl_usuario_logeado = new System.Windows.Forms.Label();
            this.Btn_cerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Pnl_agregar_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_inventario)).BeginInit();
            this.Pnl_agregar_existente.SuspendLayout();
            this.PNL_eliminacion_producto.SuspendLayout();
            this.Pnl_adm_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.PNL_eliminacion_cantidad.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Pnl_gestionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gestionUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeInventarioToolStripMenuItem,
            this.Tsm_gestion_usuarios,
            this.gestionDeEmpleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeInventarioToolStripMenuItem
            // 
            this.gestionDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_agregar,
            this.Tsm_Eliminar});
            this.gestionDeInventarioToolStripMenuItem.Name = "gestionDeInventarioToolStripMenuItem";
            this.gestionDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.gestionDeInventarioToolStripMenuItem.Text = "Gestion de Inventario";
            // 
            // Tsm_agregar
            // 
            this.Tsm_agregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_nuevo_prod,
            this.Tsm_agregar_existente});
            this.Tsm_agregar.Name = "Tsm_agregar";
            this.Tsm_agregar.Size = new System.Drawing.Size(117, 22);
            this.Tsm_agregar.Text = "Agregar";
            // 
            // Tsm_nuevo_prod
            // 
            this.Tsm_nuevo_prod.Name = "Tsm_nuevo_prod";
            this.Tsm_nuevo_prod.Size = new System.Drawing.Size(173, 22);
            this.Tsm_nuevo_prod.Text = "Nuevo Producto";
            this.Tsm_nuevo_prod.Click += new System.EventHandler(this.Tsm_nuevo_prod_Click);
            // 
            // Tsm_agregar_existente
            // 
            this.Tsm_agregar_existente.Name = "Tsm_agregar_existente";
            this.Tsm_agregar_existente.Size = new System.Drawing.Size(173, 22);
            this.Tsm_agregar_existente.Text = "Producto Existente";
            this.Tsm_agregar_existente.Click += new System.EventHandler(this.Tsm_agregar_existente_Click);
            // 
            // Tsm_Eliminar
            // 
            this.Tsm_Eliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_eliminar_producto,
            this.TSM_eliminar_existencias});
            this.Tsm_Eliminar.Name = "Tsm_Eliminar";
            this.Tsm_Eliminar.Size = new System.Drawing.Size(117, 22);
            this.Tsm_Eliminar.Text = "Eliminar";
            this.Tsm_Eliminar.Click += new System.EventHandler(this.Tsm_Eliminar_Click);
            // 
            // TSM_eliminar_producto
            // 
            this.TSM_eliminar_producto.Name = "TSM_eliminar_producto";
            this.TSM_eliminar_producto.Size = new System.Drawing.Size(131, 22);
            this.TSM_eliminar_producto.Text = "Productos";
            this.TSM_eliminar_producto.Click += new System.EventHandler(this.TSM_eliminar_producto_Click);
            // 
            // TSM_eliminar_existencias
            // 
            this.TSM_eliminar_existencias.Name = "TSM_eliminar_existencias";
            this.TSM_eliminar_existencias.Size = new System.Drawing.Size(131, 22);
            this.TSM_eliminar_existencias.Text = "Existencias";
            this.TSM_eliminar_existencias.Click += new System.EventHandler(this.TSM_eliminar_existencias_Click);
            // 
            // Tsm_gestion_usuarios
            // 
            this.Tsm_gestion_usuarios.Name = "Tsm_gestion_usuarios";
            this.Tsm_gestion_usuarios.Size = new System.Drawing.Size(122, 20);
            this.Tsm_gestion_usuarios.Text = "Gestion de usuarios";
            this.Tsm_gestion_usuarios.Click += new System.EventHandler(this.Tsm_gestion_usuarios_Click);
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            // 
            // Pnl_agregar_nuevo
            // 
            this.Pnl_agregar_nuevo.Controls.Add(this.Txb_producto_nuevo);
            this.Pnl_agregar_nuevo.Controls.Add(this.Btn_Agregar_prod_nuevo);
            this.Pnl_agregar_nuevo.Controls.Add(this.Cbx_tipo);
            this.Pnl_agregar_nuevo.Controls.Add(this.Lbl_tipo);
            this.Pnl_agregar_nuevo.Controls.Add(this.Txb_cantidad);
            this.Pnl_agregar_nuevo.Controls.Add(this.Lbl_Cantidad);
            this.Pnl_agregar_nuevo.Controls.Add(this.Producto);
            this.Pnl_agregar_nuevo.Location = new System.Drawing.Point(12, 27);
            this.Pnl_agregar_nuevo.Name = "Pnl_agregar_nuevo";
            this.Pnl_agregar_nuevo.Size = new System.Drawing.Size(345, 422);
            this.Pnl_agregar_nuevo.TabIndex = 12;
            // 
            // Txb_producto_nuevo
            // 
            this.Txb_producto_nuevo.Location = new System.Drawing.Point(176, 99);
            this.Txb_producto_nuevo.Name = "Txb_producto_nuevo";
            this.Txb_producto_nuevo.Size = new System.Drawing.Size(121, 20);
            this.Txb_producto_nuevo.TabIndex = 19;
            // 
            // Btn_Agregar_prod_nuevo
            // 
            this.Btn_Agregar_prod_nuevo.Location = new System.Drawing.Point(189, 238);
            this.Btn_Agregar_prod_nuevo.Name = "Btn_Agregar_prod_nuevo";
            this.Btn_Agregar_prod_nuevo.Size = new System.Drawing.Size(84, 29);
            this.Btn_Agregar_prod_nuevo.TabIndex = 18;
            this.Btn_Agregar_prod_nuevo.Text = "Agregar";
            this.Btn_Agregar_prod_nuevo.UseVisualStyleBackColor = true;
            this.Btn_Agregar_prod_nuevo.Click += new System.EventHandler(this.Btn_Agregar_prod_nuevo_Click);
            // 
            // Cbx_tipo
            // 
            this.Cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_tipo.FormattingEnabled = true;
            this.Cbx_tipo.Items.AddRange(new object[] {
            "Medicamentos",
            "Alimentos",
            "Otros"});
            this.Cbx_tipo.Location = new System.Drawing.Point(176, 188);
            this.Cbx_tipo.Name = "Cbx_tipo";
            this.Cbx_tipo.Size = new System.Drawing.Size(121, 21);
            this.Cbx_tipo.TabIndex = 17;
            // 
            // Lbl_tipo
            // 
            this.Lbl_tipo.AutoSize = true;
            this.Lbl_tipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipo.Location = new System.Drawing.Point(59, 192);
            this.Lbl_tipo.Name = "Lbl_tipo";
            this.Lbl_tipo.Size = new System.Drawing.Size(38, 18);
            this.Lbl_tipo.TabIndex = 16;
            this.Lbl_tipo.Text = "Tipo";
            // 
            // Txb_cantidad
            // 
            this.Txb_cantidad.Location = new System.Drawing.Point(176, 144);
            this.Txb_cantidad.Name = "Txb_cantidad";
            this.Txb_cantidad.Size = new System.Drawing.Size(39, 20);
            this.Txb_cantidad.TabIndex = 15;
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(59, 144);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(72, 18);
            this.Lbl_Cantidad.TabIndex = 14;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.AllowDrop = true;
            this.Producto.AutoSize = true;
            this.Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.Location = new System.Drawing.Point(59, 98);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(71, 18);
            this.Producto.TabIndex = 13;
            this.Producto.Text = "Producto";
            // 
            // DGV_inventario
            // 
            this.DGV_inventario.AllowUserToAddRows = false;
            this.DGV_inventario.AllowUserToDeleteRows = false;
            this.DGV_inventario.AllowUserToOrderColumns = true;
            this.DGV_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_inventario.Enabled = false;
            this.DGV_inventario.Location = new System.Drawing.Point(432, 60);
            this.DGV_inventario.Name = "DGV_inventario";
            this.DGV_inventario.ReadOnly = true;
            this.DGV_inventario.Size = new System.Drawing.Size(344, 335);
            this.DGV_inventario.TabIndex = 24;
            // 
            // Pnl_agregar_existente
            // 
            this.Pnl_agregar_existente.Controls.Add(this.BTN_agregar_existencias);
            this.Pnl_agregar_existente.Controls.Add(this.CBX_existencia);
            this.Pnl_agregar_existente.Controls.Add(this.TXB_agregar_cantidad_existencia);
            this.Pnl_agregar_existente.Controls.Add(this.label3);
            this.Pnl_agregar_existente.Controls.Add(this.label4);
            this.Pnl_agregar_existente.Location = new System.Drawing.Point(12, 27);
            this.Pnl_agregar_existente.Name = "Pnl_agregar_existente";
            this.Pnl_agregar_existente.Size = new System.Drawing.Size(345, 422);
            this.Pnl_agregar_existente.TabIndex = 20;
            // 
            // BTN_agregar_existencias
            // 
            this.BTN_agregar_existencias.Location = new System.Drawing.Point(130, 197);
            this.BTN_agregar_existencias.Name = "BTN_agregar_existencias";
            this.BTN_agregar_existencias.Size = new System.Drawing.Size(84, 29);
            this.BTN_agregar_existencias.TabIndex = 20;
            this.BTN_agregar_existencias.Text = "Agregar";
            this.BTN_agregar_existencias.UseVisualStyleBackColor = true;
            // 
            // CBX_existencia
            // 
            this.CBX_existencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_existencia.FormattingEnabled = true;
            this.CBX_existencia.Location = new System.Drawing.Point(176, 99);
            this.CBX_existencia.Name = "CBX_existencia";
            this.CBX_existencia.Size = new System.Drawing.Size(121, 21);
            this.CBX_existencia.TabIndex = 19;
            // 
            // TXB_agregar_cantidad_existencia
            // 
            this.TXB_agregar_cantidad_existencia.Location = new System.Drawing.Point(176, 144);
            this.TXB_agregar_cantidad_existencia.Name = "TXB_agregar_cantidad_existencia";
            this.TXB_agregar_cantidad_existencia.Size = new System.Drawing.Size(39, 20);
            this.TXB_agregar_cantidad_existencia.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Producto";
            // 
            // PNL_eliminacion_producto
            // 
            this.PNL_eliminacion_producto.Controls.Add(this.Pnl_adm_users);
            this.PNL_eliminacion_producto.Controls.Add(this.CBX_producto_eliminacion);
            this.PNL_eliminacion_producto.Controls.Add(this.textBox5);
            this.PNL_eliminacion_producto.Controls.Add(this.label5);
            this.PNL_eliminacion_producto.Controls.Add(this.BTN_eliminar);
            this.PNL_eliminacion_producto.Controls.Add(this.label7);
            this.PNL_eliminacion_producto.Location = new System.Drawing.Point(12, 27);
            this.PNL_eliminacion_producto.Name = "PNL_eliminacion_producto";
            this.PNL_eliminacion_producto.Size = new System.Drawing.Size(345, 422);
            this.PNL_eliminacion_producto.TabIndex = 25;
            // 
            // Pnl_adm_users
            // 
            this.Pnl_adm_users.Controls.Add(this.dataGridView4);
            this.Pnl_adm_users.Location = new System.Drawing.Point(761, 385);
            this.Pnl_adm_users.Name = "Pnl_adm_users";
            this.Pnl_adm_users.Size = new System.Drawing.Size(39, 37);
            this.Pnl_adm_users.TabIndex = 30;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_users,
            this.Tipo_user,
            this.fecha_agregacion});
            this.dataGridView4.Location = new System.Drawing.Point(456, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(343, 421);
            this.dataGridView4.TabIndex = 0;
            // 
            // Nombre_users
            // 
            this.Nombre_users.HeaderText = "Nombre";
            this.Nombre_users.Name = "Nombre_users";
            // 
            // Tipo_user
            // 
            this.Tipo_user.HeaderText = "Tipo usuario";
            this.Tipo_user.Name = "Tipo_user";
            // 
            // fecha_agregacion
            // 
            this.fecha_agregacion.HeaderText = "Fecha de Ingreso";
            this.fecha_agregacion.Name = "fecha_agregacion";
            // 
            // CBX_producto_eliminacion
            // 
            this.CBX_producto_eliminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_producto_eliminacion.FormattingEnabled = true;
            this.CBX_producto_eliminacion.Location = new System.Drawing.Point(134, 44);
            this.CBX_producto_eliminacion.Name = "CBX_producto_eliminacion";
            this.CBX_producto_eliminacion.Size = new System.Drawing.Size(211, 21);
            this.CBX_producto_eliminacion.TabIndex = 28;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 164);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(257, 143);
            this.textBox5.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Razon";
            // 
            // BTN_eliminar
            // 
            this.BTN_eliminar.Location = new System.Drawing.Point(261, 327);
            this.BTN_eliminar.Name = "BTN_eliminar";
            this.BTN_eliminar.Size = new System.Drawing.Size(84, 29);
            this.BTN_eliminar.TabIndex = 25;
            this.BTN_eliminar.Text = "Eliminar";
            this.BTN_eliminar.UseVisualStyleBackColor = true;
            this.BTN_eliminar.Click += new System.EventHandler(this.BTN_eliminar_Click);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Producto";
            // 
            // PNL_eliminacion_cantidad
            // 
            this.PNL_eliminacion_cantidad.Controls.Add(this.TXB_Eliminacion_cantidad);
            this.PNL_eliminacion_cantidad.Controls.Add(this.label1);
            this.PNL_eliminacion_cantidad.Controls.Add(this.panel3);
            this.PNL_eliminacion_cantidad.Controls.Add(this.CBX_eliminacion);
            this.PNL_eliminacion_cantidad.Controls.Add(this.BTN_eliminar_cantidad);
            this.PNL_eliminacion_cantidad.Controls.Add(this.label2);
            this.PNL_eliminacion_cantidad.Location = new System.Drawing.Point(12, 27);
            this.PNL_eliminacion_cantidad.Name = "PNL_eliminacion_cantidad";
            this.PNL_eliminacion_cantidad.Size = new System.Drawing.Size(345, 422);
            this.PNL_eliminacion_cantidad.TabIndex = 31;
            // 
            // TXB_Eliminacion_cantidad
            // 
            this.TXB_Eliminacion_cantidad.Location = new System.Drawing.Point(134, 96);
            this.TXB_Eliminacion_cantidad.Name = "TXB_Eliminacion_cantidad";
            this.TXB_Eliminacion_cantidad.Size = new System.Drawing.Size(36, 20);
            this.TXB_Eliminacion_cantidad.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(761, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 37);
            this.panel3.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(456, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de Ingreso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // CBX_eliminacion
            // 
            this.CBX_eliminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_eliminacion.FormattingEnabled = true;
            this.CBX_eliminacion.Location = new System.Drawing.Point(134, 44);
            this.CBX_eliminacion.Name = "CBX_eliminacion";
            this.CBX_eliminacion.Size = new System.Drawing.Size(211, 21);
            this.CBX_eliminacion.TabIndex = 28;
            // 
            // BTN_eliminar_cantidad
            // 
            this.BTN_eliminar_cantidad.Location = new System.Drawing.Point(131, 203);
            this.BTN_eliminar_cantidad.Name = "BTN_eliminar_cantidad";
            this.BTN_eliminar_cantidad.Size = new System.Drawing.Size(84, 29);
            this.BTN_eliminar_cantidad.TabIndex = 25;
            this.BTN_eliminar_cantidad.Text = "Eliminar";
            this.BTN_eliminar_cantidad.UseVisualStyleBackColor = true;
            this.BTN_eliminar_cantidad.Click += new System.EventHandler(this.BTN_eliminar_cantidad_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Producto";
            // 
            // Pnl_gestionUsuarios
            // 
            this.Pnl_gestionUsuarios.Controls.Add(this.label8);
            this.Pnl_gestionUsuarios.Controls.Add(this.label6);
            this.Pnl_gestionUsuarios.Controls.Add(this.Txb_nombre_usuario);
            this.Pnl_gestionUsuarios.Controls.Add(this.Cbx_filtro_tipo_usuario);
            this.Pnl_gestionUsuarios.Controls.Add(this.Btn_filtrar);
            this.Pnl_gestionUsuarios.Controls.Add(this.Dgv_gestionUsuarios);
            this.Pnl_gestionUsuarios.Location = new System.Drawing.Point(12, 27);
            this.Pnl_gestionUsuarios.Name = "Pnl_gestionUsuarios";
            this.Pnl_gestionUsuarios.Size = new System.Drawing.Size(776, 422);
            this.Pnl_gestionUsuarios.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre de Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Usuario";
            // 
            // Txb_nombre_usuario
            // 
            this.Txb_nombre_usuario.Location = new System.Drawing.Point(167, 34);
            this.Txb_nombre_usuario.Name = "Txb_nombre_usuario";
            this.Txb_nombre_usuario.Size = new System.Drawing.Size(130, 20);
            this.Txb_nombre_usuario.TabIndex = 4;
            // 
            // Cbx_filtro_tipo_usuario
            // 
            this.Cbx_filtro_tipo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_filtro_tipo_usuario.FormattingEnabled = true;
            this.Cbx_filtro_tipo_usuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.Cbx_filtro_tipo_usuario.Location = new System.Drawing.Point(321, 33);
            this.Cbx_filtro_tipo_usuario.Name = "Cbx_filtro_tipo_usuario";
            this.Cbx_filtro_tipo_usuario.Size = new System.Drawing.Size(103, 21);
            this.Cbx_filtro_tipo_usuario.TabIndex = 3;
            // 
            // Btn_filtrar
            // 
            this.Btn_filtrar.Location = new System.Drawing.Point(452, 31);
            this.Btn_filtrar.Name = "Btn_filtrar";
            this.Btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_filtrar.TabIndex = 1;
            this.Btn_filtrar.Text = "Filtrar";
            this.Btn_filtrar.UseVisualStyleBackColor = true;
            this.Btn_filtrar.Click += new System.EventHandler(this.Btn_filtrar_Click);
            // 
            // Dgv_gestionUsuarios
            // 
            this.Dgv_gestionUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_gestionUsuarios.Location = new System.Drawing.Point(0, 76);
            this.Dgv_gestionUsuarios.Name = "Dgv_gestionUsuarios";
            this.Dgv_gestionUsuarios.Size = new System.Drawing.Size(776, 346);
            this.Dgv_gestionUsuarios.TabIndex = 0;
            // 
            // Lbl_usuario_logeado
            // 
            this.Lbl_usuario_logeado.AutoSize = true;
            this.Lbl_usuario_logeado.Location = new System.Drawing.Point(485, 9);
            this.Lbl_usuario_logeado.Name = "Lbl_usuario_logeado";
            this.Lbl_usuario_logeado.Size = new System.Drawing.Size(44, 13);
            this.Lbl_usuario_logeado.TabIndex = 34;
            this.Lbl_usuario_logeado.Text = "Nombre";
            // 
            // Btn_cerrarSesion
            // 
            this.Btn_cerrarSesion.Location = new System.Drawing.Point(695, 3);
            this.Btn_cerrarSesion.Name = "Btn_cerrarSesion";
            this.Btn_cerrarSesion.Size = new System.Drawing.Size(90, 24);
            this.Btn_cerrarSesion.TabIndex = 35;
            this.Btn_cerrarSesion.Text = "Cerrar Sesion";
            this.Btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.Btn_cerrarSesion.Click += new System.EventHandler(this.Btn_cerrarSesion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_cerrarSesion);
            this.Controls.Add(this.Lbl_usuario_logeado);
            this.Controls.Add(this.Pnl_gestionUsuarios);
            this.Controls.Add(this.Pnl_agregar_nuevo);
            this.Controls.Add(this.DGV_inventario);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Pnl_agregar_existente);
            this.Controls.Add(this.PNL_eliminacion_producto);
            this.Controls.Add(this.PNL_eliminacion_cantidad);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_agregar_nuevo.ResumeLayout(false);
            this.Pnl_agregar_nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_inventario)).EndInit();
            this.Pnl_agregar_existente.ResumeLayout(false);
            this.Pnl_agregar_existente.PerformLayout();
            this.PNL_eliminacion_producto.ResumeLayout(false);
            this.PNL_eliminacion_producto.PerformLayout();
            this.Pnl_adm_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.PNL_eliminacion_cantidad.ResumeLayout(false);
            this.PNL_eliminacion_cantidad.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Pnl_gestionUsuarios.ResumeLayout(false);
            this.Pnl_gestionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_gestionUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_agregar;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem Tsm_gestion_usuarios;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_agregar_nuevo;
        private System.Windows.Forms.Button Btn_Agregar_prod_nuevo;
        private System.Windows.Forms.ComboBox Cbx_tipo;
        private System.Windows.Forms.Label Lbl_tipo;
        private System.Windows.Forms.TextBox Txb_cantidad;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.ToolStripMenuItem Tsm_nuevo_prod;
        private System.Windows.Forms.ToolStripMenuItem Tsm_agregar_existente;
        private System.Windows.Forms.Panel Pnl_agregar_existente;
        private System.Windows.Forms.ComboBox CBX_existencia;
        private System.Windows.Forms.TextBox TXB_agregar_cantidad_existencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_producto_nuevo;
        private System.Windows.Forms.DataGridView DGV_inventario;
        private System.Windows.Forms.ComboBox CBX_producto_eliminacion;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PNL_eliminacion_producto;
        private System.Windows.Forms.Panel Pnl_adm_users;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_agregacion;
        private System.Windows.Forms.ToolStripMenuItem TSM_eliminar_producto;
        private System.Windows.Forms.ToolStripMenuItem TSM_eliminar_existencias;
        private System.Windows.Forms.Panel PNL_eliminacion_cantidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox CBX_eliminacion;
        private System.Windows.Forms.Button BTN_eliminar_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Eliminacion_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_agregar_existencias;
        private System.Windows.Forms.Panel Pnl_gestionUsuarios;
        private System.Windows.Forms.Button Btn_filtrar;
        private System.Windows.Forms.DataGridView Dgv_gestionUsuarios;
        private System.Windows.Forms.ComboBox Cbx_filtro_tipo_usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_nombre_usuario;
        private System.Windows.Forms.Label Lbl_usuario_logeado;
        private System.Windows.Forms.Button Btn_cerrarSesion;
    }
}