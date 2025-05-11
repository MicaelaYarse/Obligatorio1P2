using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteOcasional : Cliente
    {
        public bool TieneRegalo { get; set; }

        public ClienteOcasional(string documento, string nombre, string correo, string contrasenia, string nacionalidad, bool tieneRegalo)
            : base(documento, nombre, correo, nombre, nacionalidad)
        {
            TieneRegalo = tieneRegalo;
        }

        public override string ObtenerDescripcion()
        {
            string regalo = TieneRegalo ? "Sí" : "No";
            return base.ObtenerDescripcion() + $" - Tipo: Ocasional - Tiene regalo de cabina: {regalo}";
        }
    }
}