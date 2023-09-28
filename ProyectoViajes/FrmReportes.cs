using CEntidades;
using CNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoViajes
{
    public partial class FrmReportes : Form
    {
        List<Transportistas> LisTr = new List<Transportistas>();
        CNTransportista cnTr = new CNTransportista();
        CNReporte cnreport = new CNReporte();
        decimal montoTotal = 0;
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            LlenarTransportista();

        }

        private void LlenarDWV() //llena el data grid view con los datos filtrados 
        {
            Transportistas transportistaSeleccionado = (Transportistas)cmbTransportista.SelectedItem;
            List<Reporte> listReporte = cnreport.ConsultaReporte(dtpFecha1.Value, dtpFecha2.Value, transportistaSeleccionado.Trp_ID);
            montoTotal = 0;
            // Configura el DataGridView si no está configurado previamente
            if (dtpFecha1.Value <= dtpFecha2.Value)
            {
                if (dgvPago.Columns.Count == 0)
                {
                    dgvPago.AutoGenerateColumns = false;
                    dgvPago.Columns.Add("Viaje_ID", "ID");
                    dgvPago.Columns.Add("NombreCompleto", "Empleado");
                    dgvPago.Columns.Add("NombreSucursal", "Sucursal");
                    dgvPago.Columns.Add("Fecha", "Fecha");
                    dgvPago.Columns.Add("ViajeTotal", "Distancia Total");
                    dgvPago.Columns.Add("TotalCalculado", "Total Viaje");
                }

                // Limpia las filas existentes
                dgvPago.Rows.Clear();

                foreach (var reporte in listReporte)
                {
                    int rowIndex = dgvPago.Rows.Add();
                    dgvPago.Rows[rowIndex].Cells["Viaje_ID"].Value = reporte.Viaje_ID;
                    dgvPago.Rows[rowIndex].Cells["NombreCompleto"].Value = reporte.NombreCompleto;
                    dgvPago.Rows[rowIndex].Cells["NombreSucursal"].Value = reporte.NombreSucursal;
                    dgvPago.Rows[rowIndex].Cells["Fecha"].Value = reporte.Fecha;
                    dgvPago.Rows[rowIndex].Cells["ViajeTotal"].Value = reporte.ViajeTotal;
                    dgvPago.Rows[rowIndex].Cells["TotalCalculado"].Value = reporte.TotalCalculado;
                    montoTotal += reporte.TotalCalculado;

                }

                txtmonto.Text = montoTotal.ToString();
            }
            else {
                MessageBox.Show("La fecha de inicio debe ser menor que la fecha final");
            }

        }
        private void LlenarTransportista() //llena cmb de transportista
        {
            try
            {
                LisTr = cnTr.Listar();

                cmbTransportista.DataSource = LisTr;

                cmbTransportista.ValueMember = "Trp_ID";
                cmbTransportista.DisplayMember = "Trp_NombreCompleto";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LlenarDWV();
        }
    }
}
