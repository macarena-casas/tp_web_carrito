using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace tp2_grupal
{
    public class marca_negocio
    {

        public void Eliminar(int id)
        {
            try
            {
                Acceso_Datos datos = new Acceso_Datos();
                datos.setearconsulta("DELETE FROM MARCAS WHERE Id = @Id ");
                datos.setearparametro("@Id", id);
                datos.ejecutaraccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Agregar(Marca nueva_marca)
        { 
            Acceso_Datos datos = new Acceso_Datos();
            
            try
            {
                datos.setearconsulta("insert into MARCAS (Descripcion)Values ('"+ nueva_marca.Nombre +"')");
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }


       

        public List<Marca> Listar()
        {
            List<Marca> Lista_marca = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion from MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

             while (lector.Read())
                {
                Marca aux = new Marca();
                aux.Codigo = lector.GetInt32(0);
                aux.Nombre = (string)lector["Descripcion"];

                 Lista_marca.Add(aux);
                }
                conexion.Close();
                return Lista_marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}

