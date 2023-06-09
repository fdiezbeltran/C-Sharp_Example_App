﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    abstract class Prendas
    {
        protected string calidadPrenda;
        protected float precioUnitario;
        protected int stock;

        public string CalidadPrenda { get => calidadPrenda; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Stock { get => stock; }
    }
}
