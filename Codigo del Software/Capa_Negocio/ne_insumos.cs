using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_insumos
    {
        public bool insumos_ins(Insumos obIns)
        {
            return new da_insumos().insumos_ins(obIns);
        }
        public ColeccionClases insumos_sel()
        {
            return new da_insumos().insumos_sel();
        }
        public ColeccionClases insumos_by_id(int idInsu)
        {
            return new da_insumos().insumos_by_id(idInsu);
        }
        public bool insumo_del(int idInsu)
        {
            return new da_insumos().insumo_del(idInsu);
        }
        public bool insumo_upd(Insumos obIns)
        {
            return new da_insumos().insumo_upd(obIns);
        }
    }
}
