namespace SistemaARD.Vistas
{
    partial class MostrarAguinaldos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarAguinaldos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReporteAguinaldo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbxAño = new System.Windows.Forms.ComboBox();
            this.btnReporteAguinaldoVentas = new System.Windows.Forms.Button();
            this.btnReporteAguinaldoTransporte = new System.Windows.Forms.Button();
            this.btnReporteAguinaldoProduccion = new System.Windows.Forms.Button();
            this.btnReporteAguinaldoMantenimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(6, 29);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(142, 24);
            this.cbxDepartamento.TabIndex = 1;
            this.cbxDepartamento.TextChanged += new System.EventHandler(this.cbxDepartamento_TextChanged);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
            this.iconMinimizar.Location = new System.Drawing.Point(732, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 5;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(763, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 4;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Aguinaldos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDepartamento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(16, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 66);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar un departamento";
            // 
            // btnReporteAguinaldo
            // 
            this.btnReporteAguinaldo.FlatAppearance.BorderSize = 0;
            this.btnReporteAguinaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAguinaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteAguinaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAguinaldo.Image")));
            this.btnReporteAguinaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAguinaldo.Location = new System.Drawing.Point(523, 52);
            this.btnReporteAguinaldo.Name = "btnReporteAguinaldo";
            this.btnReporteAguinaldo.Size = new System.Drawing.Size(262, 45);
            this.btnReporteAguinaldo.TabIndex = 15;
            this.btnReporteAguinaldo.Text = "Generar Reporte Aguinaldo";
            this.btnReporteAguinaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAguinaldo.UseVisualStyleBackColor = true;
            this.btnReporteAguinaldo.Visible = false;
            this.btnReporteAguinaldo.Click += new System.EventHandler(this.btnReporteAguinaldo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbxAño);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(302, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 66);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Año de Aguinaldo";
            // 
            // cmbxAño
            // 
            this.cmbxAño.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cmbxAño.FormattingEnabled = true;
            this.cmbxAño.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbxAño.Location = new System.Drawing.Point(6, 29);
            this.cmbxAño.Name = "cmbxAño";
            this.cmbxAño.Size = new System.Drawing.Size(118, 24);
            this.cmbxAño.TabIndex = 1;
            this.cmbxAño.Text = "Seleccione Año";
            // 
            // btnReporteAguinaldoVentas
            // 
            this.btnReporteAguinaldoVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteAguinaldoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAguinaldoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteAguinaldoVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAguinaldoVentas.Image")));
            this.btnReporteAguinaldoVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAguinaldoVentas.Location = new System.Drawing.Point(526, 52);
            this.btnReporteAguinaldoVentas.Name = "btnReporteAguinaldoVentas";
            this.btnReporteAguinaldoVentas.Size = new System.Drawing.Size(262, 45);
            this.btnReporteAguinaldoVentas.TabIndex = 16;
            this.btnReporteAguinaldoVentas.Text = "Generar Reporte Aguinaldo";
            this.btnReporteAguinaldoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAguinaldoVentas.UseVisualStyleBackColor = true;
            this.btnReporteAguinaldoVentas.Visible = false;
            this.btnReporteAguinaldoVentas.Click += new System.EventHandler(this.btnReporteAguinaldoVentas_Click);
            // 
            // btnReporteAguinaldoTransporte
            // 
            this.btnReporteAguinaldoTransporte.FlatAppearance.BorderSize = 0;
            this.btnReporteAguinaldoTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAguinaldoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteAguinaldoTransporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAguinaldoTransporte.Image")));
            this.btnReporteAguinaldoTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAguinaldoTransporte.Location = new System.Drawing.Point(526, 52);
            this.btnReporteAguinaldoTransporte.Name = "btnReporteAguinaldoTransporte";
            this.btnReporteAguinaldoTransporte.Size = new System.Drawing.Size(262, 45);
            this.btnReporteAguinaldoTransporte.TabIndex = 17;
            this.btnReporteAguinaldoTransporte.Text = "Generar Reporte Aguinaldo";
            this.btnReporteAguinaldoTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAguinaldoTransporte.UseVisualStyleBackColor = true;
            this.btnReporteAguinaldoTransporte.Visible = false;
            this.btnReporteAguinaldoTransporte.Click += new System.EventHandler(this.btnReporteAguinaldoTransporte_Click);
            // 
            // btnReporteAguinaldoProduccion
            // 
            this.btnReporteAguinaldoProduccion.FlatAppearance.BorderSize = 0;
            this.btnReporteAguinaldoProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAguinaldoProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteAguinaldoProduccion.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAguinaldoProduccion.Image")));
            this.btnReporteAguinaldoProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAguinaldoProduccion.Location = new System.Drawing.Point(522, 52);
            this.btnReporteAguinaldoProduccion.Name = "btnReporteAguinaldoProduccion";
            this.btnReporteAguinaldoProduccion.Size = new System.Drawing.Size(262, 45);
            this.btnReporteAguinaldoProduccion.TabIndex = 18;
            this.btnReporteAguinaldoProduccion.Text = "Generar Reporte Aguinaldo";
            this.btnReporteAguinaldoProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAguinaldoProduccion.UseVisualStyleBackColor = true;
            this.btnReporteAguinaldoProduccion.Visible = false;
            this.btnReporteAguinaldoProduccion.Click += new System.EventHandler(this.btnReporteAguinaldoProduccion_Click);
            // 
            // btnReporteAguinaldoMantenimiento
            // 
            this.btnReporteAguinaldoMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnReporteAguinaldoMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAguinaldoMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporteAguinaldoMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAguinaldoMantenimiento.Image")));
            this.btnReporteAguinaldoMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAguinaldoMantenimiento.Location = new System.Drawing.Point(526, 52);
            this.btnReporteAguinaldoMantenimiento.Name = "btnReporteAguinaldoMantenimiento";
            this.btnReporteAguinaldoMantenimiento.Size = new System.Drawing.Size(262, 45);
            this.btnReporteAguinaldoMantenimiento.TabIndex = 19;
            this.btnReporteAguinaldoMantenimiento.Text = "Generar Reporte Aguinaldo";
            this.btnReporteAguinaldoMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAguinaldoMantenimiento.UseVisualStyleBackColor = true;
            this.btnReporteAguinaldoMantenimiento.Visible = false;
            this.btnReporteAguinaldoMantenimiento.Click += new System.EventHandler(this.btnReporteAguinaldoMantenimiento_Click);
            // 
            // MostrarAguinaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteAguinaldoMantenimiento);
            this.Controls.Add(this.btnReporteAguinaldoProduccion);
            this.Controls.Add(this.btnReporteAguinaldoTransporte);
            this.Controls.Add(this.btnReporteAguinaldoVentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReporteAguinaldo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconMinimizar);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 250);
            this.Name = "MostrarAguinaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarAguinaldos";
            this.Load += new System.EventHandler(this.MostrarAguinaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReporteAguinaldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbxAño;
        private System.Windows.Forms.Button btnReporteAguinaldoVentas;
        private System.Windows.Forms.Button btnReporteAguinaldoTransporte;
        private System.Windows.Forms.Button btnReporteAguinaldoProduccion;
        private System.Windows.Forms.Button btnReporteAguinaldoMantenimiento;
    }
}