using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Productos
    {
        private int idProd;
        private string descripcion;
        private decimal precio;

        public int IdProd { get => idProd; set => idProd = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
