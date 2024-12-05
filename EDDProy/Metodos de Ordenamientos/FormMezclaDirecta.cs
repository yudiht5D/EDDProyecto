﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_de_Ordenamientos;

namespace EDDemo.Metodos_de_Ordenamientos
{
    public partial class FormMezclaDirecta : Form
    {
        public FormMezclaDirecta()
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

            // Llamamos al algoritmo Mezcla Directa para ordenar la lista
            lista = MezclaDirecta.FuncionMezclaDirecta(lista);

            stopwatch.Stop();

            // Mostramos la lista ordenada en txtOrdenado
            txtOrdenado.Text = lista.ToString();  // Usamos ToString para mostrar los números ordenados

            // Mostramos el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
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
    }
}
