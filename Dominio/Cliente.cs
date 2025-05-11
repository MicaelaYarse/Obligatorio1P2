using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Cliente: Usuario
    {
        private string _documento;
        private string _nombre;
        private string _nacionalidad;
        public Cliente(string documento, string nombre, string correo, string contrasenia, string nacionalidad)
            : base(correo, contrasenia)
        {
            _documento = documento;
            _nombre = nombre;
            _nacionalidad = nacionalidad;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_documento))
                throw new Exception("El documento no puede ser vacío");

            if (string.IsNullOrEmpty(_nombre))
                throw new Exception("El nombre no puede ser vacío");
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente otroCliente && _documento == otroCliente._documento;
        }

        public virtual string ObtenerDescripcion()
        {
            return $"{_nombre} - {Correo} - {_nacionalidad}";
        }

        public override string ToString()
        {
            return ObtenerDescripcion();
        }
    }
}

