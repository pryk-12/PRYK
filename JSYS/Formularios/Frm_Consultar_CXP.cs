using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Consultar_CXP : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Consultar_CXP()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_CXP()
        {
            string Condicion = "(A.ID_CXP LIKE'%" + Txt_Buscar.Text + "%' OR A.ID_MOVIMIENTO LIKE'%" + Txt_Buscar.Text + "%' OR B.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_CXP.Listar_CXP(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int vigente = 0;
            int anulado = 0;
            int pagado = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[8].Value.ToString() == "Anulado")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    anulado++;
                }
                else if (row.Cells[8].Value.ToString() == "Vigente" && Convert.ToDecimal(row.Cells[7].Value.ToString())>0)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    vigente++;
                }
                else if (row.Cells[8].Value.ToString() == "Vigente" && Convert.ToDecimal(row.Cells[7].Value.ToString()) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    pagado++;
                }
            }
            lbl_anulado.Text = anulado.ToString();
            lbl_pagado.Text = pagado.ToString();
            lbl_vigente.Text = vigente.ToString();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_CXP();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_CXP();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }

            CXP obj = new CXP();
            obj.ID_MOVIMIENTO = Convert.ToInt32(DG.SelectedCells[1].Value);
            Frm_CXP frm = new Frm_CXP();
            frm.Recibir_Datos(obj);
            frm.Titulo("Anular CXP");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            if (DG.RowCount == 0)
            {
                return;
            }

            if (DG.SelectedCells[8].Value.ToString()=="Anulado")
            {
                S_Utilidades.Mensaje_Informacion("Esta CXP ya Fue Anulada");
                return;
            }

            if (Convert.ToDecimal(DG.SelectedCells[7].Value.ToString()) == 0)
            {
                S_Utilidades.Mensaje_Informacion("Esta CXP ya Fue Pagada");
                return;
            }

            PAGOS_CXP obj = new PAGOS_CXP();
            obj.ID_CXP = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Pago_CXP frm = new Frm_Pago_CXP();
            frm.Recibir_Datos_CXP(obj);
            frm.Titulo("Pagar CXP");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void Frm_Consultar_CXP_Load(object sender, EventArgs e)
        {
            Listar_CXP();
        }

        private void Frm_Consultar_CXP_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
