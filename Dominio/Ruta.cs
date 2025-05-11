using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ruta
    {
        static int ultId = 0;
        private int _idRuta;
        private Aeropuerto _aeropuertoSalida;
        private Aeropuerto _aeropuertoLlegada;
        private double _distancia;

        public double Distancia
        {
            get { return _distancia; }
        }
        public Aeropuerto AeropuertoSalida
        {
            get { return _aeropuertoSalida; }
        }
        public Aeropuerto AeropuertoLlegada
        {
            get { return _aeropuertoLlegada; }
        }
        public Ruta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, double distancia)
        {
            ultId++;
            _idRuta = ultId;
            _aeropuertoSalida = aeropuertoSalida;
            _aeropuertoLlegada = aeropuertoLlegada;
            _distancia = distancia;
        }

        public void Validar()
        {
            if (_aeropuertoSalida == null)
                throw new Exception("La ruta debe tener un aeropuerto de salida.");

            if (_aeropuertoLlegada == null)
                throw new Exception("La ruta debe tener un aeropuerto de llegada.");


            if (_aeropuertoSalida.CodigoIATA == _aeropuertoLlegada.CodigoIATA)
                throw new Exception("El aeropuerto de salida y llegada no pueden ser el mismo.");

            if (_distancia <= 0)
                throw new Exception("La distancia debe ser mayor a 0.");
        }
        public override bool Equals(object? obj)
        {
            return obj is Ruta otraRuta && _idRuta == otraRuta._idRuta;
        }

    }

}

