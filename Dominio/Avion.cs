using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Avion
    {
        private string _fabricante;
        private string _modelo;
        private int _cantAsientos;
        private double _alcanceKm;
        private decimal _costoXKm;
        public double AlcanceKm
        {
            get { return _alcanceKm; }
        }

        public Avion(string fabricante, string modelo, int cantAsientos, double alcanceKm, decimal costoXKm)
        {
            _fabricante = fabricante;
            _modelo = modelo;
            _cantAsientos = cantAsientos;
            _alcanceKm = alcanceKm;
            _costoXKm = costoXKm;
        }
        public  void Validar()
        {
            if (string.IsNullOrEmpty(_fabricante))
                throw new Exception("El fabricante no puede ser vacío");
            if (string.IsNullOrEmpty(_modelo))
                throw new Exception("El modelo no puede ser vacío");
            if (_cantAsientos<0)
                throw new Exception("La cantidad de asientos no puede ser un número negativo");
            if (_alcanceKm<0)
                throw new Exception("El alcance en km no puede ser un número negativo");
            if (_costoXKm < 0)
                throw new Exception("El costo por km no puede ser un número negativo");

        }
        public override bool Equals(object? obj)
        {
            return obj is Avion otroAvion && _modelo == otroAvion._modelo;
        }
    }
}

