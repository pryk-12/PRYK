namespace JSYS.Formularios
{
    partial class Frm_Articulo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precio_venta3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precio_venta2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio_venta1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_borrar_imagen = new System.Windows.Forms.Button();
            this.btn_agregar_imagen = new System.Windows.Forms.Button();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(525, 41);
            this.panel1.TabIndex = 19;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(442, 13);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Referencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // txt_referencia
            // 
            this.txt_referencia.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_referencia.Location = new System.Drawing.Point(109, 18);
            this.txt_referencia.MaxLength = 20;
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(142, 22);
            this.txt_referencia.TabIndex = 0;
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(109, 136);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(88, 22);
            this.cb_estado.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_descripcion.Location = new System.Drawing.Point(109, 42);
            this.txt_descripcion.MaxLength = 200;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(286, 44);
            this.txt_descripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(7, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 278);
            this.groupBox2.TabIndex = 21;
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
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stock_minimo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_precio_venta3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_precio_venta2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_precio_venta1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_precio_compra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_referencia);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(104, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 168);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_stock_minimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_stock_minimo.Location = new System.Drawing.Point(307, 136);
            this.txt_stock_minimo.MaxLength = 15;
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(88, 22);
            this.txt_stock_minimo.TabIndex = 7;
            this.txt_stock_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stock_minimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_minimo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "Stock Minimo";
            // 
            // txt_precio_venta3
            // 
            this.txt_precio_venta3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_precio_venta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio_venta3.Location = new System.Drawing.Point(307, 112);
            this.txt_precio_venta3.MaxLength = 15;
            this.txt_precio_venta3.Name = "txt_precio_venta3";
            this.txt_precio_venta3.Size = new System.Drawing.Size(88, 22);
            this.txt_precio_venta3.TabIndex = 5;
            this.txt_precio_venta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_venta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "Precio Venta 3";
            // 
            // txt_precio_venta2
            // 
            this.txt_precio_venta2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_precio_venta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio_venta2.Location = new System.Drawing.Point(109, 112);
            this.txt_precio_venta2.MaxLength = 15;
            this.txt_precio_venta2.Name = "txt_precio_venta2";
            this.txt_precio_venta2.Size = new System.Drawing.Size(88, 22);
            this.txt_precio_venta2.TabIndex = 4;
            this.txt_precio_venta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_venta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Precio Venta 2";
            // 
            // txt_precio_venta1
            // 
            this.txt_precio_venta1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_precio_venta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio_venta1.Location = new System.Drawing.Point(307, 88);
            this.txt_precio_venta1.MaxLength = 15;
            this.txt_precio_venta1.Name = "txt_precio_venta1";
            this.txt_precio_venta1.Size = new System.Drawing.Size(88, 22);
            this.txt_precio_venta1.TabIndex = 3;
            this.txt_precio_venta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_venta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio Venta 1";
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_precio_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio_compra.Location = new System.Drawing.Point(109, 88);
            this.txt_precio_compra.MaxLength = 15;
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(88, 22);
            this.txt_precio_compra.TabIndex = 2;
            this.txt_precio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_compra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio Compra";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_borrar_imagen
            // 
            this.btn_borrar_imagen.Image = global::JSYS.Properties.Resources.Delete_16x16;
            this.btn_borrar_imagen.Location = new System.Drawing.Point(225, 283);
            this.btn_borrar_imagen.Name = "btn_borrar_imagen";
            this.btn_borrar_imagen.Size = new System.Drawing.Size(130, 35);
            this.btn_borrar_imagen.TabIndex = 24;
            this.btn_borrar_imagen.Text = "Borrar Imagen";
            this.btn_borrar_imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borrar_imagen.UseVisualStyleBackColor = true;
            this.btn_borrar_imagen.Click += new System.EventHandler(this.btn_borrar_imagen_Click);
            // 
            // btn_agregar_imagen
            // 
            this.btn_agregar_imagen.Image = global::JSYS.Properties.Resources.Add_16x16;
            this.btn_agregar_imagen.Location = new System.Drawing.Point(225, 247);
            this.btn_agregar_imagen.Name = "btn_agregar_imagen";
            this.btn_agregar_imagen.Size = new System.Drawing.Size(130, 35);
            this.btn_agregar_imagen.TabIndex = 23;
            this.btn_agregar_imagen.Text = "Agregar Imagen";
            this.btn_agregar_imagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar_imagen.UseVisualStyleBackColor = true;
            this.btn_agregar_imagen.Click += new System.EventHandler(this.btn_agregar_imagen_Click);
            // 
            // pb_imagen
            // 
            this.pb_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imagen.Image = global::JSYS.Properties.Resources.Logo_Transparente;
            this.pb_imagen.Location = new System.Drawing.Point(359, 214);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(155, 105);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 22;
            this.pb_imagen.TabStop = false;
            // 
            // Frm_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(525, 326);
            this.Controls.Add(this.btn_borrar_imagen);
            this.Controls.Add(this.btn_agregar_imagen);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Articulo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precio_venta3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precio_venta2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precio_venta1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.Button btn_agregar_imagen;
        private System.Windows.Forms.Button btn_borrar_imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
