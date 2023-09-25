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
    public partial class FrmRegistroViajes : Form
    {
        private static Usuarios usuarioActual;
        private static Empleados empActual;
        List<Sucursal> lista = new List<Sucursal>();
        CNSucursal cnSucur = new CNSucursal();
        CNEmpleados cnEmp = new CNEmpleados();
        CNSucursalxEmpleado cnSuxemp = new CNSucursalxEmpleado();
        SucursalxEmpleado SuxEmp = new SucursalxEmpleado
        {
            oEmpleado = new Empleados(),
            oSucursal = new Sucursal()
        };
        List<Transportistas> LisTr = new List<Transportistas>();
        CNTransportista cnTr = new CNTransportista();
        HashSet<Empleados> empleadosAgregados = new HashSet<Empleados>();
        int distanciaKM = 0;    

        public FrmRegistroViajes(Usuarios UsuActivo, Empleados EmpActivo)
        {
            InitializeComponent();
            usuarioActual = UsuActivo;
            empActual = EmpActivo;
        }

        private void FrmRegistroViajes_Load(object sender, EventArgs e)
        {
            LlenarSucursal();
            LlenarTransportista();
            txtRegistrador.Text = empActual.Emp_Nombre+ " "+ empActual.Emp_Apellido;
            txtRegistrador.ReadOnly = true;
            txtDistancia.Text=distanciaKM.ToString();
        }

        private void LlenarSucursal()
        {
            try
            {
                lista = cnSucur.Listar();

                cmbSucursal.DataSource = lista;

                cmbSucursal.ValueMember = "Sucursal_ID";
                cmbSucursal.DisplayMember = "sucursal";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }
        }

        private void LlenarDWV() {
            Empleados empleadoSeleccionado = (Empleados)cmbColaborador.SelectedItem;
            if((empleadoSeleccionado.Emp_Distancia + Convert.ToInt32(txtDistancia.Text)) < 100) {
            if (dgvEmpleado.Columns.Count == 0)
            {
                dgvEmpleado.AutoGenerateColumns = false;
                dgvEmpleado.Columns.Add("Emp_Id", "ID");
                dgvEmpleado.Columns.Add("Emp_NomCompleto", "Empleado");
                dgvEmpleado.Columns.Add("Distancia_KM", "Distancia (KM)");
            }
            if (empleadosAgregados.Contains(empleadoSeleccionado))
            {
                MessageBox.Show("Este empleado ya ha sido agregado al DataGridView.");
            }
            else
            {
                    if (cnEmp.EmpleadoxFechal(empleadoSeleccionado.Emp_ID) == 0) { 
                int rowIndex = dgvEmpleado.Rows.Add();
                dgvEmpleado.Rows[rowIndex].Cells["Emp_Id"].Value = empleadoSeleccionado.Emp_ID;
                dgvEmpleado.Rows[rowIndex].Cells["Emp_NomCompleto"].Value = empleadoSeleccionado.Emp_NomCompleto;
                dgvEmpleado.Rows[rowIndex].Cells["Distancia_KM"].Value = empleadoSeleccionado.Emp_Distancia;

                txtDistancia.Text = Convert.ToString(empleadoSeleccionado.Emp_Distancia + Convert.ToInt32(txtDistancia.Text));

                empleadosAgregados.Add(empleadoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Este empleado ya realizo un viaje el dia de hoy");
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede sobrepasar el limite de 100 KM");
            }


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

        private void LlenarEmpleado()
        {
            try
            {
                Sucursal sucursalSeleccionado = (Sucursal)cmbSucursal.SelectedItem;


                List<Empleados> empleados = cnEmp.BuscarEmpxSucursal(sucursalSeleccionado.Sucursal_ID);
               
                cmbColaborador.DataSource = empleados;
                cmbColaborador.ValueMember = "Emp_ID";
                cmbColaborador.DisplayMember = "Emp_NomCompleto";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleados empleadoSeleccionado = (Empleados)cmbColaborador.SelectedItem;
            txtKM.Text = empleadoSeleccionado.Emp_Distancia.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {  
            dgvEmpleado.Rows.Clear();
            txtKM.Text = "0";
            LlenarEmpleado();
            txtDistancia.Text = "0";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LlenarDWV();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
