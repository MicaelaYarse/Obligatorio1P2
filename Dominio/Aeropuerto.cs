using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        private string _codigoIATA;
        private string _ciudad;
        private decimal _costoOperacion;
        private decimal _costoTasas;

        public string CodigoIATA
        {
            get { return _codigoIATA; }
        }
        
        public Aeropuerto(string codigoIATA, string ciudad, decimal costoOperacion, decimal costoTasas)
        {
            _codigoIATA = codigoIATA;
            _ciudad = ciudad;
            _costoOperacion = costoOperacion;
            _costoTasas = costoTasas;
        }
        public void Validar()
        {
            if (string.IsNullOrEmpty(_codigoIATA))
                throw new Exception("El codigo IATA no puede ser vacío");
            if (string.IsNullOrEmpty(_ciudad))
                throw new Exception("La ciudad no puede ser vacío");
            if (_costoOperacion<0)
                throw new Exception("El costo de operación no puede ser menor a 0");
            if (_costoTasas < 0)
                throw new Exception("El costo de tasas no puede ser menor a 0");
            //expresión para validar que sean letras
            if (_codigoIATA.Length != 3 && _codigoIATA.All(char.IsLetter))
                throw new Exception("El codigo IATA no puede tener ni más ni menos de tres letras");
        }
        public override bool Equals(object? obj)
        {
            return obj is Aeropuerto otroAero && _codigoIATA == otroAero._codigoIATA;
        }

    }
   
}
