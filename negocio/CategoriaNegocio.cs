using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Acceso_Datos datos = new Acceso_Datos();
          
            try
            {
      
                datos.setearconsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.nombre_categoria = (string)datos.lector["Descripcion"];
                    aux.codigo_categoria = (int)datos.lector["Id"];
                   
                    lista.Add(aux);


                }
               
                return lista;
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
   
      public void agregar (Categoria nueva_Categoria)
      {
      Acceso_Datos datos = new Acceso_Datos();
      try
      {
             datos.setearconsulta("insert into CATEGORIAS values('"+ nueva_Categoria.nombre_categoria + "')");
        
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
        public void modificar(Categoria cat)
        {
            Acceso_Datos datos = new Acceso_Datos();

            try
            {
                datos.setearconsulta("update CATEGORIAS set  Descripcion= @Descripcion where Id=@Id");
                datos.setearparametro("@Id", cat.codigo_categoria);
                datos.setearparametro("@Descripcion", cat.nombre_categoria);
            
                datos.ejecutaraccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public void Eliminar (int Id)
        {
                Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("DELETE FROM CATEGORIAS WHERE Id = @Id ");
                datos.setearparametro("@Id", Id);
                datos.ejecutaraccion();

            

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

}
}