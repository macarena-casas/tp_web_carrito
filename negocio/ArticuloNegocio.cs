using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class ArticulosNegocio

    {

        public List <Articulos> listar()
        {
            List <Articulos> lista = new List <Articulos>();
            Acceso_Datos datos = new Acceso_Datos(); 
           
            try
            {
               
                datos.setearconsulta("select Codigo, Nombre, Precio, A.Id , A.Descripcion,M.Descripcion Marca,A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS AS A left JOIN MARCAS M ON A.IdMarca = M.Id left JOIN CATEGORIAS C ON A.IdCategoria = C.Id ");
                datos.ejecutarlectura();               
                    while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a =(string)datos.lector["Nombre"];
                    aux.precio_a=(decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Descripcion"];
                    aux.Id_a = (int)datos.lector["Id"];
                    
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
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


        public void agregar(Articulos nuevo)
        {
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
               datos.setearconsulta("insert into ARTICULOS values ('" + nuevo.codigo_a + "','" + nuevo.nombre_a + "','" + nuevo.descripcion_a+ "', @marca,@categoria , " + nuevo.precio_a + ")");
               datos.setearparametro("@categoria", nuevo.categoria_a.codigo_categoria);
               datos.setearparametro("@marca", nuevo.marca_a.Codigo);
               datos.ejecutaraccion();
              
               datos.setearconsulta("SELECT TOP 1 * FROM ARTICULOS ORDER BY Id DESC");
               int id = Convert.ToInt32(datos.ejecutarScalar());

               datos.setearconsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(@Id,@url)");
               datos.setearparametro("@Id", id);
               datos.setearparametro("@url", nuevo.urlimagen);
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
   
        public List<Articulos> listarco(string cod)
        {
            List<Articulos> lista = new List<Articulos>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Codigo, A.Id , A.Nombre,A.Precio, A.Descripcion Detalle, M.Descripcion Marca, A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.Codigo = @Cod AND M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datos.setearparametro("@Cod", cod);
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a = (string)datos.lector["Nombre"];
                    aux.precio_a = (decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Detalle"];
                    aux.Id_a = (int)datos.lector["Id"];
                 
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                return null;

            }
            finally { datos.cerrarconexion(); }
        }
        public List<Articulos> listarid(int id)
        {
            List<Articulos> lista = new List<Articulos>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Codigo, A.Id , A.Nombre,A.Precio, A.Descripcion Detalle, M.Descripcion Marca, A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.Id=@Id AND M.Id = A.IdMarca AND C.Id = A.IdCategoria ");
                datos.setearparametro("@Id", id);
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a = (string)datos.lector["Nombre"];
                    aux.precio_a = (decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Detalle"];
                    aux.Id_a = (int)datos.lector["Id"];
                   if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                return null;

            }
            finally { datos.cerrarconexion(); }
        }
        public List<Articulos> listarno(string nom)
        {
            List<Articulos> lista = new List<Articulos>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Codigo, A.Id , A.Nombre, A.Precio, A.Descripcion Detalle, M.Descripcion Marca, A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.Nombre = @nombre AND M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datos.setearparametro("@nombre", nom);
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a = (string)datos.lector["Nombre"];
                    aux.precio_a = (decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Detalle"];
                    aux.Id_a = (int)datos.lector["Id"];
                 
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                return null;

            }
            finally { datos.cerrarconexion(); }
        }
        public List<Articulos> listar(Marca id)
        {
            List<Articulos> lista = new List<Articulos>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Codigo, Nombre, Precio, A.Id, A.Descripcion, M.Descripcion Marca, A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = @Id AND C.Id = A.IdCategoria AND m.Id = @Id");
                datos.setearparametro("@Id", id.Codigo);
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a = (string)datos.lector["Nombre"];
                    aux.precio_a = (decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Descripcion"];
                    aux.Id_a = (int)datos.lector["Id"];
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    lista.Add(aux);

                }
                return lista;
                
             }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { datos.cerrarconexion(); }
        }
        public List<Articulos> listarcategoria(Categoria id)
        {
            List<Articulos> lista = new List<Articulos>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Codigo, A.Id,A.Nombre,A.Precio, A.Descripcion, M.Descripcion Marca, A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdCategoria = @Id AND M.Id = A.IdMarca AND C.Id = @Id");
                datos.setearparametro("@Id", id.codigo_categoria);
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a = (string)datos.lector["Nombre"];
                    aux.precio_a = (decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Descripcion"];
                    aux.Id_a = (int)datos.lector["Id"];
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { datos.cerrarconexion(); }

        }
        public void modificar (Articulos articulo)
        {
            Acceso_Datos datos = new Acceso_Datos();

            try
            {
                datos.setearconsulta("update ARTICULOS set Codigo=@Codigo, Nombre= @Nombre, Descripcion =@Descripcion,IdMarca=@IdMarca, IdCategoria= @IdCategoria, Precio= @Precio where Id=@Id ");
                datos.setearparametro("@Codigo",articulo.codigo_a);
                datos.setearparametro("@Nombre", articulo.nombre_a);
                datos.setearparametro("@Descripcion",articulo.descripcion_a);
                datos.setearparametro("@IdMarca", articulo.marca_a.Codigo);
                datos.setearparametro("@IdCategoria",articulo.categoria_a.codigo_categoria);
                datos.setearparametro("@Precio",articulo.precio_a);
                datos.setearparametro("@Id", articulo.Id_a);
                datos.ejecutaraccion();
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("DELETE FROM ARTICULOS WHERE Id = @Id ");
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
