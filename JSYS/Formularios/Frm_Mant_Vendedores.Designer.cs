﻿namespace JSYS.Formularios
{
    partial class Frm_Mant_Vendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_COBRADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREADO_POR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_activo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_inactivo = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Txt_Buscar.Location = new System.Drawing.Point(66, 18);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(305, 22);
            this.Txt_Buscar.TabIndex = 3;
            this.Txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged);
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COBRADOR,
            this.NOMBRE,
            this.ID_TIPO_IDENTIFICACION,
            this.DESCRIPCION,
            this.IDENTIFICACION,
            this.SEXO,
            this.ESTADO,
            this.CREADO_POR,
            this.FECHA_CREADO});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG.Location = new System.Drawing.Point(14, 43);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(773, 320);
            this.DG.TabIndex = 0;
            this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
            // 
            // ID_COBRADOR
            // 
            this.ID_COBRADOR.DataPropertyName = "ID_VENDEDOR";
            this.ID_COBRADOR.HeaderText = "ID";
            this.ID_COBRADOR.Name = "ID_COBRADOR";
            this.ID_COBRADOR.ReadOnly = true;
            this.ID_COBRADOR.Visible = false;
            this.ID_COBRADOR.Width = 40;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 220;
            // 
            // ID_TIPO_IDENTIFICACION
            // 
            this.ID_TIPO_IDENTIFICACION.DataPropertyName = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.HeaderText = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.Name = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.ReadOnly = true;
            this.ID_TIPO_IDENTIFICACION.Visible = false;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Tipo Identificación";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 145;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "NUMERO_IDENTIFICACION";
            this.IDENTIFICACION.HeaderText = "Identificación";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
            this.IDENTIFICACION.Width = 105;
            // 
            // SEXO
            // 
            this.SEXO.DataPropertyName = "SEXO";
            this.SEXO.HeaderText = "Sexo";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 80;
            // 
            // CREADO_POR
            // 
            this.CREADO_POR.DataPropertyName = "CREADO_POR";
            this.CREADO_POR.HeaderText = "Creado Por";
            this.CREADO_POR.Name = "CREADO_POR";
            this.CREADO_POR.ReadOnly = true;
            this.CREADO_POR.Width = 90;
            // 
            // FECHA_CREADO
            // 
            this.FECHA_CREADO.DataPropertyName = "FECHA_CREADO";
            this.FECHA_CREADO.HeaderText = "Fecha";
            this.FECHA_CREADO.Name = "FECHA_CREADO";
            this.FECHA_CREADO.ReadOnly = true;
            this.FECHA_CREADO.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.DG);
            this.groupBox1.Controls.Add(this.Txt_Buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 372);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Activo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_activo);
            this.panel3.Location = new System.Drawing.Point(538, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 22);
            this.panel3.TabIndex = 19;
            // 
            // lbl_activo
            // 
            this.lbl_activo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activo.Location = new System.Drawing.Point(1, 3);
            this.lbl_activo.Name = "lbl_activo";
            this.lbl_activo.Size = new System.Drawing.Size(47, 14);
            this.lbl_activo.TabIndex = 21;
            this.lbl_activo.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(729, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "Inactivo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_inactivo);
            this.panel2.Location = new System.Drawing.Point(677, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 22);
            this.panel2.TabIndex = 17;
            // 
            // lbl_inactivo
            // 
            this.lbl_inactivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inactivo.Location = new System.Drawing.Point(1, 3);
            this.lbl_inactivo.Name = "lbl_inactivo";
            this.lbl_inactivo.Size = new System.Drawing.Size(47, 14);
            this.lbl_inactivo.TabIndex = 22;
            this.lbl_inactivo.Text = "0";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Total.Location = new System.Drawing.Point(407, 37);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(380, 26);
            this.Lbl_Total.TabIndex = 6;
            this.Lbl_Total.Text = "0";
            this.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.Lbl_Total);
            this.groupBox2.Location = new System.Drawing.Point(11, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 70);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::JSYS.Properties.Resources.File_Edit_WF;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(126, 14);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(113, 47);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = global::JSYS.Properties.Resources.File_Add_WF;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(7, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(113, 47);
            this.btn_nuevo.TabIndex = 7;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mantenimiento de Vendedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 46);
            this.panel1.TabIndex = 15;
            // 
            // Frm_Mant_Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(832, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Mant_Vendedores";
            this.Activated += new System.EventHandler(this.Frm_Mant_Vendedores_Activated);
            this.Load += new System.EventHandler(this.Frm_Mant_Vendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COBRADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREADO_POR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREADO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_activo;
        private System.Windows.Forms.Label lbl_inactivo;
    }
}