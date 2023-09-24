using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocios;
using CEntidades;
using FontAwesome.Sharp;

namespace ProyectoViajes
{
    public partial class FrmAdminSucursal : Form

    {
        CNEmpleados cEmp = new CNEmpleados();
        List<Empleados> lista = new List<Empleados>();
        public FrmAdminSucursal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdminSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                lista = cEmp.Listar();

                cmbColaborador.DataSource = lista;
       
                cmbColaborador.ValueMember = "Emp_ID";
                cmbColaborador.DisplayMember = "Emp_NomCompleto";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
