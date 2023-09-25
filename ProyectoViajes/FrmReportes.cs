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
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            LlenarTransportista();

        }


        private void LlenarTransportista()
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
    }
}
