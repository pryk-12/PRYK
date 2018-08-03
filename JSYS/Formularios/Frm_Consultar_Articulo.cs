using Servicios;
using System;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Articulo : JSYS.Formularios.Frm_Plantilla
    {

        public Frm_Consultar_Articulo()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Articulos()
        {
            string Condicion = "(ID_ARTICULO LIKE'%" + Txt_Buscar.Text + "%' OR DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%' OR REFERENCIA LIKE'%" + Txt_Buscar.Text + "%') AND ESTADO='A'";
            DG.DataSource = S_Articulo.Listar_Articulos(Condicion);
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            if(DG.Rows.Count > 0)
            {
                S_Utilidades.Datos_Entidades.REFERENCIA = DG.SelectedCells[1].Value.ToString();
                Close();
            }
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Articulos();
        }

        private void Frm_Consultar_Articulo_Load(object sender, EventArgs e)
        {
            Listar_Articulos();
        }



    }
}
