using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace capaDatos
{
    public class clsManejador
    {
        public SqlConnection conexion = new SqlConnection();
        public static string _cadena;

        public void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = retornarCadena();
                conexion.Open();
            }
        }

        public void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        public static String retornarCadena()
        {
            return "Data Source=DESKTOP-M1DR28P;Initial Catalog=dbBanco;Integrated Security=True";
        }
        public void EjecutarSp(String nombreSp, ref List<clsparametros> lst)
        {
            SqlCommand cmd;
            try
            {
                conectar();
                cmd = new SqlCommand(nombreSp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            desconectar();
        }



        public DataTable Listado(String nombreSp, List<clsparametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                conectar();
                da = new SqlDataAdapter(nombreSp, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            desconectar();
            return dt;
        }
        public DataTable ConsultaDatos(string consultaSql)
        {
            SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
