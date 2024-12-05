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
    public partial class FormRadix : Form
    {
        public FormRadix()
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
            // Convertimos el texto de txtLista a un arreglo de enteros
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            int[] numeros = new int[numerosTexto.Length];

            // Llenamos el arreglo con los valores de la lista
            for (int i = 0; i < numerosTexto.Length; i++)
            {
                if (int.TryParse(numerosTexto[i], out int numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    MessageBox.Show("Inserta un elemento válido");
                    return;
                }
            }

            // Usamos un cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos al algoritmo Radix Sort para ordenar el arreglo
            Radix.FuncionRadix(numeros);

            stopwatch.Stop();

            // Mostramos el arreglo ordenado en txtOrdenado
            txtOrdenado.Text = string.Join(", ", numeros);

            // Mostramos el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }

    }

    internal class Radix
    {
        // Aquí tambien hice uso de arreglos en lugar de la lista para no dificultar el codigo
        public static void FuncionRadix(int[] a)
        {
            int n = a.Length;

            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            for (int pos = 1; max / pos > 0; pos *= 10)
            {
                CountSort(a, n, pos);
            }
        }

        private static void CountSort(int[] a, int n, int pos)
        {
            int[] count = new int[10];
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[(a[i] / pos) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(a[i] / pos) % 10] - 1] = a[i];
                count[(a[i] / pos) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                a[i] = output[i];
            }

        }
    }
}
