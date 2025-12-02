using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negociacion
{
    public class csModuloProduccionLechera
    {
        csOperacionesProduccionLechera clase_operacion_produccion_lechera = new csOperacionesProduccionLechera();

        public DataTable ListaProduccionLechera()
        {
            return clase_operacion_produccion_lechera.ListaProduccionLechera();
        }

        public DataTable ObtenerAnimales()
        {
            return clase_operacion_produccion_lechera.ObtenerAnimales();
        }

        public DataTable ListaAnimalesHembras()
        {
            return clase_operacion_produccion_lechera.ListaAnimalesHembras();
        }

        public bool RegistrarProduccionLechera(int id_usuario, int id_animal, decimal cantidad_litros, char tipo_ordeño, DateTime fecha_hora_ordeño)
        {
            return clase_operacion_produccion_lechera.RegistrarProduccionLechera(id_usuario, id_animal, cantidad_litros, tipo_ordeño, fecha_hora_ordeño);
        }

        public bool ModificarProduccionLechera(int id_produccion, int id_usuario, int id_animal, decimal cantidad_litros, char tipo_ordeño, DateTime fecha_hora_ordeño)
        {
            return clase_operacion_produccion_lechera.ModificarProduccionLechera(id_produccion, id_usuario, id_animal, cantidad_litros, tipo_ordeño, fecha_hora_ordeño);
        }
    }
}
