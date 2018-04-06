namespace PV.UI
{
    partial class frmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVesion = new System.Windows.Forms.Label();
            this.dgvPuntoVenta = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.llblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReporteHoy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReporteSemanal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReporteMensual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReporteAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSesiones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTipoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTiposPago = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbcTienda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(157, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(34, 23);
            this.lblUsuario.TabIndex = 31;
            this.lblUsuario.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lo atiende :";
            // 
            // lblVesion
            // 
            this.lblVesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVesion.AutoSize = true;
            this.lblVesion.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesion.Location = new System.Drawing.Point(1091, 86);
            this.lblVesion.Name = "lblVesion";
            this.lblVesion.Size = new System.Drawing.Size(42, 25);
            this.lblVesion.TabIndex = 29;
            this.lblVesion.Text = ".....";
            // 
            // dgvPuntoVenta
            // 
            this.dgvPuntoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuntoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoVenta.Location = new System.Drawing.Point(29, 131);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            this.dgvPuntoVenta.Size = new System.Drawing.Size(966, 250);
            this.dgvPuntoVenta.TabIndex = 28;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(405, 86);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(163, 27);
            this.btnBusqueda.TabIndex = 27;
            this.btnBusqueda.Text = "Busqueda Avanzada";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProducto.Location = new System.Drawing.Point(148, 86);
            this.txtBusquedaProducto.Multiline = true;
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(235, 27);
            this.txtBusquedaProducto.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Producto :";
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(772, 66);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(28, 23);
            this.lblfecha.TabIndex = 24;
            this.lblfecha.Text = "...";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(447, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 42);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Punto Venta";
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(887, 550);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(47, 25);
            this.lblCambio.TabIndex = 41;
            this.lblCambio.Text = ".....";
            // 
            // llblTotal
            // 
            this.llblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblTotal.AutoSize = true;
            this.llblTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblTotal.Location = new System.Drawing.Point(887, 516);
            this.llblTotal.Name = "llblTotal";
            this.llblTotal.Size = new System.Drawing.Size(47, 25);
            this.llblTotal.TabIndex = 40;
            this.llblTotal.Text = ".....";
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(887, 482);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(47, 25);
            this.lblIVA.TabIndex = 39;
            this.lblIVA.Text = ".....";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(887, 448);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(47, 25);
            this.lblSubtotal.TabIndex = 38;
            this.lblSubtotal.Text = ".....";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(713, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "       Cambio :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEfectivo.Location = new System.Drawing.Point(878, 398);
            this.txtEfectivo.Multiline = true;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(117, 34);
            this.txtEfectivo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(741, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Efectivo :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "IVA :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Subtotal :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportes,
            this.menuAdmUsuarios,
            this.menuProductos,
            this.menuMarca,
            this.menuProveedores,
            this.menuTipoProductos,
            this.MenuTiposPago,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 27);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReporteHoy,
            this.menuReporteSemanal,
            this.MenuReporteMensual,
            this.menuReporteAnual});
            this.menuReportes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(83, 23);
            this.menuReportes.Text = "Reportes";
            // 
            // menuReporteHoy
            // 
            this.menuReporteHoy.Name = "menuReporteHoy";
            this.menuReporteHoy.Size = new System.Drawing.Size(138, 24);
            this.menuReporteHoy.Text = "Hoy";
            // 
            // menuReporteSemanal
            // 
            this.menuReporteSemanal.Name = "menuReporteSemanal";
            this.menuReporteSemanal.Size = new System.Drawing.Size(138, 24);
            this.menuReporteSemanal.Text = "Semanal";
            // 
            // MenuReporteMensual
            // 
            this.MenuReporteMensual.Name = "MenuReporteMensual";
            this.MenuReporteMensual.Size = new System.Drawing.Size(138, 24);
            this.MenuReporteMensual.Text = "Menual";
            // 
            // menuReporteAnual
            // 
            this.menuReporteAnual.Name = "menuReporteAnual";
            this.menuReporteAnual.Size = new System.Drawing.Size(138, 24);
            this.menuReporteAnual.Text = "Anual";
            // 
            // menuAdmUsuarios
            // 
            this.menuAdmUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRoles,
            this.menuUsuarios,
            this.menuSesiones});
            this.menuAdmUsuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmUsuarios.Image = global::PV.UI.Properties.Resources.if_partners_45076;
            this.menuAdmUsuarios.Name = "menuAdmUsuarios";
            this.menuAdmUsuarios.Size = new System.Drawing.Size(231, 23);
            this.menuAdmUsuarios.Text = "Administración de Usuarios";
            // 
            // menuRoles
            // 
            this.menuRoles.Image = global::PV.UI.Properties.Resources.if_Login_Manager_7261;
            this.menuRoles.Name = "menuRoles";
            this.menuRoles.Size = new System.Drawing.Size(152, 24);
            this.menuRoles.Text = "Roles";
            this.menuRoles.Click += new System.EventHandler(this.menuRoles_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Image = global::PV.UI.Properties.Resources.loginImage_400x3001;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(152, 24);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuSesiones
            // 
            this.menuSesiones.Image = global::PV.UI.Properties.Resources.if_time_173116;
            this.menuSesiones.Name = "menuSesiones";
            this.menuSesiones.Size = new System.Drawing.Size(152, 24);
            this.menuSesiones.Text = "Sesiones";
            this.menuSesiones.Click += new System.EventHandler(this.menuSesiones_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductos.Image = global::PV.UI.Properties.Resources.if_vendingmachine_1936906;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(107, 23);
            this.menuProductos.Text = "Productos";
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // menuMarca
            // 
            this.menuMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMarca.Image = global::PV.UI.Properties.Resources.if_MicrosoftWindows_2503937;
            this.menuMarca.Name = "menuMarca";
            this.menuMarca.Size = new System.Drawing.Size(78, 23);
            this.menuMarca.Text = "Marca";
            this.menuMarca.Click += new System.EventHandler(this.menuMarca_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.Image = global::PV.UI.Properties.Resources.if_partners_45076;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(124, 23);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuTipoProductos
            // 
            this.menuTipoProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTipoProductos.Image = global::PV.UI.Properties.Resources.if_Groceries_online_shopping_cart_e_commerce_shopping_cart_1887038;
            this.menuTipoProductos.Name = "menuTipoProductos";
            this.menuTipoProductos.Size = new System.Drawing.Size(166, 23);
            this.menuTipoProductos.Text = "Tipo de Productos";
            this.menuTipoProductos.Click += new System.EventHandler(this.menuTipoProductos_Click);
            // 
            // MenuTiposPago
            // 
            this.MenuTiposPago.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTiposPago.Image = global::PV.UI.Properties.Resources.if_coins_17220;
            this.MenuTiposPago.Name = "MenuTiposPago";
            this.MenuTiposPago.Size = new System.Drawing.Size(138, 23);
            this.MenuTiposPago.Text = "Tipos de Pago";
            this.MenuTiposPago.Click += new System.EventHandler(this.MenuTiposPago_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesiónToolStripMenuItem.Image = global::PV.UI.Properties.Resources.if_exit_3226;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // pbcTienda
            // 
            this.pbcTienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbcTienda.Image = global::PV.UI.Properties.Resources.maxresdefault;
            this.pbcTienda.Location = new System.Drawing.Point(42, 407);
            this.pbcTienda.Name = "pbcTienda";
            this.pbcTienda.Size = new System.Drawing.Size(313, 168);
            this.pbcTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcTienda.TabIndex = 42;
            this.pbcTienda.TabStop = false;
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 604);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbcTienda);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.llblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVesion);
            this.Controls.Add(this.dgvPuntoVenta);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusquedaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPuntoVenta";
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPuntoVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVesion;
        private System.Windows.Forms.DataGridView dgvPuntoVenta;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label llblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbcTienda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuReporteHoy;
        private System.Windows.Forms.ToolStripMenuItem menuReporteSemanal;
        private System.Windows.Forms.ToolStripMenuItem MenuReporteMensual;
        private System.Windows.Forms.ToolStripMenuItem menuReporteAnual;
        private System.Windows.Forms.ToolStripMenuItem menuAdmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuRoles;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuMarca;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuTipoProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuTiposPago;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSesiones;
    }
}