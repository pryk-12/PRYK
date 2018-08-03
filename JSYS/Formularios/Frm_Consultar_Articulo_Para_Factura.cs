using Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Datos;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Articulo_Para_Factura : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Articulo_Para_Factura()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Articulos(string Condicion)
        { 
            DG.DataSource = S_Articulo.Listar_Inventario_Articulos(Condicion);
        }
               
        public void Recibir_Datos()
        {            
            BD_JSYSEntities db = new BD_JSYSEntities();
            string referencia = DG.SelectedCells[1].Value.ToString();
            int id_articulo =Convert.ToInt32(DG.SelectedCells[0].Value.ToString());
            var obj = db.ARTICULOS.Where(a => a.REFERENCIA == referencia).Single();
            var obj_inv = db.INVENTARIO_ARTICULOS.Where(a => a.ID_ARTICULO == id_articulo).Single();

            txt_referencia.Text = referencia;
            txt_stock.Text = obj_inv.STOCK_ACTUAL.ToString();
            txt_descripcion.Text = obj.DESCRIPCION;
            txt_id.Text = obj.ID_ARTICULO.ToString();
            txt_total.Text = "";
            txt_cantidad.Text = "";
            cb_tipo_precio.Text = "Precio 1";

            if (cb_tipo_precio.Text=="Precio 1")
            {
                txt_precio.Text = obj.PRECIO_VENTA1.ToString("N2");
            }
        }

        private void cb_tipo_precio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD_JSYSEntities db = new BD_JSYSEntities();

                if(txt_referencia.Text.Equals(""))
                {
                    S_Utilidades.Mensaje_Informacion("Se Debe Seleccionar el Articulo");
                    return;
                }

                string referencia = txt_referencia.Text.Trim();
                var obj = db.ARTICULOS.Where(a => a.REFERENCIA == referencia).Single();

                if (cb_tipo_precio.Text == "Precio 1")
                {
                    txt_precio.Text = obj.PRECIO_VENTA1.ToString("N2");
                }
                else if (cb_tipo_precio.Text == "Precio 2")
                {
                    txt_precio.Text = obj.PRECIO_VENTA2.ToString("N2");
                }
                else if (cb_tipo_precio.Text == "Precio 3")
                {
                    txt_precio.Text = obj.PRECIO_VENTA3.ToString("N2");
                }
            }
            catch
            {

            }
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string condicion = "(A.ID_ARTICULO LIKE'%" + Txt_Buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%' OR B.REFERENCIA LIKE'%" + Txt_Buscar.Text + "%') AND B.ESTADO='A'";
            Listar_Articulos(condicion);
        }

        private void DG_Click(object sender, EventArgs e)
        {
            Recibir_Datos();
            txt_cantidad.Focus();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero(sender,e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal total = 0;
                decimal precio = txt_precio.TextLength ==0 ? 0: Convert.ToDecimal(txt_precio.Text);
                decimal cantidad = txt_cantidad.TextLength == 0 ? 0: Convert.ToDecimal(txt_cantidad.Text);

                total = precio * cantidad;
                txt_total.Text = total.ToString("n2");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_referencia.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("Se Debe Seleccionar el Articulo");
                return;
            }

            if (txt_total.TextLength == 0 || (txt_total.TextLength > 0 && Convert.ToDecimal(txt_total.Text) == 0))
            {
                S_Utilidades.Mensaje_Informacion("Se Debe Seleccionar el Articulo");
                return;
            }

            int id = Convert.ToInt32(txt_id.Text);
            string referencia = txt_referencia.Text;
            string descripcion = txt_descripcion.Text.Trim();
            int cantidad = Convert.ToInt32(txt_cantidad.Text.Trim());
            decimal precio = Convert.ToDecimal(txt_precio.Text);
            decimal total = Convert.ToDecimal(txt_total.Text);
            List<DataGridViewRow> lista_Temporal = new List<DataGridViewRow>();

            Frm_Factura dato = new Frm_Factura();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Frm_Factura")
                {
                    dato = (Frm_Factura)frm;

                    if (dato.dg_detalle_factura.RowCount == 0)
                    {
                        dato.dg_detalle_factura.Rows.Add(id, referencia, descripcion, cantidad, precio, total);
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dato.dg_detalle_factura.Rows)
                        {
                            if (row.Cells[1].Value.ToString() == referencia)
                            {
                                lista_Temporal.Add(row);
                            }
                        }

                        foreach (DataGridViewRow row in lista_Temporal)
                        {
                            dato.dg_detalle_factura.Rows.Remove(row);
                        }
                        dato.dg_detalle_factura.Rows.Add(id, referencia, descripcion, cantidad, precio, total);
                    }
                    double monto = Convert.ToDouble(dato.dg_detalle_factura.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells[5].Value.ToString())));
                    dato.txt_total.Text = monto.ToString("N2");

                    this.Close();
                    break;
                }
            }

        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if(txt_cantidad.TextLength > 0)
            {
                decimal total = 0;
                decimal precio = txt_precio.TextLength == 0 ? 0 : Convert.ToDecimal(txt_precio.Text);
                decimal cantidad = txt_cantidad.TextLength == 0 ? 0 : Convert.ToDecimal(txt_cantidad.Text);

                total = precio * cantidad;
                txt_total.Text = total.ToString("n2");
            }
        }
    }
}
