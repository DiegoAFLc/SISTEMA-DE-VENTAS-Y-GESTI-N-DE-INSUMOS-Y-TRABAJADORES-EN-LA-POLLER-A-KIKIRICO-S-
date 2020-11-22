namespace Sistema_Polleria
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.basedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basedDataSet = new Sistema_Polleria.BasedDataSet();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcRegUs = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despedirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.representantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basedDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basedDataSetBindingSource
            // 
            this.basedDataSetBindingSource.DataSource = this.basedDataSet;
            this.basedDataSetBindingSource.Position = 0;
            // 
            // basedDataSet
            // 
            this.basedDataSet.DataSetName = "BasedDataSet";
            this.basedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcRegUs,
            this.cerrarSesiónToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(85, 80);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.MouseHover += new System.EventHandler(this.inicioToolStripMenuItem_MouseHover);
            // 
            // opcRegUs
            // 
            this.opcRegUs.Image = ((System.Drawing.Image)(resources.GetObject("opcRegUs.Image")));
            this.opcRegUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.opcRegUs.Name = "opcRegUs";
            this.opcRegUs.Size = new System.Drawing.Size(199, 38);
            this.opcRegUs.Text = "Registrar Usuario";
            this.opcRegUs.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarUnaVentaToolStripMenuItem,
            this.cancelarUnaVentaToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem,
            this.asignaciónDePreciosToolStripMenuItem,
            this.pagarPedidoToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(94, 80);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // realizarUnaVentaToolStripMenuItem
            // 
            this.realizarUnaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("realizarUnaVentaToolStripMenuItem.Image")));
            this.realizarUnaVentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.realizarUnaVentaToolStripMenuItem.Name = "realizarUnaVentaToolStripMenuItem";
            this.realizarUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.realizarUnaVentaToolStripMenuItem.Text = "Realizar una Venta";
            this.realizarUnaVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarUnaVentaToolStripMenuItem_Click);
            // 
            // cancelarUnaVentaToolStripMenuItem
            // 
            this.cancelarUnaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarUnaVentaToolStripMenuItem.Image")));
            this.cancelarUnaVentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelarUnaVentaToolStripMenuItem.Name = "cancelarUnaVentaToolStripMenuItem";
            this.cancelarUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.cancelarUnaVentaToolStripMenuItem.Text = "Cancelar una Venta";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeVentasToolStripMenuItem.Image")));
            this.reporteDeVentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // asignaciónDePreciosToolStripMenuItem
            // 
            this.asignaciónDePreciosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asignaciónDePreciosToolStripMenuItem.Image")));
            this.asignaciónDePreciosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asignaciónDePreciosToolStripMenuItem.Name = "asignaciónDePreciosToolStripMenuItem";
            this.asignaciónDePreciosToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.asignaciónDePreciosToolStripMenuItem.Text = "Asignación de Precios";
            this.asignaciónDePreciosToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDePreciosToolStripMenuItem_Click);
            // 
            // pagarPedidoToolStripMenuItem
            // 
            this.pagarPedidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagarPedidoToolStripMenuItem.Image")));
            this.pagarPedidoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pagarPedidoToolStripMenuItem.Name = "pagarPedidoToolStripMenuItem";
            this.pagarPedidoToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.pagarPedidoToolStripMenuItem.Text = "Pagar Pedido";
            this.pagarPedidoToolStripMenuItem.Click += new System.EventHandler(this.pagarPedidoToolStripMenuItem_Click);
            // 
            // opcAdmin
            // 
            this.opcAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.opcAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.trabajadoresToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.opcAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.opcAdmin.Name = "opcAdmin";
            this.opcAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.opcAdmin.Size = new System.Drawing.Size(144, 80);
            this.opcAdmin.Text = "Administración";
            this.opcAdmin.Click += new System.EventHandler(this.administraciónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosRegistradosToolStripMenuItem,
            this.registrarProductosToolStripMenuItem});
            this.productosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem1.Image")));
            this.productosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(171, 38);
            this.productosToolStripMenuItem1.Text = "Insumos";
            this.productosToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // productosRegistradosToolStripMenuItem
            // 
            this.productosRegistradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosRegistradosToolStripMenuItem.Image")));
            this.productosRegistradosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosRegistradosToolStripMenuItem.Name = "productosRegistradosToolStripMenuItem";
            this.productosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.productosRegistradosToolStripMenuItem.Text = "Insumos Registrados";
            this.productosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.productosRegistradosToolStripMenuItem_Click);
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarProductosToolStripMenuItem.Image")));
            this.registrarProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.registrarProductosToolStripMenuItem.Text = "Registrar Insumos ";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresRegistradosToolStripMenuItem,
            this.registrarTrabajadorToolStripMenuItem,
            this.despedirToolStripMenuItem});
            this.trabajadoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trabajadoresToolStripMenuItem.Image")));
            this.trabajadoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // trabajadoresRegistradosToolStripMenuItem
            // 
            this.trabajadoresRegistradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trabajadoresRegistradosToolStripMenuItem.Image")));
            this.trabajadoresRegistradosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trabajadoresRegistradosToolStripMenuItem.Name = "trabajadoresRegistradosToolStripMenuItem";
            this.trabajadoresRegistradosToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.trabajadoresRegistradosToolStripMenuItem.Text = "Trabajadores Registrados";
            this.trabajadoresRegistradosToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresRegistradosToolStripMenuItem_Click_1);
            // 
            // registrarTrabajadorToolStripMenuItem
            // 
            this.registrarTrabajadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarTrabajadorToolStripMenuItem.Image")));
            this.registrarTrabajadorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarTrabajadorToolStripMenuItem.Name = "registrarTrabajadorToolStripMenuItem";
            this.registrarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.registrarTrabajadorToolStripMenuItem.Text = "Registrar Trabajador";
            this.registrarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.registrarTrabajadorToolStripMenuItem_Click);
            // 
            // despedirToolStripMenuItem
            // 
            this.despedirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("despedirToolStripMenuItem.Image")));
            this.despedirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.despedirToolStripMenuItem.Name = "despedirToolStripMenuItem";
            this.despedirToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.despedirToolStripMenuItem.Text = "Despedir Trabajador";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem,
            this.listarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarProveedorToolStripMenuItem.Image")));
            this.registrarProveedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.registrarProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // listarProveedoresToolStripMenuItem
            // 
            this.listarProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarProveedoresToolStripMenuItem.Image")));
            this.listarProveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listarProveedoresToolStripMenuItem.Name = "listarProveedoresToolStripMenuItem";
            this.listarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.listarProveedoresToolStripMenuItem.Text = "Listar Proveedores";
            this.listarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listarProveedoresToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.representantesToolStripMenuItem});
            this.contactosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(115, 80);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // representantesToolStripMenuItem
            // 
            this.representantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("representantesToolStripMenuItem.Image")));
            this.representantesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.representantesToolStripMenuItem.Name = "representantesToolStripMenuItem";
            this.representantesToolStripMenuItem.Size = new System.Drawing.Size(188, 38);
            this.representantesToolStripMenuItem.Text = "Representantes";
            this.representantesToolStripMenuItem.Click += new System.EventHandler(this.representantesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.opcAdmin,
            this.contactosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 84);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imagenToolStripMenuItem.Image")));
            this.imagenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(80, 80);
            this.imagenToolStripMenuItem.Click += new System.EventHandler(this.imagenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 49);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUsu.Location = new System.Drawing.Point(1180, 40);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(40, 13);
            this.lblUsu.TabIndex = 0;
            this.lblUsu.Text = "prueba";
            this.lblUsu.Click += new System.EventHandler(this.lblUsu_Click);
            // 
            // lbUsu
            // 
            this.lbUsu.FormattingEnabled = true;
            this.lbUsu.Items.AddRange(new object[] {
            "Cerrar sesión"});
            this.lbUsu.Location = new System.Drawing.Point(1134, 61);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(120, 95);
            this.lbUsu.TabIndex = 1;
            this.lbUsu.Visible = false;
            this.lbUsu.MouseLeave += new System.EventHandler(this.lbUsu_MouseLeave);
            this.lbUsu.MouseHover += new System.EventHandler(this.lbUsu_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1406, 634);
            this.label2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 62);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "© 2020 D.W.D. Todos los derechos Reservados.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "KIKIRICO\'S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basedDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource basedDataSetBindingSource;
        private BasedDataSet basedDataSet;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despedirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem representantesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem realizarUnaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarUnaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem opcRegUs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem opcAdmin;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProveedoresToolStripMenuItem;
        public System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.ListBox lbUsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDePreciosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pagarPedidoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}