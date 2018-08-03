using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_Pagos_CXP : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_Pagos_CXP()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Pago_CXP()
        {
            string Condicion = "(A.ID_PAGO LIKE'%" + Txt_Buscar.Text + "%' OR A.ID_CXP LIKE'%" + Txt_Buscar.Text + "%' OR C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_Pago_CXP.Listar_Pago_CXP(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int vigente = 0;
            int anulado = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[6].Value.ToString() == "Anulado")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    anulado++;
                }
                else 
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    vigente++;
                }
            }
            lbl_anulado.Text = anulado.ToString();
            lbl_vigente.Text = vigente.ToString();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Pago_CXP();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }

            if(DG.SelectedCells[6].Value.ToString()=="Anulado")
            {
                S_Utilidades.Mensaje_Informacion("Este Pago ya Esta Anulado");
                return;
            }

            PAGOS_CXP obj = new PAGOS_CXP();
            obj.ID_PAGO = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Pago_CXP frm = new Frm_Pago_CXP();
            frm.Recibir_Datos(obj);
            frm.Titulo("Anular Pago CXP");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Pago_CXP();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void Frm_Consultar_Pagos_CXP_Load(object sender, EventArgs e)
        {
            Listar_Pago_CXP();
        }

        private void Frm_Consultar_Pagos_CXP_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
