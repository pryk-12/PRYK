using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Servicios;
using Entidades;
using Datos;

namespace JSYS.Formularios
{
    public partial class Frm_Cambiar_Clave : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Cambiar_Clave()
        {
            InitializeComponent();
            Txt_Usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_Clave.Text.Length==0)
            {
                S_Utilidades.Mensaje_Informacion("La Clave es Obligatoria");
                Txt_Clave.Focus();
                return;
            }
            if (Txt_Clave.Text.Trim()!= txt_confirmar_clave.Text.Trim())
            {
                S_Utilidades.Mensaje_Informacion("Las Clave Son Diferentes");
                txt_confirmar_clave.Clear();
                txt_confirmar_clave.Focus();
                return;
            }

            USUARIOS obj = new USUARIOS();
            obj.USUARIO = Txt_Usuario.Text.Trim();
            obj.CLAVE = S_Utilidades.Encriptar_Clave(Txt_Clave.Text.Trim());
            S_Usuario.Actualizar_Clave_Usuario(obj);

            S_Utilidades.Mensaje_Informacion("La Clave Se Actualizo Correctamente");
            Close();
        }
    }
}
