using CEntidades;
using CNegocios;
using Microsoft.Win32;
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
        List<Viaje_Detalles> listaDetalleViaje = new List<Viaje_Detalles>();
        CNDetalleViaje cndetalle = new CNDetalleViaje();
        CNSucursal cnSucur = new CNSucursal();
        CNEmpleados cnEmp = new CNEmpleados();
        CNViajes cnViajes = new CNViajes();
        CNSucursalxEmpleado cnSuxemp = new CNSucursalxEmpleado();
        SucursalxEmpleado SuxEmp = new SucursalxEmpleado
        {
            oEmpleado = new Empleados(),
            oSucursal = new Sucursal()
        };
        Viajes viaje = new Viajes
        {
            oEmpleado = new Empleados(),
            oSucursal = new Sucursal(),
            oTransportista = new Transportistas()
        };
        Viaje_Detalles dviaje = new Viaje_Detalles
        {
            oEmpleado = new Empleados(),

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

        private void FrmRegistroViajes_Load(object sender, EventArgs e) //carga datos en cmb al iniciar 
        {
            LlenarSucursal();
            LlenarTransportista();
            txtRegistrador.Text = empActual.Emp_Nombre + " " + empActual.Emp_Apellido;
            txtRegistrador.ReadOnly = true;
            txtDistancia.Text = distanciaKM.ToString();
        }
        private void obtenerValores() //obtiene valores del los cmb y txt

        {

            viaje.oEmpleado.Emp_ID = Convert.ToInt32(empActual.Emp_ID);
            viaje.oSucursal.Sucursal_ID = Convert.ToInt32(cmbSucursal.SelectedValue);
            viaje.oTransportista.Trp_ID = Convert.ToInt32(cmbTransportista.SelectedValue);
            viaje.Viaje_Total = Convert.ToInt32(txtDistancia.Text);
        }

        private void ObtenerValoresDGV(int viajeid) //obtiene valores del datagrid view en una lista
        {

            foreach (DataGridViewRow fila in dgvEmpleado.Rows)
            {
                if (fila.IsNewRow) continue;
                dviaje.oEmpleado.Emp_ID = Convert.ToInt32(fila.Cells["Emp_ID"].Value);
                dviaje.idEmp = Convert.ToInt32(fila.Cells["Emp_ID"].Value);
                dviaje.VD_ID = viajeid;
                dviaje.Distancia_KM = Convert.ToInt32(fila.Cells["Emp_Distancia"].Value);
                listaDetalleViaje.Add(dviaje);
            }

        }

        private void LlenarSucursal() // llena combobox de sucursal
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

        private void LlenarDWV() // llena el data grid view segun los agregados desde el combobox
        {
            Empleados empleadoSeleccionado = (Empleados)cmbColaborador.SelectedItem;
            if ((empleadoSeleccionado.Emp_Distancia + Convert.ToInt32(txtDistancia.Text)) < 100)
            {
                if (dgvEmpleado.Columns.Count == 0)
                {
                    dgvEmpleado.AutoGenerateColumns = false;
                    dgvEmpleado.Columns.Add("Emp_ID", "ID");
                    dgvEmpleado.Columns.Add("Emp_NomCompleto", "Empleado");
                    dgvEmpleado.Columns.Add("Emp_Distancia", "Distancia (KM)");
                }
                if (empleadosAgregados.Contains(empleadoSeleccionado))
                {
                    MessageBox.Show("Este empleado ya ha sido agregado a la lista");
                }
                else
                {
                    if (cnEmp.EmpleadoxFechal(empleadoSeleccionado.Emp_ID) == 0)
                    { //condicion que verifica si el empleado ya esta registrado para un viaje ese dia
                        int rowIndex = dgvEmpleado.Rows.Add();
                        dgvEmpleado.Rows[rowIndex].Cells["Emp_ID"].Value = empleadoSeleccionado.Emp_ID;
                        dgvEmpleado.Rows[rowIndex].Cells["Emp_NomCompleto"].Value = empleadoSeleccionado.Emp_NomCompleto;
                        dgvEmpleado.Rows[rowIndex].Cells["Emp_Distancia"].Value = empleadoSeleccionado.Emp_Distancia;

                        distanciaKM += empleadoSeleccionado.Emp_Distancia;

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
        private void LlenarTransportista() // llena combobox de transportista
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

        private void LlenarEmpleado() //llena el cmb de empleado afiliados a una sucursal seleccionada
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
            txtDistancia.Text= distanciaKM.ToString();
        }



        private void btnRegistrar_Click(object sender, EventArgs e) //envia a registrar el viaje
        {
            if (dgvEmpleado.Rows.Count > 1)
            {
                obtenerValores();
                int idviaje = cnViajes.InsertarNuevoViaje(viaje);

                ObtenerValoresDGV(idviaje);
                foreach (Viaje_Detalles detalles in listaDetalleViaje)
                {
                    cndetalle.InsertarNuevoDetalle(detalles);
                }
                MessageBox.Show("Viaje registrado correctamente");
                LlenarSucursal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar los empleados que viajaran");
            }
        }



        private void btnQuitar_Click(object sender, EventArgs e) // quita un empleado seleccionado en el data grid view
        {

            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                
                DataGridViewRow filaSeleccionada = dgvEmpleado.SelectedRows[0];
                if ((filaSeleccionada != null)&& (filaSeleccionada.Cells["Emp_Distancia"].Value!=null)) {
                    Empleados registroAEliminar = filaSeleccionada.DataBoundItem as Empleados;
                    string valorColumna = filaSeleccionada.Cells["Emp_Distancia"].Value.ToString();
                    int idAEliminar = Convert.ToInt32(filaSeleccionada.Cells["Emp_ID"].Value.ToString());
                    Empleados empleadoAEliminar = empleadosAgregados.FirstOrDefault(empleado => empleado.Emp_ID == idAEliminar);

                    distanciaKM -= Convert.ToInt32(valorColumna);

                    dgvEmpleado.Rows.Remove(filaSeleccionada);
                    empleadosAgregados.Remove(empleadoAEliminar);

                    txtDistancia.Text = distanciaKM.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una celda valida");
                }

                    
            }


        }


    }
}