using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negociacion
{
    public class csModuloTransacccion
    {
        static csOperacionesTransaccion clase_modulo_compra_venta = new csOperacionesTransaccion();

        public DataTable CargarDatosTablaCompra()
        {
            return clase_modulo_compra_venta.CargarDatosTablaCompra();
        }

        public DataTable ObtenerTipoPago()
        {
            return clase_modulo_compra_venta.ObtenerTipoPago();
        }

        public bool RegistrarTransaccionVentaAnimal(int id_transaccion, int id_animal, decimal valor_animal)
        {
            return clase_modulo_compra_venta.RegistrarTransaccionVentaAnimal(id_transaccion, id_animal, valor_animal);
        }

        public (bool, int) RegistrarTransaccion(int id_usuario, char tipo_transaccion, int id_tipo_pago, int cantidad_animales, decimal valor_total, DateTime fecha_hora_registro)
        {
            return clase_modulo_compra_venta.RegistrarTransaccion(id_usuario, tipo_transaccion, id_tipo_pago, cantidad_animales, valor_total, fecha_hora_registro);
        }

        public DataTable CargarDatosTablaVenta()
        {
            return clase_modulo_compra_venta.CargarDatosTablaVenta();
        }

        public DataTable CargarDatosTablaVentaAnimales()
        {
            return clase_modulo_compra_venta.CargarDatosTablaVentaAnimales();
        }

        public bool ActualizarEstadoAnimalVenta(int id_animal)
        {
            return clase_modulo_compra_venta.ActualizarEstadoAnimalVenta(id_animal);
        }
    }
}
