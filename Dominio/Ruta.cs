using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Ruta
    {
        private int _idRuta = ultId++;
        private Aeropuerto _aeropuertoSalida;
        private Aeropuerto _aeropuertoLlegada;
        private double _distancia;

        static int ultId = 0;
    }
}
