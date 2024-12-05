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
    public partial class FormQuicksort : Form
    {
        public FormQuicksort()
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
            int[] numeros = new int[numerosTexto.Length];

            for (int i = 0; i < numerosTexto.Length; i++)
            {
                if (int.TryParse(numerosTexto[i], out int num))
                {
                    numeros[i] = num;
                }
                else
                {
                    MessageBox.Show("Inserta un elemento válido");
                    return;
                }
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Quicksort.FuncionQuicksort(numeros, 0, numeros.Length - 1);

            stopwatch.Stop();

            txtOrdenado.Text = string.Join(", ", numeros);

            // Aquí se mide en ticks, ya que los milisegundos es una escala grande para esto
            // Siempre marca 0 cuando se usan milisegundos
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
        public class Quicksort
        {
            // Aquí utilice int[] (arreglo) para quicksort porque el codigo se iba a complicar si utilizaba las listas
            public static void FuncionQuicksort(int[] A, int inf, int sup)
            {
                if (inf >= sup)
                    return;

                int i = inf;
                int j = sup;
                int x = A[(inf + sup) / 2]; // Elemento pivote

                while (i <= j)
                {
                    // Buscar un elemento en la izquierda que sea mayor que el pivote
                    while (A[i] < x)
                        i++;

                    // Buscar un elemento en la derecha que sea menor que el pivote
                    while (A[j] > x)
                        j--;

                    // Si los índices no se han cruzado, intercambiar los elementos
                    if (i <= j)
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        i++;
                        j--;
                    }
                }

                // Llamadas recursivas para ordenar las sublistas
                if (inf < j)
                {
                    FuncionQuicksort(A, inf, j);
                }
                if (i < sup)
                {
                    FuncionQuicksort(A, i, sup);
                }
            }
        }
    }
}
