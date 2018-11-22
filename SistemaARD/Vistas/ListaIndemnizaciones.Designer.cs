namespace SistemaARD.Vistas
{
    partial class ListaIndemnizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaIndemnizaciones));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalPagoLiquido = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.lblRetenciones = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnReporteIndemnizacionAdministracion = new System.Windows.Forms.Button();
            this.btnReporteIndemnizacionVentas = new System.Windows.Forms.Button();
            this.btnReporteIndemnizacionProduccion = new System.Windows.Forms.Button();
            this.btnReporteIndemnizacionTransporte = new System.Windows.Forms.Button();
            this.btnReporteIndemnizacionMantenimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(924, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTotalPagoLiquido
            // 
            this.lblTotalPagoLiquido.AutoSize = true;
            this.lblTotalPagoLiquido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTotalPagoLiquido.Location = new System.Drawing.Point(460, 465);
            this.lblTotalPagoLiquido.Name = "lblTotalPagoLiquido";
            this.lblTotalPagoLiquido.Size = new System.Drawing.Size(84, 16);
            this.lblTotalPagoLiquido.TabIndex = 1;
            this.lblTotalPagoLiquido.Text = "Total Liquido";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(79, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(139, 24);
            this.dtpDesde.TabIndex = 2;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(35, 28);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(290, 28);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.Location = new System.Drawing.Point(331, 112);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 45);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(331, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(124, 24);
            this.dtpHasta.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(88, 112);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 45);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Items.AddRange(new object[] {
            "Todos",
            "Administración",
            "Mantenimiento",
            "Producción",
            "Ventas",
            "Transporte"});
            this.cbxDepartamento.Location = new System.Drawing.Point(79, 76);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(139, 24);
            this.cbxDepartamento.TabIndex = 8;
            this.cbxDepartamento.TextChanged += new System.EventHandler(this.cbxDepartamento_TextChanged);
            // 
            // lblRetenciones
            // 
            this.lblRetenciones.AutoSize = true;
            this.lblRetenciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblRetenciones.Location = new System.Drawing.Point(226, 465);
            this.lblRetenciones.Name = "lblRetenciones";
            this.lblRetenciones.Size = new System.Drawing.Size(108, 16);
            this.lblRetenciones.TabIndex = 9;
            this.lblRetenciones.Text = "Total retenciones";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTotalPago.Location = new System.Drawing.Point(19, 465);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(72, 16);
            this.lblTotalPago.TabIndex = 10;
            this.lblTotalPago.Text = "Total pago";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(16, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(228, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(461, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1);
            this.panel3.TabIndex = 13;
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(989, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 14;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // btnReporteIndemnizacionAdministracion
            // 
            this.btnReporteIndemnizacionAdministracion.FlatAppearance.BorderSize = 0;
            this.btnReporteIndemnizacionAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIndemnizacionAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteIndemnizacionAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteIndemnizacionAdministracion.Image")));
            this.btnReporteIndemnizacionAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIndemnizacionAdministracion.Location = new System.Drawing.Point(497, 112);
            this.btnReporteIndemnizacionAdministracion.Name = "btnReporteIndemnizacionAdministracion";
            this.btnReporteIndemnizacionAdministracion.Size = new System.Drawing.Size(215, 45);
            this.btnReporteIndemnizacionAdministracion.TabIndex = 15;
            this.btnReporteIndemnizacionAdministracion.Text = "Generar Reporte                Anual Administración";
            this.btnReporteIndemnizacionAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIndemnizacionAdministracion.UseVisualStyleBackColor = true;
            this.btnReporteIndemnizacionAdministracion.Click += new System.EventHandler(this.btnReporteIndemnizacionAdministracion_Click);
            // 
            // btnReporteIndemnizacionVentas
            // 
            this.btnReporteIndemnizacionVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteIndemnizacionVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIndemnizacionVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteIndemnizacionVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteIndemnizacionVentas.Image")));
            this.btnReporteIndemnizacionVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIndemnizacionVentas.Location = new System.Drawing.Point(497, 61);
            this.btnReporteIndemnizacionVentas.Name = "btnReporteIndemnizacionVentas";
            this.btnReporteIndemnizacionVentas.Size = new System.Drawing.Size(215, 45);
            this.btnReporteIndemnizacionVentas.TabIndex = 16;
            this.btnReporteIndemnizacionVentas.Text = "Generar Reporte                Anual Ventas";
            this.btnReporteIndemnizacionVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIndemnizacionVentas.UseVisualStyleBackColor = true;
            this.btnReporteIndemnizacionVentas.Click += new System.EventHandler(this.btnReporteIndemnizacionVentas_Click);
            // 
            // btnReporteIndemnizacionProduccion
            // 
            this.btnReporteIndemnizacionProduccion.FlatAppearance.BorderSize = 0;
            this.btnReporteIndemnizacionProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIndemnizacionProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteIndemnizacionProduccion.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteIndemnizacionProduccion.Image")));
            this.btnReporteIndemnizacionProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIndemnizacionProduccion.Location = new System.Drawing.Point(497, 10);
            this.btnReporteIndemnizacionProduccion.Name = "btnReporteIndemnizacionProduccion";
            this.btnReporteIndemnizacionProduccion.Size = new System.Drawing.Size(215, 45);
            this.btnReporteIndemnizacionProduccion.TabIndex = 17;
            this.btnReporteIndemnizacionProduccion.Text = "Generar Reporte                Anual Producción";
            this.btnReporteIndemnizacionProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIndemnizacionProduccion.UseVisualStyleBackColor = true;
            this.btnReporteIndemnizacionProduccion.Click += new System.EventHandler(this.btnReporteIndemnizacionProduccion_Click);
            // 
            // btnReporteIndemnizacionTransporte
            // 
            this.btnReporteIndemnizacionTransporte.FlatAppearance.BorderSize = 0;
            this.btnReporteIndemnizacionTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIndemnizacionTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteIndemnizacionTransporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteIndemnizacionTransporte.Image")));
            this.btnReporteIndemnizacionTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIndemnizacionTransporte.Location = new System.Drawing.Point(718, 10);
            this.btnReporteIndemnizacionTransporte.Name = "btnReporteIndemnizacionTransporte";
            this.btnReporteIndemnizacionTransporte.Size = new System.Drawing.Size(215, 45);
            this.btnReporteIndemnizacionTransporte.TabIndex = 18;
            this.btnReporteIndemnizacionTransporte.Text = "Generar Reporte                Anual Transporte";
            this.btnReporteIndemnizacionTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIndemnizacionTransporte.UseVisualStyleBackColor = true;
            this.btnReporteIndemnizacionTransporte.Click += new System.EventHandler(this.btnReporteIndemnizacionTransporte_Click);
            // 
            // btnReporteIndemnizacionMantenimiento
            // 
            this.btnReporteIndemnizacionMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnReporteIndemnizacionMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIndemnizacionMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteIndemnizacionMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteIndemnizacionMantenimiento.Image")));
            this.btnReporteIndemnizacionMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIndemnizacionMantenimiento.Location = new System.Drawing.Point(718, 64);
            this.btnReporteIndemnizacionMantenimiento.Name = "btnReporteIndemnizacionMantenimiento";
            this.btnReporteIndemnizacionMantenimiento.Size = new System.Drawing.Size(215, 45);
            this.btnReporteIndemnizacionMantenimiento.TabIndex = 19;
            this.btnReporteIndemnizacionMantenimiento.Text = "Generar Reporte                Anual Mantenimiento";
            this.btnReporteIndemnizacionMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIndemnizacionMantenimiento.UseVisualStyleBackColor = true;
            this.btnReporteIndemnizacionMantenimiento.Click += new System.EventHandler(this.btnReporteIndemnizacionMantenimiento_Click);
            // 
            // ListaIndemnizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1026, 504);
            this.Controls.Add(this.btnReporteIndemnizacionMantenimiento);
            this.Controls.Add(this.btnReporteIndemnizacionTransporte);
            this.Controls.Add(this.btnReporteIndemnizacionProduccion);
            this.Controls.Add(this.btnReporteIndemnizacionVentas);
            this.Controls.Add(this.btnReporteIndemnizacionAdministracion);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblRetenciones);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblTotalPagoLiquido);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaIndemnizaciones";
            this.Text = "ListaIndemnizaciones";
            this.Load += new System.EventHandler(this.ListaIndemnizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalPagoLiquido;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label lblRetenciones;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Button btnReporteIndemnizacionAdministracion;
        private System.Windows.Forms.Button btnReporteIndemnizacionVentas;
        private System.Windows.Forms.Button btnReporteIndemnizacionProduccion;
        private System.Windows.Forms.Button btnReporteIndemnizacionTransporte;
        private System.Windows.Forms.Button btnReporteIndemnizacionMantenimiento;
    }
}