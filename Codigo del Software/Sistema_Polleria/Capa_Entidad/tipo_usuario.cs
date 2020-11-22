using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class tipo_usuario
    {
        private int idTipo;
        private string descripcion;

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
