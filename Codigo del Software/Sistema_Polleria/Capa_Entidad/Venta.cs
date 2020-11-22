using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        private string id_venta;
        private string cliente;
        private string met_pago;
        private int id_vend;
        private string vale;
        private decimal total;
        private DateTime fecha_emision;
        private string vendedor;
        private string estado;
        public string Cliente { get => cliente; set => cliente = value; }
        public string Met_pago { get => met_pago; set => met_pago = value; }
        public int Id_vend { get => id_vend; set => id_vend = value; }
        public string Vale { get => vale; set => vale = value; }
        public decimal Total { get => total; set => total = value; }
        public string Id_venta { get => id_venta; set => id_venta = value; }
        public DateTime Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
