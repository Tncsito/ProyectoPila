﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPila
{
    internal class NODO
    {
        private int valor;
        private NODO sig;
        public NODO (int Valor)
        {
            valor = Valor;
            sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal NODO Sig { get => sig; set => sig = value; }
    }
}
