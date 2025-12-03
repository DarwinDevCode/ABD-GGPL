using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class csOperacionesAnimal
    {
        public DataTable ListaHectareas()
        {
            const string sp = "SP_V_ListaHectareas";
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

        public DataTable ListaLotesAnimales()
        {
            const string sp = "SP_V_ListaLotesAnimales";
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

        public DataTable ListaTiposAnimales()
        {
            const string sp = "SP_V_ListaTiposAnimales";
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

        public DataTable ListaTiposEspecies()
        {
            const string sp = "SP_V_ListaTiposEspecies";
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

        public DataTable ListaTiposRazas()
        {
            const string sp = "SP_V_ListaTiposRazas";
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

        public DataTable ListaAnimales()
        {
            const string sp = "SP_V_ListaAnimales";
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

        public DataTable ListaLotesInsumos()
        {
            const string sp = "SP_V_ListaLotesInsumos";
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

        public DataTable ListaAnimalesEnfermedades()
        {
            const string sp = "SP_V_ListaAnimalesEnfermedades";
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

        public DataTable VistaGeneralHectareasLotesAnimales()
        {
            const string sp = "SP_V_VistaGeneralHectareasLotesAnimales";
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

        public DataTable ProduccionPorRazaAnimal()
        {
            const string sp = "SP_V_ProduccionPorRazaAnimal";
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

        public DataTable ListaSaludGeneral()
        {
            const string sp = "SP_V_ListaSaludGeneral";
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

        public DataTable ListaHectareasCombobox()
        {
            const string sp = "SP_V_ListaHectareasCombobox";
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

        public DataTable ListaLotesAnimalesCombobox()
        {
            const string sp = "SP_V_ListaLotesAnimalesCombobox";
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

        public DataTable ListaTiposLotesAnimalesCombobox()
        {
            const string sp = "SP_V_ListaTipoLoteAnimalCombobox";
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

        public DataTable ListaTiposRazasCombobox()
        {
            const string sp = "SP_V_ListaTiposRazasAnimalCombobox";
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

        public DataTable ListaTiposEspeciesCombobox()
        {
            const string sp = "SP_V_ListaTiposEspeciesCombobox";
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

        public DataTable ListaTipoEstadosCombobox()
        {
            const string sp = "SP_V_ListaEstadosAnimalCombobox";
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

        public DataTable ListaTipoLoteInsumosCombobox()
        {
            const string sp = "SP_V_ListaTipoLoteInsumo";
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

        public DataTable ListaAnimalesCombobox()
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

        public DataTable ListaTipoEnfermedadesCombobox()
        {
            const string sp = "SP_V_ListaTipoEnfermedadesCombobox";
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

        public (bool, int) RegistrarAnimal(string codigo_animal, int id_lote_animales,
                                           int id_tipo_raza_animal, char sexo,
                                           DateTime fecha_nacimiento,
                                           DateTime fecha_hora_registro,
                                           int id_tipo_estado_animal)
        {
            bool resultado01;
            int resultado02;

            const string sp = "SP_InsertAnimal";

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodigoAnimal", codigo_animal);
                comando.Parameters.AddWithValue("@LoteAnimalesIDLote", id_lote_animales);
                comando.Parameters.AddWithValue("@TipoRazaAnimalIDTipoRazaAnimal", id_tipo_raza_animal);
                comando.Parameters.AddWithValue("@Sexo", sexo);
                comando.Parameters.AddWithValue("@FechaNacimientoAnimal", fecha_nacimiento);
                comando.Parameters.AddWithValue("@FechaHoraRegistroAnimal", fecha_hora_registro);
                comando.Parameters.AddWithValue("@TipoEstadoAnimalIDTipoEstadoAnimal", id_tipo_estado_animal);

                SqlParameter salida01 = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida01);

                SqlParameter salida02 = new SqlParameter("@IDAnimal", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida02);

                comando.ExecuteNonQuery();

                resultado01 = Convert.ToBoolean(salida01.Value);
                resultado02 = Convert.ToInt32(salida02.Value);
            }

            return (resultado01, resultado02);
        }

        public bool ModificarAnimal(int id_animal, string codigo_animal, int id_lote_animales,
                                    int id_tipo_raza_animal, char sexo, DateTime fecha_nacimiento,
                                    DateTime fecha_hora_registro, int id_tipo_estado_animal)
        {
            const string sp = "SP_UpdateAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDAnimal", id_animal);
                comando.Parameters.AddWithValue("@CodigoAnimal", codigo_animal);
                comando.Parameters.AddWithValue("@LoteAnimalesIDLote", id_lote_animales);
                comando.Parameters.AddWithValue("@TipoRazaAnimalIDTipoRazaAnimal", id_tipo_raza_animal);
                comando.Parameters.AddWithValue("@Sexo", sexo);
                comando.Parameters.AddWithValue("@FechaNacimientoAnimal", fecha_nacimiento);
                comando.Parameters.AddWithValue("@FechaHoraRegistroAnimal", fecha_hora_registro);
                comando.Parameters.AddWithValue("@TipoEstadoAnimalIDTipoEstadoAnimal", id_tipo_estado_animal);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarAscendencia(string codigo_ascendencia, int animal_id_animal,
                                         char tipo_parentesco)
        {
            const string sp = "SP_InsertAscendencia";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodigoAscendencia", codigo_ascendencia);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", animal_id_animal);
                comando.Parameters.AddWithValue("@TipoParentesco", tipo_parentesco);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarEnfermedad(int id_animal, int id_tipo_enfermedad,
                                        string observaciones,
                                        DateTime fecha_hora_registro)
        {
            const string sp = "SP_InsertEnfermedad";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@TipoEnfermedadIDTipoEnfermedad", id_tipo_enfermedad);
                comando.Parameters.AddWithValue("@ObservacionEnfermedad", observaciones);
                comando.Parameters.AddWithValue("@FechaHoraRegistroEnfermedad", fecha_hora_registro);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarEnfermedad(int id_enfermedad, int id_animal,
                                        int id_tipo_enfermedad, string observaciones)
        {
            const string sp = "SP_UpdateEnfermedad";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDEnfermedad", id_enfermedad);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@TipoEnfermedadIDTipoEnfermedad", id_tipo_enfermedad);
                comando.Parameters.AddWithValue("@ObservacionEnfermedad", observaciones);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarHectarea(string codigo, decimal area)
        {
            const string sp = "SP_InsertHectarea";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AreaTotalHectarea", area);
                comando.Parameters.AddWithValue("@Codigo", codigo);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarHectarea(int id_hectarea, string codigo_hectarea,
                                      decimal area)
        {
            const string sp = "SP_UpdateHectarea";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDHectarea", id_hectarea);
                comando.Parameters.AddWithValue("@Codigo", codigo_hectarea);
                comando.Parameters.AddWithValue("@AreaTotalHectarea", area);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = Convert.ToBoolean(salida.Value);
            }

            return resultado;
        }

        public bool RegistrarLoteAnimales(string codigo_lote, int id_hectarea,
                                          int id_tipo_lote_animal, int capacidad)
        {
            const string sp = "SP_InsertLoteAnimales";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodigoLote", codigo_lote);
                comando.Parameters.AddWithValue("@HectareaIDHectarea", id_hectarea);
                comando.Parameters.AddWithValue("@TipoLoteAnimalIDTipoLoteAnimal", id_tipo_lote_animal);
                comando.Parameters.AddWithValue("@CapacidadLote", capacidad);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarLoteAnimales(int id_lote, string codigo_lote,
                                          int id_hectarea, int id_tipo_lote_animal,
                                          int capacidad)
        {
            const string sp = "SP_UpdateLoteAnimales";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDLote", id_lote);
                comando.Parameters.AddWithValue("@CodigoLote", codigo_lote);
                comando.Parameters.AddWithValue("@HectareaIDHectarea", id_hectarea);
                comando.Parameters.AddWithValue("@TipoLoteAnimalIDTipoLoteAnimal", id_tipo_lote_animal);
                comando.Parameters.AddWithValue("@CapacidadLote", capacidad);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarLoteInsumo(string codigo_lote, int id_tipo_lote,
                                        string distribuidor,
                                        DateTime fecha_fabricacion,
                                        DateTime fecha_caducidad,
                                        DateTime fecha_hora_registro)
        {
            const string sp = "SP_InsertLoteInsumo";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodigoLote", codigo_lote);
                comando.Parameters.AddWithValue("@TipoLoteInsumoIDTipoLoteInsumo", id_tipo_lote);
                comando.Parameters.AddWithValue("@Distribuidor", distribuidor);
                comando.Parameters.AddWithValue("@FechaFabricacionLote", fecha_fabricacion.Date);
                comando.Parameters.AddWithValue("@FechaCaducidadLote", fecha_caducidad.Date);
                comando.Parameters.AddWithValue("@FechaHoraRegistroLote", fecha_hora_registro);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarLoteInsumo(int id_lote_insumo, string codigo_lote_insumo,
                                        int id_tipo_lote_insumo, string distribuidor,
                                        DateTime fecha_fabricacion_lote,
                                        DateTime fecha_caducidad_lote,
                                        DateTime fecha_hora_regitro_lote)
        {
            const string sp = "SP_UpdateLoteInsumo";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDLoteInsumo", id_lote_insumo);
                comando.Parameters.AddWithValue("@CodigoLote", codigo_lote_insumo);
                comando.Parameters.AddWithValue("@TipoLoteInsumoIDTipoLoteInsumo", id_tipo_lote_insumo);
                comando.Parameters.AddWithValue("@Distribuidor", distribuidor);
                comando.Parameters.AddWithValue("@FechaFabricacionLote", fecha_fabricacion_lote);
                comando.Parameters.AddWithValue("@FechaCaducidadLote", fecha_caducidad_lote);
                comando.Parameters.AddWithValue("@FechaHoraRegistroLote", fecha_hora_regitro_lote);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarMedicamento(string nombre_medicamento, int id_tipo_medicamento)
        {
            const string sp = "SP_InsertMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreMedicamento", nombre_medicamento);
                comando.Parameters.AddWithValue("@TipoMedicamentoIDTipoMedicamento", id_tipo_medicamento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarMedicamento(int id_medicamento, string nombre_medicamento,
                                         int id_tipo_medicamento)
        {
            const string sp = "SP_UpdateMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDMedicamento", id_medicamento);
                comando.Parameters.AddWithValue("@NombreMedicamento", nombre_medicamento);
                comando.Parameters.AddWithValue("@TipoMedicamentoIDTipoMedicamento", id_tipo_medicamento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarReproduccion(string codigo_reproduccion, int id_tipo_reproduccion)
        {
            const string sp = "SP_InsertReproduccion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodigoReproduccion", codigo_reproduccion);
                comando.Parameters.AddWithValue("@TipoReproduccionIDTipoReproduccion", id_tipo_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarReproduccion(int id_reproduccion, string codigo_reproduccion,
                                          int id_tipo_reproduccion)
        {
            const string sp = "SP_UpdateReproduccion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDReproduccion", id_reproduccion);
                comando.Parameters.AddWithValue("@CodigoReproduccion", codigo_reproduccion);
                comando.Parameters.AddWithValue("@TipoReproduccionIDTipoReproduccion", id_tipo_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarReproduccionAnimal(int id_reproduccion, int id_animal,
                                                DateTime fecha_reproduccion)
        {
            const string sp = "SP_InsertReproduccionAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ReproduccionIDReproduccion", id_reproduccion);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@FechaReproduccion", fecha_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarReproduccionAnimal(int id_reproduccion_animal, int id_reproduccion,
                                                int id_animal, DateTime fecha_reproduccion)
        {
            const string sp = "SP_UpdateReproduccionAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDReproduccionAnimal", id_reproduccion_animal);
                comando.Parameters.AddWithValue("@ReproduccionIDReproduccion", id_reproduccion);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@FechaReproduccion", fecha_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarSaludGeneral(int id_animal, decimal peso_animal,
                                          string condicion_corporal,
                                          DateTime fecha_registro,
                                          DateTime fecha_proxima_revision,
                                          decimal temperatura_animal,
                                          int frecuencia_cardiaca,
                                          int frecuencia_respiratoria,
                                          string observacion_mucosas)
        {
            const string sp = "SP_InsertSaludGeneral";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@PesoAnimal", peso_animal);
                comando.Parameters.AddWithValue("@CondicionCorporal", condicion_corporal);
                comando.Parameters.AddWithValue("@FechaHoraRegistroSalud", fecha_registro);
                comando.Parameters.AddWithValue("@FechaHoraProximaRevision", fecha_proxima_revision);
                comando.Parameters.AddWithValue("@TemperaturaAnimal", temperatura_animal);
                comando.Parameters.AddWithValue("@FrecuenciaCardiacaAnimal", frecuencia_cardiaca);
                comando.Parameters.AddWithValue("@FrecuenciaRespiratoriaAnimal", frecuencia_respiratoria);
                comando.Parameters.AddWithValue("@ObservacionMucosasAnimal", observacion_mucosas);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarSaludGeneral(int id_salud_general, int id_animal,
                                          DateTime fecha_evaluacion,
                                          string estado_salud)
        {
            const string sp = "SP_UpdateSaludGeneral";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDSaludGeneral", id_salud_general);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@FechaEvaluacion", fecha_evaluacion);
                comando.Parameters.AddWithValue("@EstadoSalud", estado_salud);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarSignosClinicos(int id_enfermedad, string descripcion_signo)
        {
            const string sp = "SP_InsertSignosClinicos";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@EnfermedadIDEnfermedad", id_enfermedad);
                comando.Parameters.AddWithValue("@DescripcionSigno", descripcion_signo);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarSignosClinicos(int id_signos_clinicos, int id_enfermedad,
                                            string descripcion_signo)
        {
            const string sp = "SP_UpdateSignosClinicos";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDSignosClinicos", id_signos_clinicos);
                comando.Parameters.AddWithValue("@EnfermedadIDEnfermedad", id_enfermedad);
                comando.Parameters.AddWithValue("@DescripcionSigno", descripcion_signo);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoAnimal(string nombre_tipo_animal)
        {
            const string sp = "SP_InsertTipoAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TipoAnimal", nombre_tipo_animal);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoAnimal(int id_tipo_animal, string nombre_tipo_animal)
        {
            const string sp = "SP_UpdateTipoAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoAnimal", id_tipo_animal);
                comando.Parameters.AddWithValue("@TipoAnimal", nombre_tipo_animal);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoEnfermedad(string nombre_tipo_enfermedad)
        {
            const string sp = "SP_InsertTipoEnfermedad";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoEnfermedad", nombre_tipo_enfermedad);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoEnfermedad(int id_tipo_enfermedad,
                                            string nombre_tipo_enfermedad)
        {
            const string sp = "SP_UpdateTipoEnfermedad";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoEnfermedad", id_tipo_enfermedad);
                comando.Parameters.AddWithValue("@NombreTipoEnfermedad", nombre_tipo_enfermedad);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoEspecieAnimal(int id_tipo_animal, string nombre_especie)
        {
            const string sp = "SP_InsertTipoEspecieAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TipoAnimalIDTipoAnimal", id_tipo_animal);
                comando.Parameters.AddWithValue("@TipoEspecieAnimal", nombre_especie);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoEspecieAnimal(int id_tipo_especie_animal,
                                               int id_tipo_animal,
                                               string nombre_especie)
        {
            const string sp = "SP_UpdateTipoEspecieAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoEspecieAnimal", id_tipo_especie_animal);
                comando.Parameters.AddWithValue("@TipoAnimalIDTipoAnimal", id_tipo_animal);
                comando.Parameters.AddWithValue("@TipoEspecieAnimal", nombre_especie);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoEstadoAnimal(string nombre_estado)
        {
            const string sp = "SP_InsertTipoEstadoAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreEstado", nombre_estado);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoEstadoAnimal(int id_tipo_estado_animal,
                                              string nombre_estado)
        {
            const string sp = "SP_UpdateTipoEstadoAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoEstadoAnimal", id_tipo_estado_animal);
                comando.Parameters.AddWithValue("@NombreEstado", nombre_estado);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoLoteAnimal(string nombre_tipo_lote)
        {
            const string sp = "SP_InsertTipoLoteAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoLote", nombre_tipo_lote);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoLoteAnimal(int id_tipo_lote_animal,
                                            string nombre_tipo_lote)
        {
            const string sp = "SP_UpdateTipoLoteAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoLoteAnimal", id_tipo_lote_animal);
                comando.Parameters.AddWithValue("@NombreTipoLote", nombre_tipo_lote);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoLoteInsumo(string nombre_tipo_lote_insumo)
        {
            const string sp = "SP_InsertTipoLoteInsumo";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoLoteInsumo", nombre_tipo_lote_insumo);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoLoteInsumo(int id_tipo_lote_insumo,
                                            string nombre_tipo_lote_insumo)
        {
            const string sp = "SP_UpdateTipoLoteInsumo";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoLoteInsumo", id_tipo_lote_insumo);
                comando.Parameters.AddWithValue("@NombreTipoLoteInsumo", nombre_tipo_lote_insumo);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoMedicamento(string nombre_tipo_medicamento)
        {
            const string sp = "SP_InsertTipoMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoMedicamento", nombre_tipo_medicamento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoMedicamento(int id_tipo_medicamento,
                                             string nombre_tipo_medicamento)
        {
            const string sp = "SP_UpdateTipoMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoMedicamento", id_tipo_medicamento);
                comando.Parameters.AddWithValue("@NombreTipoMedicamento", nombre_tipo_medicamento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoRazaAnimal(int id_tipo_especie_animal,
                                            string nombre_raza)
        {
            const string sp = "SP_InsertTipoRazaAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TipoEspecieAnimalIDTipoEspecieAnimal", id_tipo_especie_animal);
                comando.Parameters.AddWithValue("@TipoRazaAnimal", nombre_raza);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoRazaAnimal(int id_tipo_raza_animal,
                                            string nombre_raza,
                                            int id_tipo_especie_animal)
        {
            const string sp = "SP_UpdateTipoRazaAnimal";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoRazaAnimal", id_tipo_raza_animal);
                comando.Parameters.AddWithValue("@TipoEspecieAnimalIDTipoEspecieAnimal", id_tipo_especie_animal);
                comando.Parameters.AddWithValue("@TipoRazaAnimal", nombre_raza);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoReproduccion(string nombre_tipo_reproduccion)
        {
            const string sp = "SP_InsertTipoReproduccion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoReproduccion", nombre_tipo_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoReproduccion(int id_tipo_reproduccion,
                                              string nombre_tipo_reproduccion)
        {
            const string sp = "SP_UpdateTipoReproduccion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoReproduccion", id_tipo_reproduccion);
                comando.Parameters.AddWithValue("@NombreTipoReproduccion", nombre_tipo_reproduccion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoTratamiento(string nombre_tipo_tratamiento)
        {
            const string sp = "SP_InsertTipoTratamiento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoTratamiento", nombre_tipo_tratamiento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoTratamiento(int id_tipo_tratamiento,
                                             string nombre_tipo_tratamiento)
        {
            const string sp = "SP_UpdateTipoTratamiento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoTratamiento", id_tipo_tratamiento);
                comando.Parameters.AddWithValue("@NombreTipoTratamiento", nombre_tipo_tratamiento);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTipoVacuna(string nombre_tipo_vacuna)
        {
            const string sp = "SP_InsertTipoVacuna";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTipoVacuna", nombre_tipo_vacuna);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTipoVacuna(int id_tipo_vacuna,
                                        string nombre_tipo_vacuna)
        {
            const string sp = "SP_UpdateTipoVacuna";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTipoVacuna", id_tipo_vacuna);
                comando.Parameters.AddWithValue("@NombreTipoVacuna", nombre_tipo_vacuna);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTratamiento(int id_animal, int id_enfermedad,
                                         int id_tipo_tratamiento,
                                         DateTime fecha_inicio)
        {
            const string sp = "SP_InsertTratamiento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@EnfermedadIDEnfermedad", id_enfermedad);
                comando.Parameters.AddWithValue("@TipoTratamientoIDTipoTratamiento", id_tipo_tratamiento);
                comando.Parameters.AddWithValue("@FechaInicio", fecha_inicio);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTratamiento(int id_tratamiento, int id_animal,
                                         int id_enfermedad, int id_tipo_tratamiento,
                                         DateTime fecha_inicio)
        {
            const string sp = "SP_UpdateTratamiento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTratamiento", id_tratamiento);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@EnfermedadIDEnfermedad", id_enfermedad);
                comando.Parameters.AddWithValue("@TipoTratamientoIDTipoTratamiento", id_tipo_tratamiento);
                comando.Parameters.AddWithValue("@FechaInicio", fecha_inicio);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarTratamientoMedicamento(int id_tratamiento,
                                                    int id_medicamento,
                                                    decimal dosis)
        {
            const string sp = "SP_InsertTratamientoMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@TratamientoIDTratamiento", id_tratamiento);
                comando.Parameters.AddWithValue("@MedicamentoIDMedicamento", id_medicamento);
                comando.Parameters.AddWithValue("@Dosis", dosis);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarTratamientoMedicamento(int id_tratamiento_medicamento,
                                                    int id_tratamiento,
                                                    int id_medicamento,
                                                    decimal dosis)
        {
            const string sp = "SP_UpdateTratamientoMedicamento";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDTratamientoMedicamento", id_tratamiento_medicamento);
                comando.Parameters.AddWithValue("@TratamientoIDTratamiento", id_tratamiento);
                comando.Parameters.AddWithValue("@MedicamentoIDMedicamento", id_medicamento);
                comando.Parameters.AddWithValue("@Dosis", dosis);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarVacuna(string nombre_vacuna, int id_tipo_vacuna)
        {
            const string sp = "SP_InsertVacuna";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreVacuna", nombre_vacuna);
                comando.Parameters.AddWithValue("@TipoVacunaIDTipoVacuna", id_tipo_vacuna);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarVacuna(int id_vacuna, string nombre_vacuna,
                                    int id_tipo_vacuna)
        {
            const string sp = "SP_UpdateVacuna";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDVacuna", id_vacuna);
                comando.Parameters.AddWithValue("@NombreVacuna", nombre_vacuna);
                comando.Parameters.AddWithValue("@TipoVacunaIDTipoVacuna", id_tipo_vacuna);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool RegistrarVacunacion(int id_animal, int id_vacuna,
                                        DateTime fecha_vacunacion)
        {
            const string sp = "SP_InsertVacunacion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@VacunaIDVacuna", id_vacuna);
                comando.Parameters.AddWithValue("@FechaVacunacion", fecha_vacunacion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarVacunacion(int id_vacunacion, int id_animal,
                                        int id_vacuna, DateTime fecha_vacunacion)
        {
            const string sp = "SP_UpdateVacunacion";
            bool resultado;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDVacunacion", id_vacunacion);
                comando.Parameters.AddWithValue("@AnimalIDAnimal", id_animal);
                comando.Parameters.AddWithValue("@VacunaIDVacuna", id_vacuna);
                comando.Parameters.AddWithValue("@FechaVacunacion", fecha_vacunacion);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();
                resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public bool ModificarEstadoAnimal(int id_animal, int id_tipo_estado_animal)
        {
            const string sp = "SP_UpdateEstadoAnimal";
            bool resultado = false;

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sp, cn))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IDAnimal", id_animal);
                comando.Parameters.AddWithValue("@TipoEstadoAnimalIDTipoEstadoAnimal", id_tipo_estado_animal);

                SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                { Direction = ParameterDirection.Output };
                comando.Parameters.Add(salida);

                comando.ExecuteNonQuery();

                if (salida.Value != DBNull.Value)
                    resultado = (bool)salida.Value;
            }

            return resultado;
        }

        public DataTable ListaEstadoEnfermedadAnimal()
        {
            const string sp = "SP_V_EstadoEnfermoAnimal";
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

        public DataTable ListaAnimalCompra(int id_transaccion)
        {
            const string sp = "SP_V_ListaAnimalCompra";
            DataTable tabla = new DataTable();

            using (SqlConnection cn = csConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sp, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTransaccion", id_transaccion);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
