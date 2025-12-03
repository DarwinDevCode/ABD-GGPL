using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negociacion
{
    public class csModuloAnimal
    {
        static csOperacionesAnimal clase_operacion_animal = new csOperacionesAnimal();
        static csConexionBD clase_conexion = new csConexionBD();
        //VISUALIZAR TABLA

        public DataTable ListaHectareas()
        {
            return clase_operacion_animal.ListaHectareas();
        }

        public DataTable ListaEstadoEnfermedadAnimal()
        {
            return clase_operacion_animal.ListaEstadoEnfermedadAnimal();
        }

        public DataTable ListaLotesAnimales()
        {
            return clase_operacion_animal.ListaLotesAnimales();
        }

        public DataTable ListaTiposAnimales()
        {
            return clase_operacion_animal.ListaTiposAnimales();
        }

        public DataTable ListaTiposEspecies()
        {
            return clase_operacion_animal.ListaTiposEspecies();
        }

        public DataTable ListaTiposRazas()
        {
            return clase_operacion_animal.ListaTiposRazas();
        }

        public DataTable ListaAnimales()
        {
            return clase_operacion_animal.ListaAnimales();
        }

        public DataTable ListaLotesInsumos()
        {
            return clase_operacion_animal.ListaLotesInsumos();
        }

        public DataTable ListaAnimalesEnfermedades()
        {
            return clase_operacion_animal.ListaAnimalesEnfermedades();
        }

        public DataTable VistaGeneralHectareasLotesAnimales()
        {
            return clase_operacion_animal.VistaGeneralHectareasLotesAnimales();
        }

        public DataTable ProduccionPorRazaAnimal()
        {
            return clase_operacion_animal.ProduccionPorRazaAnimal();
        }

        public DataTable ListaSaludGeneral()
        {
            return clase_operacion_animal.ListaSaludGeneral();
        }

        //LLENAR CAMPOS

        public DataTable ListaTiposRazasCombobox()
        {
            return clase_operacion_animal.ListaTiposRazasCombobox();
        }

        public DataTable ListaHectareasCombobox()
        {
            return clase_operacion_animal.ListaHectareasCombobox();
        }

        public DataTable ListaLotesAnimalesCombobox()
        {
            return clase_operacion_animal.ListaLotesAnimalesCombobox();
        }

        public DataTable ListaTiposLotesAnimalesCombobox()
        {
            return clase_operacion_animal.ListaTiposLotesAnimalesCombobox();
        }

        public DataTable ListaTiposEspeciesCombobox()
        {
            return clase_operacion_animal.ListaTiposEspeciesCombobox();
        }

        public DataTable ListaTipoEstadosCombobox()
        {
            return clase_operacion_animal.ListaTipoEstadosCombobox();
        }

        public DataTable ListaTipoLoteInsumosCombobox()
        {
            return clase_operacion_animal.ListaTipoLoteInsumosCombobox();
        }

        public DataTable ListaAnimalesCombobox()
        {
            return clase_operacion_animal.ListaAnimalesCombobox();
        }

        public DataTable ListaTipoEnfermedadesCombobox()
        {
            return clase_operacion_animal.ListaTipoEnfermedadesCombobox();
        }

        //INSERTAR Y ACTUALIZAR

        public bool RegistrarHectarea(string codigo, string area)
        {
            if (string.IsNullOrEmpty(codigo))
                throw new ArgumentException("El Codigo de la hectárea no ser nulo.");

            decimal areaDecimal;
            if (!decimal.TryParse(area, out areaDecimal))
                throw new ArgumentException("El Area Total de la Hectarea debe ser un valor decimal válido.");

            if (areaDecimal <= 0)
                throw new ArgumentException("El Area Total de la Hectarea debe ser un valor positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.RegistrarHectarea(codigo, areaDecimal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar la hectárea: {ex.Message}", ex);
            }
        }

        public bool ModificarHectarea(string id_hectarea, string codigo_hectarea, string area)
        {
            int idHectareaVal;
            if (!int.TryParse(id_hectarea, out idHectareaVal))
                throw new ArgumentException("El Id de la Hectárea debe ser un valor entero válido.");

            if (idHectareaVal <= 0)
                throw new ArgumentException("El Id de la Hectárea debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(codigo_hectarea))
                throw new ArgumentException("El Código de la Hectárea no puede estar vacío.");

            decimal areaDecimal;
            if (!decimal.TryParse(area, out areaDecimal))
                throw new ArgumentException("El Área de la Hectárea debe ser un valor decimal válido.");

            if (areaDecimal <= 0)
                throw new ArgumentException("El Área de la Hectárea debe ser un valor positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.ModificarHectarea(idHectareaVal, codigo_hectarea, areaDecimal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar la hectárea: {ex.Message}", ex);
            }
        }

        public bool RegistrarLoteAnimales(string codigo_lote, string id_hectarea, string id_tipo_lote_animal, string capacidad)
        {
            if (string.IsNullOrEmpty(codigo_lote))
                throw new ArgumentException("El parámetro @CodigoLote no puede estar vacío.");

            int idHectareaVal;
            if (!int.TryParse(id_hectarea, out idHectareaVal))
                throw new ArgumentException("El parámetro @IDHectarea debe ser un valor entero válido.");

            if (idHectareaVal <= 0)
                throw new ArgumentException("El parámetro @IDHectarea debe ser un entero positivo mayor que 0.");

            int idTipoLoteAnimalVal;
            if (!int.TryParse(id_tipo_lote_animal, out idTipoLoteAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoLoteAnimal debe ser un valor entero válido.");

            if (idTipoLoteAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoLoteAnimal debe ser un entero positivo mayor que 0.");

            int capacidadVal;
            if (!int.TryParse(capacidad, out capacidadVal))
                throw new ArgumentException("El parámetro @Capacidad debe ser un valor entero válido.");

            if (capacidadVal <= 0)
                throw new ArgumentException("El parámetro @Capacidad debe ser un entero positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.RegistrarLoteAnimales(codigo_lote, idHectareaVal, idTipoLoteAnimalVal, capacidadVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el lote de animales: {ex.Message}", ex);
            }
        }

        public bool ModificarLoteAnimales(string id_lote, string codigo_lote, string id_hectarea, string id_tipo_lote_animal, string capacidad)
        {
            int idLoteVal;
            if (!int.TryParse(id_lote, out idLoteVal))
                throw new ArgumentException("El parámetro @IDLote debe ser un valor entero válido.");

            if (idLoteVal <= 0)
                throw new ArgumentException("El parámetro @IDLote debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(codigo_lote))
                throw new ArgumentException("El parámetro @CodigoLote no puede estar vacío.");

            int idHectareaVal;
            if (!int.TryParse(id_hectarea, out idHectareaVal))
                throw new ArgumentException("El parámetro @IDHectarea debe ser un valor entero válido.");

            if (idHectareaVal <= 0)
                throw new ArgumentException("El parámetro @IDHectarea debe ser un entero positivo mayor que 0.");

            int idTipoLoteAnimalVal;
            if (!int.TryParse(id_tipo_lote_animal, out idTipoLoteAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoLoteAnimal debe ser un valor entero válido.");

            if (idTipoLoteAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoLoteAnimal debe ser un entero positivo mayor que 0.");

            int capacidadVal;
            if (!int.TryParse(capacidad, out capacidadVal))
                throw new ArgumentException("El parámetro @Capacidad debe ser un valor entero válido.");

            if (capacidadVal <= 0)
                throw new ArgumentException("El parámetro @Capacidad debe ser un entero positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.RegistrarLoteAnimales(codigo_lote, idHectareaVal, idTipoLoteAnimalVal, capacidadVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el lote de animales: {ex.Message}", ex);
            }
        }

        public bool RegistrarLoteInsumo(string codigo_lote, string id_tipo_lote, string distribuidor, string fecha_fabricacion, string fecha_caducidad, string fecha_hora_registro)
        {
            if (string.IsNullOrEmpty(codigo_lote))
                throw new ArgumentException("El parámetro @CodigoLote no puede estar vacío.");

            int idTipoLoteVal;
            if (!int.TryParse(id_tipo_lote, out idTipoLoteVal))
                throw new ArgumentException("El parámetro @IDTipoLote debe ser un valor entero válido.");

            if (idTipoLoteVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoLote debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(distribuidor))
                throw new ArgumentException("El parámetro @Distribuidor no puede estar vacío.");

            DateTime fechaFabricacionVal;
            if (!DateTime.TryParse(fecha_fabricacion, out fechaFabricacionVal))
                throw new ArgumentException("El parámetro @FechaFabricacion debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaFabricacionVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaFabricacion no puede ser una fecha futura.");

            DateTime fechaCaducidadVal;
            if (!DateTime.TryParse(fecha_caducidad, out fechaCaducidadVal))
                throw new ArgumentException("El parámetro @FechaCaducidad debe ser una fecha válida.");

            if (fechaCaducidadVal <= fechaFabricacionVal)
                throw new ArgumentException("El parámetro @FechaCaducidad debe ser posterior a la fecha de fabricación.");

            DateTime fechaHoraRegistroVal;
            if (!DateTime.TryParse(fecha_hora_registro, out fechaHoraRegistroVal))
                throw new ArgumentException("El parámetro @FechaHoraRegistro debe ser una fecha y hora válida.");

            if (fechaHoraRegistroVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaHoraRegistro no puede ser una fecha futura.");

            try
            {
                return clase_operacion_animal.RegistrarLoteInsumo(codigo_lote, idTipoLoteVal, distribuidor, fechaFabricacionVal, fechaCaducidadVal, fechaHoraRegistroVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el lote de insumo: {ex.Message}", ex);
            }
        }

        public bool ModificarLoteInsumo(string id_lote_insumo, string codigo_lote_insumo, string id_tipo_lote_insumo, string distribuidor, string fecha_fabricacion_lote, string fecha_caducidad_lote, string fecha_hora_regitro_lote)
        {
            int idLoteInsumoVal;
            if (!int.TryParse(id_lote_insumo, out idLoteInsumoVal))
                throw new ArgumentException("El parámetro @IDLoteInsumo debe ser un valor entero válido.");

            if (idLoteInsumoVal <= 0)
                throw new ArgumentException("El parámetro @IDLoteInsumo debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(codigo_lote_insumo))
                throw new ArgumentException("El parámetro @CodigoLoteInsumo no puede estar vacío.");

            int idTipoLoteInsumoVal;
            if (!int.TryParse(id_tipo_lote_insumo, out idTipoLoteInsumoVal))
                throw new ArgumentException("El parámetro @IDTipoLoteInsumo debe ser un valor entero válido.");

            if (idTipoLoteInsumoVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoLoteInsumo debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(distribuidor))
                throw new ArgumentException("El parámetro @Distribuidor no puede estar vacío.");

            DateTime fechaFabricacionLoteVal;
            if (!DateTime.TryParse(fecha_fabricacion_lote, out fechaFabricacionLoteVal))
                throw new ArgumentException("El parámetro @FechaFabricacionLote debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaFabricacionLoteVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaFabricacionLote no puede ser una fecha futura.");

            DateTime fechaCaducidadLoteVal;
            if (!DateTime.TryParse(fecha_caducidad_lote, out fechaCaducidadLoteVal))
                throw new ArgumentException("El parámetro @FechaCaducidadLote debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaCaducidadLoteVal <= fechaFabricacionLoteVal)
                throw new ArgumentException("El parámetro @FechaCaducidadLote debe ser posterior a la fecha de fabricación.");

            DateTime fechaHoraRegitroLoteVal;
            if (!DateTime.TryParse(fecha_hora_regitro_lote, out fechaHoraRegitroLoteVal))
                throw new ArgumentException("El parámetro @FechaHoraRegitroLote debe ser una fecha y hora válida (formato: yyyy-MM-dd HH:mm:ss).");

            if (fechaHoraRegitroLoteVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaHoraRegitroLote no puede ser una fecha futura.");

            try
            {
                return clase_operacion_animal.ModificarLoteInsumo(idLoteInsumoVal, codigo_lote_insumo, idTipoLoteInsumoVal, distribuidor, fechaFabricacionLoteVal, fechaCaducidadLoteVal, fechaHoraRegitroLoteVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el lote de insumo: {ex.Message}", ex);
            }
        }

        public (bool, int) RegistrarAnimal(string codigo_animal, string id_lote_animales, string id_tipo_raza_animal, string sexo, string fecha_nacimiento, string fecha_hora_registro, string id_tipo_estado_animal)
        {
            if (string.IsNullOrEmpty(codigo_animal))
                throw new ArgumentException("El parámetro @CodigoAnimal no puede estar vacío.");

            int idLoteAnimalesVal;
            if (!int.TryParse(id_lote_animales, out idLoteAnimalesVal))
                throw new ArgumentException("El parámetro @IDLoteAnimales debe ser un valor entero válido.");

            if (idLoteAnimalesVal <= 0)
                throw new ArgumentException("El parámetro @IDLoteAnimales debe ser un entero positivo mayor que 0.");

            int idTipoRazaAnimalVal;
            if (!int.TryParse(id_tipo_raza_animal, out idTipoRazaAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un valor entero válido.");

            if (idTipoRazaAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(sexo))
                throw new ArgumentException("El parámetro @Sexo no puede estar vacío.");

            char sexoVal;
            if (!char.TryParse(sexo, out sexoVal) && sexo != "M" && sexo != "H")
                throw new ArgumentException("El parámetro @Sexo debe ser 'M' (macho) o 'H' (hembra).");

            DateTime fechaNacimientoVal;
            if (!DateTime.TryParse(fecha_nacimiento, out fechaNacimientoVal))
                throw new ArgumentException("El parámetro @FechaNacimiento debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaNacimientoVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaNacimiento no puede ser una fecha futura.");

            DateTime fechaHoraRegistroVal;
            if (!DateTime.TryParse(fecha_hora_registro, out fechaHoraRegistroVal))
                throw new ArgumentException("El parámetro @FechaHoraRegistro debe ser una fecha y hora válida (formato: yyyy-MM-dd HH:mm:ss).");

            if (fechaHoraRegistroVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaHoraRegistro no puede ser una fecha futura.");

            int idTipoEstadoAnimalVal;
            if (!int.TryParse(id_tipo_estado_animal, out idTipoEstadoAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoEstadoAnimal debe ser un valor entero válido.");

            if (idTipoEstadoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEstadoAnimal debe ser un entero positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.RegistrarAnimal(codigo_animal, idLoteAnimalesVal, idTipoRazaAnimalVal, sexoVal, fechaNacimientoVal, fechaHoraRegistroVal, idTipoEstadoAnimalVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el animal: {ex.Message}", ex);
            }
        }

        public bool ModificarAnimal(string id_animal, string codigo_animal, string id_lote_animales, string id_tipo_raza_animal, string sexo, string fecha_nacimiento, string fecha_hora_registro, string id_tipo_estado_animal)
        {
            int idAnimalVal;
            if (!int.TryParse(id_animal, out idAnimalVal))
                throw new ArgumentException("El parámetro @IDAnimal debe ser un valor entero válido.");

            if (idAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(codigo_animal))
                throw new ArgumentException("El parámetro @CodigoAnimal no puede estar vacío.");

            int idLoteAnimalesVal;
            if (!int.TryParse(id_lote_animales, out idLoteAnimalesVal))
                throw new ArgumentException("El parámetro @IDLoteAnimales debe ser un valor entero válido.");

            if (idLoteAnimalesVal <= 0)
                throw new ArgumentException("El parámetro @IDLoteAnimales debe ser un entero positivo mayor que 0.");

            int idTipoRazaAnimalVal;
            if (!int.TryParse(id_tipo_raza_animal, out idTipoRazaAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un valor entero válido.");

            if (idTipoRazaAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(sexo))
                throw new ArgumentException("El parámetro @Sexo no puede estar vacío.");

            char sexoVal;
            if (!char.TryParse(sexo, out sexoVal) && sexo != "M" && sexo != "H")
                throw new ArgumentException("El parámetro @Sexo debe ser 'M' (macho) o 'H' (hembra).");

            DateTime fechaNacimientoVal;
            if (!DateTime.TryParse(fecha_nacimiento, out fechaNacimientoVal))
                throw new ArgumentException("El parámetro @FechaNacimiento debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaNacimientoVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaNacimiento no puede ser una fecha futura.");

            DateTime fechaHoraRegistroVal;
            if (!DateTime.TryParse(fecha_hora_registro, out fechaHoraRegistroVal))
                throw new ArgumentException("El parámetro @FechaHoraRegistro debe ser una fecha y hora válida (formato: yyyy-MM-dd HH:mm:ss).");

            if (fechaHoraRegistroVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaHoraRegistro no puede ser una fecha futura.");

            int idTipoEstadoAnimalVal;
            if (!int.TryParse(id_tipo_estado_animal, out idTipoEstadoAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoEstadoAnimal debe ser un valor entero válido.");

            if (idTipoEstadoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEstadoAnimal debe ser un entero positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.ModificarAnimal(idAnimalVal, codigo_animal, idLoteAnimalesVal, idTipoRazaAnimalVal, sexoVal, fechaNacimientoVal, fechaHoraRegistroVal, idTipoEstadoAnimalVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el animal: {ex.Message}", ex);
            }
        }

        public bool RegistrarTipoAnimal(string nombre_tipo_animal)
        {
            if (string.IsNullOrEmpty(nombre_tipo_animal))
                throw new ArgumentException("El parámetro @NombreRaza no puede estar vacío.");

            try
            {
                return clase_operacion_animal.RegistrarTipoAnimal(nombre_tipo_animal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el tipo de animal: {ex.Message}", ex);
            }
        }

        public bool ModificarTipoAnimal(string id_tipo_animal, string nombre_tipo_animal)
        {
            int idTipoAnimalVal;
            if (!int.TryParse(id_tipo_animal, out idTipoAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un valor entero válido.");

            if (idTipoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(nombre_tipo_animal))
                throw new ArgumentException("El parámetro @NombreTipoAnimal no puede estar vacío.");

            try
            {
                return clase_operacion_animal.ModificarTipoAnimal(idTipoAnimalVal, nombre_tipo_animal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el tipo de animal: {ex.Message}", ex);
            }
        }

        public bool RegistrarTipoEspecieAnimal(string id_tipo_animal, string nombre_especie)
        {
            int idTipoAnimalVal;
            if (!int.TryParse(id_tipo_animal, out idTipoAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un valor entero válido.");

            if (idTipoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(nombre_especie))
                throw new ArgumentException("El parámetro @NombreEspecie no puede estar vacío.");

            try
            {
                return clase_operacion_animal.RegistrarTipoEspecieAnimal(idTipoAnimalVal, nombre_especie);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el tipo de especie animal: {ex.Message}", ex);
            }
        }

        public bool ModificarTipoEspecieAnimal(string id_tipo_especie_animal, string id_tipo_animal, string nombre_especie)
        {
            int idTipoEspecieAnimalVal;
            if (!int.TryParse(id_tipo_especie_animal, out idTipoEspecieAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un valor entero válido.");

            if (idTipoEspecieAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un entero positivo mayor que 0.");

            int idTipoAnimalVal;
            if (!int.TryParse(id_tipo_animal, out idTipoAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un valor entero válido.");

            if (idTipoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(nombre_especie))
                throw new ArgumentException("El parámetro @NombreEspecie no puede estar vacío.");

            try
            {
                return clase_operacion_animal.ModificarTipoEspecieAnimal(idTipoEspecieAnimalVal, idTipoAnimalVal, nombre_especie);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el tipo de especie animal: {ex.Message}", ex);
            }
        }

        public bool RegistrarTipoRazaAnimal(string id_tipo_especie_animal, string nombre_raza)
        {
            int idTipoEspecieAnimalVal;
            if (!int.TryParse(id_tipo_especie_animal, out idTipoEspecieAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un valor entero válido.");

            if (idTipoEspecieAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(nombre_raza))
                throw new ArgumentException("El parámetro @NombreRaza no puede estar vacío.");

            try
            {
                return clase_operacion_animal.RegistrarTipoRazaAnimal(idTipoEspecieAnimalVal, nombre_raza);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el tipo de raza animal: {ex.Message}", ex);
            }
        }

        public bool ModificarTipoRazaAnimal(string id_tipo_raza_animal, string nombre_raza, string id_tipo_especie_animal)
        {
            int idTipoRazaAnimalVal;
            if (!int.TryParse(id_tipo_raza_animal, out idTipoRazaAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un valor entero válido.");

            if (idTipoRazaAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoRazaAnimal debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrEmpty(nombre_raza))
                throw new ArgumentException("El parámetro @NombreRaza no puede estar vacío.");

            int idTipoEspecieAnimalVal;
            if (!int.TryParse(id_tipo_especie_animal, out idTipoEspecieAnimalVal))
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un valor entero válido.");

            if (idTipoEspecieAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEspecieAnimal debe ser un entero positivo mayor que 0.");

            try
            {
                return clase_operacion_animal.ModificarTipoRazaAnimal(idTipoRazaAnimalVal, nombre_raza, idTipoEspecieAnimalVal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el tipo de raza animal: {ex.Message}", ex);
            }
        }

        public bool RegistrarEnfermedad(int id_animal, int id_tipo_enfermedad, string observaciones, DateTime fecha_hora_registro)
        {
            return clase_operacion_animal.RegistrarEnfermedad(id_animal, id_tipo_enfermedad, observaciones, fecha_hora_registro);
        }

        public bool RegistrarSaludGeneral(string id_animal, string peso_animal, string condicion_corporal, string fecha_registro, string fecha_proxima_revision, string temperatura_animal, string frecuencia_cardiaca, string frecuencia_respiratoria, string observacion_mucosas)
        {
            int idAnimalVal;
            if (!int.TryParse(id_animal, out idAnimalVal))
                throw new ArgumentException("El parámetro @IDAnimal debe ser un valor entero válido.");

            if (idAnimalVal <= 0)
                throw new ArgumentException("El parámetro @IDAnimal debe ser un entero positivo mayor que 0.");

            decimal pesoAnimalVal;
            if (!decimal.TryParse(peso_animal, out pesoAnimalVal))
                throw new ArgumentException("El parámetro @PesoAnimal debe ser un valor decimal válido.");

            if (pesoAnimalVal <= 0)
                throw new ArgumentException("El parámetro @PesoAnimal debe ser un valor positivo mayor que 0.");

            if (string.IsNullOrEmpty(condicion_corporal))
                throw new ArgumentException("El parámetro @CondicionCorporal no puede estar vacío.");

            DateTime fechaRegistroVal;
            if (!DateTime.TryParse(fecha_registro, out fechaRegistroVal))
                throw new ArgumentException("El parámetro @FechaRegistro debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaRegistroVal > DateTime.Now)
                throw new ArgumentException("El parámetro @FechaRegistro no puede ser una fecha futura.");

            DateTime fechaProximaRevisionVal;
            if (!DateTime.TryParse(fecha_proxima_revision, out fechaProximaRevisionVal))
                throw new ArgumentException("El parámetro @FechaProximaRevision debe ser una fecha válida (formato: yyyy-MM-dd).");

            if (fechaProximaRevisionVal <= fechaRegistroVal)
                throw new ArgumentException("El parámetro @FechaProximaRevision debe ser posterior a la fecha de registro.");

            decimal temperaturaAnimalVal;
            if (!decimal.TryParse(temperatura_animal, out temperaturaAnimalVal))
                throw new ArgumentException("El parámetro @TemperaturaAnimal debe ser un valor decimal válido.");

            if (temperaturaAnimalVal < 30.0m || temperaturaAnimalVal > 42.0m)
                throw new ArgumentException("El parámetro @TemperaturaAnimal debe estar entre 35.0 y 42.0 grados Celsius.");

            int frecuenciaCardiacaVal;
            if (!int.TryParse(frecuencia_cardiaca, out frecuenciaCardiacaVal))
                throw new ArgumentException("El parámetro @FrecuenciaCardiaca debe ser un valor entero válido.");

            if (frecuenciaCardiacaVal <= 0)
                throw new ArgumentException("El parámetro @FrecuenciaCardiaca debe ser un entero positivo mayor que 0.");

            if (frecuenciaCardiacaVal < 10 || frecuenciaCardiacaVal > 200)
                throw new ArgumentException("El parámetro @FrecuenciaCardiaca debe estar entre 30 y 200 latidos por minuto.");

            int frecuenciaRespiratoriaVal;
            if (!int.TryParse(frecuencia_respiratoria, out frecuenciaRespiratoriaVal))
                throw new ArgumentException("El parámetro @FrecuenciaRespiratoria debe ser un valor entero válido.");

            if (frecuenciaRespiratoriaVal <= 0)
                throw new ArgumentException("El parámetro @FrecuenciaRespiratoria debe ser un entero positivo mayor que 0.");

            if (frecuenciaRespiratoriaVal < 10 || frecuenciaRespiratoriaVal > 100)
                throw new ArgumentException("El parámetro @FrecuenciaRespiratoria debe estar entre 10 y 100 respiraciones por minuto.");

            if (string.IsNullOrEmpty(observacion_mucosas))
                throw new ArgumentException("El parámetro @ObservacionMucosas no puede estar vacío.");

            try
            {
                return clase_operacion_animal.RegistrarSaludGeneral(idAnimalVal, pesoAnimalVal, condicion_corporal, fechaRegistroVal, fechaProximaRevisionVal, temperaturaAnimalVal, frecuenciaCardiacaVal, frecuenciaRespiratoriaVal, observacion_mucosas);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar la salud general y signos clínicos: {ex.Message}", ex);
            }
        }


        public bool ModificarEstadoAnimal(int id_animal, int id_tipo_estado_animal)
        {
            if (id_animal <= 0)
                throw new ArgumentException("El parámetro @IDAnimal debe ser un entero positivo mayor que 0");

            if (id_tipo_estado_animal <= 0)
                throw new ArgumentException("El parámetro @IDTipoEstadoAnimal debe ser un entero positivo mayor que 0");

            try
            {
                return clase_operacion_animal.ModificarEstadoAnimal(id_animal, id_tipo_estado_animal);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al modificar el estado del animal (BD): {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el estado del animal: {ex.Message}", ex);
            }
        }


        public bool ModificarEnfermedad(int id_enfermedad, int id_animal,
                                        int id_tipo_enfermedad, string observaciones)
        {
            if (id_enfermedad <= 0)
                throw new ArgumentException("El parámetro @IDEnfermedad debe ser un entero positivo mayor que 0.");

            if (id_animal <= 0)
                throw new ArgumentException("El parámetro @IDAnimal debe ser un entero positivo mayor que 0.");

            if (id_tipo_enfermedad <= 0)
                throw new ArgumentException("El parámetro @IDTipoEnfermedad debe ser un entero positivo mayor que 0.");

            if (string.IsNullOrWhiteSpace(observaciones))
                throw new ArgumentException("El parámetro @ObservacionEnfermedad no puede estar vacío.");

            if (observaciones.Length > 100)
                throw new ArgumentException("El parámetro @ObservacionEnfermedad no puede superar los 100 caracteres.");

            try
            {
                return clase_operacion_animal.ModificarEnfermedad(id_enfermedad, id_animal, id_tipo_enfermedad, observaciones);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al modificar la enfermedad (BD): {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar la enfermedad: {ex.Message}", ex);
            }
        }

        public DataTable ListaAnimalCompra(int id_transaccion)
        {
            return clase_operacion_animal.ListaAnimalCompra(id_transaccion);
        }

    }

}
