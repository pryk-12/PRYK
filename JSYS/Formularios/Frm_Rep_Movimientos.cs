using DevExpress.XtraReports.UI;
using Servicios;
using System;

namespace JSYS.Formularios
{
    
    public partial class Frm_Rep_Movimientos : JSYS.Formularios.Frm_Plantilla
    {
        public class _MOTIVOS_MOVIMIENTOS_
        {
            public int ID_MOTIVO { get; set; }
            public string DESCRIPCION { get; set; }
        }

        public class _USUARIO_
        {
            public int ID_USUARIO { get; set; }
            public string USUARIO { get; set; }
        }

        public Frm_Rep_Movimientos()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<_MOTIVOS_MOVIMIENTOS_>(cb_motivo, "DESCRIPCION", "ID_MOTIVO", "DESCRIPCION LIKE'%" + "" + "%'", "MOTIVOS_MOVIMIENTOS");
            S_Utilidades.Llenar_ComboBox<_USUARIO_>(cb_creado_por, "USUARIO", "ID_USUARIO", "USUARIO LIKE'%" + "" + "%'", "USUARIOS");
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            string condicion = "";

            if (ch_incluir_fechas.Checked == true)
            {
                condicion = @"([MOTIVO] = '" + cb_motivo.Text + "' OR '' = '" + cb_motivo.Text + @"')
                          and ([TIPO_MOVIMIENTO] = '" + cb_tipo.Text + "' OR '' = '" + cb_tipo.Text + @"')
                          and ([REFERENCIA] = '" + txt_referencia.Text + "' OR '' = '" + txt_referencia.Text + @"')
                          and ([CREADO_POR] = '" + cb_creado_por.Text + "' OR '' = '" + cb_creado_por.Text + @"')
                          and ([FECHA_CREADO] Between('" + dt_desde.Value.Date + "', '" + dt_hasta.Value.Date + "'))";
            }
            else
            {
                condicion = @"([MOTIVO] = '" + cb_motivo.Text + "' OR '' = '" + cb_motivo.Text + @"')
                          and ([TIPO_MOVIMIENTO] = '" + cb_tipo.Text + "' OR '' = '" + cb_tipo.Text + @"')
                          and ([REFERENCIA] = '" + txt_referencia.Text + "' OR '' = '" + txt_referencia.Text + @"')
                          and ([CREADO_POR] = '" + cb_creado_por.Text + "' OR '' = '" + cb_creado_por.Text + @"')";
            }

            Reportes.Rep_Movimientos report = new Reportes.Rep_Movimientos();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
