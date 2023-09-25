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
using System.Windows.Documents;

namespace ProyectoViajes
{
    public partial class FrmAdminSucursal : Form

    {
        CNEmpleados cEmp = new CNEmpleados();
        CNSucursal cSucur = new CNSucursal();
        List<Empleados> lista = new List<Empleados>();
  
        CNSucursalxEmpleado cnsuxemp = new CNSucursalxEmpleado();
        SucursalxEmpleado SuxEmp = new SucursalxEmpleado
        {
           oEmpleado = new Empleados(), 
          oSucursal = new Sucursal()  
          };

   
        public FrmAdminSucursal()
        {
            InitializeComponent();
            cmbColaborador.SelectedItem=null;
            cmbSucursal.SelectedItem = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdminSucursal_Load(object sender, EventArgs e)
        {

            LlenarEmpleado();
        }

        private void LlenarEmpleado()
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


            private void LlenarSucursal()
        {
            try { 
            Empleados empleadoSeleccionado = (Empleados)cmbColaborador.SelectedItem;

           
            List<Sucursal> sucursales = cSucur.BuscarSucursalNoVinc(empleadoSeleccionado.Emp_ID);
            cmbSucursal.DataSource = sucursales;
            cmbSucursal.ValueMember = "Sucursal_ID"; 
            cmbSucursal.DisplayMember = "sucursal";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }
        }

        private void LlenarDWV()
        {
            Empleados empleadoSeleccionado = (Empleados)cmbColaborador.SelectedItem;
            List<SucursalxEmpleado> sucuxemp = cnsuxemp.BuscarSucursalxEmp(empleadoSeleccionado.Emp_ID);

            // Configura el DataGridView si no está configurado previamente
            if (dgvSucursal.Columns.Count == 0)
            {
                dgvSucursal.AutoGenerateColumns = false;
                dgvSucursal.Columns.Add("Empleado", "Empleado");
                dgvSucursal.Columns.Add("Sucursal", "Sucursal");
                dgvSucursal.Columns.Add("Distancia_KM", "Distancia (KM)");
            }

            // Limpia las filas existentes
            dgvSucursal.Rows.Clear();

            foreach (var sucursalxmpleado in sucuxemp)
            {
                int rowIndex = dgvSucursal.Rows.Add();
                dgvSucursal.Rows[rowIndex].Cells["Empleado"].Value = sucursalxmpleado.oEmpleado.Emp_ID;
                dgvSucursal.Rows[rowIndex].Cells["Sucursal"].Value = sucursalxmpleado.oSucursal.sucursal;
                dgvSucursal.Rows[rowIndex].Cells["Distancia_KM"].Value = sucursalxmpleado.Distancia_KM;
            }



        }

            private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarSucursal();
            LlenarDWV();

        }


        private void obtenerValores()

        {
           
            SuxEmp.oEmpleado.Emp_ID = Convert.ToInt32(cmbColaborador.SelectedValue);
            SuxEmp.oSucursal.Sucursal_ID = Convert.ToInt32(cmbSucursal.SelectedValue); 
            SuxEmp.Distancia_KM = Convert.ToInt32(txtDistancia.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                if((Convert.ToInt32(cmbColaborador.SelectedValue) > 0) && (Convert.ToInt32(cmbSucursal.SelectedValue) > 0) && (Convert.ToInt32(txtDistancia.Text)<=50) && (Convert.ToInt32(txtDistancia.Text) > 0))
                {
                    obtenerValores();
                    string mensaje =cnsuxemp.AgregarSucursalxEmp(SuxEmp);
                    MessageBox.Show(mensaje);
                    LlenarEmpleado();
                    txtDistancia.Text = "";
                }
                else if(Convert.ToInt32(txtDistancia.Text) >= 50)
                {
                    MessageBox.Show("La distancia maxima permitida es de 50km");
                }
                else if (Convert.ToInt32(txtDistancia.Text) <= 0)
                {
                    MessageBox.Show("La distancia minima permitida es de 1km");
                }
                else
                {
                    MessageBox.Show("Asegurese de llenar todos los campos");
                }
            }
            catch { 
            }
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                
                e.Handled = true;
            }
        }
    }
}
