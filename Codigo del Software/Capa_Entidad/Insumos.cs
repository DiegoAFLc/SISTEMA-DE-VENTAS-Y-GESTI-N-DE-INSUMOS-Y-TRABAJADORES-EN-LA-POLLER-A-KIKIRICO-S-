using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Insumos
    {
        private int idInsumo;
        private string codInsumo;
        private DateTime fecha_reg;
        private string insumo;
        private string tipo_cant;
        private int cantidad;
        private string descripcion;
        private int idempresa;
        private string empresa;

        public int IdInsumo { get => idInsumo; set => idInsumo = value; }
        public string CodInsumo { get => codInsumo; set => codInsumo = value; }
        public DateTime Fecha_reg { get => fecha_reg; set => fecha_reg = value; }
        public string Insumo { get => insumo; set => insumo = value; }
        public string Tipo_cant { get => tipo_cant; set => tipo_cant = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Idempresa { get => idempresa; set => idempresa = value; }
        public string Empresa { get => empresa; set => empresa = value; }
    }
}
