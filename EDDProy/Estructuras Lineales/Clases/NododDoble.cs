using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class NododDoble
    {
        public string Valor;
        public NodoDoble sig;
        public NodoDoble ant;
        public NododDoble(string valor)
        {
            Valor = valor;
            sig = null;
            ant = null;
        }
    }
}
