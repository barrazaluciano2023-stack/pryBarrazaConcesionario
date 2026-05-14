namespace pryBarrazaConcesionario
{
    partial class Concesionaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concesionaria));
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.gpbReserva = new System.Windows.Forms.GroupBox();
            this.mtbImporte = new System.Windows.Forms.MaskedTextBox();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.btnCargarReserva = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbAuto = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrarVehiculo = new System.Windows.Forms.Button();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grbClinte = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.BtnCancelarCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.gpbAutos.SuspendLayout();
            this.gpbReserva.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbAuto.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grbClinte.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(6, 19);
            this.dgvAutos.MultiSelect = false;
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            this.dgvAutos.RowHeadersVisible = false;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutos.Size = new System.Drawing.Size(550, 112);
            this.dgvAutos.TabIndex = 1;
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.dgvAutos);
            this.gpbAutos.Location = new System.Drawing.Point(9, 19);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(562, 137);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Seleccione un Auto";
            // 
            // gpbReserva
            // 
            this.gpbReserva.Controls.Add(this.mtbImporte);
            this.gpbReserva.Controls.Add(this.dtpReserva);
            this.gpbReserva.Controls.Add(this.btnCancelar);
            this.gpbReserva.Controls.Add(this.dtpDevolucion);
            this.gpbReserva.Controls.Add(this.cmbSeguro);
            this.gpbReserva.Controls.Add(this.btnCargarReserva);
            this.gpbReserva.Controls.Add(this.label9);
            this.gpbReserva.Controls.Add(this.label8);
            this.gpbReserva.Controls.Add(this.label7);
            this.gpbReserva.Controls.Add(this.label6);
            this.gpbReserva.Location = new System.Drawing.Point(9, 333);
            this.gpbReserva.Name = "gpbReserva";
            this.gpbReserva.Size = new System.Drawing.Size(550, 171);
            this.gpbReserva.TabIndex = 3;
            this.gpbReserva.TabStop = false;
            this.gpbReserva.Text = "Detalles de Reserva";
            // 
            // mtbImporte
            // 
            this.mtbImporte.Location = new System.Drawing.Point(191, 105);
            this.mtbImporte.Mask = "$99999999";
            this.mtbImporte.Name = "mtbImporte";
            this.mtbImporte.Size = new System.Drawing.Size(148, 20);
            this.mtbImporte.TabIndex = 7;
            // 
            // dtpReserva
            // 
            this.dtpReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReserva.Location = new System.Drawing.Point(135, 24);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(204, 20);
            this.dtpReserva.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 63);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(135, 52);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(204, 20);
            this.dtpDevolucion.TabIndex = 7;
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Items.AddRange(new object[] {
            "Total",
            "Contra Terceros",
            "No tiene"});
            this.cmbSeguro.Location = new System.Drawing.Point(191, 78);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(148, 21);
            this.cmbSeguro.TabIndex = 7;
            // 
            // btnCargarReserva
            // 
            this.btnCargarReserva.Location = new System.Drawing.Point(422, 25);
            this.btnCargarReserva.Name = "btnCargarReserva";
            this.btnCargarReserva.Size = new System.Drawing.Size(107, 23);
            this.btnCargarReserva.TabIndex = 4;
            this.btnCargarReserva.Text = "Cargar Reserva";
            this.btnCargarReserva.UseVisualStyleBackColor = true;
            this.btnCargarReserva.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Importe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Seguro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha de Devolucion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Reserva:";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Controls.Add(this.tabPage3);
            this.tbcPrincipal.Controls.Add(this.tabPage2);
            this.tbcPrincipal.Location = new System.Drawing.Point(240, 35);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(582, 551);
            this.tbcPrincipal.TabIndex = 6;
            this.tbcPrincipal.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbAuto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbAuto
            // 
            this.grbAuto.Controls.Add(this.label15);
            this.grbAuto.Controls.Add(this.cmbEstado);
            this.grbAuto.Controls.Add(this.button1);
            this.grbAuto.Controls.Add(this.RegistrarVehiculo);
            this.grbAuto.Controls.Add(this.txtKilometraje);
            this.grbAuto.Controls.Add(this.txtPatente);
            this.grbAuto.Controls.Add(this.txtAño);
            this.grbAuto.Controls.Add(this.txtModelo);
            this.grbAuto.Controls.Add(this.txtMarca);
            this.grbAuto.Controls.Add(this.label10);
            this.grbAuto.Controls.Add(this.label11);
            this.grbAuto.Controls.Add(this.label12);
            this.grbAuto.Controls.Add(this.label13);
            this.grbAuto.Controls.Add(this.label14);
            this.grbAuto.Location = new System.Drawing.Point(89, 91);
            this.grbAuto.Name = "grbAuto";
            this.grbAuto.Size = new System.Drawing.Size(378, 295);
            this.grbAuto.TabIndex = 1;
            this.grbAuto.TabStop = false;
            this.grbAuto.Text = "Datos Vehiculo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Excelente",
            "Muy bueno",
            "Buebi"});
            this.cmbEstado.Location = new System.Drawing.Point(177, 180);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(165, 21);
            this.cmbEstado.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarVehiculo
            // 
            this.RegistrarVehiculo.Location = new System.Drawing.Point(268, 244);
            this.RegistrarVehiculo.Name = "RegistrarVehiculo";
            this.RegistrarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.RegistrarVehiculo.TabIndex = 10;
            this.RegistrarVehiculo.Text = "Registrar Vehiculo";
            this.RegistrarVehiculo.UseVisualStyleBackColor = true;
            this.RegistrarVehiculo.Click += new System.EventHandler(this.RegistrarVehiculo_Click);
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(87, 144);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(255, 20);
            this.txtKilometraje.TabIndex = 9;
            this.txtKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometraje_KeyPress);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(87, 116);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(255, 20);
            this.txtPatente.TabIndex = 8;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(85, 77);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(258, 20);
            this.txtAño.TabIndex = 7;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(85, 47);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(258, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(85, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(258, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Patente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Modelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "kilometraje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Año";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Marca: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grbClinte);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registrar Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grbClinte
            // 
            this.grbClinte.Controls.Add(this.txtDni);
            this.grbClinte.Controls.Add(this.BtnCancelarCliente);
            this.grbClinte.Controls.Add(this.btnRegistrarCliente);
            this.grbClinte.Controls.Add(this.txtMail);
            this.grbClinte.Controls.Add(this.txtDireccion);
            this.grbClinte.Controls.Add(this.txtTelefono);
            this.grbClinte.Controls.Add(this.txtNombre);
            this.grbClinte.Controls.Add(this.label5);
            this.grbClinte.Controls.Add(this.label4);
            this.grbClinte.Controls.Add(this.label3);
            this.grbClinte.Controls.Add(this.label2);
            this.grbClinte.Controls.Add(this.label1);
            this.grbClinte.Location = new System.Drawing.Point(56, 68);
            this.grbClinte.Name = "grbClinte";
            this.grbClinte.Size = new System.Drawing.Size(440, 319);
            this.grbClinte.TabIndex = 1;
            this.grbClinte.TabStop = false;
            this.grbClinte.Text = "Datos Cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(195, 75);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(167, 20);
            this.txtDni.TabIndex = 12;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // BtnCancelarCliente
            // 
            this.BtnCancelarCliente.Location = new System.Drawing.Point(195, 252);
            this.BtnCancelarCliente.Name = "BtnCancelarCliente";
            this.BtnCancelarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarCliente.TabIndex = 11;
            this.BtnCancelarCliente.Text = "Cancelar";
            this.BtnCancelarCliente.UseVisualStyleBackColor = true;
            this.BtnCancelarCliente.Click += new System.EventHandler(this.BtnCancelarCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(287, 252);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarCliente.TabIndex = 10;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click_1);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(109, 161);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(255, 20);
            this.txtMail.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(109, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(255, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(104, 101);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(258, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.gpbAutos);
            this.tabPage2.Controls.Add(this.gpbReserva);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Reserva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClientes);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 137);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un Cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 13);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(550, 118);
            this.dgvClientes.TabIndex = 1;
            // 
            // Concesionaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 742);
            this.Controls.Add(this.tbcPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concesionaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concesionaria";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.gpbAutos.ResumeLayout(false);
            this.gpbReserva.ResumeLayout(false);
            this.gpbReserva.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbAuto.ResumeLayout(false);
            this.grbAuto.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grbClinte.ResumeLayout(false);
            this.grbClinte.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbReserva;
        private System.Windows.Forms.Button btnCargarReserva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegistrarVehiculo;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private System.Windows.Forms.MaskedTextBox mtbImporte;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grbClinte;
        private System.Windows.Forms.Button BtnCancelarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
    }
}