using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class csOperacionesTransaccion
    {

        public (bool, int) RegistrarTransaccion(
            int id_usuario,
            char tipo_transaccion,
            int id_tipo_pago,
            int cantidad_animales,
            decimal valor_total,
            DateTime fecha_hora_registro)
        {
            const string sp = "SP_InsertTransaccion";
            bool resultado01;
            int resultado02;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@UsuarioIDUsuario", id_usuario);
                comando.Parameters.AddWithValue("@TipoTransaccion", tipo_transaccion);
                comando.Parameters.AddWithValue("@TipoPagoIDTipoPago", id_tipo_pago);
                comando.Parameters.AddWithValue("@CantidadAnimales", cantidad_animales);
                comando.Parameters.AddWithValue("@ValorTotal", valor_total);
                comando.Parameters.AddWithValue("@FechaHoraRegistroTransaccion", fecha_hora_registro);

                SqlParameter salida01 = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida01);

                SqlParameter salida02 = new SqlParameter("@IDTransaccion", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida02);

                comando.ExecuteNonQuery();

                resultado01 = Convert.ToBoolean(salida01.Value);
                resultado02 = Convert.ToInt32(salida02.Value);
            }

            return (resultado01, resultado02);
        }

        public bool ModificarTransaccion(
            int id_transaccion,
            int id_usuario,
            char tipo_transaccion,
            int id_tipo_pago,
            int cantidad_animales,
            decimal valor_total,
            DateTime fecha_hora_registro)
        {
            const string sp = "SP_UpdateTransaccion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTransaccion", id_transaccion);
                comando.Parameters.AddWithValue("@UsuarioIDUsuario", id_usuario);
                comando.Parameters.AddWithValue("@TipoTransaccion", tipo_transaccion);
                comando.Parameters.AddWithValue("@TipoPagoIDTipoPago", id_tipo_pago);
                comando.Parameters.AddWithValue("@CantidadAnimales", cantidad_animales);
                comando.Parameters.AddWithValue("@ValorTotal", valor_total);
                comando.Parameters.AddWithValue("@FechaHoraRegistroTransaccion", fecha_hora_registro);

                object escalar = comando.ExecuteScalar();
                resultado = escalar != null && Convert.ToBoolean(escalar);
            }

            return resultado;
        }

        public bool RegistrarTransaccionVentaAnimal(
            int id_transaccion,
            int id_animal,
            decimal valor_animal)
        {
            const string sp = "SP_InsertTransaccionVentaAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TransaccionIDTransaccion", id_transaccion);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@ValorAnimal", valor_animal);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTransaccionVentaAnimal(
            int id_transaccion_venta_animal,
            int id_transaccion,
            int id_animal,
            decimal valor_animal)
        {
            const string sp = "SP_UpdateTransaccionVentaAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTransaccionVentaAnimal", id_transaccion_venta_animal);
                comando.Parameters.AddWithValue("@TransaccionIDTransaccion", id_transaccion);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@ValorAnimal", valor_animal);

                object escalar = comando.ExecuteScalar();
                resultado = escalar != null && Convert.ToBoolean(escalar);
            }

            return resultado;
        }

        public DataTable CargarDatosTablaCompra()
        {
            const string sp = "SP_V_ListaTransaccionesCompra";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerTipoPago()
        {
            const string sp = "SP_V_ListaTipoPagos";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public DataTable CargarDatosTablaVenta()
        {
            const string sp = "SP_V_ListaTransaccionesVenta";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public DataTable CargarDatosTablaVentaAnimales()
        {
            const string sp = "SP_V_ListaSeleccionAnimales";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            using (SqlDataAdapter datos = new SqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.StoredProcedure;
                datos.Fill(tabla);
            }

            return tabla;
        }

        public bool ActualizarEstadoAnimalVenta(int id_animal)
        {
            const string sp = "SP_V_ActualizarEstadoAnimalVenta";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDAnimal", id_animal);

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



