﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazorEF.Shared
{
    public class Articulo
    {
        public string Categoria { get; set; }
        public string NombreArticulo { get; set; }
        public bool IsConsumo { get; set; }
    }
}
