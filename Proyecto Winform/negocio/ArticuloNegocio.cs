using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection(); //Declaro y creo objeto conexion
            SqlCommand comando = new SqlCommand();        //Declaro y creo objeto comando para realizar acciones con la conexion  
            SqlDataReader lector;
            try
            {   // Lineas 21 y 22, diferentes forma de conectar con la base de datos (Comentar y descomentar la que les funcione)
                conexion.ConnectionString = "server=.\\localhost,1433; database=CATALOGO_P3_DB; integrated security=false; user=sa; password= Passw0rd2025!";
                //conexion.ConnectionString = "server=localhost\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["descripcion"];
                    aux.Precio = (decimal)lector["precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); }

            return lista;
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
 
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) " + "VALUES ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Precio + ", " + nuevo.Categoria.Id + ", " + nuevo.Marca.Id + ")");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarRegistro(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> Filtrar(string campo, string criterio, int filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";

            if (campo == "Id")
            {
                switch (criterio)
                {
                    case "Mayor a":
                        consulta += "A.Id >" + filtro;
                        break;
                    case "Menor a":
                        consulta += "A.Id <" + filtro;
                        break;
                    case "Igual a":
                        consulta += "A.Id =" + filtro;
                        break;
                }
            }
            else
            {
                switch (criterio)
                {
                    case "Mayor a":
                        consulta += "Precio > " + filtro;
                        break;
                    case "Menor a":
                        consulta += "Precio < " + filtro;
                        break;
                    case "Igual a":
                        consulta += "Precio = " + filtro;
                        break;
                }


            }
            datos.setearConsulta(consulta);
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["descripcion"];
                aux.Precio = (decimal)datos.Lector["precio"];
                aux.Marca = new Marca();
                aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                aux.Categoria = new Categoria();
                aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                lista.Add(aux);
            }
            return lista;

        }

    }
    }

