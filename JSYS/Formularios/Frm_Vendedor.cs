using Datos;
using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Vendedor : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Vendedor()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<TIPOS_IDENTIFICACIONES>(cb_tipo_identificacion, "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'", "TIPOS_IDENTIFICACIONES");
        }

        public void Recibir_Datos(VENDEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_vendedor = db.VENDEDORES.Find(obj.ID_VENDEDOR);
                Txt_ID.Text = obj_vendedor.ID_VENDEDOR.ToString();
                txt_nombre.Text = obj_vendedor.NOMBRE;
                txt_numero_identificacion.Text = obj_vendedor.NUMERO_IDENTIFICACION;
                cb_estado.Text = obj_vendedor.ESTADO == "A" ? "Activo" : "Inactivo";
                cb_sexo.Text = obj_vendedor.SEXO == "M" ? "Masculino" : "Femenino";
                cb_tipo_identificacion.SelectedValue = obj_vendedor.ID_TIPO_IDENTIFICACION;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            VENDEDORES obj = new VENDEDORES();
            obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
            obj.FECHA_CREADO = DateTime.Now;
            obj.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
            obj.NUMERO_IDENTIFICACION = txt_numero_identificacion.Text.Trim();
            obj.NOMBRE = txt_nombre.Text.Trim();
            obj.SEXO = cb_sexo.Text == "Masculino" ? "M" : "F"; ;
            try
            {
                if (Txt_ID.Text.Equals(""))
                {
                    S_Vendedor.Insertar_Vendedor(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.ID_VENDEDOR = Convert.ToInt32(Txt_ID.Text);
                    S_Vendedor.Actualizar_Vendedor(obj);
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

            Insertar();
        }
    }
}
