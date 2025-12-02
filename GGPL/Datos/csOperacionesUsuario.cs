using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class csOperacionesUsuario
    {
        public (object, object, bool) VerificarCredenciales(string usuario, string contraseña)
        {
            string cadena_comando = "SP_ValidarCredenciales";

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(cadena_comando, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasena", contraseña);

                SqlParameter salida01 = new SqlParameter("@IdUsuario", SqlDbType.Int);
                salida01.Direction = ParameterDirection.Output;
                comando.Parameters.Add(salida01);

                SqlParameter salida02 = new SqlParameter("@TipoUsuario", SqlDbType.VarChar, 50);
                salida02.Direction = ParameterDirection.Output;
                comando.Parameters.Add(salida02);

                SqlParameter salida03 = new SqlParameter("@Resultado", SqlDbType.Bit);
                salida03.Direction = ParameterDirection.Output;
                comando.Parameters.Add(salida03);

                comando.ExecuteNonQuery();

                return (salida01.Value, salida02.Value, (bool)salida03.Value);
            }
        }

        public DataTable ListaUsuarios()
        {
            string cadena_comando = "SP_V_ListaUsuarios";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(cadena_comando, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ListaRoles()
        {
            string cadena_comando = "SP_V_ListaTipoUsuarioCombobox";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(cadena_comando, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public bool RegistrarUsuario(
            int id_tipo_usuario,
            string cedula,
            string nombre,
            string apellido,
            char genero,
            DateTime fecha_nacimiento,
            string celular,
            string correo,
            string credencial_usuario,
            string credencial_contraseña)
        {
            string cadena_comando = "SP_InsertUsuario";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(cadena_comando, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TipoUsuarioIDTipoUsuario", id_tipo_usuario);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@FechaNacimientoUsuario", fecha_nacimiento.Date);
                comando.Parameters.AddWithValue("@Telefono", celular);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@CredencialUsuario", credencial_usuario);
                comando.Parameters.AddWithValue("@CredencialContrasena", credencial_contraseña);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarUsuario(
            int id_usuario,
            int id_tipo_usuario,
            string cedula,
            string nombre,
            string apellido,
            char genero,
            DateTime fecha_nacimiento,
            string celular,
            string correo,
            string credencial_usuario,
            string credencial_contraseña)
        {
            bool resultado = false;
            string cadena_comando = "SP_UpdateUsuario";

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(cadena_comando, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDUsuario", id_tipo_usuario);
                comando.Parameters.AddWithValue("@TipoUsuarioIDTipoUsuario", id_tipo_usuario);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@FechaNacimientoUsuario", fecha_nacimiento.ToString("dd/MM/yyyy"));
                comando.Parameters.AddWithValue("@Telefono", celular);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@CredencialUsuario", credencial_usuario);
                comando.Parameters.AddWithValue("@CredencialContrasena", credencial_contraseña);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }
    }
}
