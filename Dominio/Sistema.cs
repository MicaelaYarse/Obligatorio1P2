using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {private List<Usuario> _usuarios = new List<Usuario>();
        private List<Cliente> _clientes=new List<Cliente>();
        private List<Administrador> _administradores=new List<Administrador>();
        private List<Avion> _aviones=new List<Avion>();
        private List<Aeropuerto> _aeropuertos=new List<Aeropuerto>();
        private List<Ruta> _rutas=new List<Ruta>();
        private List<Vuelo> _vuelos=new List<Vuelo>();
        private List<Pasaje> _pasajes=new List<Pasaje>();

        #region Singleton 

        private static Sistema _instancia;

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Sistema();
                return _instancia;
            }
        }
        private Sistema()
        {
            _clientes = new List<Cliente>();
            Precargar();
        }

        #endregion

        private void Precargar()
        {
            PrecargarClientes();
            PrecargarAdministradores();
            PrecargarAviones();
            PrecargarAeropuertosYRutas();
            PrecargarVuelos();
            PrecargarPasajes();


        }

        private void PrecargarClientes()
        {
            // Clientes Premium
            AltaCliente(new ClientePremium("juan.perez@gmail.com", "Ju@nP2025!", "1234567-5", "Juan Pérez", "Uruguaya", 1500));
            AltaCliente(new ClientePremium("maria.lopez@hotmail.com", "M@rL0p3z#", "2345678-2", "María López", "Argentina", 2350));
            AltaCliente(new ClientePremium("rodrigo.martinez@yahoo.com", "R0dr!g0Mtz", "3456789-4", "Rodrigo Martínez", "Chilena", 980));
            AltaCliente(new ClientePremium("andrea.gomez@gmail.com", "AndGm#2025", "4567890-9", "Andrea Gómez", "Paraguaya", 1720));
            AltaCliente(new ClientePremium("felipe.torres@outlook.com", "F3l1p3_T!", "5678901-1", "Felipe Torres", "Brasileña", 3000));
            // Clientes Ocasionales
            AltaCliente(new ClienteOcasional("lucia.mendez@gmail.com", "Lm3nd3z!", "8765432-7", "Lucía Méndez", "Uruguaya", true));
            AltaCliente(new ClienteOcasional("julieta.alvarez@outlook.com", "J4lv@r3z!", "6543210-9", "Julieta Álvarez", "Chilena", true));
            AltaCliente(new ClienteOcasional("dario.fernandez@gmail.com", "D@r_F3rn", "5432109-8", "Darío Fernández", "Paraguaya", false));
            AltaCliente(new ClienteOcasional("tomas.rivera@yahoo.com", "T0ma$R2025", "7654321-4", "Tomás Rivera", "Argentina", false));
            AltaCliente(new ClienteOcasional("sofia.rojas@hotmail.com", "S0fi@R#", "4321098-5", "Sofía Rojas", "Brasileña", true));
        }

        private void PrecargarAdministradores()
        {
            AltaAdministrador( new Administrador("luciana.admin@aerolinea.com","L#uAdm!n2025","adminLu"));  
           AltaAdministrador( new Administrador("juan.admin@aerolinea.com","Sup3rJ!Admin","2.superJuan"));
        }
        private void PrecargarAviones()
        {
            AltaAvion(new Avion("Boeing", "737MAX", 189, 6100, 50));
            AltaAvion(new Avion("Airbus", "A320neo", 180, 6300, 48));
            AltaAvion(new Avion("Embraer", "E195-E2", 132, 4800, 35));
            AltaAvion(new Avion("Bombardier", "CRJ900", 90, 3700, 30));
           
        }

        private void PrecargarAeropuertosYRutas()
        {
           Aeropuerto mvd=new Aeropuerto("MVD", "Montevideo", 1200, 55);
           Aeropuerto eze = new Aeropuerto("EZE", "Buenos Aires", 1400, 60);
            Aeropuerto scl = new Aeropuerto("SCL", "Santiago", 1300, 58);
            Aeropuerto gru = new Aeropuerto("GRU", "São Paulo", 1500, 65);
            Aeropuerto lim = new Aeropuerto("LIM", "Lima", 1350, 57);
            Aeropuerto bog = new Aeropuerto("BOG", "Bogotá", 1450, 62);
            Aeropuerto mex = new Aeropuerto("MEX", "Ciudad de México", 1550, 64);
            Aeropuerto jfk = new Aeropuerto("JFK", "Nueva York", 2000, 80);
            Aeropuerto mad = new Aeropuerto("MAD", "Madrid", 2100, 85);
            Aeropuerto cdg = new Aeropuerto("CDG", "París", 2200, 88);
            Aeropuerto lhr = new Aeropuerto("LHR", "Londres", 2300, 90);
            Aeropuerto rom = new Aeropuerto("ROM", "Roma", 2150, 86);
            Aeropuerto ber = new Aeropuerto("BER", "Berlín", 2250, 87);
            Aeropuerto ams = new Aeropuerto("AMS", "Ámsterdam", 2100, 83);
            Aeropuerto lis = new Aeropuerto("LIS", "Lisboa", 2000, 82);
            Aeropuerto fra = new Aeropuerto("FRA", "Frankfurt", 2250, 89);
            Aeropuerto bcn = new Aeropuerto("BCN", "Barcelona", 2100, 84);
            Aeropuerto mia = new Aeropuerto("MIA", "Miami", 1950, 78);
            Aeropuerto doh = new Aeropuerto("DOH", "Doha", 2400, 92);
            Aeropuerto dxb = new Aeropuerto("DXB", "Dubái", 2500, 95);

            AltaAero(mvd);
            AltaAero(eze);
            AltaAero(scl);
            AltaAero(gru);  
            AltaAero(lim);
            AltaAero(bog);
            AltaAero(mex);
            AltaAero(jfk);
            AltaAero(mad);  
            AltaAero(cdg);
            AltaAero(lhr);
            AltaAero(rom);
            AltaAero(ber);
            AltaAero(ams);
            AltaAero(lis);
            AltaAero(fra);
            AltaAero(bcn);
            AltaAero(mia);
            AltaAero(doh);
            AltaAero(dxb);
            AltaRuta(new Ruta(mvd, eze, 220));
            AltaRuta(new Ruta(eze, gru, 1670));
            AltaRuta(new Ruta(scl, lim, 2450));
            AltaRuta(new Ruta(gru, bog, 4330));
            AltaRuta(new Ruta(lim, jfk, 5850));
            AltaRuta(new Ruta(mex, mad, 9000));
            AltaRuta(new Ruta(cdg, fra, 870));
            AltaRuta(new Ruta(rom, ber, 1180));
            AltaRuta(new Ruta(ber, ams, 650));
            AltaRuta(new Ruta(ams, lis, 1860));
            AltaRuta(new Ruta(lis, bcn, 1250));
            AltaRuta(new Ruta(bcn, mia, 7500));
            AltaRuta(new Ruta(mia, dxb, 12600));
            AltaRuta(new Ruta(doh, dxb, 380));
            AltaRuta(new Ruta(jfk, mvd, 8400));
            AltaRuta(new Ruta(eze, scl, 1440));
            AltaRuta(new Ruta(scl, mex, 6600));
            AltaRuta(new Ruta(mvd, lim, 3200));
            AltaRuta(new Ruta(gru, mad, 8100));
            AltaRuta(new Ruta(eze, jfk, 8800));
            AltaRuta(new Ruta(rom, lhr, 1430));
            AltaRuta(new Ruta(lhr, fra, 1080));
            AltaRuta(new Ruta(fra, cdg, 480));
            AltaRuta(new Ruta(mad, lis, 625));
            AltaRuta(new Ruta(bog, doh, 12300));
            AltaRuta(new Ruta(dxb, mex, 13700));
            AltaRuta(new Ruta(jfk, ber, 6380));
            AltaRuta(new Ruta(bcn, gru, 8600));
            AltaRuta(new Ruta(mvd, bog, 5100));
            AltaRuta(new Ruta(scl, doh, 13100));

        }
        
        private void PrecargarVuelos()
        {
            AltaVuelo(new Vuelo()); 1.AR123, Ruta 1, Avión 1, [1, 3, 5]
2.LA456, Ruta 2, Avión 2, [2, 4, 6]
3.G3789, Ruta 3, Avión 3, [1, 2, 5]
4.CM321, Ruta 4, Avión 4, [3, 5, 7]
5.UX654, Ruta 5, Avión 1, [4, 6, 7]
6.IB987, Ruta 6, Avión 2, [1, 3, 6]
7.AF246, Ruta 7, Avión 3, [2, 5, 7]
8.AZ135, Ruta 8, Avión 4, [1, 4, 6]
9.LH753, Ruta 9, Avión 1, [3, 5, 7]
10.KL369, Ruta 10, Avión 2, [2, 4, 6]
11.TP852, Ruta 11, Avión 3, [1, 3, 6]
12.IB320, Ruta 12, Avión 4, [2, 5, 7]
13.EK999, Ruta 13, Avión 1, [1, 3, 5]
14.QR111, Ruta 14, Avión 2, [2, 4, 6]
15.UA777, Ruta 15, Avión 3, [1, 5, 7]
16.AR200, Ruta 16, Avión 4, [3, 5, 7]
17.LA330, Ruta 17, Avión 1, [2, 4, 6]
18.CM880, Ruta 18, Avión 2, [1, 3, 6]
19.UX503, Ruta 19, Avión 3, [2, 5, 7]
20.IB408, Ruta 20, Avión 4, [1, 3, 6]
21.BA543, Ruta 21, Avión 1, [1, 4, 6]
22.LH999, Ruta 22, Avión 2, [2, 5, 7]
23.AF300, Ruta 23, Avión 3, [3, 6]
24.TP411, Ruta 24, Avión 4, [1, 3, 6]
25.EK765, Ruta 25, Avión 1, [2, 4, 6]
26.QR876, Ruta 26, Avión 2, [1, 3, 5]
27.DL777, Ruta 27, Avión 3, [3, 5, 7]
28.UX654, Ruta 28, Avión 4, [2, 4, 6]
29.G3789, Ruta 29, Avión 1, [1, 3, 5]
30.CM321, Ruta 30, Avión 2, [2, 5, 7]
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());
            AltaVuelo(new Vuelo());

        }
        private void PrecargarPasajes()
        {
         

        }
        public void AltaCliente(Cliente nuevoCliente)
        {
            nuevoCliente.Validar();
            if (_clientes.Contains(nuevoCliente))
                throw new Exception("El cliente ya existe");
            _clientes.Add(nuevoCliente);
        }
        public void AltaAdministrador(Administrador nuevoAdmin)
        {
            nuevoAdmin.Validar();
            if (_administradores.Contains(nuevoAdmin))
                throw new Exception("El administrador ya existe");
            _administradores.Add(nuevoAdmin);
        }

        public void AltaAvion(Avion nuevoAvion)
        {
            nuevoAvion.Validar();
            if (_aviones.Contains(nuevoAvion))
                throw new Exception("El avion ya existe");
            _aviones.Add(nuevoAvion);
        }

        public void AltaAero(Aeropuerto nuevoAero)
        {
            nuevoAero.Validar();
            if (_aeropuertos.Contains(nuevoAero))
                throw new Exception("El aeropuerto ya existe");
            _aeropuertos.Add(nuevoAero);
        }

        public void AltaRuta(Ruta nuevaRuta)
        {
            nuevaRuta.Validar();
            if (_rutas.Contains(nuevaRuta))
                throw new Exception("La ruta ya existe");
            _rutas.Add(nuevaRuta);
        }

        public void AltaVuelo(Vuelo nuevoVuelo)
        {
            nuevoVuelo.Validar();
            if (_vuelos.Contains(nuevoVuelo))
                throw new Exception("El vuelo ya existe");
            _vuelos.Add(nuevoVuelo);
        }
        public void AltaPasaje(Pasaje nuevoPasaje)
        {
            nuevoPasaje.Validar();
            if (_pasajes.Contains(nuevoPasaje))
                throw new Exception("El pasaje ya existe");
            _pasajes.Add(nuevoPasaje);
        }


        public string ObtenerListadoClientes()
        {
            string resultado = "";
            foreach (Cliente cliente in _clientes)
            {
                resultado += cliente.ObtenerDescripcion() + "\n";
            }
            return resultado;
        }


    }
}





