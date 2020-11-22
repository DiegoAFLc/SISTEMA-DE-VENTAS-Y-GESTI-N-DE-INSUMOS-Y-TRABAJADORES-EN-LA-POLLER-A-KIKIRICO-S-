using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ne_ventas
    {
        public bool ventas_ins(Venta v)
        {
            return new da_ventas().ventas_ins(v);
        }
        public ColeccionClases ventas_sel()
        {
            return new da_ventas().ventas_sel();
        }
        public ColeccionClases sel_by_idventa(string id_venta) 
        {
            return new da_ventas().sel_by_ideventa(id_venta);
        }
        public bool pagar_pedido(string id_venta)
        {
            return new da_ventas().pagar_pedido(id_venta);
        }
        public ColeccionClases vent_sel_unica(DateTime fecha_ini)
        {
            return new da_ventas().vent_sel_unica(fecha_ini);
        }
        public ColeccionClases vent_sel_intervalo(DateTime fecha_ini,DateTime fecha_fin)
        {
            return new da_ventas().vent_sel_intervalo(fecha_ini,fecha_fin);
        }
        public bool ventas_del(string id_Venta)
        {
            return new da_ventas().ventas_del(id_Venta);
        }
        public bool ventas_udp(Venta v)
        {
            return new da_ventas().ventas_udp(v);
        }

    }
}
