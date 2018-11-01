namespace SistemaARD.Vistas
{
    partial class AdministracionPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionPlanilla));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblPagoHora = new System.Windows.Forms.Label();
            this.txtPagoHora = new System.Windows.Forms.TextBox();
            this.lblHorasLaboradas = new System.Windows.Forms.Label();
            this.txtHorasLaboradas = new System.Windows.Forms.TextBox();
            this.lblAnticipos = new System.Windows.Forms.Label();
            this.txtAnticipos = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPagoDiario = new System.Windows.Forms.Label();
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.txtPagoDiario = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.chbAfp = new System.Windows.Forms.CheckBox();
            this.chbIsss = new System.Windows.Forms.CheckBox();
            this.lblHorasExtra = new System.Windows.Forms.Label();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAguinaldo = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 17);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.Apellidos,
            this.Cargo_Id,
            this.Cargo});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(399, 251);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Cargo_Id
            // 
            this.Cargo_Id.DataPropertyName = "Cargo_Id";
            this.Cargo_Id.HeaderText = "Cargo_Id";
            this.Cargo_Id.Name = "Cargo_Id";
            this.Cargo_Id.ReadOnly = true;
            this.Cargo_Id.Visible = false;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(832, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 11;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtEmpleado.Location = new System.Drawing.Point(6, 20);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(192, 17);
            this.txtEmpleado.TabIndex = 13;
            // 
            // lblPagoHora
            // 
            this.lblPagoHora.AutoSize = true;
            this.lblPagoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoHora.Location = new System.Drawing.Point(18, 26);
            this.lblPagoHora.Name = "lblPagoHora";
            this.lblPagoHora.Size = new System.Drawing.Size(87, 13);
            this.lblPagoHora.TabIndex = 14;
            this.lblPagoHora.Text = "Pago por hora";
            // 
            // txtPagoHora
            // 
            this.txtPagoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtPagoHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoHora.Enabled = false;
            this.txtPagoHora.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtPagoHora.Location = new System.Drawing.Point(109, 21);
            this.txtPagoHora.Name = "txtPagoHora";
            this.txtPagoHora.Size = new System.Drawing.Size(43, 17);
            this.txtPagoHora.TabIndex = 15;
            this.txtPagoHora.TextChanged += new System.EventHandler(this.txtPagoHora_TextChanged);
            this.txtPagoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoHora_KeyPress);
            // 
            // lblHorasLaboradas
            // 
            this.lblHorasLaboradas.AutoSize = true;
            this.lblHorasLaboradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasLaboradas.Location = new System.Drawing.Point(6, 29);
            this.lblHorasLaboradas.Name = "lblHorasLaboradas";
            this.lblHorasLaboradas.Size = new System.Drawing.Size(99, 13);
            this.lblHorasLaboradas.TabIndex = 16;
            this.lblHorasLaboradas.Text = "Horas laboradas";
            // 
            // txtHorasLaboradas
            // 
            this.txtHorasLaboradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtHorasLaboradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasLaboradas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtHorasLaboradas.Location = new System.Drawing.Point(107, 22);
            this.txtHorasLaboradas.Name = "txtHorasLaboradas";
            this.txtHorasLaboradas.Size = new System.Drawing.Size(43, 17);
            this.txtHorasLaboradas.TabIndex = 17;
            this.txtHorasLaboradas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHorasLaboradas_KeyDown);
            this.txtHorasLaboradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasLaboradas_KeyPress);
            // 
            // lblAnticipos
            // 
            this.lblAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnticipos.AutoSize = true;
            this.lblAnticipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnticipos.Location = new System.Drawing.Point(5, 28);
            this.lblAnticipos.Name = "lblAnticipos";
            this.lblAnticipos.Size = new System.Drawing.Size(59, 13);
            this.lblAnticipos.TabIndex = 18;
            this.lblAnticipos.Text = "Anticipos";
            this.lblAnticipos.Click += new System.EventHandler(this.lblAnticipos_Click);
            // 
            // txtAnticipos
            // 
            this.txtAnticipos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnticipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtAnticipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnticipos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtAnticipos.Location = new System.Drawing.Point(65, 24);
            this.txtAnticipos.Name = "txtAnticipos";
            this.txtAnticipos.Size = new System.Drawing.Size(43, 17);
            this.txtAnticipos.TabIndex = 19;
            this.txtAnticipos.TextChanged += new System.EventHandler(this.txtAnticipos_TextChanged);
            this.txtAnticipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnticipos_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(63, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(198, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(293, 387);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPagoDiario
            // 
            this.lblPagoDiario.AutoSize = true;
            this.lblPagoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoDiario.Location = new System.Drawing.Point(15, 26);
            this.lblPagoDiario.Name = "lblPagoDiario";
            this.lblPagoDiario.Size = new System.Drawing.Size(71, 13);
            this.lblPagoDiario.TabIndex = 23;
            this.lblPagoDiario.Text = "Pago diario";
            this.lblPagoDiario.Visible = false;
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasLaborados.Location = new System.Drawing.Point(8, 27);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(93, 13);
            this.lblDiasLaborados.TabIndex = 24;
            this.lblDiasLaborados.Text = "Días laborados";
            this.lblDiasLaborados.Visible = false;
            // 
            // txtPagoDiario
            // 
            this.txtPagoDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtPagoDiario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoDiario.Enabled = false;
            this.txtPagoDiario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtPagoDiario.Location = new System.Drawing.Point(108, 21);
            this.txtPagoDiario.Name = "txtPagoDiario";
            this.txtPagoDiario.Size = new System.Drawing.Size(44, 17);
            this.txtPagoDiario.TabIndex = 25;
            this.txtPagoDiario.Visible = false;
            this.txtPagoDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoDiario_KeyPress);
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtDiasLaborados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasLaborados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtDiasLaborados.Location = new System.Drawing.Point(107, 24);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(44, 17);
            this.txtDiasLaborados.TabIndex = 26;
            this.txtDiasLaborados.Visible = false;
            this.txtDiasLaborados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasLaborados_KeyPress);
            // 
            // chbAfp
            // 
            this.chbAfp.AutoSize = true;
            this.chbAfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAfp.Location = new System.Drawing.Point(10, 26);
            this.chbAfp.Name = "chbAfp";
            this.chbAfp.Size = new System.Drawing.Size(49, 17);
            this.chbAfp.TabIndex = 27;
            this.chbAfp.Text = "AFP";
            this.chbAfp.UseVisualStyleBackColor = true;
            // 
            // chbIsss
            // 
            this.chbIsss.AutoSize = true;
            this.chbIsss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsss.Location = new System.Drawing.Point(82, 26);
            this.chbIsss.Name = "chbIsss";
            this.chbIsss.Size = new System.Drawing.Size(54, 17);
            this.chbIsss.TabIndex = 28;
            this.chbIsss.Text = "ISSS";
            this.chbIsss.UseVisualStyleBackColor = true;
            // 
            // lblHorasExtra
            // 
            this.lblHorasExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasExtra.AutoSize = true;
            this.lblHorasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtra.Location = new System.Drawing.Point(114, 30);
            this.lblHorasExtra.Name = "lblHorasExtra";
            this.lblHorasExtra.Size = new System.Drawing.Size(72, 13);
            this.lblHorasExtra.TabIndex = 30;
            this.lblHorasExtra.Text = "Horas extra";
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHorasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtHorasExtra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasExtra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtHorasExtra.Location = new System.Drawing.Point(192, 24);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(44, 17);
            this.txtHorasExtra.TabIndex = 31;
            this.txtHorasExtra.TextChanged += new System.EventHandler(this.txtHorasExtra_TextChanged);
            this.txtHorasExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasExtra_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 52);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilla de";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel6.Location = new System.Drawing.Point(6, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 1);
            this.panel6.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 311);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de empleados";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chbAfp);
            this.groupBox3.Controls.Add(this.chbIsss);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 60);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aplicar retenciones";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.txtEmpleado);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(429, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 60);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empleado";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel8.Location = new System.Drawing.Point(6, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(192, 1);
            this.panel8.TabIndex = 64;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.lblPagoHora);
            this.groupBox5.Controls.Add(this.txtPagoHora);
            this.groupBox5.Controls.Add(this.lblPagoDiario);
            this.groupBox5.Controls.Add(this.txtPagoDiario);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(429, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 60);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pagos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(109, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 1);
            this.panel3.TabIndex = 63;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.panel2);
            this.groupBox6.Controls.Add(this.lblHorasLaboradas);
            this.groupBox6.Controls.Add(this.txtHorasLaboradas);
            this.groupBox6.Controls.Add(this.lblDiasLaborados);
            this.groupBox6.Controls.Add(this.txtDiasLaborados);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(429, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(353, 60);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dias y horas laborados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(107, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 1);
            this.panel2.TabIndex = 62;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.panel5);
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Controls.Add(this.lblAnticipos);
            this.groupBox7.Controls.Add(this.txtAnticipos);
            this.groupBox7.Controls.Add(this.lblHorasExtra);
            this.groupBox7.Controls.Add(this.txtHorasExtra);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(429, 255);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(353, 60);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Anticipos y Horas extras";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel5.Location = new System.Drawing.Point(192, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 1);
            this.panel5.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(65, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 1);
            this.panel4.TabIndex = 63;
            // 
            // btnAguinaldo
            // 
            this.btnAguinaldo.FlatAppearance.BorderSize = 0;
            this.btnAguinaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAguinaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAguinaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnAguinaldo.Image")));
            this.btnAguinaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAguinaldo.Location = new System.Drawing.Point(157, 387);
            this.btnAguinaldo.Name = "btnAguinaldo";
            this.btnAguinaldo.Size = new System.Drawing.Size(130, 45);
            this.btnAguinaldo.TabIndex = 39;
            this.btnAguinaldo.Text = "Generar Aguinaldo";
            this.btnAguinaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAguinaldo.UseVisualStyleBackColor = true;
            this.btnAguinaldo.Visible = false;
            this.btnAguinaldo.Click += new System.EventHandler(this.btnAguinaldo_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dtpFecha);
            this.groupBox8.Controls.Add(this.lblFecha);
            this.groupBox8.Location = new System.Drawing.Point(429, 321);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(353, 60);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(293, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 61;
            // 
            // AdministracionPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(869, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnAguinaldo);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.iconCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministracionPlanilla";
            this.Load += new System.EventHandler(this.AdministracionPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblPagoHora;
        private System.Windows.Forms.TextBox txtPagoHora;
        private System.Windows.Forms.Label lblHorasLaboradas;
        private System.Windows.Forms.TextBox txtHorasLaboradas;
        private System.Windows.Forms.Label lblAnticipos;
        private System.Windows.Forms.TextBox txtAnticipos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPagoDiario;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.TextBox txtPagoDiario;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.CheckBox chbAfp;
        private System.Windows.Forms.CheckBox chbIsss;
        private System.Windows.Forms.Label lblHorasExtra;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnAguinaldo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}