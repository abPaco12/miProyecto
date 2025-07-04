using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace capaDatos
{
    public class clsparametros
    {
        private String m_nombre;

        public String Nombre
        {
            get { return m_nombre; }
            set { m_nombre = value; }
        }
        private Object m_valor;

        public Object Valor
        {
            get { return m_valor; }
            set { m_valor = value; }
        }
        private SqlDbType m_tipoDato;

        public SqlDbType TipoDato
        {
            get { return m_tipoDato; }
            set { m_tipoDato = value; }
        }
        private ParameterDirection m_direccion;

        public ParameterDirection Direccion
        {
            get { return m_direccion; }
            set { m_direccion = value; }
        }
        
        private int m_tamaño;

        public int Tamaño
        {
            get { return m_tamaño; }
            set { m_tamaño = value; }
        }
        public clsparametros(String objnombre, Object objvalor)
        {
            m_nombre = objnombre;
            m_valor = objvalor;
            m_direccion = ParameterDirection.Input;

        }
        public clsparametros(String objnombre, Object objvalor, SqlDbType objtipo, ParameterDirection objdireccion, int objtamaño)
        {
            m_nombre = objnombre;
            m_valor = objvalor;
            m_tipoDato = objtipo;
            m_direccion = objdireccion;
            m_tamaño = objtamaño;
        }
    }
}
