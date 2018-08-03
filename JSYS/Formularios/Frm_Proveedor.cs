using Datos;
using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Proveedor : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Proveedor()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<TIPOS_IDENTIFICACIONES>(cb_tipo_identificacion, "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'", "TIPOS_IDENTIFICACIONES");
        }

        public void Recibir_Datos(PROVEEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_proveedor = db.PROVEEDORES.Find(obj.ID_PROVEEDOR);
                Txt_ID.Text = obj_proveedor.ID_PROVEEDOR.ToString();
                txt_nombre.Text = obj_proveedor.NOMBRE;
                txt_celular.Text = obj_proveedor.CELULAR;
                txt_direccion.Text = obj_proveedor.DIRECCION;
                txt_email.Text = obj_proveedor.EMAIL;
                txt_numero_identificacion.Text = obj_proveedor.NUMERO_IDENTIFICACION;
                txt_telefono.Text = obj_proveedor.TELEFONO;
                cb_estado.Text = obj_proveedor.ESTADO == "A" ? "Activo" : "Inactivo";
                cb_tipo_identificacion.SelectedValue = obj_proveedor.ID_TIPO_IDENTIFICACION;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar()
        {
            string Mensaje = "";
            PROVEEDORES obj = new PROVEEDORES();
          
            obj.CELULAR = txt_celular.Text == "   -   -" ? "" : txt_celular.Text.Trim();
            obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj.DIRECCION = txt_direccion.Text.Trim();
            obj.EMAIL = txt_email.Text.Trim();
            obj.ESTADO = cb_estado.Text == "Activo" ? "A" : "I";
            obj.FECHA_CREADO = DateTime.Now;
            obj.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
            obj.NOMBRE = txt_nombre.Text.Trim();        
            obj.NUMERO_IDENTIFICACION = txt_numero_identificacion.Text.Trim();          
            obj.TELEFONO = txt_telefono.Text == "   -   -" ? "" : txt_telefono.Text.Trim();
      
            try
            {
                if (Txt_ID.Text.Equals(""))
                {
                    S_Proveedor.Insertar_Proveedor(obj);
                    Mensaje = "Datos Insertados con Exito";
                }
                else
                {
                    obj.ID_PROVEEDOR = Convert.ToInt32(Txt_ID.Text);
                    S_Proveedor.Actualizar_Proveedor(obj);
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

            if (txt_direccion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Dirección Es Obligatoria");
                txt_direccion.Focus();
                return;
            }

            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
                return;
            }

            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Teléfono Esta Incompleto");
                    txt_telefono.Focus();
                    return;
                }
            }

            if (!txt_celular.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    S_Utilidades.Mensaje_Informacion("El Número de Celular Esta Incompleto");
                    txt_celular.Focus();
                    return;
                }
            }

            if (!txt_email.Text.Trim().Equals(""))
            {
                if (!S_Utilidades.Validar_Formato_Correo(txt_email.Text))
                {
                    S_Utilidades.Mensaje_Informacion("El Formato del E-Mail es Incorrecto");
                    txt_email.Focus();
                    return;
                }
            }

            Insertar();
        }
    }
}
