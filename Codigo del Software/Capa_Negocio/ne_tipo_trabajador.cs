using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_tipo_trabajador
    {
        public ColeccionClases tipo_usuario()
        {
            return new da_tipo_usuario().tipo_usuario();
        }
    }
}
