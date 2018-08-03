namespace JSYS.Formularios
{
    partial class Frm_Factura
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cb_cobrador = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dg_detalle_factura = new System.Windows.Forms.DataGridView();
            this.ID_ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dt_fecha_factura = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_numero_contrato = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_numero_loteria = new System.Windows.Forms.ComboBox();
            this.txt_numero_factura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_detalle_cuotas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_fecha_primera_cuota = new System.Windows.Forms.DateTimePicker();
            this.txt_cantidad_cuota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_modo_calculo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_quitar_articulo = new System.Windows.Forms.Button();
            this.btn_agregar_articulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_factura)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_cuotas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(10, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 482);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(105, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 478);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.cb_estado);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_total);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.btn_quitar_articulo);
            this.tabPage1.Controls.Add(this.dg_detalle_factura);
            this.tabPage1.Controls.Add(this.btn_agregar_articulo);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.txt_observacion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de Factura";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cb_vendedor);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.cb_cobrador);
            this.groupBox8.Controls.Add(this.label31);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(17, 115);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(636, 51);
            this.groupBox8.TabIndex = 42;
            this.groupBox8.TabStop = false;
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vendedor.FormattingEnabled = true;
            this.cb_vendedor.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_vendedor.Location = new System.Drawing.Point(76, 17);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(230, 22);
            this.cb_vendedor.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(7, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(66, 14);
            this.label30.TabIndex = 37;
            this.label30.Text = "Vendedor";
            // 
            // cb_cobrador
            // 
            this.cb_cobrador.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cobrador.FormattingEnabled = true;
            this.cb_cobrador.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_cobrador.Location = new System.Drawing.Point(393, 17);
            this.cb_cobrador.Name = "cb_cobrador";
            this.cb_cobrador.Size = new System.Drawing.Size(230, 22);
            this.cb_cobrador.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(326, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 14);
            this.label31.TabIndex = 39;
            this.label31.Text = "Cobrador";
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(104, 368);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(323, 22);
            this.cb_estado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_total.Location = new System.Drawing.Point(543, 325);
            this.txt_total.MaxLength = 25;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(111, 22);
            this.txt_total.TabIndex = 30;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(502, 329);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 14);
            this.label27.TabIndex = 31;
            this.label27.Text = "Total";
            // 
            // dg_detalle_factura
            // 
            this.dg_detalle_factura.AllowUserToAddRows = false;
            this.dg_detalle_factura.AllowUserToDeleteRows = false;
            this.dg_detalle_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalle_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ARTICULO,
            this.REFERENCIA,
            this.DESCRIPCION,
            this.PRECIO_VENTA1,
            this.precio,
            this.SUBTOTAL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_detalle_factura.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_detalle_factura.Location = new System.Drawing.Point(17, 175);
            this.dg_detalle_factura.Name = "dg_detalle_factura";
            this.dg_detalle_factura.ReadOnly = true;
            this.dg_detalle_factura.RowHeadersVisible = false;
            this.dg_detalle_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_detalle_factura.Size = new System.Drawing.Size(636, 148);
            this.dg_detalle_factura.TabIndex = 28;
            // 
            // ID_ARTICULO
            // 
            this.ID_ARTICULO.DataPropertyName = "ID_ARTICULO";
            this.ID_ARTICULO.HeaderText = "ID";
            this.ID_ARTICULO.Name = "ID_ARTICULO";
            this.ID_ARTICULO.ReadOnly = true;
            this.ID_ARTICULO.Visible = false;
            this.ID_ARTICULO.Width = 40;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "REFERENCIA";
            this.REFERENCIA.HeaderText = "Referencia";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            this.REFERENCIA.Width = 80;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripción";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 325;
            // 
            // PRECIO_VENTA1
            // 
            this.PRECIO_VENTA1.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "n2";
            this.PRECIO_VENTA1.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECIO_VENTA1.HeaderText = "Cant.";
            this.PRECIO_VENTA1.Name = "PRECIO_VENTA1";
            this.PRECIO_VENTA1.ReadOnly = true;
            this.PRECIO_VENTA1.Width = 40;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PRECIO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 90;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.DataPropertyName = "MONTO_TOTAL";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.SUBTOTAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.SUBTOTAL.HeaderText = "Total";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            this.SUBTOTAL.Width = 90;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.dt_fecha_factura);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.txt_numero_contrato);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.cb_numero_loteria);
            this.groupBox7.Controls.Add(this.txt_numero_factura);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(17, 61);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(637, 52);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Datos de Factura";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(464, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 14);
            this.label26.TabIndex = 23;
            this.label26.Text = "Fecha";
            // 
            // dt_fecha_factura
            // 
            this.dt_fecha_factura.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dt_fecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_factura.Location = new System.Drawing.Point(508, 21);
            this.dt_fecha_factura.Name = "dt_fecha_factura";
            this.dt_fecha_factura.Size = new System.Drawing.Size(115, 22);
            this.dt_fecha_factura.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(325, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 14);
            this.label25.TabIndex = 21;
            this.label25.Text = "No. Loteria";
            // 
            // txt_numero_contrato
            // 
            this.txt_numero_contrato.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_numero_contrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numero_contrato.Location = new System.Drawing.Point(232, 21);
            this.txt_numero_contrato.MaxLength = 25;
            this.txt_numero_contrato.Name = "txt_numero_contrato";
            this.txt_numero_contrato.Size = new System.Drawing.Size(74, 22);
            this.txt_numero_contrato.TabIndex = 0;
            this.txt_numero_contrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(142, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 14);
            this.label24.TabIndex = 20;
            this.label24.Text = "No. Contrato";
            // 
            // cb_numero_loteria
            // 
            this.cb_numero_loteria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_numero_loteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numero_loteria.FormattingEnabled = true;
            this.cb_numero_loteria.Items.AddRange(new object[] {
            "",
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cb_numero_loteria.Location = new System.Drawing.Point(402, 21);
            this.cb_numero_loteria.Name = "cb_numero_loteria";
            this.cb_numero_loteria.Size = new System.Drawing.Size(49, 22);
            this.cb_numero_loteria.TabIndex = 1;
            // 
            // txt_numero_factura
            // 
            this.txt_numero_factura.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_numero_factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numero_factura.Enabled = false;
            this.txt_numero_factura.Location = new System.Drawing.Point(74, 21);
            this.txt_numero_factura.MaxLength = 25;
            this.txt_numero_factura.Name = "txt_numero_factura";
            this.txt_numero_factura.Size = new System.Drawing.Size(52, 22);
            this.txt_numero_factura.TabIndex = 0;
            this.txt_numero_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "No.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.cb_cliente);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(17, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(636, 51);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos del Cliente";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 14);
            this.label23.TabIndex = 18;
            this.label23.Text = "Cliente";
            // 
            // cb_cliente
            // 
            this.cb_cliente.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_cliente.Location = new System.Drawing.Point(74, 22);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(453, 22);
            this.cb_cliente.TabIndex = 0;
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_observacion.Location = new System.Drawing.Point(104, 393);
            this.txt_observacion.MaxLength = 500;
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(549, 44);
            this.txt_observacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Observación";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_detalle_cuotas);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Desglose de Cuotas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_detalle_cuotas
            // 
            this.dg_detalle_cuotas.AllowUserToAddRows = false;
            this.dg_detalle_cuotas.AllowUserToDeleteRows = false;
            this.dg_detalle_cuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalle_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_detalle_cuotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_detalle_cuotas.Location = new System.Drawing.Point(329, 10);
            this.dg_detalle_cuotas.Name = "dg_detalle_cuotas";
            this.dg_detalle_cuotas.ReadOnly = true;
            this.dg_detalle_cuotas.RowHeadersVisible = false;
            this.dg_detalle_cuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_detalle_cuotas.Size = new System.Drawing.Size(311, 432);
            this.dg_detalle_cuotas.TabIndex = 187;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ARTICULO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "REFERENCIA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPCION";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dt_fecha_primera_cuota);
            this.groupBox3.Controls.Add(this.txt_cantidad_cuota);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_modo_calculo);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBox3.Location = new System.Drawing.Point(30, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 179);
            this.groupBox3.TabIndex = 186;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculo de Cuota(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fecha Primera Cuota";
            // 
            // dt_fecha_primera_cuota
            // 
            this.dt_fecha_primera_cuota.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dt_fecha_primera_cuota.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_primera_cuota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_primera_cuota.Location = new System.Drawing.Point(151, 69);
            this.dt_fecha_primera_cuota.Name = "dt_fecha_primera_cuota";
            this.dt_fecha_primera_cuota.Size = new System.Drawing.Size(115, 21);
            this.dt_fecha_primera_cuota.TabIndex = 45;
            // 
            // txt_cantidad_cuota
            // 
            this.txt_cantidad_cuota.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_cantidad_cuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cantidad_cuota.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_cuota.Location = new System.Drawing.Point(151, 46);
            this.txt_cantidad_cuota.MaxLength = 25;
            this.txt_cantidad_cuota.Name = "txt_cantidad_cuota";
            this.txt_cantidad_cuota.Size = new System.Drawing.Size(52, 21);
            this.txt_cantidad_cuota.TabIndex = 43;
            this.txt_cantidad_cuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad Cuota(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Modo de Calculo";
            // 
            // cb_modo_calculo
            // 
            this.cb_modo_calculo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_modo_calculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modo_calculo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modo_calculo.FormattingEnabled = true;
            this.cb_modo_calculo.Items.AddRange(new object[] {
            "",
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.cb_modo_calculo.Location = new System.Drawing.Point(151, 23);
            this.cb_modo_calculo.Name = "cb_modo_calculo";
            this.cb_modo_calculo.Size = new System.Drawing.Size(108, 21);
            this.cb_modo_calculo.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 41);
            this.panel1.TabIndex = 23;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(714, 13);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 22);
            this.Txt_ID.TabIndex = 9;
            this.Txt_ID.Visible = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Titulo.Location = new System.Drawing.Point(9, 10);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(13, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = ":";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::JSYS.Properties.Resources._1450119000_reports;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(9, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reporte";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::JSYS.Properties.Resources.File_Save_WF;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(9, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 59);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_quitar_articulo
            // 
            this.btn_quitar_articulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_articulo.Image = global::JSYS.Properties.Resources.Delete_16x16;
            this.btn_quitar_articulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar_articulo.Location = new System.Drawing.Point(143, 325);
            this.btn_quitar_articulo.Name = "btn_quitar_articulo";
            this.btn_quitar_articulo.Size = new System.Drawing.Size(124, 32);
            this.btn_quitar_articulo.TabIndex = 29;
            this.btn_quitar_articulo.Text = "Borrar Articulo";
            this.btn_quitar_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar_articulo.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_articulo
            // 
            this.btn_agregar_articulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_articulo.Image = global::JSYS.Properties.Resources.Add_16x16;
            this.btn_agregar_articulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_articulo.Location = new System.Drawing.Point(17, 325);
            this.btn_agregar_articulo.Name = "btn_agregar_articulo";
            this.btn_agregar_articulo.Size = new System.Drawing.Size(124, 32);
            this.btn_agregar_articulo.TabIndex = 0;
            this.btn_agregar_articulo.Text = "Agregar Articulo";
            this.btn_agregar_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_articulo.UseVisualStyleBackColor = true;
            this.btn_agregar_articulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::JSYS.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(529, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::JSYS.Properties.Resources.Money_Coin_02_WF;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(153, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 46);
            this.button3.TabIndex = 47;
            this.button3.Text = "Calcular";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(797, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Factura";
            this.Load += new System.EventHandler(this.Frm_Factura_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_factura)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_cuotas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_agregar_articulo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dt_fecha_factura;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_numero_contrato;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_numero_loteria;
        private System.Windows.Forms.TextBox txt_numero_factura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cb_vendedor;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cb_cobrador;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_quitar_articulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_fecha_primera_cuota;
        private System.Windows.Forms.TextBox txt_cantidad_cuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_modo_calculo;
        private System.Windows.Forms.DataGridView dg_detalle_cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridView dg_detalle_factura;
        public System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        public System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Button button2;
    }
}
