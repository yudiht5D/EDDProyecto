using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        public String Dato;
        public Nodo sig;
        private string valor;

        public Nodo()
        {
        }

        public Nodo(string valor)
        {
            this.valor = valor;
        }
    }
    
}
