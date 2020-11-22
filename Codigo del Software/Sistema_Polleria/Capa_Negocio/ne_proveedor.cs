using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_proveedor
    {
        public bool proveedor_ins(Proveedor obPro)
        {
            return new da_proveedor().proveedor_ins(obPro);
        }
        public ColeccionClases proveedor_sel()
        {
            return new da_proveedor().proveedor_sel();
        }
        public ColeccionClases proveedor_sel_especial(string texto)
        {
            return new da_proveedor().proveedor_sel_especial(texto);
        }
        public string proveedor_sel_by_id(int idtra)
        {
            return new da_proveedor().proveedor_sel_by_id(idtra);
        }
    }
}
