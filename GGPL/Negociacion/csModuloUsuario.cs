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
    public class csModuloUsuario
    {
        static csOperacionesUsuario clase_operacion_usuario = new csOperacionesUsuario();
        static csConexionBD data_base = new csConexionBD();

        public (object, object, bool) VerificarCredenciales(string usuario, string contraseña)
        {
            return clase_operacion_usuario.VerificarCredenciales(usuario, contraseña);
        }

        public DataTable ListaUsuarios()
        {
            return clase_operacion_usuario.ListaUsuarios();
        }

        public DataTable ListaRoles()
        {
            return clase_operacion_usuario.ListaRoles();
        }

        public bool RegistrarUsuario(int id_tipo_usuario, string cedula, string nombre, string apellido, char genero, DateTime fecha_nacimiento, string celular, string correo, string credencial_usuario, string credencial_contraseña)
        {
            return clase_operacion_usuario.RegistrarUsuario(id_tipo_usuario, cedula, nombre, apellido, genero, fecha_nacimiento, celular, correo, credencial_usuario, credencial_contraseña);
        }

        public bool ModificarUsuario(int id_usuario, int id_tipo_usuario, string cedula, string nombre, string apellido, char genero, DateTime fecha_nacimiento, string celular, string correo, string credencial_usuario, string credencial_contraseña)
        {
            return clase_operacion_usuario.ModificarUsuario(id_usuario, id_tipo_usuario, cedula, nombre, apellido, genero, fecha_nacimiento, celular, correo, credencial_usuario, credencial_contraseña);
        }
    }
}
