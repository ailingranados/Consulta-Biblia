using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios_registros
    {

        public List<Usuario_registros> Listar()
        {
            List<Usuario_registros> lista = new List<Usuario_registros>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    string query = "select Id_usuario,Correo ,Fecha_nac, Nombre, ApellidoM, ApellidoP, Clave from Usuario.UsuarioRegistros";

                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario_registros()
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                             
                                Correo = dr["Correo"].ToString(),
                                Fecha_nac = dr["Fecha_nac"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                ApellidoM = dr["ApellidoM"].ToString(),
                                ApellidoP = dr["ApellidoP"].ToString(),
                                Clave = dr["Clave"].ToString(),

                             

                            }) ;
                        }
                    }

                }catch (Exception ex)
                {
                    lista = new List<Usuario_registros>();
                }
            }

            return lista;
        }
    }
}

