using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ModeloIntermedio
    {
        public Clientes modeloCliente { get; set; }
        public Telefono modeloTelefono1 { get; set; }
        public Telefono modeloTelefono2 { get; set; }
        public Cuenta modeloCuenta1 { get; set; }
        public Cuenta modeloCuenta2 { get; set; }
        public Cuenta modeloCuenta3 { get; set; }
        public List<Clientes> listaClientes { get; set; }
        public List<Telefono> listaTelefonos { get; set; }
        public List<Cuenta> listaCuentas { get; set; }
    }
}
