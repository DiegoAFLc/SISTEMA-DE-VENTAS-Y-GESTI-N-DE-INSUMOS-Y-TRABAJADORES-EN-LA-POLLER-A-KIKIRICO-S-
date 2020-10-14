using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Trabajador
    {
        private int idTrab;
        private string nombres;
        private string apellidos;
        private string tipodoc;
        private int edad;
        private int nidentidad;
        private string correo;
        private string puesto;
        private string modalidad;
        private string rutaimage;
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Tipodoc { get => tipodoc; set => tipodoc = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Nidentidad { get => nidentidad; set => nidentidad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public string Rutaimage { get => rutaimage; set => rutaimage = value; }
        public int IdTrab { get => idTrab; set => idTrab = value; }
    }
}
