using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientesV2Controller : Controller
    {
        BD_B04751Entities BD = new BD_B04751Entities();
        // GET: ClientesV2
        public ActionResult Index()
        {
            ModeloIntermedio modeloInt = new ModeloIntermedio();
            modeloInt.listaClientes = BD.Clientes.ToList();
            modeloInt.listaTelefonos = BD.Telefono.ToList();
            modeloInt.listaCuentas = BD.Cuenta.ToList();
            return View(modeloInt);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                BD.Clientes.Add(modelo.modeloCliente);
                BD.SaveChanges();
                if (modelo.modeloTelefono1.Numero != null)
                {
                    modelo.modeloTelefono1.ClienteId_fk = modelo.modeloCliente.Cedula;
                    BD.Telefono.Add(modelo.modeloTelefono1);
                }
                if (modelo.modeloTelefono2.Numero != null)
                {
                    modelo.modeloTelefono2.ClienteId_fk = modelo.modeloCliente.Cedula;
                    BD.Telefono.Add(modelo.modeloTelefono2);
                }
                if (modelo.modeloCuenta1.Cuenta1 != null)
                {
                    modelo.modeloCuenta1.ClienteCId_fk = modelo.modeloCliente.Cedula;
                    BD.Cuenta.Add(modelo.modeloCuenta1);
                }
                if (modelo.modeloCuenta2.Cuenta1 != null)
                {
                    modelo.modeloCuenta2.ClienteCId_fk = modelo.modeloCliente.Cedula;
                    BD.Cuenta.Add(modelo.modeloCuenta2);
                }
                if (modelo.modeloCuenta3.Cuenta1 != null)
                {
                    modelo.modeloCuenta3.ClienteCId_fk = modelo.modeloCliente.Cedula;
                    BD.Cuenta.Add(modelo.modeloCuenta3);
                }
                BD.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}