using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClientePremium : Cliente
    {
        private int _saldoPuntos;

        public ClientePremium(string documento, string nombre, string correo, string contrasenia, string nacionalidad, int saldo)
        : base(documento, nombre, correo, contrasenia, nacionalidad)
        {
            _saldoPuntos = saldo;
        }
        public override void Validar()
        {
            base.Validar();
            if (_saldoPuntos<0)
                throw new Exception("El número de puntos no puede ser negativo");

        }
        public override string ObtenerDescripcion()
        {
            return base.ObtenerDescripcion() + $" - Tipo: Premium - Saldo ${_saldoPuntos}";
        }
    }
}

