using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazorEF.Server.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("api/Lambda")]
        public String Lambda()
        {
            String salida = "";
            /* Func<int, string> MayoriaEdad = delegate (int edad)
              {
                  return edad >= 18 ? "Mayor de Edad" : "Menor de Edad";
              };*/
            /*  Func<int, string> MayoriaEdad = edad => edad >= 18 ? "Mayor de Edad" : "Menor de Edad";            
              salida = MayoriaEdad(18);  */
            int[] numeros = { 2, 4, 6, 8 };
            salida=  String.Join(" ",numeros.Select(x => x * x));
            
            return salida;
        }
        
    }
}
