namespace SistemaARD.Vistas
{
    partial class RegistroEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleados));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbxNombreAfp = new System.Windows.Forms.ComboBox();
            this.txtNumeroIsss = new System.Windows.Forms.MaskedTextBox();
            this.txtNup = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroNit = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroDui = new System.Windows.Forms.MaskedTextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblNup = new System.Windows.Forms.Label();
            this.lblNombreAFP = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbxCargos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(277, 465);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(127, 493);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 24);
            this.cbxEstado.TabIndex = 42;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(127, 412);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaIngreso.TabIndex = 41;
            // 
            // cbxNombreAfp
            // 
            this.cbxNombreAfp.BackColor = System.Drawing.SystemColors.Window;
            this.cbxNombreAfp.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxNombreAfp.FormattingEnabled = true;
            this.cbxNombreAfp.Location = new System.Drawing.Point(136, 305);
            this.cbxNombreAfp.Name = "cbxNombreAfp";
            this.cbxNombreAfp.Size = new System.Drawing.Size(121, 24);
            this.cbxNombreAfp.TabIndex = 40;
            // 
            // txtNumeroIsss
            // 
            this.txtNumeroIsss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtNumeroIsss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroIsss.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtNumeroIsss.Location = new System.Drawing.Point(136, 376);
            this.txtNumeroIsss.Mask = "000000000";
            this.txtNumeroIsss.Name = "txtNumeroIsss";
            this.txtNumeroIsss.Size = new System.Drawing.Size(121, 17);
            this.txtNumeroIsss.TabIndex = 39;
            this.txtNumeroIsss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIsss_KeyPress);
            // 
            // txtNup
            // 
            this.txtNup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtNup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNup.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtNup.Location = new System.Drawing.Point(136, 343);
            this.txtNup.Mask = "000000000000";
            this.txtNup.Name = "txtNup";
            this.txtNup.Size = new System.Drawing.Size(121, 17);
            this.txtNup.TabIndex = 38;
            this.txtNup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNup_KeyPress);
            // 
            // txtNumeroNit
            // 
            this.txtNumeroNit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtNumeroNit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtNumeroNit.Location = new System.Drawing.Point(136, 268);
            this.txtNumeroNit.Mask = "0000-000000-000-0";
            this.txtNumeroNit.Name = "txtNumeroNit";
            this.txtNumeroNit.Size = new System.Drawing.Size(121, 17);
            this.txtNumeroNit.TabIndex = 37;
            this.txtNumeroNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroNit_KeyPress);
            // 
            // txtNumeroDui
            // 
            this.txtNumeroDui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtNumeroDui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroDui.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtNumeroDui.Location = new System.Drawing.Point(136, 231);
            this.txtNumeroDui.Mask = "00000000-0";
            this.txtNumeroDui.Name = "txtNumeroDui";
            this.txtNumeroDui.Size = new System.Drawing.Size(121, 17);
            this.txtNumeroDui.TabIndex = 36;
            this.txtNumeroDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDui_KeyPress);
            // 
            // cbxGenero
            // 
            this.cbxGenero.BackColor = System.Drawing.SystemColors.Window;
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(79, 191);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 24);
            this.cbxGenero.TabIndex = 35;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(79, 157);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtApellidos.Location = new System.Drawing.Point(79, 72);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 32;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtNombres.Location = new System.Drawing.Point(79, 33);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 20);
            this.txtNombres.TabIndex = 34;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEstado.Location = new System.Drawing.Point(6, 496);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 16);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(7, 412);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(108, 16);
            this.lblFechaIngreso.TabIndex = 30;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblIsss.Location = new System.Drawing.Point(13, 383);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(32, 16);
            this.lblIsss.TabIndex = 29;
            this.lblIsss.Text = "ISSS";
            // 
            // lblNup
            // 
            this.lblNup.AutoSize = true;
            this.lblNup.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblNup.Location = new System.Drawing.Point(10, 346);
            this.lblNup.Name = "lblNup";
            this.lblNup.Size = new System.Drawing.Size(34, 16);
            this.lblNup.TabIndex = 28;
            this.lblNup.Text = "NUP";
            // 
            // lblNombreAFP
            // 
            this.lblNombreAFP.AutoSize = true;
            this.lblNombreAFP.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblNombreAFP.Location = new System.Drawing.Point(10, 314);
            this.lblNombreAFP.Name = "lblNombreAFP";
            this.lblNombreAFP.Size = new System.Drawing.Size(101, 16);
            this.lblNombreAFP.TabIndex = 27;
            this.lblNombreAFP.Text = "Nombre de AFP";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblNit.Location = new System.Drawing.Point(7, 271);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(99, 16);
            this.lblNit.TabIndex = 26;
            this.lblNit.Text = "Número de NIT";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDui.Location = new System.Drawing.Point(6, 231);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(100, 16);
            this.lblDui.TabIndex = 25;
            this.lblDui.Text = "Número de DUI";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblGenero.Location = new System.Drawing.Point(6, 194);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(51, 16);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Género";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDireccion.Location = new System.Drawing.Point(6, 157);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 16);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 116);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(127, 16);
            this.lblFechaNacimiento.TabIndex = 22;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(153, 111);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(126, 24);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblApellidos.Location = new System.Drawing.Point(6, 75);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(62, 16);
            this.lblApellidos.TabIndex = 20;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblNombres.Location = new System.Drawing.Point(6, 36);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(63, 16);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblId.Location = new System.Drawing.Point(232, 193);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 16);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(704, 20);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 45;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblCargo.Location = new System.Drawing.Point(7, 453);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 16);
            this.lblCargo.TabIndex = 46;
            this.lblCargo.Text = "Cargo";
            // 
            // cbxCargos
            // 
            this.cbxCargos.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCargos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cbxCargos.FormattingEnabled = true;
            this.cbxCargos.Location = new System.Drawing.Point(127, 453);
            this.cbxCargos.Name = "cbxCargos";
            this.cbxCargos.Size = new System.Drawing.Size(121, 24);
            this.cbxCargos.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Controls.Add(this.iconCerrar);
            this.groupBox1.Controls.Add(this.cbxCargos);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.txtNumeroIsss);
            this.groupBox1.Controls.Add(this.cbxNombreAfp);
            this.groupBox1.Controls.Add(this.txtNup);
            this.groupBox1.Controls.Add(this.cbxGenero);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Controls.Add(this.lblIsss);
            this.groupBox1.Controls.Add(this.txtNumeroNit);
            this.groupBox1.Controls.Add(this.lblNup);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtNumeroDui);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDui);
            this.groupBox1.Controls.Add(this.lblNit);
            this.groupBox1.Controls.Add(this.lblNombreAFP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 533);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel7.Location = new System.Drawing.Point(277, 516);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 1);
            this.panel7.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel4.Location = new System.Drawing.Point(498, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 58;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel9.Location = new System.Drawing.Point(136, 398);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(121, 1);
            this.panel9.TabIndex = 57;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel8.Location = new System.Drawing.Point(136, 365);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 1);
            this.panel8.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel6.Location = new System.Drawing.Point(136, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 1);
            this.panel6.TabIndex = 54;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel5.Location = new System.Drawing.Point(136, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 1);
            this.panel5.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel3.Location = new System.Drawing.Point(79, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel2.Location = new System.Drawing.Point(78, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.panel1.Location = new System.Drawing.Point(79, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 50;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.txtSalario.Location = new System.Drawing.Point(498, 352);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 17);
            this.txtSalario.TabIndex = 49;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblSalario.Location = new System.Drawing.Point(392, 353);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(100, 16);
            this.lblSalario.TabIndex = 48;
            this.lblSalario.Text = "Salario mensual";
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(770, 549);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblNup;
        private System.Windows.Forms.Label lblNombreAFP;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cbxNombreAfp;
        private System.Windows.Forms.MaskedTextBox txtNumeroIsss;
        private System.Windows.Forms.MaskedTextBox txtNup;
        private System.Windows.Forms.MaskedTextBox txtNumeroNit;
        private System.Windows.Forms.MaskedTextBox txtNumeroDui;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbxCargos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
    }
}