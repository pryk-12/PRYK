using Datos;
using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Entregar_Articulos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Entregar_Articulos()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            dg_detalle_factura.AutoGenerateColumns = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listar_Facturas();
        }

        public void Listar_Facturas()
        {
            string Condicion = "";
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            try
            {
                if (cb_buscar.Text == "Cobrador")
                {
                    Condicion = "(A.ID_COBRADOR=" + cb_cobrador.SelectedValue + " AND A.ID_ESTADO=1 AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                if (cb_buscar.Text == "Cliente")
                {
                    Condicion = "(A.ID_CLIENTE=" + cb_cobrador.SelectedValue + " AND A.ID_ESTADO=1 AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                if (cb_buscar.Text == "Numero Factura")
                {
                    Condicion = "(A.ID_FACTURA=" + txt_buscar.Text + " AND A.ID_ESTADO=1 AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }
                if (cb_buscar.Text == "Numero Contrato")
                {
                    Condicion = "(A.NUMERO_CONTRATO=" + txt_buscar.Text + " AND A.ID_ESTADO=1 AND (CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "'))";
                }

                DG.DataSource = S_Factura.Listar_Facturas(Condicion);
            }
            catch
            {

            }
        }



        private void cb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_buscar.Text == "Cobrador" || cb_buscar.Text == "Cliente")
                {
                    txt_buscar.Visible = false;
                    cb_cobrador.Visible = true;
                }
                else
                {
                    txt_buscar.Visible = true;
                    cb_cobrador.Visible = false;
                }

                if(cb_buscar.Text =="Cobrador")
                {
                    S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Factura._COBRADOR>(cb_cobrador, "NOMBRE", "ID_COBRADOR", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "COBRADORES");
                }
                else if(cb_buscar.Text =="Cliente")
                {
                    S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Factura._CLIENTE>(cb_cobrador, "NOMBRE", "ID_CLIENTE", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
                }
            }
            catch
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dg_detalle_factura.DataSource = null;
            Listar_Facturas();
        }

        private void DG_Click(object sender, EventArgs e)
        {
            dg_detalle_factura.DataSource = S_Factura.Listar_Detalles_Facturas("A.ID_FACTURA=" + DG.SelectedCells[0].Value + "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Condicion = "";
            try
            {
                if (cb_buscar.Text == "Cobrador")
                {
                    Condicion = "(A.ID_COBRADOR=" + cb_cobrador.SelectedValue + " AND A.ID_ESTADO=1)";
                }
                if (cb_buscar.Text == "Cliente")
                {
                    Condicion = "(A.ID_CLIENTE=" + cb_cobrador.SelectedValue + " AND A.ID_ESTADO=1)";
                }
                if (cb_buscar.Text == "Numero Factura")
                {
                    Condicion = "(A.ID_FACTURA=" + txt_buscar.Text + " AND A.ID_ESTADO=1)";
                }
                if (cb_buscar.Text == "Numero Contrato")
                {
                    Condicion = "(A.NUMERO_CONTRATO=" + txt_buscar.Text + " AND A.ID_ESTADO=1)";
                }
                dg_detalle_factura.DataSource = null;
                txt_observacion.Text = "";
                DG.DataSource = S_Factura.Listar_Facturas(Condicion);
            }
            catch
            {

            }
        }

        private void btn_entregar_Click(object sender, EventArgs e)
        {
            if(DG.Rows.Count==0)
            {
                S_Utilidades.Mensaje_Informacion("Se Debe Seleccionar Una Factura");
                return;
            }
            if (txt_observacion.Text.Trim() =="")
            {
                S_Utilidades.Mensaje_Informacion("La Observación es Obligatoria");
                txt_observacion.Focus();
                return;
            }
            try
            {
                FACTURAS obj_factura = new FACTURAS();
                int id_factura = Convert.ToInt32(DG.SelectedCells[0].Value);
                obj_factura.ID_FACTURA = id_factura;
                obj_factura.CAMBIO_ESTADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj_factura.FECHA_CAMBIO_ESTADO = DateTime.Now.ToString();
                obj_factura.NOTA_CAMBIO_ESTADO = txt_observacion.Text.Trim();
                obj_factura.ID_ESTADO = 5;
                S_Factura.Cambiar_Estado_Factura(obj_factura);

                S_Utilidades.Mensaje_Informacion("Información Generada Correctamente");
                button1.PerformClick();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }

        }
    }
}
