using DevExpress.XtraReports.UI;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Rep_Articulos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Rep_Articulos()
        {
            InitializeComponent();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Rep_Articulos report = new Rep_Articulos();
            report.FilterString = "([REFERENCIA] LIKE'%" + txt_referencia.Text + "%' AND [DESCRIPCION] LIKE'%" + txt_descripcion.Text + "%' AND [ESTADO] LIKE'%" + cb_estado.Text + "%')";
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
