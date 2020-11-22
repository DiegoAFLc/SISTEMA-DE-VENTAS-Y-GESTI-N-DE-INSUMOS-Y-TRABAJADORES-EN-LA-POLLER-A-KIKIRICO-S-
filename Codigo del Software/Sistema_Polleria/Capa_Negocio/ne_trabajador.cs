using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_trabajador
    {
        public bool trabajador_ins(Trabajador obTra)
        {
            return new da_trabajador().trabajador_ins(obTra);
        }
        public ColeccionClases trabajador_sel()
        {
            return new da_trabajador().trabajador_sel();
        }
        public ColeccionClases filtrado_trabajador(string texto)
        {
            return new da_trabajador().filtrado_trabajador(texto);
        }
        public bool trabajador_del(int idTra)
        {
            return new da_trabajador().trabajador_del(idTra);
        }
        public ColeccionClases trabajador_sel_by_idtra(int idTra)
        {
            return new da_trabajador().trabajador_sel_by_idtra(idTra);
        }
        public ColeccionClases prueba()
        {
            return new da_trabajador().prueba();
        }
        public ColeccionClases trabajador_Get()
        {
            return new da_trabajador().trabajador_Get();
        }
    }
}
