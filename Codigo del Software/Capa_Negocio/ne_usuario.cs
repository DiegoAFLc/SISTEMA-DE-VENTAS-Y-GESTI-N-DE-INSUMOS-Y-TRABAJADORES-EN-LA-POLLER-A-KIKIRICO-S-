using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_usuario
    {
        public bool validar_usuario(string usuario,string contraseña)
        {
            return new da_usuario().validar_usuario(usuario, contraseña);
        }
        public ColeccionClases usuario_sel()
        {
            return new da_usuario().usuario_sel();
        }
        public string val_tipo_us(string us, string contra)
        {
            return new da_usuario().val_tipo_us(us, contra);
        }
        public string nombre_usuarios(string us, string contraseña)
        {
            return new da_usuario().nombre_usuarios(us, contraseña);
        }
        public bool usuario_ins(Usuario obUs)
        {
            return new da_usuario().usuario_ins(obUs);
        }
    }
}
