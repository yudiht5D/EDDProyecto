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
    public partial class FormShellsort : Form
    {
        public FormShellsort()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);

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

            // Llamamos al algoritmo Shell Sort para ordenar la lista
            Shellsort.FuncionShellSort(lista);

            stopwatch.Stop();

            // Mostramos la lista ordenada en txtOrdenado
            txtOrdenado.Text = lista.ToString();  // Usamos ToString para mostrar los números ordenados

            // Mostramos el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }

        private class Shellsort
        {
            public static void FuncionShellSort(Listas lista)
            {
                Nodo actual = lista.inicio;
                int tamaño = lista.Total();
                int[] valores = new int[tamaño];
                int index = 0;

                // Extraemos los valores de la lista enlazada y los almacenamos en el arreglo
                while (actual != null)
                {
                    if (int.TryParse(actual.Dato, out int valor))
                    {
                        valores[index++] = valor;
                    }
                    actual = actual.sig;
                }

                // Aplicamos el algoritmo Shell Sort al array de enteros
                int gap = tamaño / 2;
                while (gap > 0)
                {
                    for (int i = gap; i < tamaño; i++)
                    {
                        int temp = valores[i];
                        int j = i;

                        // Realizamos la comparación e intercambio con el gap
                        while (j >= gap && valores[j - gap] > temp)
                        {
                            valores[j] = valores[j - gap];
                            j -= gap;
                        }

                        valores[j] = temp;
                    }

                    gap /= 2; // Reducimos el tamaño del gap
                }
                actual = lista.inicio;
                foreach (int valor in valores)
                {
                    if (actual != null)
                    {
                        actual.Dato= valor.ToString();
                        actual = actual.sig;
                    }
                }
            }
        }
    }
}
