﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace negocio
{
    public class Acceso_Datos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader Lector;

        public SqlDataReader lector
        {
            get { return Lector; }
        }

        public Acceso_Datos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();

        }

        public void setearconsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void setearparametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
       

        public void ejecutarlectura ()
        {
            comando.Connection = conexion;
            try
            {
            conexion.Open();
            Lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void ejecutaraccion()
        { 
            comando.Connection = conexion;
            try
            { 
                conexion.Open();
                comando.ExecuteNonQuery();
                }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public object ejecutarScalar()
        {
            
            object res = comando.ExecuteScalar();
            conexion.Close();
            return res;
        }
        
     

        public void cerrarconexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
