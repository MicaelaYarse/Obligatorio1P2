using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Pasaje
    {
        private int _idPasaje = ultId++;
        private Vuelo _vuelo;
        private DateOnly _fecha;
        private Cliente _pasajero;
        private decimal _precio;
        static int ultId = 0;
        public Pasaje()
        {
            
        }
        // Costo base = costo x asiento
        // costo base + 25% margen ganancias + 10% equipaje cabina o 20% equipaje bodega.
        // Clientes premium solo pagan 5% por equipaje bodega
        // Se debe tener en cuenta tasas aeroportuarias
      
    }
}
