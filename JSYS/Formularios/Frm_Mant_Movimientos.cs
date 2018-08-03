using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Movimientos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Movimientos()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            Listar_Movimientos();
        }

        public void Listar_Movimientos()
        {
            try
            {
            if(cb_buscar.Text =="ID MOVIMIENTO")
            {
                string Condicion = "(A.ID_MOVIMIENTO =" + Txt_Buscar.Text + ")";
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            }
            if(cb_buscar.Text =="MOTIVO" || cb_buscar.Text =="")
            {
                string Condicion = "(B.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%')";
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            }
            if(cb_buscar.Text =="TIPO MOVIMIENTO")
            {
                string Condicion = "(B.TIPO_MOVIMIENTO LIKE'%" + Txt_Buscar.Text + "%')";
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            }
            if(cb_buscar.Text =="REFERENCIA")
            {
                string Condicion = "(C.REFERENCIA LIKE'%" + Txt_Buscar.Text + "%')";
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            }
            if (cb_buscar.Text == "ARTICULO")
            {
                string Condicion = "(C.DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%')";
                DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            }
            Cambiar_Color_Filas();
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            }
            catch
            {
            }
        }

        public void Cambiar_Color_Filas()
        {
            int vigente = 0;
            int anulado = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[7].Value.ToString() == "Anulado")
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
            Listar_Movimientos();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            MOVIMIENTOS obj = new MOVIMIENTOS();
            obj.ID_MOVIMIENTO = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Movimiento frm = new Frm_Movimiento();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Movimiento");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Movimiento frm = new Frm_Movimiento();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Movimiento");
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Listar_Movimientos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            string Condicion = "(CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) >= '" + desde.Date.ToString("yyyy-MM-dd") + "' and CONVERT(smalldatetime, CONVERT(char(10), A.FECHA_CREADO, 103), 103) <= '" + hasta.Date.ToString("yyyy-MM-dd") + "')";
            DG.DataSource = S_Movimiento.Listar_Movimientos(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        private void Frm_Mant_Movimientos_Load(object sender, EventArgs e)
        {
           
        }

        private void Frm_Mant_Movimientos_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }


    }
}
