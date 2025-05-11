using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Vuelo
    {
        private string _codigoVuelo;
        private Ruta _ruta;
        private Avion _avion;
        private List<DiasSemana> _frecuencia;
        public List<DiasSemana> Frecuencia
        {
            get { return _frecuencia; }
        }


        public Vuelo(string codigoVuelo, Ruta ruta, Avion avion, List<DiasSemana> frecuencia)
        {
            _codigoVuelo = codigoVuelo;
            _ruta = ruta;
            _avion = avion;
            _frecuencia = frecuencia;
        }

        private void ValidarNumCodigo()
        {
            for (int i = 2; i < _codigoVuelo.Length; i++)
            {
                if (!char.IsDigit(_codigoVuelo[i]))
                {
                    throw new Exception("El codigo de vuelo debe tener de 1 a 4 números luego de las dos primeras letras");
                }
            }
        }
        public void AlcanceNecesario()
        {
            if (_avion.AlcanceKm < _ruta.Distancia)
            {
                throw new Exception("El avión no tiene alcance suficiente para esta ruta.");
            }
        }

        private void ValidarFrecuencia()
        {
            if (_frecuencia == null || _frecuencia.Count == 0)
                throw new Exception("El vuelo debe tener al menos un día asignado.");

            foreach (DiasSemana dia in _frecuencia)
            {
                if ((int)dia < 1 || (int)dia > 7)
                {
                    throw new Exception("Día inválido: " + dia);
                }
            }
        }


        public void Validar()
        {
            if (string.IsNullOrEmpty(_codigoVuelo))
                throw new Exception("El código de vuelo no puede ser vacío");
            if (_ruta == null)
                throw new Exception("El vuelo debe tener una ruta.");
            if (_avion == null)
                throw new Exception("El vuelo debe tener un avión.");
            if (_codigoVuelo.Length < 3)
                throw new Exception("El código de vuelo debe tener al menos 2 letras y 1 número.");
            if (!char.IsLetter(_codigoVuelo[0]) || !char.IsLetter(_codigoVuelo[1]))
            {
                throw new Exception("El código de vuelo deben ser letras en los primeros 2 caracteres.");
            }

            ValidarNumCodigo();
            AlcanceNecesario();
            ValidarFrecuencia();

        }
    }
}
       

      
       




