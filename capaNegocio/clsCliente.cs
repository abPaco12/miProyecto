using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using capaDatos;
using System.Windows.Forms;
using System.Data.SqlClient;

using excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace capaNegocio
{
    public class clsCliente
    {
        string _Idcliente;

        public string Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }


        string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


        public void ExportarDatos(DataGridView dgv, string filename)
        {
            excel.Application app = new excel.Application();
            app.Application.Workbooks.Open(filename);

            int fila = 3;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    app.Cells[fila, 1] = row.Cells[0].Value.ToString();
                    app.Cells[fila, 2] = row.Cells[1].Value.ToString();
                    app.Cells[fila, 3] = row.Cells[2].Value.ToString();
                    app.Cells[fila, 4] = row.Cells[3].Value.ToString();

                }
                fila++;
            }
            app.Visible = true;
        }

        public string registrarCli()
        {
            List<clsparametros> lst = new List<clsparametros>();
            string mensaje = "";
            try
            {
                lst.Add(new clsparametros("@id", _Idcliente));
                lst.Add(new clsparametros("@nombre", _nombre));
                lst.Add(new clsparametros("@apellido", _apellido));
                lst.Add(new clsparametros("@telefono", _telefono));
                lst.Add(new clsparametros("@correo", _correo));
                lst.Add(new clsparametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                m.EjecutarSp("spRegistrarUsuario", ref lst);

                mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE HA PRODUCIDO LOS SIGUIENTES ERRORES: " + ex);
            }
            return mensaje;
        }
        public string ActualizarCli()
        {
            List<clsparametros> lst = new List<clsparametros>();
            string men = "";
            try
            {
                lst.Add(new clsparametros("@id", _Idcliente));
                lst.Add(new clsparametros("@nombre", _nombre));
                lst.Add(new clsparametros("@apellido", _apellido));
                lst.Add(new clsparametros("@telefono", _telefono));
                lst.Add(new clsparametros("@correo", _correo));
                lst.Add(new clsparametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                m.EjecutarSp("spActualizarUsuario", ref lst);
                men = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE HA PRODUCIDO LOS SIGUIENTES ERRORES: " + ex);
            }
            return men;
        }
        clsManejador m = new clsManejador();
        public DataTable Listacliente()
        {
            return m.Listado("Listadocliente", null);
        }
        public DataTable Buscarcliente(string dato)
        {
            List<clsparametros> lst = new List<clsparametros>();
            try
            {
                lst.Add(new clsparametros("@id", dato));
                return m.Listado("spBuscarUsuario", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string EliminarCliente()
        {
            List<clsparametros> lst = new List<clsparametros>();
            string mensaje = "";
            try
            {
                // Solo necesitas el id del cliente y el mensaje de salida
                lst.Add(new clsparametros("@id", _Idcliente));
                lst.Add(new clsparametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

                m.EjecutarSp("spEliminarCliente", ref lst);

                mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE HA PRODUCIDO LOS SIGUIENTES ERRORES: " + ex);
            }
            return mensaje;
        }
        public void actualizarClientesPorLotes(DataGridView dgv)
        {

            try
            {
                m.conectar();

                String query = "update usuarios set nombre=@nombre, apellido=@apellido, telefono=@telefono, correo=@correo where id=@id";
                SqlCommand cmd = new SqlCommand(query, m.conexion);
                foreach (DataGridViewRow dtRow in dgv.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", dtRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@nombre", dtRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@apellido", dtRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@telefono", dtRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@correo", dtRow.Cells[4].Value.ToString());

                    cmd.ExecuteNonQuery();


                }
                MessageBox.Show("se registraron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void insertarClientesPorLotes(DataGridView dgv)
        {

            try
            {
                m.conectar();
                String query = "insert into usuarios values(@id,@nombre,@apellido,@telefono,@correo)";
                SqlCommand cmd = new SqlCommand(query, m.conexion);
                foreach (DataGridViewRow dtRow in dgv.Rows)
                {
                    cmd.Parameters.Clear();
                    
                    cmd.Parameters.AddWithValue("@id", dtRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@nombre", dtRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@apellido", dtRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@telefono", dtRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@correo", dtRow.Cells[4].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("se registraron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("LOS VALORES QUE ESCRIBIO NO SON CORRECTOS, O LOS PRECIOS NO PUEDEN ESTAR EN BLANCO... CORRIJA E INTENTE NUEVAMENTE");
            }


            //    M.conexion.Close();

        }
        public DataTable ObtenerClientes()
        {
            return m.ConsultaDatos("select * from usuarios");
        }

    }
}
