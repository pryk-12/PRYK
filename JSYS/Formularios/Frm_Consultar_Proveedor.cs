using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Proveedor : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Proveedor()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Proveedores()
        {
            string Condicion = "(C.ID_PROVEEDOR LIKE'%" + Txt_Buscar.Text + "%' OR C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%') AND C.ESTADO='A'";
            DG.DataSource = S_Proveedor.Listar_Proveedores(Condicion);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Proveedores();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            if (DG.Rows.Count > 0)
            {
                S_Utilidades.Datos_Entidades.ID_PROVEEDOR = Convert.ToInt32(DG.SelectedCells[0].Value.ToString());
                Close();
            }
        }

        private void Frm_Consultar_Proveedor_Load(object sender, EventArgs e)
        {
            Listar_Proveedores();
        }
    }
}
