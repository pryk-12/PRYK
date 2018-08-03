using Datos;
using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Cobrador : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Cobrador()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<TIPOS_IDENTIFICACIONES>(cb_tipo_identificacion, "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'", "TIPOS_IDENTIFICACIONES");
        }

        public void Recibir_Datos(COBRADORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cobrador = db.COBRADORES.Find(obj.ID_COBRADOR);
                Txt_ID.Text = obj_cobrador.ID_COBRADOR.ToString();
                txt_nombre.Text = obj_cobrador.NOMBRE;
                txt_numero_identificacion.Text = obj_cobrador.NUMERO_IDENTIFICACION;
                cb_estado.Text = obj_cobrador.ESTADO == "A" ? "Activo" : "Inactivo";
                cb_sexo.Text = obj_cobrador.SEXO == "M" ? "Masculino" : "Femenino";
                cb_tipo_identificacion.SelectedValue = obj_cobrador.ID_TIPO_IDENTIFICACION;
                cb_ruta.Text = obj_cobrador.RUTA;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            COBRADORES obj = new COBRADORES();
            obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
            obj.FECHA_CREADO = DateTime.Now;
            obj.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
            obj.NUMERO_IDENTIFICACION = txt_numero_identificacion.Text.Trim();
            obj.NOMBRE = txt_nombre.Text.Trim();
            obj.SEXO = cb_sexo.Text == "Masculino" ? "M" : "F"; ;
            obj.RUTA = cb_ruta.Text;
            try
            {
                if (Txt_ID.Text.Equals(""))
                {
                    S_Cobrador.Insertar_Cobrador(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.ID_COBRADOR = Convert.ToInt32(Txt_ID.Text);
                    S_Cobrador.Actualizar_Cobrador(obj);
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
           
            if (txt_nombre.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Nombre Es Obligatorio");
                txt_nombre.Focus();
                return;
            }

            if (cb_tipo_identificacion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Tipo de Identificación Es Obligatorio");
                cb_tipo_identificacion.Focus();
                return;
            }

            if (Convert.ToInt32(cb_tipo_identificacion.SelectedValue) != 5 && txt_numero_identificacion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Número de Identificación es Obligatorio");
                txt_numero_identificacion.Focus();
                return;
            }

            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
                return;
            }

            if (cb_sexo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Sexo Es Obligatorio");
                cb_sexo.Focus();
                return;
            }
            if (cb_ruta.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Ruta Es Obligatoria");
                cb_ruta.Focus();
                return;
            }
          
            Insertar();
        }
    }
}
