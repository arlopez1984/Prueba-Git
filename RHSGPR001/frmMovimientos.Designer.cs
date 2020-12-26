namespace RHSGPR001
{
    partial class frmMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientos));
            this.menuBar1 = new Net4Sage.Controls.MenuBar();
            this.grbMovimientos = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lvMovimientos = new System.Windows.Forms.ListView();
            this.ColTipoMov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUnidadOrigen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCargoOrigen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUnidadOrganzDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCargoDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPeriodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar1 = new Net4Sage.Controls.StatusBar();
            this.sageSession1 = new Net4Sage.SageSession();
            this.grbMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Mode = Net4Sage.Controls.MenuBarMode.Mantaince;
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.ShowItemToolTips = true;
            this.menuBar1.Size = new System.Drawing.Size(1088, 28);
            this.menuBar1.SysSession = null;
            this.menuBar1.TabIndex = 0;
            this.menuBar1.Text = "menuBar1";
            this.menuBar1.OnSave += new System.EventHandler(this.Do_Save);
            this.menuBar1.OnCancel += new System.EventHandler(this.Do_Cancel);
            // 
            // grbMovimientos
            // 
            this.grbMovimientos.Controls.Add(this.btnSeleccionar);
            this.grbMovimientos.Controls.Add(this.lvMovimientos);
            this.grbMovimientos.Location = new System.Drawing.Point(13, 42);
            this.grbMovimientos.Name = "grbMovimientos";
            this.grbMovimientos.Size = new System.Drawing.Size(1063, 366);
            this.grbMovimientos.TabIndex = 21;
            this.grbMovimientos.TabStop = false;
            this.grbMovimientos.Text = "Movimientos";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(949, 329);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 28);
            this.btnSeleccionar.TabIndex = 81;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // lvMovimientos
            // 
            this.lvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTipoMov,
            this.ColFecha,
            this.ColUnidadOrigen,
            this.ColCargoOrigen,
            this.ColUnidadOrganzDestino,
            this.ColCargoDestino,
            this.ColPeriodo});
            this.lvMovimientos.FullRowSelect = true;
            this.lvMovimientos.GridLines = true;
            this.lvMovimientos.HideSelection = false;
            this.lvMovimientos.Location = new System.Drawing.Point(13, 37);
            this.lvMovimientos.MultiSelect = false;
            this.lvMovimientos.Name = "lvMovimientos";
            this.lvMovimientos.Size = new System.Drawing.Size(1036, 286);
            this.lvMovimientos.TabIndex = 80;
            this.lvMovimientos.UseCompatibleStateImageBehavior = false;
            this.lvMovimientos.View = System.Windows.Forms.View.Details;
            this.lvMovimientos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvMovimientos_MouseDoubleClick);
            // 
            // ColTipoMov
            // 
            this.ColTipoMov.Text = "Tipo de Movimiento";
            this.ColTipoMov.Width = 143;
            // 
            // ColFecha
            // 
            this.ColFecha.Text = "Fecha Movimiento";
            this.ColFecha.Width = 157;
            // 
            // ColUnidadOrigen
            // 
            this.ColUnidadOrigen.Text = "U. Organizativa Origen";
            this.ColUnidadOrigen.Width = 147;
            // 
            // ColCargoOrigen
            // 
            this.ColCargoOrigen.Text = "Cargo Origen";
            this.ColCargoOrigen.Width = 106;
            // 
            // ColUnidadOrganzDestino
            // 
            this.ColUnidadOrganzDestino.Text = "U. Organizativa Destino";
            this.ColUnidadOrganzDestino.Width = 195;
            // 
            // ColCargoDestino
            // 
            this.ColCargoDestino.Text = "Cargo Destino";
            this.ColCargoDestino.Width = 118;
            // 
            // ColPeriodo
            // 
            this.ColPeriodo.Text = "Período";
            this.ColPeriodo.Width = 117;
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 412);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusBar1.MinimumSize = new System.Drawing.Size(0, 38);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Padding = new System.Windows.Forms.Padding(0, 4, 7, 4);
            this.statusBar1.Size = new System.Drawing.Size(1088, 38);
            this.statusBar1.SysSession = this.sageSession1;
            this.statusBar1.TabIndex = 22;
            // 
            // sageSession1
            // 
            this.sageSession1.Parameters = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("sageSession1.Parameters")));
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.grbMovimientos);
            this.Controls.Add(this.menuBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar1;
            this.Name = "frmMovimientos";
            this.Text = "Movimientos del Trabajador";
            this.grbMovimientos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Net4Sage.Controls.MenuBar menuBar1;
        private System.Windows.Forms.GroupBox grbMovimientos;
        private System.Windows.Forms.ListView lvMovimientos;
        private System.Windows.Forms.ColumnHeader ColTipoMov;
        private System.Windows.Forms.ColumnHeader ColFecha;
        private System.Windows.Forms.ColumnHeader ColUnidadOrigen;
        private Net4Sage.Controls.StatusBar statusBar1;
        private Net4Sage.SageSession sageSession1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ColumnHeader ColCargoOrigen;
        private System.Windows.Forms.ColumnHeader ColUnidadOrganzDestino;
        private System.Windows.Forms.ColumnHeader ColCargoDestino;
        private System.Windows.Forms.ColumnHeader ColPeriodo;
    }
}