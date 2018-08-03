using Datos;
using Servicios;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Articulo : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Articulo()
        {
            InitializeComponent();
        }

        public void Recibir_Datos(ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_articulo = db.ARTICULOS.Find(obj.ID_ARTICULO);
                Txt_ID.Text = obj_articulo.ID_ARTICULO.ToString();
                txt_descripcion.Text = obj_articulo.DESCRIPCION;
                txt_precio_compra.Text = obj_articulo.PRECIO_COMPRA.ToString("N2");
                txt_precio_venta1.Text = obj_articulo.PRECIO_VENTA1.ToString("N2");
                txt_precio_venta2.Text = obj_articulo.PRECIO_VENTA2.ToString("N2");
                txt_precio_venta3.Text = obj_articulo.PRECIO_VENTA3.ToString("N2");
                cb_estado.Text = obj_articulo.ESTADO == "A" ? "Activo" : "Inactivo";
                txt_referencia.Text = obj_articulo.REFERENCIA;
                txt_stock_minimo.Text = obj_articulo.STOCK_MININO.ToString();
                byte[] Logo = (byte[])obj_articulo.IMAGEN;
                System.IO.MemoryStream ms = new MemoryStream(Logo);
                pb_imagen.Image = Image.FromStream(ms);
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        private void btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pb_imagen.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    S_Utilidades.Mensaje_Informacion("No ha Seleccionado Ninguna Imagen");
                    return;
                }
            }
        }

        public void Insertar()
        {
            string Mensaje = "";
            System.IO.MemoryStream ms = new MemoryStream();
            this.pb_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] ruta_imagen = ms.GetBuffer();
            try
            {
                ARTICULOS obj = new ARTICULOS();
                obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj.DESCRIPCION = txt_descripcion.Text.Trim();
                obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
                obj.FECHA_CREADO = DateTime.Now;
                obj.IMAGEN = ruta_imagen;
                obj.PRECIO_COMPRA = txt_precio_compra.TextLength == 0 ? 0 : Convert.ToDecimal(txt_precio_compra.Text);
                obj.PRECIO_VENTA1 = txt_precio_venta1.TextLength == 0 ? 0 : Convert.ToDecimal(txt_precio_venta1.Text);
                obj.PRECIO_VENTA2 = txt_precio_venta2.TextLength == 0 ? 0 : Convert.ToDecimal(txt_precio_venta2.Text);
                obj.PRECIO_VENTA3 = txt_precio_venta3.TextLength == 0 ? 0 : Convert.ToDecimal(txt_precio_venta3.Text);               
                obj.STOCK_MININO = txt_stock_minimo.TextLength == 0 ? 0 : Convert.ToInt32(txt_stock_minimo.Text);
                obj.REFERENCIA = txt_referencia.Text.Trim();
                if (Txt_ID.Text.Equals(""))
                { 
                    S_Articulo.Insertar_Articulo(obj);
                    Mensaje = "Registro Insertado con Éxito";
                }
                else
                {
                    obj.ID_ARTICULO = Convert.ToInt32(Txt_ID.Text);
                    S_Articulo.Actualizar_Articulo(obj);
                    Mensaje = "Registro Actualizado con Éxito";
                }
                S_Utilidades.Mensaje_Informacion(Mensaje);
                this.Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            if (txt_descripcion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Descripción Es Obligatoria");
                txt_descripcion.Focus();
                return;
            }
            if (txt_referencia.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Referencia Es Obligatoria");
                txt_referencia.Focus();
                return;
            }
            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
                return;
            }
            int id = Convert.ToInt32(Txt_ID.Text);
            var articulo = db.INVENTARIO_ARTICULOS.Where(s => s.ID_ARTICULO == id).Single();

            if (!Txt_ID.Text.Equals("") && cb_estado.Text == "Inactivo")
            {
                if(articulo.STOCK_ACTUAL > 0 )
                {
                    S_Utilidades.Mensaje_Informacion("Este Articulo Tiene Stock, No puede Ser Inactivado");
                    return;
                }
            }

            Insertar();
        }

        private void btn_borrar_imagen_Click(object sender, EventArgs e)
        {
            pb_imagen.Image = global::JSYS.Properties.Resources.Logo_Transparente;
        }

        private void txt_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender,e,txt_precio_compra);
        }

        private void txt_precio_venta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender, e, txt_precio_venta1);
        }

        private void txt_precio_venta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender, e, txt_precio_venta2);
        }

        private void txt_precio_venta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender, e, txt_precio_venta3);
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero(sender, e);
        }
    }
}
