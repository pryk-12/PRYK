using Datos;
using System;
using System.Windows.Forms;
using System.Linq;
using Servicios;

namespace JSYS.Formularios
{
    public partial class Frm_Pago_CXP : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Pago_CXP()
        {
            InitializeComponent();
        }

        public void Recibir_Datos(PAGOS_CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_pago = db.PAGOS_CXP.Where(p => p.ID_PAGO == obj.ID_PAGO).Single();

                var obj_cxp = db.CXP.Where(p => p.ID_CXP == obj_pago.ID_CXP).Single();

                Txt_ID.Text = obj_pago.ID_PAGO.ToString();
                txt_id_cxp.Text = obj_pago.ID_CXP.ToString();
                txt_monto_total.Text = obj_cxp.MONTO_TOTAL.ToString("N2");
                txt_monto_pagado.Text = obj_cxp.MONTO_PAGADO.ToString("N2");
                txt_monto_pendiente.Text = obj_cxp.MONTO_PENDIENTE.ToString("N2");
                cb_estado.Text = obj_cxp.ESTADO == "V" ? "Vigente" : "Anulado";
                txt_monto_pagar.Text = obj_pago.MONTO_PAGADO.ToString("N2");
                cb_forma_pago.Text = obj_pago.FORMA_PAGO;                
                cb_estado.Text = "Anulado";
                cb_estado.Enabled = false;
                cb_forma_pago.Enabled = false;
                txt_monto_pagar.Enabled = false;
                txt_observacion.Enabled = true;                
            }
        }

        public void Recibir_Datos_CXP(PAGOS_CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.CXP.Where(p => p.ID_CXP == obj.ID_CXP).Single();

                txt_id_cxp.Text = obj_cxp.ID_CXP.ToString();
                txt_monto_total.Text = obj_cxp.MONTO_TOTAL.ToString("N2");
                txt_monto_pagado.Text = obj_cxp.MONTO_PAGADO.ToString("N2");
                txt_monto_pendiente.Text = obj_cxp.MONTO_PENDIENTE.ToString("N2");
                cb_estado.Text = obj_cxp.ESTADO == "V" ? "Vigente" : "Anulado";
                cb_estado.Text = "Vigente";
                cb_estado.Enabled = false;
            }
        }

        public void Insertar_Pago_CXP()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            PAGOS_CXP obj_cxp = new PAGOS_CXP();
            obj_cxp.ESTADO = cb_estado.Text == "Vigente" ? "V" : "A";
            obj_cxp.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj_cxp.FECHA_CREADO = DateTime.Now;
            obj_cxp.FORMA_PAGO = cb_forma_pago.Text;
            obj_cxp.ID_CXP = Convert.ToInt32(txt_id_cxp.Text);
            obj_cxp.OBSERVACION = txt_observacion.Text.Trim();
            if (cb_estado.Text == "Vigente")
            {
                if(Convert.ToDecimal(txt_monto_pagar.Text)>Convert.ToDecimal(txt_monto_pendiente.Text))
                {
                    obj_cxp.MONTO_PAGADO = Convert.ToDecimal(txt_monto_pendiente.Text);
                    S_Pago_CXP.Insertar_Pago_CXP(obj_cxp);
                }
                else
                {
                    obj_cxp.MONTO_PAGADO = Convert.ToDecimal(txt_monto_pagar.Text);
                    S_Pago_CXP.Insertar_Pago_CXP(obj_cxp);
                }
            }
            else
            {
                obj_cxp.ANULADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj_cxp.FECHA_ANULACION = DateTime.Now.ToString();
                obj_cxp.NOTA_ANULACION = txt_observacion.Text.Trim();
                obj_cxp.ID_PAGO = Convert.ToInt32(Txt_ID.Text);
                S_Pago_CXP.Anular_Pago_CXP(obj_cxp);
            }         
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado es Obligatorio");
                return;
            }

            if (txt_observacion.Text.Equals("") && cb_estado.Text == "Anulado")
            {
                S_Utilidades.Mensaje_Informacion("La Observación Es Obligatoria");
                txt_observacion.Focus();
                return;
            }

            if (cb_estado.Text.Equals("Vigente") && txt_monto_pagar.TextLength==0)
            {
                S_Utilidades.Mensaje_Informacion("El Monto a Pagar es Obligatorio");
                return;
            }

            DialogResult Resultado = MessageBox.Show("Deseas Realiar esta Acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                try
                {
                    Insertar_Pago_CXP();

                    BD_JSYSEntities db = new BD_JSYSEntities();
                    CXP obj = new CXP();
                    obj.ID_CXP = Convert.ToInt32(txt_id_cxp.Text);
                    var obj_cxp = db.CXP.Where(p => p.ID_CXP == obj.ID_CXP).Single();                    

                    if(cb_estado.Text=="Anulado")
                    {                        
                        obj.MONTO_PAGADO = (obj_cxp.MONTO_PAGADO - Convert.ToDecimal(txt_monto_pagar.Text));
                        obj.MONTO_PENDIENTE = (obj_cxp.MONTO_PENDIENTE + Convert.ToDecimal(txt_monto_pagar.Text));
                        S_Pago_CXP.Actualizar_Monto(obj);
                    }
                    else
                    {
                        if(Convert.ToDecimal(txt_monto_pagar.Text)> Convert.ToDecimal(txt_monto_pendiente.Text))
                        {
                            obj.MONTO_PAGADO = Convert.ToDecimal(txt_monto_total.Text);
                            obj.MONTO_PENDIENTE = 0;
                            S_Pago_CXP.Actualizar_Monto(obj);
                        }
                        else
                        {
                            obj.MONTO_PAGADO = (obj_cxp.MONTO_PAGADO + Convert.ToDecimal(txt_monto_pagar.Text));
                            obj.MONTO_PENDIENTE = (obj_cxp.MONTO_PENDIENTE - Convert.ToDecimal(txt_monto_pagar.Text));
                            S_Pago_CXP.Actualizar_Monto(obj);
                        }                     
                    }
                    
                    S_Utilidades.Mensaje_Informacion("Acción Realizada con Exito");
                    Close();
                }
                catch(Exception ex)
                {
                    S_Utilidades.Mensaje_Error(ex.Message);
                }
            }             
        }

        private void txt_monto_pagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender,e,txt_monto_pagar);
        }
    }
}
