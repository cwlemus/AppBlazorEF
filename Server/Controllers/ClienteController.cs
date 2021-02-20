using AppBlazorEF.Server.Models;
using AppBlazorEF.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazorEF.Server.Controllers
{
    [ApiController]
    public class ClienteController : Controller
    {
       [HttpGet]
       [Route("api/Clientes/Get")]
       public List<ClienteCls> Get()
        {
            List<ClienteCls> lista = new List<ClienteCls>();
            using (Facturacion_DBContext db= new Facturacion_DBContext())
            {
                lista = (from clte in db.Cliente
                         select new ClienteCls
                         {
                             IdCliente = clte.IdCliente,
                             Nombre = clte.Nombre,
                             Apellido = clte.Apellido,
                             Telefono = clte.Telefono
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Cliente/Filtrar/{data?}")]
        public List<ClienteCls> Filtrar(string data)
        {
            List<ClienteCls> lst = new List<ClienteCls>();
            using(Facturacion_DBContext db = new Facturacion_DBContext())
            {
                if (data == null)
                {
                    lst = (from clte in db.Cliente
                             select new ClienteCls
                             {
                                 IdCliente = clte.IdCliente,
                                 Nombre = clte.Nombre,
                                 Apellido = clte.Apellido,
                                 Telefono = clte.Telefono
                             }
                    ).ToList();
                }
                else
                {
                    lst = (from clte in db.Cliente
                           where clte.IdCliente.ToString().Contains(data) ||
                                 clte.Nombre.Contains(data)|| clte.Apellido.Contains(data)||
                                 clte.Telefono.Contains(data)
                             select new ClienteCls
                             {
                                 IdCliente = clte.IdCliente,
                                 Nombre = clte.Nombre,
                                 Apellido = clte.Apellido,
                                 Telefono = clte.Telefono
                             }
                    ).ToList();
                }
            }
            return lst;
        }

    }
}
