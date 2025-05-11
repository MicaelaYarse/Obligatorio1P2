using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {
        private string _apodo;

        public Administrador(string email, string contrasena, string apodo)
           : base(email, contrasena)
        {
            _apodo = apodo;
        }
    }
}
