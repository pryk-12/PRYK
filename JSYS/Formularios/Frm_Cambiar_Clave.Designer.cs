namespace JSYS.Formularios
{
    partial class Frm_Cambiar_Clave
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_confirmar_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_confirmar_clave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Clave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(110, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 112);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Usuario.Enabled = false;
            this.Txt_Usuario.Location = new System.Drawing.Point(113, 24);
            this.Txt_Usuario.MaxLength = 15;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(180, 22);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Txt_Clave.Location = new System.Drawing.Point(113, 48);
            this.Txt_Clave.MaxLength = 30;
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(180, 22);
            this.Txt_Clave.TabIndex = 2;
            this.Txt_Clave.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Clave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 112);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ID.Location = new System.Drawing.Point(346, 13);
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
            this.Lbl_Titulo.Size = new System.Drawing.Size(116, 18);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Cambiar Clave";
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
            this.panel1.Size = new System.Drawing.Size(429, 41);
            this.panel1.TabIndex = 19;
            // 
            // txt_confirmar_clave
            // 
            this.txt_confirmar_clave.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_confirmar_clave.Location = new System.Drawing.Point(113, 72);
            this.txt_confirmar_clave.MaxLength = 30;
            this.txt_confirmar_clave.Name = "txt_confirmar_clave";
            this.txt_confirmar_clave.Size = new System.Drawing.Size(180, 22);
            this.txt_confirmar_clave.TabIndex = 13;
            this.txt_confirmar_clave.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirmar Clave";
            // 
            // Frm_Cambiar_Clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(429, 168);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cambiar_Clave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_confirmar_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
    }
}
