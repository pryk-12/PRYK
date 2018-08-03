namespace JSYS.Formularios
{
    partial class Frm_Pago_CXP
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto_pendiente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_monto_pagado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id_cxp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_monto_pagar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_monto_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_forma_pago = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "Pendiente";
            // 
            // txt_monto_pendiente
            // 
            this.txt_monto_pendiente.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_monto_pendiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_monto_pendiente.Enabled = false;
            this.txt_monto_pendiente.Location = new System.Drawing.Point(101, 91);
            this.txt_monto_pendiente.MaxLength = 25;
            this.txt_monto_pendiente.Name = "txt_monto_pendiente";
            this.txt_monto_pendiente.Size = new System.Drawing.Size(93, 22);
            this.txt_monto_pendiente.TabIndex = 3;
            this.txt_monto_pendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pagado";
            // 
            // txt_monto_pagado
            // 
            this.txt_monto_pagado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_monto_pagado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_monto_pagado.Enabled = false;
            this.txt_monto_pagado.Location = new System.Drawing.Point(101, 67);
            this.txt_monto_pagado.MaxLength = 25;
            this.txt_monto_pagado.Name = "txt_monto_pagado";
            this.txt_monto_pagado.Size = new System.Drawing.Size(93, 22);
            this.txt_monto_pagado.TabIndex = 2;
            this.txt_monto_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 39;
            this.label13.Text = "ID CXP";
            // 
            // txt_id_cxp
            // 
            this.txt_id_cxp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_id_cxp.Enabled = false;
            this.txt_id_cxp.Location = new System.Drawing.Point(101, 19);
            this.txt_id_cxp.MaxLength = 15;
            this.txt_id_cxp.Name = "txt_id_cxp";
            this.txt_id_cxp.Size = new System.Drawing.Size(93, 22);
            this.txt_id_cxp.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Monto a Pagar";
            // 
            // txt_monto_pagar
            // 
            this.txt_monto_pagar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_monto_pagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_monto_pagar.Location = new System.Drawing.Point(311, 91);
            this.txt_monto_pagar.MaxLength = 25;
            this.txt_monto_pagar.Name = "txt_monto_pagar";
            this.txt_monto_pagar.Size = new System.Drawing.Size(103, 22);
            this.txt_monto_pagar.TabIndex = 7;
            this.txt_monto_pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_monto_pagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_pagar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estado";
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Vigente",
            "Anulado"});
            this.cb_estado.Location = new System.Drawing.Point(311, 43);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(103, 22);
            this.cb_estado.TabIndex = 5;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(461, 13);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 41);
            this.panel1.TabIndex = 27;
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_observacion.Location = new System.Drawing.Point(101, 115);
            this.txt_observacion.MaxLength = 500;
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(313, 66);
            this.txt_observacion.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 14);
            this.label12.TabIndex = 10;
            this.label12.Text = "Observación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_monto_total);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_forma_pago);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_monto_pendiente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_monto_pagado);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_id_cxp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_monto_pagar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cb_estado);
            this.groupBox3.Controls.Add(this.txt_observacion);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(106, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 195);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "Monto Total";
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_monto_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_monto_total.Enabled = false;
            this.txt_monto_total.Location = new System.Drawing.Point(101, 43);
            this.txt_monto_total.MaxLength = 25;
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(93, 22);
            this.txt_monto_total.TabIndex = 1;
            this.txt_monto_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 45;
            this.label3.Text = "Forma de Pago";
            // 
            // cb_forma_pago
            // 
            this.cb_forma_pago.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_forma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_forma_pago.FormattingEnabled = true;
            this.cb_forma_pago.Items.AddRange(new object[] {
            "",
            "Efectivo",
            "Cheque",
            "Tarjeta",
            "Bono",
            "Nota",
            "Otros"});
            this.cb_forma_pago.Location = new System.Drawing.Point(311, 67);
            this.cb_forma_pago.Name = "cb_forma_pago";
            this.cb_forma_pago.Size = new System.Drawing.Size(103, 22);
            this.cb_forma_pago.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(10, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 195);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
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
            // Frm_Pago_CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(544, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Pago_CXP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto_pendiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_monto_pagado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id_cxp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_monto_pagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_forma_pago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_monto_total;
    }
}
