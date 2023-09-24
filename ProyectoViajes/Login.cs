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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //buscar usuario
                Usuarios oUsuario = new Usuarios();
                CNUsuarios cUsuario = new CNUsuarios();
                oUsuario = cUsuario.BuscarUsuario(txtUsuario.Text);
       



                //Verificar si el usuario existe
                if (oUsuario == null)
                {
                    MessageBox.Show("El usuario o contraseña es incorrecto");
                }
                else
                {
                    if ((oUsuario.Usu_clave == txtContra.Text) && (oUsuario.Usu_activo == true))
                    {
                        
                        FrmInicio frmInicio = new FrmInicio(oUsuario);
                        frmInicio.Show();
                        this.Hide();
                        frmInicio.FormClosing += frm_closing;
                    }
                    else if ((oUsuario.Usu_activo == false)&&(oUsuario.Usuario == txtUsuario.Text))
                    {
                        MessageBox.Show("Su usuario se encuentra deshabilitado, por favor comunicarse con soporte técnico ");
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña es incorrecto");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al momento de realizar la consulta");
                Console.WriteLine(ex.Message);
            }

            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
