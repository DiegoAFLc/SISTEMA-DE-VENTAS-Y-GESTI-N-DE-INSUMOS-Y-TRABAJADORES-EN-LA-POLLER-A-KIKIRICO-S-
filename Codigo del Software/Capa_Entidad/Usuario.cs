using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        private int idUsuario;
        private string nidenti;
        private string usuarios;
        private string contraseña;
        private int idTipo;
       

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        
        public string Nidenti { get => nidenti; set => nidenti = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
