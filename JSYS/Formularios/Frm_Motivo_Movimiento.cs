using Datos;
using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Motivo_Movimiento : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Motivo_Movimiento()
        {
            InitializeComponent();
        }

        public void Recibir_Datos(MOTIVOS_MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_motivo = db.MOTIVOS_MOVIMIENTOS.Find(obj.ID_MOTIVO);
                Txt_ID.Text = obj_motivo.ID_MOTIVO.ToString();
                txt_descripcion.Text = obj_motivo.DESCRIPCION;
                txt_observacion.Text = obj_motivo.OBSERVACION;
                cb_estado.Text = obj_motivo.ESTADO == "A" ? "Activo" : "Inactivo";
                cb_tipo_movimiento.Text = obj_motivo.TIPO_MOVIMIENTO;

                if (obj_motivo.ID_MOTIVO==3)
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                }
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            MOTIVOS_MOVIMIENTOS obj = new MOTIVOS_MOVIMIENTOS();
            obj.DESCRIPCION = txt_descripcion.Text.Trim();
            obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
            obj.OBSERVACION = txt_observacion.Text.Trim();
            obj.TIPO_MOVIMIENTO = cb_tipo_movimiento.Text;
            try
            {
                if (Txt_ID.Text.Equals(""))
                {
                    S_Motivo_Movimiento.Insertar_Motivo_Movimiento(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.ID_MOTIVO = Convert.ToInt32(Txt_ID.Text);
                    S_Motivo_Movimiento.Actualizar_Motivo_Movimiento(obj);
                    Mensaje = "Datos Actualizados con Exito";
                }
                S_Utilidades.Mensaje_Informacion(Mensaje);
                Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Descripción Es Obligatoria");
                txt_descripcion.Focus();
                return;
            }

            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
                return;
            }

            if (cb_tipo_movimiento.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Tipo de Movimiento Es Obligatorio");
                cb_tipo_movimiento.Focus();
                return;
            }

            Insertar();
        }
    }
}
