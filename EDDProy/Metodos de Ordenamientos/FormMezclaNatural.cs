using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_Ordenamientos
{
    public partial class FormMezclaNatural : Form
    {
        public FormMezclaNatural()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            Listas lista = new Listas();

            // Insertamos los números en la lista enlazada
            foreach (var numero in numerosTexto)
            {
                lista.InsertBase(numero);  // Insertamos al final de la lista
            }

            // Usamos un cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos al algoritmo Mezcla Natural para ordenar la lista
            lista = MezclaNatural.FuncionMezclaNatural(lista);

            stopwatch.Stop();

            // Mostramos la lista ordenada en txtOrdenado
            txtOrdenado.Text = lista.ToString();  // Usamos ToString para mostrar los números ordenados

            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                string listaTexto = "";

                Listas lista = new Listas();
                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);

                    lista.InsertBase(numero.ToString());
                    if (i > 0)
                    {
                        listaTexto += ", ";
                    }

                    listaTexto += numero.ToString();
                }

                txtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }
    }

    internal class MezclaNatural
    {
        public static Listas Mezclar(Listas lista1, Listas lista2)
        {
            Listas mergedList = new Listas();
            Nodo actual1 = lista1.inicio;
            Nodo actual2 = lista2.inicio;

            while (actual1 != null && actual2 != null)
            {
                if (string.Compare(actual1.Dato, actual2.Dato) <= 0)
                {
                    mergedList.InsertBase(actual1.Dato); // Insertamos el valor de la primera lista
                    actual1 = actual1.sig;
                }
                else
                {
                    mergedList.InsertBase(actual2.Dato); // Insertamos el valor de la segunda lista
                    actual2 = actual2.sig;
                }
            }

            // Si alguna lista tiene elementos restantes, los agregamos
            while (actual1 != null)
            {
                mergedList.InsertBase(actual1.Dato);
                actual1 = actual1.sig;
            }

            while (actual2 != null)
            {
                mergedList.InsertBase(actual2.Dato);
                actual2 = actual2.sig;
            }

            return mergedList;
        }

        public static List<Listas> IdentificarRuns(Listas list)
        {
            List<Listas> runs = new List<Listas>();  // Lista para almacenar todas las subsecuencias ordenadas.
            if (list.estaVacio()) return runs;

            Nodo actual = list.inicio;
            Listas subsecuencia = new Listas();
            subsecuencia.InsertBase(actual.Dato);  // Comienza una nueva subsecuencia ordenada.

            while (actual.sig != null)
            {
                if (string.Compare(actual.sig.Dato, actual.Dato) >= 0)
                {
                    // La subsecuencia sigue siendo ordenada, añadimos el siguiente valor.
                    subsecuencia.InsertBase(actual.sig.Dato
                        );
                }
                else
                {
                    // Fin de la subsecuencia, la guardamos y comenzamos una nueva.
                    runs.Add(subsecuencia);
                    subsecuencia = new Listas();
                    subsecuencia.InsertBase(actual.sig.Dato);
                }
                actual = actual.sig;
            }
            runs.Add(subsecuencia);  // Añadimos la última subsecuencia.
            return runs;
        }

        public static Listas FuncionMezclaNatural(Listas list)
        {
            List<Listas> subsecuencias = IdentificarRuns(list);  // Obtener todas las subsecuencias ordenadas.

            while (subsecuencias.Count > 1)
            {
                Listas mergedList = Mezclar(subsecuencias[0], subsecuencias[1]);  // Fusionamos las dos primeras subsecuencias.
                subsecuencias.RemoveAt(0);  // Eliminamos las subsecuencias fusionadas.
                subsecuencias.RemoveAt(0);
                subsecuencias.Insert(0, mergedList);  // Insertamos la lista fusionada al principio de la lista de subsecuencias.
            }

            return subsecuencias[0];  // La lista ordenada final.
        } 
    }
}
