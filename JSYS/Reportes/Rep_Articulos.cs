using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Servicios;

namespace JSYS.Formularios
{
    public partial class Rep_Articulos : DevExpress.XtraReports.UI.XtraReport
    {
        public Rep_Articulos()
        {
            InitializeComponent();
            lbl_usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
        }

    }
}
