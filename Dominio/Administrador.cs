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
    
    public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_apodo))
                throw new Exception("El apodo no puede ser vacío");
            if (string.IsNullOrEmpty(Correo))
                throw new Exception("El correo no puede ser vacío");
            if (Correo.IndexOf("@") == -1)
                throw new Exception("El correo no está en el formato correcto");
            if (string.IsNullOrEmpty(Contrasenia))
                throw new Exception("La contraseña no puede ser vacía");

        }
        public override bool Equals(object? obj)
        {
            return obj is Administrador otroAdmin&& _apodo == otroAdmin._apodo;
        }
    } }
