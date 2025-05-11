using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private string _correo;
        private string _contrasenia;
        
        public string Correo
        {
            get { return _correo; }
        }
         public string Contrasenia
        {
            get { return _contrasenia; }
        }

        public Usuario(string correo, string contrasenia)
        {
            _correo = correo;
            _contrasenia = contrasenia;
        }
    }
}
