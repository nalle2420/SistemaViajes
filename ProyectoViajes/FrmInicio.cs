
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
    public partial class FrmInicio : Form
    {
        private static Usuarios usuarioActual;
        private static Empleados EmpleadoActual = new Empleados();
        CNEmpleados cEmp = new CNEmpleados();
        private static IconMenuItem MenuActual = null;
        private static Form FrmActivo = null;
        
       
       
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
            AbrirFormulario(MenuReporte, new FrmReportes());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
            try
            {
                List<Permiso> ListaPermisos = new CNPermiso().PermisoPermisosPorEmpleado(usuarioActual.Emp_ID);

                foreach(IconMenuItem iconmenu in menuNav.Items)
                {
                    bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                    if(encontrado == false)
                    {
                        iconmenu.Visible = false;
                    }
                }
                EmpleadoActual = cEmp.BuscarEmpleado(usuarioActual.Emp_ID);
                lblNombre.Text = EmpleadoActual.Emp_Nombre + " " + EmpleadoActual.Emp_Apellido;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }

           


        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(MenuActual != null)
            {
                MenuActual.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActual = menu;

            if(FrmActivo != null)
            {
                FrmActivo.Close();

            }

            FrmActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            Contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void MenuAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmAdminSucursal());
        }

        private void MenuRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuRegistro, new FrmRegistroViajes());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
