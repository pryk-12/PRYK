using Servicios;
using System;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Movimientos_Anulados : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Movimientos_Anulados()
        {
            InitializeComponent();
            DG.AutoGenerateColumns =false;
        }

        public void Listar_Movimientos()
        {
            try
            {
                string Condicion = "";

                if (cb_buscar.Text == "No.")
                {
                    Condicion = "(A.ID_MOVIMIENTO =" + Txt_Buscar.Text + ")";
                }
                if (cb_buscar.Text == "Motivo" || cb_buscar.Text == "")
                {
                    Condicion = "(B.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Tipo Movimiento")
                {
                    Condicion = "(B.TIPO_MOVIMIENTO LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Referencia Articulo")
                {
                    Condicion = "(C.REFERENCIA LIKE'%" + Txt_Buscar.Text + "%')";
                }
                if (cb_buscar.Text == "Descripción Articulo")
                {
                    Condicion = "(C.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%')";
                }
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion + " AND A.ESTADO='A' ORDER BY A.ID_MOVIMIENTO DESC");
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar_Movimientos();
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DG.RowCount==0)
            {
                return;
            }
            txt_observacion.Text = DG.SelectedCells[9].Value.ToString();
        }
    }
}
