using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Proveedor
    {
        private int idempresa;
        private string empresa;
        private string tipreg;
        private int nreg;
        private string correo;
        private string direccion;
        private string tipoprod;

        public string Empresa { get => empresa; set => empresa = value; }
        public string Tipreg { get => tipreg; set => tipreg = value; }
        public int Nreg { get => nreg; set => nreg = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Tipoprod { get => tipoprod; set => tipoprod = value; }
        public int Idempresa { get => idempresa; set => idempresa = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
