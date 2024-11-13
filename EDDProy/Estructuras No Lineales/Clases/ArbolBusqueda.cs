using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Busqueda(Dato, Raiz) == true)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            else
            {
                if (Nodo == null)
                {
                    Nodo = new NodoBinario(Dato);
                    // CAMBIO 2

                    if (Raiz == null)
                        Raiz = Nodo;
                }
                else if (Dato < Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Izq);
                else if (Dato > Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Der);
            }

        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        public Boolean Busqueda(int Valor, NodoBinario Nodo)
        {
            if (Nodo == null)
                return false;
            if (Valor < Nodo.Dato)
                return
           Busqueda(Valor, Nodo.Izq);
            if (Valor > Nodo.Dato) return
                    Busqueda(Valor, Nodo.Der);
            return true;
        }
        public void BuscaNodo(int Valor)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            NodoBinario miRaiz = Raiz;
            if (Busqueda(Valor, miRaiz) == true)
            {
                MessageBox.Show("Se ha encontrado el dato");
                return;
            }
            else
            {
                MessageBox.Show("Valor no encontrado");
                return;
            }

        }
        public void PodarArbol()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol está vacio");
                return;
            }
            NodoBinario miRaiz = RegresaRaiz();
            PodarArbol (ref miRaiz);
            Raiz = null;
        }
        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
            {
                return;
            }
            PodarArbol(ref nodo.Izq);
            PodarArbol(ref nodo.Der);
            nodo = null;
        }
        public void eliminarPredecesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;
            else if (x < nodoPtr.Dato)
                eliminarPredecesor(x, ref nodoPtr.Izq);
            else if (x > nodoPtr.Dato)
                eliminarPredecesor(x, ref nodoPtr.Der);
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario mayor = buscarMayor(nodoPtr.Izq);
                nodoPtr.Dato = mayor.Dato;
                eliminarPredecesor(mayor.Dato, ref nodoPtr.Izq);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null)
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }
        public void eliminarSucesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;
            else if (x < nodoPtr.Dato)
                eliminarSucesor(x, ref nodoPtr.Izq);
            else if (x > nodoPtr.Dato)
                eliminarSucesor(x, ref nodoPtr.Der);
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario menor = buscarMenor(nodoPtr.Der);
                nodoPtr.Dato = menor.Dato;
                eliminarSucesor(menor.Dato, ref nodoPtr.Der);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else if (nodoPtr.Der == null)
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }
        public NodoBinario buscarMenor(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return null;
            else if (nodoPtr.Izq == null)
                return nodoPtr;
            else
                return buscarMenor(nodoPtr.Izq);
        }
        public NodoBinario buscarMayor(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return null;
            else if (nodoPtr.Der == null)
                return nodoPtr;
            else
                return buscarMayor(nodoPtr.Der);
        }
        public void RecorrerNiveles()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol está vacío");
                return;
            }
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(Raiz);

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                strRecorrido += nodoAuxiliar.Dato + ", ";

                if (nodoAuxiliar.Izq != null)
                {
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                }

                if (nodoAuxiliar.Der != null)
                {
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                }
            }

        }
        public int alturaArbol(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            // Se obtiene altura del subarbol izquierdo y el subarbol derecho
            int alturaIzq = alturaArbol(nodo.Izq);
            int alturaDer = alturaArbol(nodo.Der);
            // Se calcula la altura del nodo, siendo el maximo de las alturas de los subarboles mas 1, que es el nodo actual
            return Math.Max(alturaIzq, alturaDer) + 1;
        }
        public int contarHojas(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
            {
                return 0;
            }
            if (nodoPtr.Izq == null && nodoPtr.Der == null)
            {
                return 1;
            }
            else
            {
                return contarHojas(nodoPtr.Izq) + contarHojas(nodoPtr.Der);
            }
        }
        public int contarNodos(NodoBinario nodoPtr)
        {
            // Si el nodo es null, no hay nodos por esta parte del arbol
            if (nodoPtr == null)
            {
                return 0;
            }

            // Retorna 1 (el nodo actual) más la suma de los nodos en los subárboles izquierdo y derecho
            return 1 + contarNodos(nodoPtr.Izq) + contarNodos(nodoPtr.Der);
        }
        public int cantidadHojas()
        {
            return contarHojas(Raiz);
        }
        public int cantidadNodos()
        {
            return contarNodos(Raiz);
        }
        public bool ArbolCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true; // Un árbol vacío es completo

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);
            bool nodoIncompleto = false;

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario actual = colaAuxiliar.Dequeue(); // Obtiene el nodo al frente de la cola

                // Verifica el hijo izquierdo
                if (actual.Izq != null)
                {
                    if (nodoIncompleto) // Si encontramos un nodo incompleto antes, no es completo
                        return false;

                    colaAuxiliar.Enqueue(actual.Izq);
                }
                else
                {
                    // Si el nodo izquierdo no está presente, marcamos como nodo incompleto
                    nodoIncompleto = true;
                }

                // Verifica el hijo derecho
                if (actual.Der != null)
                {
                    if (nodoIncompleto) 
                        return false;

                    colaAuxiliar.Enqueue(actual.Der);
                }
                else
                {
                    // Si el nodo derecho no está presente, marcamos como nodo incompleto
                    nodoIncompleto = true;
                }
            }

            return true; 
        }
        public bool ArbolLleno(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true;
            if (nodoPtr.Der == null && nodoPtr.Izq == null)
                return true;
            if (nodoPtr.Der != null && nodoPtr.Izq != null)
                return (ArbolLleno(nodoPtr.Izq) && ArbolLleno(nodoPtr.Der));
            return false;
        }
    }

}


