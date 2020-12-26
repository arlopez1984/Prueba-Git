namespace RHSGMT001
{
    partial class frmGestionMovimientoTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMovimientoTrabajador));
            this.starBar = new Net4Sage.Controls.StatusBar();
            this.sageSession1 = new Net4Sage.SageSession();
            this.menuBar1 = new Net4Sage.Controls.MenuBar();
            this.grbTrabajadores = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaMovimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbUnidadOrganizativas = new System.Windows.Forms.ComboBox();
            this.lbldatosPersona = new System.Windows.Forms.Label();
            this.grbSeleccionarTRabajador = new System.Windows.Forms.GroupBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lkuNav = new Net4Sage.Controls.Lookup.LookupButton();
            this.lblCI = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.grbDatosMovimiento = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmovimiento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.grborigen = new System.Windows.Forms.GroupBox();
            this.txtUnidadOrganizativa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbtraslado = new System.Windows.Forms.GroupBox();
            this.grbAlta = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfechaAlta = new System.Windows.Forms.DateTimePicker();
            this.grbBaja = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.chkcrearMovimiento = new System.Windows.Forms.CheckBox();
            this.lblPeriodoActivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbReubicacion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnidadOrgReubicacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCargoReubicacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtFechaMoviminetoReubicacion = new System.Windows.Forms.DateTimePicker();
            this.txtCausaReubicacion = new System.Windows.Forms.TextBox();
            this.cmbCargoReubicacion = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbUnidadReubicacion = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grbTrabajadores.SuspendLayout();
            this.grbSeleccionarTRabajador.SuspendLayout();
            this.grbDatosMovimiento.SuspendLayout();
            this.grborigen.SuspendLayout();
            this.grbtraslado.SuspendLayout();
            this.grbAlta.SuspendLayout();
            this.grbBaja.SuspendLayout();
            this.grbReubicacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // starBar
            // 
            this.starBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.starBar.Location = new System.Drawing.Point(0, 558);
            this.starBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.starBar.MinimumSize = new System.Drawing.Size(0, 38);
            this.starBar.Name = "starBar";
            this.starBar.Padding = new System.Windows.Forms.Padding(0, 4, 7, 4);
            this.starBar.Size = new System.Drawing.Size(855, 38);
            this.starBar.SysSession = this.sageSession1;
            this.starBar.TabIndex = 0;
            // 
            // sageSession1
            // 
            this.sageSession1.Parameters = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("sageSession1.Parameters")));
            // 
            // menuBar1
            // 
            this.menuBar1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Mode = Net4Sage.Controls.MenuBarMode.Mantaince;
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.ShowItemToolTips = true;
            this.menuBar1.Size = new System.Drawing.Size(855, 28);
            this.menuBar1.SysSession = null;
            this.menuBar1.TabIndex = 1;
            this.menuBar1.Text = "menuBar1";
            this.menuBar1.OnSave += new System.EventHandler(this.Do_Save);
            this.menuBar1.OnCancel += new System.EventHandler(this.Do_Cancel);
            this.menuBar1.OnDelete += new Net4Sage.Controls.ValidationEvenHandler(this.Do_Delete);
            // 
            // grbTrabajadores
            // 
            this.grbTrabajadores.Controls.Add(this.label11);
            this.grbTrabajadores.Controls.Add(this.dtpFechaMovimiento);
            this.grbTrabajadores.Controls.Add(this.txtCausa);
            this.grbTrabajadores.Controls.Add(this.cmbCargo);
            this.grbTrabajadores.Controls.Add(this.label6);
            this.grbTrabajadores.Controls.Add(this.label10);
            this.grbTrabajadores.Controls.Add(this.label13);
            this.grbTrabajadores.Controls.Add(this.cmbUnidadOrganizativas);
            this.grbTrabajadores.Location = new System.Drawing.Point(297, 21);
            this.grbTrabajadores.Name = "grbTrabajadores";
            this.grbTrabajadores.Size = new System.Drawing.Size(516, 194);
            this.grbTrabajadores.TabIndex = 119;
            this.grbTrabajadores.TabStop = false;
            this.grbTrabajadores.Text = "Destino";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 17);
            this.label11.TabIndex = 121;
            this.label11.Text = "Fecha de Movimiento *";
            // 
            // dtpFechaMovimiento
            // 
            this.dtpFechaMovimiento.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMovimiento.Location = new System.Drawing.Point(19, 157);
            this.dtpFechaMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            this.dtpFechaMovimiento.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaMovimiento.TabIndex = 120;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(231, 43);
            this.txtCausa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCausa.MaxLength = 50;
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(278, 137);
            this.txtCausa.TabIndex = 119;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(18, 100);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(195, 24);
            this.cmbCargo.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 110;
            this.label6.Text = "Causa *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 117;
            this.label10.Text = "Cargo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 116;
            this.label13.Text = "Unidad organizativa";
            // 
            // cmbUnidadOrganizativas
            // 
            this.cmbUnidadOrganizativas.FormattingEnabled = true;
            this.cmbUnidadOrganizativas.Location = new System.Drawing.Point(17, 43);
            this.cmbUnidadOrganizativas.Name = "cmbUnidadOrganizativas";
            this.cmbUnidadOrganizativas.Size = new System.Drawing.Size(195, 24);
            this.cmbUnidadOrganizativas.TabIndex = 115;
            this.cmbUnidadOrganizativas.SelectionChangeCommitted += new System.EventHandler(this.CmbUnidadOrganizativas_SelectionChangeCommitted);
            // 
            // lbldatosPersona
            // 
            this.lbldatosPersona.AutoSize = true;
            this.lbldatosPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatosPersona.Location = new System.Drawing.Point(236, 51);
            this.lbldatosPersona.Name = "lbldatosPersona";
            this.lbldatosPersona.Size = new System.Drawing.Size(0, 20);
            this.lbldatosPersona.TabIndex = 81;
            // 
            // grbSeleccionarTRabajador
            // 
            this.grbSeleccionarTRabajador.Controls.Add(this.btnDetalles);
            this.grbSeleccionarTRabajador.Controls.Add(this.lkuNav);
            this.grbSeleccionarTRabajador.Controls.Add(this.lblCI);
            this.grbSeleccionarTRabajador.Controls.Add(this.txtCI);
            this.grbSeleccionarTRabajador.Controls.Add(this.lbldatosPersona);
            this.grbSeleccionarTRabajador.Location = new System.Drawing.Point(15, 41);
            this.grbSeleccionarTRabajador.Name = "grbSeleccionarTRabajador";
            this.grbSeleccionarTRabajador.Size = new System.Drawing.Size(828, 83);
            this.grbSeleccionarTRabajador.TabIndex = 118;
            this.grbSeleccionarTRabajador.TabStop = false;
            this.grbSeleccionarTRabajador.Text = "Seleccionar Trabajador";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(731, 48);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(80, 28);
            this.btnDetalles.TabIndex = 85;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Visible = false;
            this.btnDetalles.Click += new System.EventHandler(this.BtnDetalles_Click);
            // 
            // lkuNav
            // 
            this.lkuNav.BackColor = System.Drawing.Color.Transparent;
            this.lkuNav.Enable = true;
            this.lkuNav.Location = new System.Drawing.Point(173, 48);
            this.lkuNav.Margin = new System.Windows.Forms.Padding(5);
            this.lkuNav.Name = "lkuNav";
            this.lkuNav.Size = new System.Drawing.Size(31, 28);
            this.lkuNav.SysSession = this.sageSession1;
            this.lkuNav.TabIndex = 84;
            this.lkuNav.Tag = "";
            this.lkuNav.OnLookupReturn += new Net4Sage.Controls.Lookup.LookupReturnEventHandler(this.OnNavChange);
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(13, 29);
            this.lblCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(141, 17);
            this.lblCI.TabIndex = 83;
            this.lblCI.Text = "Carnet de Identidad *";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(13, 50);
            this.txtCI.Margin = new System.Windows.Forms.Padding(4);
            this.txtCI.MaxLength = 11;
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(156, 22);
            this.txtCI.TabIndex = 82;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCI_KeyPress);
            // 
            // grbDatosMovimiento
            // 
            this.grbDatosMovimiento.Controls.Add(this.label3);
            this.grbDatosMovimiento.Controls.Add(this.cmbmovimiento);
            this.grbDatosMovimiento.Controls.Add(this.label12);
            this.grbDatosMovimiento.Location = new System.Drawing.Point(16, 228);
            this.grbDatosMovimiento.Name = "grbDatosMovimiento";
            this.grbDatosMovimiento.Size = new System.Drawing.Size(827, 91);
            this.grbDatosMovimiento.TabIndex = 122;
            this.grbDatosMovimiento.TabStop = false;
            this.grbDatosMovimiento.Text = "Datos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tipo de Movimiento *";
            // 
            // cmbmovimiento
            // 
            this.cmbmovimiento.FormattingEnabled = true;
            this.cmbmovimiento.Location = new System.Drawing.Point(11, 55);
            this.cmbmovimiento.Name = "cmbmovimiento";
            this.cmbmovimiento.Size = new System.Drawing.Size(258, 24);
            this.cmbmovimiento.TabIndex = 102;
            this.cmbmovimiento.SelectedIndexChanged += new System.EventHandler(this.Cmbmovimiento_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(564, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 81;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(18, 107);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(214, 27);
            this.txtCargo.TabIndex = 109;
            // 
            // grborigen
            // 
            this.grborigen.Controls.Add(this.txtUnidadOrganizativa);
            this.grborigen.Controls.Add(this.label9);
            this.grborigen.Controls.Add(this.label2);
            this.grborigen.Controls.Add(this.txtCargo);
            this.grborigen.Controls.Add(this.label7);
            this.grborigen.Location = new System.Drawing.Point(10, 21);
            this.grborigen.Name = "grborigen";
            this.grborigen.Size = new System.Drawing.Size(270, 194);
            this.grborigen.TabIndex = 123;
            this.grborigen.TabStop = false;
            this.grborigen.Text = "Origen";
            // 
            // txtUnidadOrganizativa
            // 
            this.txtUnidadOrganizativa.Enabled = false;
            this.txtUnidadOrganizativa.Location = new System.Drawing.Point(19, 50);
            this.txtUnidadOrganizativa.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadOrganizativa.MaxLength = 50;
            this.txtUnidadOrganizativa.Multiline = true;
            this.txtUnidadOrganizativa.Name = "txtUnidadOrganizativa";
            this.txtUnidadOrganizativa.Size = new System.Drawing.Size(214, 27);
            this.txtUnidadOrganizativa.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 113;
            this.label9.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "Unidad Organizativa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 81;
            // 
            // grbtraslado
            // 
            this.grbtraslado.Controls.Add(this.grborigen);
            this.grbtraslado.Controls.Add(this.grbTrabajadores);
            this.grbtraslado.Location = new System.Drawing.Point(15, 326);
            this.grbtraslado.Name = "grbtraslado";
            this.grbtraslado.Size = new System.Drawing.Size(828, 229);
            this.grbtraslado.TabIndex = 124;
            this.grbtraslado.TabStop = false;
            this.grbtraslado.Text = "Traslado";
            this.grbtraslado.Visible = false;
            // 
            // grbAlta
            // 
            this.grbAlta.Controls.Add(this.label8);
            this.grbAlta.Controls.Add(this.label4);
            this.grbAlta.Controls.Add(this.dtpfechaAlta);
            this.grbAlta.Location = new System.Drawing.Point(15, 326);
            this.grbAlta.Name = "grbAlta";
            this.grbAlta.Size = new System.Drawing.Size(828, 100);
            this.grbAlta.TabIndex = 125;
            this.grbAlta.TabStop = false;
            this.grbAlta.Text = "Alta";
            this.grbAlta.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Fecha de Alta *";
            // 
            // dtpfechaAlta
            // 
            this.dtpfechaAlta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpfechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechaAlta.Location = new System.Drawing.Point(25, 48);
            this.dtpfechaAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpfechaAlta.Name = "dtpfechaAlta";
            this.dtpfechaAlta.Size = new System.Drawing.Size(193, 22);
            this.dtpfechaAlta.TabIndex = 116;
            // 
            // grbBaja
            // 
            this.grbBaja.Controls.Add(this.label5);
            this.grbBaja.Controls.Add(this.dtpFechaBaja);
            this.grbBaja.Location = new System.Drawing.Point(15, 326);
            this.grbBaja.Name = "grbBaja";
            this.grbBaja.Size = new System.Drawing.Size(828, 100);
            this.grbBaja.TabIndex = 126;
            this.grbBaja.TabStop = false;
            this.grbBaja.Text = "Baja";
            this.grbBaja.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 117;
            this.label5.Text = "Fecha de Baja *";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaBaja.Location = new System.Drawing.Point(27, 48);
            this.dtpFechaBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaBaja.TabIndex = 116;
            // 
            // chkcrearMovimiento
            // 
            this.chkcrearMovimiento.AutoSize = true;
            this.chkcrearMovimiento.Enabled = false;
            this.chkcrearMovimiento.Location = new System.Drawing.Point(16, 195);
            this.chkcrearMovimiento.Name = "chkcrearMovimiento";
            this.chkcrearMovimiento.Size = new System.Drawing.Size(140, 21);
            this.chkcrearMovimiento.TabIndex = 104;
            this.chkcrearMovimiento.Text = "Crear Movimiento";
            this.chkcrearMovimiento.UseVisualStyleBackColor = true;
            this.chkcrearMovimiento.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // lblPeriodoActivo
            // 
            this.lblPeriodoActivo.AutoSize = true;
            this.lblPeriodoActivo.Location = new System.Drawing.Point(147, 143);
            this.lblPeriodoActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoActivo.Name = "lblPeriodoActivo";
            this.lblPeriodoActivo.Size = new System.Drawing.Size(0, 17);
            this.lblPeriodoActivo.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 127;
            this.label1.Text = "Período Activo:";
            // 
            // grbReubicacion
            // 
            this.grbReubicacion.Controls.Add(this.groupBox2);
            this.grbReubicacion.Controls.Add(this.groupBox3);
            this.grbReubicacion.Location = new System.Drawing.Point(15, 322);
            this.grbReubicacion.Name = "grbReubicacion";
            this.grbReubicacion.Size = new System.Drawing.Size(828, 229);
            this.grbReubicacion.TabIndex = 129;
            this.grbReubicacion.TabStop = false;
            this.grbReubicacion.Text = "Reubicación";
            this.grbReubicacion.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnidadOrgReubicacion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtCargoReubicacion);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(10, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 194);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origen";
            // 
            // txtUnidadOrgReubicacion
            // 
            this.txtUnidadOrgReubicacion.Enabled = false;
            this.txtUnidadOrgReubicacion.Location = new System.Drawing.Point(19, 50);
            this.txtUnidadOrgReubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadOrgReubicacion.MaxLength = 50;
            this.txtUnidadOrgReubicacion.Multiline = true;
            this.txtUnidadOrgReubicacion.Name = "txtUnidadOrgReubicacion";
            this.txtUnidadOrgReubicacion.Size = new System.Drawing.Size(214, 27);
            this.txtUnidadOrgReubicacion.TabIndex = 114;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 113;
            this.label14.Text = "Cargo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 17);
            this.label15.TabIndex = 112;
            this.label15.Text = "Unidad Organizativa";
            // 
            // txtCargoReubicacion
            // 
            this.txtCargoReubicacion.Enabled = false;
            this.txtCargoReubicacion.Location = new System.Drawing.Point(18, 107);
            this.txtCargoReubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargoReubicacion.MaxLength = 50;
            this.txtCargoReubicacion.Multiline = true;
            this.txtCargoReubicacion.Name = "txtCargoReubicacion";
            this.txtCargoReubicacion.Size = new System.Drawing.Size(214, 27);
            this.txtCargoReubicacion.TabIndex = 109;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 81;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtFechaMoviminetoReubicacion);
            this.groupBox3.Controls.Add(this.txtCausaReubicacion);
            this.groupBox3.Controls.Add(this.cmbCargoReubicacion);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cmbUnidadReubicacion);
            this.groupBox3.Location = new System.Drawing.Point(297, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 194);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 17);
            this.label17.TabIndex = 121;
            this.label17.Text = "Fecha de Movimiento *";
            // 
            // dtFechaMoviminetoReubicacion
            // 
            this.dtFechaMoviminetoReubicacion.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtFechaMoviminetoReubicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaMoviminetoReubicacion.Location = new System.Drawing.Point(19, 157);
            this.dtFechaMoviminetoReubicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaMoviminetoReubicacion.Name = "dtFechaMoviminetoReubicacion";
            this.dtFechaMoviminetoReubicacion.Size = new System.Drawing.Size(193, 22);
            this.dtFechaMoviminetoReubicacion.TabIndex = 120;
            // 
            // txtCausaReubicacion
            // 
            this.txtCausaReubicacion.Location = new System.Drawing.Point(231, 43);
            this.txtCausaReubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCausaReubicacion.MaxLength = 50;
            this.txtCausaReubicacion.Multiline = true;
            this.txtCausaReubicacion.Name = "txtCausaReubicacion";
            this.txtCausaReubicacion.Size = new System.Drawing.Size(278, 137);
            this.txtCausaReubicacion.TabIndex = 119;
            // 
            // cmbCargoReubicacion
            // 
            this.cmbCargoReubicacion.FormattingEnabled = true;
            this.cmbCargoReubicacion.Location = new System.Drawing.Point(18, 100);
            this.cmbCargoReubicacion.Name = "cmbCargoReubicacion";
            this.cmbCargoReubicacion.Size = new System.Drawing.Size(195, 24);
            this.cmbCargoReubicacion.TabIndex = 118;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 23);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 110;
            this.label18.Text = "Causa *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 80);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 17);
            this.label19.TabIndex = 117;
            this.label19.Text = "Cargo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 17);
            this.label20.TabIndex = 116;
            this.label20.Text = "Unidad organizativa";
            // 
            // cmbUnidadReubicacion
            // 
            this.cmbUnidadReubicacion.FormattingEnabled = true;
            this.cmbUnidadReubicacion.Location = new System.Drawing.Point(17, 43);
            this.cmbUnidadReubicacion.Name = "cmbUnidadReubicacion";
            this.cmbUnidadReubicacion.Size = new System.Drawing.Size(195, 24);
            this.cmbUnidadReubicacion.TabIndex = 115;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(532, 136);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(185, 22);
            this.txtEstado.TabIndex = 131;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(469, 141);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 17);
            this.lblEstado.TabIndex = 130;
            this.lblEstado.Text = "Estado:";
            // 
            // frmGestionMovimientoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 596);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.grbReubicacion);
            this.Controls.Add(this.lblPeriodoActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkcrearMovimiento);
            this.Controls.Add(this.grbBaja);
            this.Controls.Add(this.grbAlta);
            this.Controls.Add(this.grbtraslado);
            this.Controls.Add(this.grbDatosMovimiento);
            this.Controls.Add(this.grbSeleccionarTRabajador);
            this.Controls.Add(this.starBar);
            this.Controls.Add(this.menuBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar1;
            this.Name = "frmGestionMovimientoTrabajador";
            this.Text = "Gestión de Movimientos de Trabajador";
            this.Shown += new System.EventHandler(this.Form_Show);
            this.grbTrabajadores.ResumeLayout(false);
            this.grbTrabajadores.PerformLayout();
            this.grbSeleccionarTRabajador.ResumeLayout(false);
            this.grbSeleccionarTRabajador.PerformLayout();
            this.grbDatosMovimiento.ResumeLayout(false);
            this.grbDatosMovimiento.PerformLayout();
            this.grborigen.ResumeLayout(false);
            this.grborigen.PerformLayout();
            this.grbtraslado.ResumeLayout(false);
            this.grbAlta.ResumeLayout(false);
            this.grbAlta.PerformLayout();
            this.grbBaja.ResumeLayout(false);
            this.grbBaja.PerformLayout();
            this.grbReubicacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Net4Sage.Controls.StatusBar starBar;
        private Net4Sage.SageSession sageSession1;
        private Net4Sage.Controls.MenuBar menuBar1;
        private System.Windows.Forms.GroupBox grbTrabajadores;
        private System.Windows.Forms.Label lbldatosPersona;
        private System.Windows.Forms.GroupBox grbSeleccionarTRabajador;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUnidadOrganizativas;
        private System.Windows.Forms.GroupBox grbDatosMovimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmovimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.GroupBox grborigen;
        private System.Windows.Forms.TextBox txtUnidadOrganizativa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbtraslado;
        private Net4Sage.Controls.Lookup.LookupButton lkuNav;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.GroupBox grbAlta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfechaAlta;
        private System.Windows.Forms.GroupBox grbBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaMovimiento;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.CheckBox chkcrearMovimiento;
        private System.Windows.Forms.Label lblPeriodoActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbReubicacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnidadOrgReubicacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCargoReubicacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtFechaMoviminetoReubicacion;
        private System.Windows.Forms.TextBox txtCausaReubicacion;
        private System.Windows.Forms.ComboBox cmbCargoReubicacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbUnidadReubicacion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}

