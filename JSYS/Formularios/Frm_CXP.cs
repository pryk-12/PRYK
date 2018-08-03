using Datos;
using Servicios;
using System;
using System.Windows.Forms;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_CXP : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_CXP()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Movimiento._PROVEEDORES>(cb_proveedor, "NOMBRE", "ID_PROVEEDOR", "NOMBRE LIKE'%" + "" + "%'", "PROVEEDORES");
        }

        public void Recibir_Datos(CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.CXP.Where(p => p.ID_MOVIMIENTO == obj.ID_MOVIMIENTO).Single();
                Txt_ID.Text = obj_cxp.ID_MOVIMIENTO.ToString();
                txt_numero_factura.Text = obj_cxp.NUMERO_FACTURA;
                cb_proveedor.SelectedValue = obj_cxp.ID_PROVEEDOR;
                txt_observacion_cxp.Text = obj_cxp.OBSERVACION;
                cb_estado_cxp.Text = obj_cxp.ESTADO == "V" ? "Vigente" : "Anulado";
                txt_monto.Text = obj_cxp.MONTO_TOTAL.ToString("N2");
                txt_pagado.Text = obj_cxp.MONTO_PAGADO.ToString("N2");
                txt_pendiente.Text = obj_cxp.MONTO_PENDIENTE.ToString("N2");

                if (cb_estado_cxp.Text == "Anulado" || obj_cxp.MONTO_PENDIENTE==0)
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Anular_CXP()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            CXP obj_cxp = new CXP();
            obj_cxp.ESTADO = cb_estado_cxp.Text == "Vigente" ? "V" : "A";
            obj_cxp.ANULADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj_cxp.FECHA_ANULACION = DateTime.Now.ToString();
            obj_cxp.NOTA_ANULACION = txt_observacion_cxp.Text.Trim();
            obj_cxp.ID_MOVIMIENTO = Convert.ToInt32(Txt_ID.Text);
            S_CXP.Actualizar_CXP(obj_cxp);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(cb_estado_cxp.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado es Obligatorio");
                return;
            }
             BD_JSYSEntities db = new BD_JSYSEntities();
             int id_articulo = Convert.ToInt32(Txt_ID.Text);
            var cxp = db.CXP.Where(p => p.ID_MOVIMIENTO == id_articulo).ToList();

            if (cb_estado_cxp.Text.Equals("Anulado") && cxp[0].MONTO_PAGADO > 0)
            {
                S_Utilidades.Mensaje_Informacion("Esta CxP Tiene Pagos Registrados no Puede Ser Anulada");
                return;
            }
            else if (cb_estado_cxp.Text.Equals("Anulado") && cxp[0].MONTO_PAGADO == 0)
            {
                if(txt_observacion_cxp.Text.Equals(""))
                {
                    S_Utilidades.Mensaje_Informacion("La Observación Es Obligatoria");
                    txt_observacion_cxp.Focus();
                    return;
                }

                DialogResult Resultado = MessageBox.Show("Deseas Anular Esta CXP?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == DialogResult.Yes)
                {
                    try
                    {
                        Anular_CXP();
                        S_Utilidades.Mensaje_Informacion("Anulación Realizada con Exito");
                        Close();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
