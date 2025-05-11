using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

        public class Pasaje
        {
            static int ultId = 0;
            private int _idPasaje;
        private Vuelo _vuelo;
        private DateTime _fecha;
        private Cliente _pasajero;
        private decimal _precio;
        private TipoEquipaje _tipoEquipaje;
       

        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente pasajero, TipoEquipaje equipaje)
        {
            // Generar ID autoincremental
            ultId++;
            _idPasaje = ultId;
            _vuelo = vuelo;
            _fecha = fecha;
            _pasajero = pasajero;
            _tipoEquipaje = equipaje;
            _precio = CalcularPrecio();
        }
        public void Validar()
        {
           

        }

        public override bool Equals(object? obj)
        {
            return obj is Pasaje otroPasaje && _idPasaje == otroPasaje._idPasaje;
        }

        public decimal CalcularPrecio()
        {

            return _precio;
        }
    }
}
