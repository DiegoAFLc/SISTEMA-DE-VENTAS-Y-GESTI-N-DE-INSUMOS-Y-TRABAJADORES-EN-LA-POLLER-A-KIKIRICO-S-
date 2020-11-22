using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_productos
    {
        public ColeccionClases productos_sel()
        {
            return new da_productos().productos_sel();
        }
        public bool productos_udp(Productos obPro)
        {
            return new da_productos().productos_upd(obPro);
        }
    }
}
