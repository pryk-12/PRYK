using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Servicios;

namespace JSYS.Reportes
{
    public partial class Rep_Movimientos : DevExpress.XtraReports.UI.XtraReport
    {
        int entrada = 0;
        public Rep_Movimientos()
        {
            InitializeComponent();
            lbl_usuario.Text = S_Utilidades.Datos_Usuario.USUARIO;
           
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrLabel7_SummaryReset(object sender, EventArgs e)
        {
            entrada = 0;
        }

        private void xrLabel7_SummaryRowChanged(object sender, EventArgs e)
        {
            if(GetCurrentColumnValue("TIPO_MOVIMIENTO").ToString()=="Entrada")
            {
                entrada += Convert.ToInt32(GetCurrentColumnValue("CANTIDAD"));
            }
           
        }

        private void xrLabel7_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = entrada;
        }

        private void xrLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (GetCurrentColumnValue("TIPO_MOVIMIENTO").ToString() == "Entrada")
            //{
            //    entrada += Convert.ToInt32(GetCurrentColumnValue("CANTIDAD"));
            //}

            //xrLabel7.Text = GetCurrentColumnValue("TIPO_MOVIMIENTO").ToString();
           

        }

        private void xrLabel7_AfterPrint(object sender, EventArgs e)
        {
           
        }

        private void Rep_Movimientos_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
            
        }
    }
}
