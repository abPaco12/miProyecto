using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaNegocio;
using excel = Microsoft.Office.Interop.Excel;
namespace parctica
{
    public partial class Form1 : Form
    {

       //bool adicionar = false;
        //bool modificar = false;
        clsCliente c = new clsCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*private void estadoDecontroles(bool adicionar, bool guardar,bool modificar, bool eliminar)
        {
            btnadi.Enabled = adicionar;
            btnInsertar.Enabled = guardar;
            btnModi.Enabled = modificar;
            btnEliminar.Enabled = eliminar;

        }
        private void estadoCajasTExto(bool estado)
        {
            txtId.Enabled = estado;
            txtnon.Enabled = estado;
            txtApe.Enabled = estado;
            txtTele.Enabled = estado;
            txtCorr.Enabled = estado;
        }*/
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            /*if (adicionar)
            {
                //c.Idcliente = cbocliente.SelectedValue.ToString();
                c.Idcliente = txtId.Text;

                //MessageBox.Show(cbocliente.SelectedValue.ToString());
                c.Nombre = txtnon.Text;
                c.Apellido = txtApe.Text;
                c.Telefono = txtTele.Text;
                c.Correo = txtCorr.Text;
                MessageBox.Show(c.registrarCli());
                adicionar = false;
            }*/
            try
            {
                // Asignar propiedades
                c.Idcliente = txtId.Text;
                c.Nombre = txtnon.Text;
                c.Apellido = txtApe.Text;
                c.Telefono = txtTele.Text;
                c.Correo = txtCorr.Text;

                // Registrar cliente
                string mensaje = c.registrarCli();

                // Mostrar mensaje devuelto
                MessageBox.Show(mensaje);

                c.Listacliente();
                //adicionar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCli.DataSource = c.Listacliente();
            //estadoDecontroles(true, false, true, true);
           //estadoCajasTExto(false);
            Limpiar();
        }

        private void btnadi_Click(object sender, EventArgs e)
        {
            //modificar = true;
            //estadoCajasTExto(true);
            //estadoDecontroles(true, true, false, false);

            dgvCli.ReadOnly = false;
        }

        private void dgvCli_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvCli.CurrentRow.Cells[0].Value.ToString();
            txtnon.Text = dgvCli.CurrentRow.Cells[1].Value.ToString();
            txtApe.Text = dgvCli.CurrentRow.Cells[2].Value.ToString();
            txtTele.Text = dgvCli.CurrentRow.Cells[3].Value.ToString();
            txtCorr.Text = dgvCli.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnModi_Click(object sender, EventArgs e)
        {

            /*if (modificar)
            {
                c.Idcliente = txtId.Text;
                c.Nombre = txtnon.Text;
                c.Apellido = txtApe.Text;
                c.Telefono = txtTele.Text;
                c.Correo = txtCorr.Text;
                MessageBox.Show(c.ActualizarCli());
                modificar = false;
                //estadoCajasTExto(false);
            }
           // estadoDecontroles(true, false, true, true);*/
            try
            {

                // Asignar todas las propiedades
                c.Idcliente = txtId.Text;
                c.Nombre = txtnon.Text;
                c.Apellido = txtApe.Text;
                c.Telefono = txtTele.Text;
                c.Correo = txtCorr.Text;

                // Ejecutar el método que actualiza
                string mensaje = c.ActualizarCli();

                // Mostrar el mensaje de confirmación
                MessageBox.Show(mensaje);
                c.Listacliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                c.Idcliente = txtId.Text;
                string mensaje = c.EliminarCliente();
                MessageBox.Show(mensaje);
                c.Listacliente();

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMNAR:" + ex.Message);
            }
        }
        private void Limpiar()
        {
            txtId.Text = " ";
            txtnon.Text = " ";
            txtApe.Text = " ";
            txtTele.Text = " ";
            txtCorr.Text = " ";
            txtId.Focus();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCli.DataSource = c.Buscarcliente(txtbuscar.Text);
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
