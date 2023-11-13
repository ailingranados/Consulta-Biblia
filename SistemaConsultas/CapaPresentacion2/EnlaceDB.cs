/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

NO SE PERMITE HARDCODE.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace CapaPresentacion2
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["DB_Usuarios"].ToString(); 
			// Cambiar Grupo01 por el que ustedes hayan definido en el App.Confif
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public bool Autentificar(string us, string ps)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@u", SqlDbType.Char, 20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@p", SqlDbType.Char, 20);
                parametro2.Value = ps;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if(_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch(SqlException  e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public DataTable get_Users()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
				// Ejemplo de cómo ejecutar un query, 
				// PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
                string qry = "Select Nombre, email, Fecha_modif from Usuarios where Activo = 0;";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
						// Esta opción solo la podrían utilizar si hacen un EXEC al SP concatenando los parámetros.
                _comandosql.CommandTimeout = 1200;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

		// Ejemplo de método para recibir una consulta en forma de tabla
		// Cuando el SP ejecutará un SELECT
        public DataTable get_Deptos(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla); 
				// la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
		
		// Ejemplo de método para ejecutar un SP que no se espera que regrese información, 
		// solo que ejecute ya sea un INSERT, UPDATE o DELETE
        //***********************************************************************************USUARIOS
        public bool Add_Deptos(string opc, string depto)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                parametro2.Value = depto;

                _adaptador.InsertCommand = _comandosql;
				// También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand
                
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();                
            }

            return add;
        }

        public bool Agregar_usuario(int genero, string correo, string fecha_nac, string nombre, string apellidoM, string apellidoP, string clave)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_InsertarNuevoUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_Genero", SqlDbType.Int);
                parametro1.Value = genero;

                var parametro2 = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 20);
                parametro2.Value = correo;

                var parametro3 = _comandosql.Parameters.AddWithValue("@Fecha_nac", Convert.ToDateTime(fecha_nac));
                parametro3.Value = fecha_nac;

                var parametro4 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 10);
                parametro4.Value = nombre;

                var parametro5 = _comandosql.Parameters.Add("@ApellidoM", SqlDbType.VarChar, 10);
                parametro5.Value = apellidoM;

                var parametro6 = _comandosql.Parameters.Add("@ApellidoP", SqlDbType.VarChar, 10);
                parametro6.Value = apellidoP;

                var parametro7 = _comandosql.Parameters.Add("@Clave", SqlDbType.VarChar, 10);
                parametro7.Value = clave;

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Activar_con(string clave, int id_usuario)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_ActivarContraseña";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@id_usuario", SqlDbType.Int);
                parametro1.Value = id_usuario;

                var parametro2 = _comandosql.Parameters.Add("@clave", SqlDbType.VarChar, 10);
                parametro2.Value = clave;

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public DataTable Logear(string usuario, string clave)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "SP_IniciarSesion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 20);
                parametro1.Value = usuario;

                var parametro2 = _comandosql.Parameters.Add("@clave", SqlDbType.VarChar, 10);
                parametro2.Value = clave;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Buscar_usu(int Id_usuario)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "SP_BuscarUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                //cambie el varchar de 20 por int
                var parametro1 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro1.Value = Id_usuario;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public bool Editar_usuario(int id_usuario, string nombre, string apellidoM, string apellidoP)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_ActualizarUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro3 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro3.Value = id_usuario; 

                var parametro4 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 10);
                parametro4.Value = nombre;

                var parametro5 = _comandosql.Parameters.Add("@ApellidoM", SqlDbType.VarChar, 10);
                parametro5.Value = apellidoM;

                var parametro6 = _comandosql.Parameters.Add("@ApellidoP", SqlDbType.VarChar, 10);
                parametro6.Value = apellidoP;


                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Editar_clave(int Id_usuario, string nueva, string vieja)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "SP_ContraseñasNuevas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro6 = _comandosql.Parameters.Add("@ClaveVieja", SqlDbType.VarChar, 10);
                parametro6.Value = vieja;

                var parametro5 = _comandosql.Parameters.Add("@ClaveNueva", SqlDbType.VarChar, 10);
                parametro5.Value = nueva;

                var parametro4 = _comandosql.Parameters.Add("@Id_usu", SqlDbType.Int);
                parametro4.Value = Id_usuario;


                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public DataTable Buscar_ContraseñasViejas(int Id_usuario)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "SP_LeerContraseñaUsu";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro4 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro4.Value = Id_usuario;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public bool Editar_estadoBAJA(int Id_usuario)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "Usuario.SP_BajaUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro4 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro4.Value = Id_usuario;


                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        //*******************************************************************************BIBLIA BUSQUEDAS
        public DataTable Consultar_Idioma()
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_IdiomasBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public int Buscar_Idioma(string nombre)
        {
            var msg = "";
            int id_idioma = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarIdioma";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                parametro1.Value = nombre;


                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_idioma = Convert.ToInt32(result);
                


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_idioma;
        }

        public DataTable Consultar_Version(int idioma)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_VersionBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = idioma;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public int Buscar_Version(string nombre)
        {
            var msg = "";
            int id_idioma = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarVersion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                parametro1.Value = nombre;


                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_idioma = Convert.ToInt32(result);



            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_idioma;
        }

        public DataTable Consultar_Testamento(int id_idioma)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_TestamentosBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = id_idioma;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public int Buscar_Testamento(string nombre)
        {
            var msg = "";
            int id_test = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarTestamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                parametro1.Value = nombre;


                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_test = Convert.ToInt32(result);



            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_test;
        }

        public DataTable Consultar_Libros(int id_idioma, int id_testamento)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_LibrosBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_testamento", SqlDbType.Int);
                parametro2.Value = id_testamento;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public int Buscar_Libro(string nombre)
        {
            var msg = "";
            int id_test = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarLibro";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                parametro1.Value = nombre;


                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_test = Convert.ToInt32(result);



            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_test;
        }

        public DataTable Consultar_Versiculos(int id_version, int id_libro)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_VersiculosBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_version", SqlDbType.Int);
                parametro1.Value = id_version;

                var parametro2 = _comandosql.Parameters.Add("@Id_libro", SqlDbType.Int);
                parametro2.Value = id_libro;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public int Buscar_Ver(string NumVer)
        {
            var msg = "";
            int id_test = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarVersiculo";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@NumVer", SqlDbType.VarChar, 20);
                parametro1.Value = NumVer;


                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_test = Convert.ToInt32(result);



            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_test;
        }

        //************************************************************************CONSULTA DEPENDIENDO DE LA SELECCION DEL COMBOBOX
        public DataTable Consultar_IV(int Id_idioma, int id_version)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_Consulta_IV";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                //cambie el varchar de 20 por int

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = Id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_version", SqlDbType.Int);
                parametro2.Value = id_version;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Consultar_IVT(int Id_idioma, int id_version, int id_testamento)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_Consulta_IVT";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                //cambie el varchar de 20 por int

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = Id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_version", SqlDbType.Int);
                parametro2.Value = id_version;

                var parametro3 = _comandosql.Parameters.Add("@Id_testamento", SqlDbType.Int);
                parametro3.Value = id_testamento;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Consultar_IVTL(int Id_idioma, int id_version, int id_testamento, int id_libro)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_Consulta_IVTL";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                //cambie el varchar de 20 por int

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = Id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_version", SqlDbType.Int);
                parametro2.Value = id_version;

                var parametro3 = _comandosql.Parameters.Add("@Id_testamento", SqlDbType.Int);
                parametro3.Value = id_testamento;

                var parametro4 = _comandosql.Parameters.Add("@Id_libro", SqlDbType.Int);
                parametro4.Value = id_libro;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Consultar_IVTLVE(int Id_idioma, int id_version, int id_testamento, int id_libro, int id_versiculo)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_Consulta_IVTLVE";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                //cambie el varchar de 20 por int

                var parametro1 = _comandosql.Parameters.Add("@Id_idioma", SqlDbType.Int);
                parametro1.Value = Id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_version", SqlDbType.Int);
                parametro2.Value = id_version;

                var parametro3 = _comandosql.Parameters.Add("@Id_testamento", SqlDbType.Int);
                parametro3.Value = id_testamento;

                var parametro4 = _comandosql.Parameters.Add("@Id_libro", SqlDbType.Int);
                parametro4.Value = id_libro;

                var parametro5 = _comandosql.Parameters.Add("@Id_versiculo", SqlDbType.Int);
                parametro5.Value = id_versiculo;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }


        //***********************************************************************CONSULTA FAVORITO

        public bool Agregar_referencia(int id_idioma, int id_version, int id_testamento, int id_libro, int id_versiculo)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "Biblia.SP_GuardarRef";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_Idioma", SqlDbType.Int);
                parametro1.Value = id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_Version", SqlDbType.Int);
                parametro2.Value = id_version;

                var parametro3 = _comandosql.Parameters.Add("@Id_Testamento", SqlDbType.Int);
                parametro3.Value = id_testamento;

                var parametro4 = _comandosql.Parameters.Add("@Id_Libro", SqlDbType.Int);
                parametro4.Value = id_libro;

                var parametro5 = _comandosql.Parameters.Add("@Id_Versiculo", SqlDbType.Int);
                parametro5.Value = id_versiculo;

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public int Buscar_referencia(int id_idioma, int id_version, int id_testamento, int id_libro, int id_versiculo)
        {
            var msg = "";
            int id_test = 0;

            try
            {

                conectar();
                string qry = "Biblia.SP_BuscarRef";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_Idioma", SqlDbType.Int);
                parametro1.Value = id_idioma;

                var parametro2 = _comandosql.Parameters.Add("@Id_Version", SqlDbType.Int);
                parametro2.Value = id_version;

                var parametro3 = _comandosql.Parameters.Add("@Id_Testamento", SqlDbType.Int);
                parametro3.Value = id_testamento;

                var parametro4 = _comandosql.Parameters.Add("@Id_Libro", SqlDbType.Int);
                parametro4.Value = id_libro;

                var parametro5 = _comandosql.Parameters.Add("@Id_Versiculo", SqlDbType.Int);
                parametro5.Value = id_versiculo;

                _adaptador.SelectCommand = _comandosql;
                object result = _comandosql.ExecuteScalar();
                id_test = Convert.ToInt32(result);



            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return id_test;
        }

        public bool Agregar_fav(int id_usuario, int id_referencia)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "Consultas.SP_GruardarFav";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro1.Value = id_usuario;

                var parametro2 = _comandosql.Parameters.Add("@Id_referencia", SqlDbType.Int);
                parametro2.Value = id_referencia;

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        //no se usa
        public DataTable Buscar_favorito(int id_usuario)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Consultas.SP_BuscarFavUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro1.Value = id_usuario;

                

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        //no se usa
        public DataTable tabla_referencia(int id_referencia)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Biblia.SP_EncontrarRef";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@id_referencia", SqlDbType.Int);
                parametro1.Value = id_referencia;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable tabla_favoritos(int id_usuario)
        {
            var msg = "";
            DataTable tabla = new DataTable();

            try
            {

                conectar();
                string qry = "Consultas.SP_BuscarFavUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Id_usuario", SqlDbType.Int);
                parametro1.Value = id_usuario;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla


            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

    }
}
