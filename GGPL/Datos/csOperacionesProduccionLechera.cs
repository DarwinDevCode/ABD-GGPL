using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class csOperacionesProduccionLechera
    {
        public DataTable ListaProduccionLechera()
        {
            const string sp = "SP_V_ListaGeneralProduccionLechera";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sp, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerAnimales()
        {
            const string sp = "SP_V_ListaAnimalesCombobox";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sp, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ListaAnimalesHembras()
        {
            const string sp = "SP_ListaAnimalesHembrasCombobox";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sp, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }

            return tabla;
        }

        public bool RegistrarProduccionLechera(
            int id_usuario,
            int id_animal,
            decimal cantidad_litros,
            char tipo_ordeño,
            DateTime fecha_hora_ordeño)
        {
            const string sp = "SP_InsertProduccionLechera";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioIDUsuario", id_usuario);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@LitrosLecheProducidos", cantidad_litros);
                comando.Parameters.AddWithValue("@TipoOrdeno", tipo_ordeño);
                comando.Parameters.AddWithValue("@FechaHoraOrdeno", fecha_hora_ordeño);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarProduccionLechera(
            int id_produccion_lechera,
            int id_usuario,
            int id_animal,
            decimal cantidad_litros,
            char tipo_ordeño,
            DateTime fecha_hora_ordeño)
        {
            const string sp = "SP_UpdateProduccionLechera";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDProduccion", id_produccion_lechera);
                comando.Parameters.AddWithValue("@UsuarioIDUsuario", id_usuario);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@LitrosLecheProducidos", cantidad_litros);
                comando.Parameters.AddWithValue("@TipoOrdeno", tipo_ordeño);
                comando.Parameters.AddWithValue("@FechaHoraOrdeno", fecha_hora_ordeño);

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

