
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

namespace ProyectoViajes
{
    public partial class FrmInicio : Form
    {
        private static Usuarios usuarioActual;
        private static Empleados EmpleadoActual = new Empleados();
        CNEmpleados cEmp = new CNEmpleados();
        
       
       
        public FrmInicio(Usuarios UsuActivo)
        {
            InitializeComponent();
            usuarioActual = UsuActivo;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void MenuReporta_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
            try
            {
                EmpleadoActual = cEmp.BuscarEmpleado(usuarioActual.Emp_ID);
                lblNombre.Text = EmpleadoActual.Emp_Nombre + " " + EmpleadoActual.Emp_Apellido;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }

           


        }
    }
}
