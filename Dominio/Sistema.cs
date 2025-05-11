using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private List<Cliente> _clientes;
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
            PrecargarAeropuertos();
            PrecargarRutas();
            PrecargarVuelos();
            PrecargarPasajes();


        }

        private void PrecargarClientes()
        {
            // Clientes Premium
            ClientePremium clienteP1 = new ClientePremium("juan.perez@gmail.com", "Ju@nP2025!", "1234567-5", "Juan Pérez", "Uruguaya", 1500);
            ClientePremium clienteP2 = new ClientePremium("maria.lopez@hotmail.com", "M@rL0p3z#", "2345678-2", "María López", "Argentina", 2350);
            ClientePremium clienteP3 = new ClientePremium("rodrigo.martinez@yahoo.com", "R0dr!g0Mtz", "3456789-4", "Rodrigo Martínez", "Chilena", 980);
            ClientePremium clienteP4 = new ClientePremium("andrea.gomez@gmail.com", "AndGm#2025", "4567890-9", "Andrea Gómez", "Paraguaya", 1720);
            ClientePremium clienteP5 = new ClientePremium("felipe.torres@outlook.com", "F3l1p3_T!", "5678901-1", "Felipe Torres", "Brasileña", 3000);

            ClienteOcasional clienteO1 = new ClienteOcasional("lucia.mendez@gmail.com", "Lm3nd3z!", "8765432-7", "Lucía Méndez", "Uruguaya", true);
            ClienteOcasional clienteO2 = new ClienteOcasional("julieta.alvarez@outlook.com", "J4lv@r3z!", "6543210-9", "Julieta Álvarez", "Chilena", true);
            ClienteOcasional clienteO3 = new ClienteOcasional("dario.fernandez@gmail.com", "D@r_F3rn", "5432109-8", "Darío Fernández", "Paraguaya", false);
            ClienteOcasional clienteO4 = new ClienteOcasional("tomas.rivera@yahoo.com", "T0ma$R2025", "7654321-4", "Tomás Rivera", "Argentina", false);
            ClienteOcasional clienteO5 = new ClienteOcasional("sofia.rojas@hotmail.com", "S0fi@R#", "4321098-5", "Sofía Rojas", "Brasileña", true);

            AltaCliente(clienteP1);

        }

        private void PrecargarAdministradores()
        {
            Administrador admin1 = new Administrador();
            Administrador admin2 = new Administrador();
        }
        private void PrecargarAviones()
        {
            Avion avion1 = new Avion();
            Avion avion2 = new Avion();
            Avion avion3 = new Avion();
            Avion avion4 = new Avion();
        }

        private void PrecargarAeropuertos()
        {
            Aeropuerto aereopuerto1 = new Aeropuerto();
            Aeropuerto aereopuerto2 = new Aeropuerto();
            Aeropuerto aereopuerto3 = new Aeropuerto();
            Aeropuerto aereopuerto4 = new Aeropuerto();
            Aeropuerto aereopuerto5 = new Aeropuerto();
            Aeropuerto aereopuerto6 = new Aeropuerto();
            Aeropuerto aereopuerto7 = new Aeropuerto();
            Aeropuerto aereopuerto8 = new Aeropuerto();
            Aeropuerto aereopuerto9 = new Aeropuerto();
            Aeropuerto aereopuerto10 = new Aeropuerto();
            Aeropuerto aereopuerto11 = new Aeropuerto();
            Aeropuerto aereopuerto12 = new Aeropuerto();
            Aeropuerto aereopuerto13 = new Aeropuerto();
            Aeropuerto aereopuerto14 = new Aeropuerto();
            Aeropuerto aereopuerto15 = new Aeropuerto();
            Aeropuerto aereopuerto16 = new Aeropuerto();
            Aeropuerto aereopuerto17 = new Aeropuerto();
            Aeropuerto aereopuerto18 = new Aeropuerto();
            Aeropuerto aereopuerto19 = new Aeropuerto();
            Aeropuerto aereopuerto20 = new Aeropuerto();

        }
        private void PrecargarRutas()
        {
            Ruta ruta1 = new Ruta();
            Ruta ruta2 = new Ruta();
            Ruta ruta3 = new Ruta();
            Ruta ruta4 = new Ruta();
            Ruta ruta5 = new Ruta();
            Ruta ruta6 = new Ruta();
            Ruta ruta7 = new Ruta();
            Ruta ruta8 = new Ruta();
            Ruta ruta9 = new Ruta();
            Ruta ruta10 = new Ruta();
            Ruta ruta11 = new Ruta();
            Ruta ruta12 = new Ruta();
            Ruta ruta13 = new Ruta();
            Ruta ruta14 = new Ruta();
            Ruta ruta15 = new Ruta();
            Ruta ruta16 = new Ruta();
            Ruta ruta17 = new Ruta();
            Ruta ruta18 = new Ruta();
            Ruta ruta19 = new Ruta();
            Ruta ruta20 = new Ruta();
            Ruta ruta21 = new Ruta();
            Ruta ruta22 = new Ruta();
            Ruta ruta23 = new Ruta();
            Ruta ruta24 = new Ruta();
            Ruta ruta25 = new Ruta();
            Ruta ruta26 = new Ruta();
            Ruta ruta27 = new Ruta();
            Ruta ruta28 = new Ruta();
            Ruta ruta29 = new Ruta();
            Ruta ruta30 = new Ruta();


        }
        private void PrecargarVuelos()
        {
            Vuelo Vuelo1 = new Vuelo();
            Vuelo Vuelo2 = new Vuelo();
            Vuelo Vuelo3 = new Vuelo();
            Vuelo Vuelo4 = new Vuelo();
            Vuelo Vuelo5 = new Vuelo();
            Vuelo Vuelo6 = new Vuelo();
            Vuelo Vuelo7 = new Vuelo();
            Vuelo Vuelo8 = new Vuelo();
            Vuelo Vuelo9 = new Vuelo();
            Vuelo Vuelo10 = new Vuelo();
            Vuelo Vuelo11 = new Vuelo();
            Vuelo Vuelo12 = new Vuelo();
            Vuelo Vuelo13 = new Vuelo();
            Vuelo Vuelo14 = new Vuelo();
            Vuelo Vuelo15 = new Vuelo();
            Vuelo Vuelo16 = new Vuelo();
            Vuelo Vuelo17 = new Vuelo();
            Vuelo Vuelo18 = new Vuelo();
            Vuelo Vuelo19 = new Vuelo();
            Vuelo Vuelo20 = new Vuelo();
            Vuelo Vuelo21 = new Vuelo();
            Vuelo Vuelo22 = new Vuelo();
            Vuelo Vuelo23 = new Vuelo();
            Vuelo Vuelo24 = new Vuelo();
            Vuelo Vuelo25 = new Vuelo();
            Vuelo Vuelo26 = new Vuelo();
            Vuelo Vuelo27 = new Vuelo();
            Vuelo Vuelo28 = new Vuelo();
            Vuelo Vuelo29 = new Vuelo();
            Vuelo Vuelo30 = new Vuelo();

        }
        private void PrecargarPasajes()
        {
            Pasaje Pasaje1 = new Pasaje();
            Pasaje Pasaje2 = new Pasaje();
            Pasaje Pasaje3 = new Pasaje();
            Pasaje Pasaje4 = new Pasaje();
            Pasaje Pasaje5 = new Pasaje();
            Pasaje Pasaje6 = new Pasaje();
            Pasaje Pasaje7 = new Pasaje();
            Pasaje Pasaje8 = new Pasaje();
            Pasaje Pasaje9 = new Pasaje();
            Pasaje Pasaje10 = new Pasaje();
            Pasaje Pasaje11 = new Pasaje();
            Pasaje Pasaje12 = new Pasaje();
            Pasaje Pasaje13 = new Pasaje();
            Pasaje Pasaje14 = new Pasaje();
            Pasaje Pasaje15 = new Pasaje();
            Pasaje Pasaje16 = new Pasaje();
            Pasaje Pasaje17 = new Pasaje();
            Pasaje Pasaje18 = new Pasaje();
            Pasaje Pasaje19 = new Pasaje();
            Pasaje Pasaje20 = new Pasaje();
            Pasaje Pasaje21 = new Pasaje();
            Pasaje Pasaje22 = new Pasaje();
            Pasaje Pasaje23 = new Pasaje();
            Pasaje Pasaje24 = new Pasaje();
            Pasaje Pasaje25 = new Pasaje();

        }
        public void AltaCliente(Cliente nuevoCliente)
        {
            nuevoCliente.Validar();
            if (_clientes.Contains(nuevoCliente))
                throw new Exception("El cliente ya existe");
            _clientes.Add(nuevoCliente);
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





