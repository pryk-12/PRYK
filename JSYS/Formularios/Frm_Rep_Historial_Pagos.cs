
using DevExpress.XtraReports.UI;
using Servicios;
using System.Collections.Generic;
using Datos;
using System.Linq;
using System.Data;
using System;
namespace JSYS.Formularios
{
    public partial class Frm_Rep_Historial_Pagos : JSYS.Formularios.Frm_Plantilla
    {
        public class _ID
        {
            public int id_factura { get; set; }
        }

        BD_JSYSEntities db = new BD_JSYSEntities();

        public Frm_Rep_Historial_Pagos()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<JSYS.Formularios.Frm_Factura._CLIENTE>(cb_cliente, "NOMBRE", "ID_CLIENTE", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
        }


        void Llenar_ComboBox_facturas(int id)
        {
            List<_ID> Lista = new List<_ID>();
            var numero_factura = (from e in db.FACTURAS
                                  where e.ID_CLIENTE == id && e.MONTO_PAGADO > 0
                                  select new _ID()
                                  {
                                      id_factura = e.ID_FACTURA,
                                  }).Distinct().ToList();

            Lista.AddRange(new _ID[] { new _ID { id_factura = 0 } });
            foreach (_ID emp in numero_factura)
            {
                Lista.Add(emp);
            }
            cb_facturas.DataSource = Lista;
            cb_facturas.DisplayMember = "id_factura";
        }

        void Llenar_ComboBox_contratos(int id)
        {
            List<_ID> Lista = new List<_ID>();
            var numero_factura = (from e in db.FACTURAS
                                  where e.ID_CLIENTE == id && e.MONTO_PAGADO > 0
                                  select new _ID()
                                  {
                                      id_factura = e.NUMERO_CONTRATO,
                                  }).Distinct().ToList();

            Lista.AddRange(new _ID[] { new _ID { id_factura = 0 } });
            foreach (_ID emp in numero_factura)
            {
                Lista.Add(emp);
            }
            cb_contratos.DataSource = Lista;
            cb_contratos.DisplayMember = "id_factura";
        }

        private void cb_facturas_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btn_reporte_Click(object sender, System.EventArgs e)
        {
            if(cb_cliente.Text =="")
            {
                S_Utilidades.Mensaje_Informacion("Se debe Seleccionar el Cliente");
                return;
            }

            string condicion = "";
            if(cb_facturas.Text =="" && cb_contratos.Text =="")
            {
                condicion = @"([NOMBRE] = '" + cb_cliente.Text + "')";
            }
            else if (cb_facturas.Text != "" && cb_contratos.Text == "")
            {
                condicion = @"([NOMBRE] = '" + cb_cliente.Text + "' AND [ID_FACTURA] = " + cb_facturas.Text + ")";
            }
            else if (cb_facturas.Text == "" && cb_contratos.Text != "")
            {
                condicion = @"([NOMBRE] = '" + cb_cliente.Text + "' AND [NUMERO_CONTRATO] = " + cb_contratos.Text + ")";
            }
            else if (cb_facturas.Text != "" && cb_contratos.Text != "")
            {
                condicion = @"([NOMBRE] = '" + cb_cliente.Text + "' AND [ID_FACTURA] = " + cb_facturas.Text + " AND [NUMERO_CONTRATO] = " + cb_contratos.Text + ")";
            }


            Reportes.Rep_Pagos_Cliente report = new Reportes.Rep_Pagos_Cliente();
            report.FilterString = condicion;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void cb_cliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
            try
            {
                int id = Convert.ToInt32(cb_cliente.SelectedValue);
                Llenar_ComboBox_facturas(id);
                Llenar_ComboBox_contratos(id);
            }
            catch
            {

            }
        }
    }
}
