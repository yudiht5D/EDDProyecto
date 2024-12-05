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

namespace EDDemo.Metodos_de_Ordenamientos
{
    public partial class FormBurbuja : Form
    {
        public FormBurbuja()
        {
            InitializeComponent();
        }

        public object Burbuja { get; private set; }

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
            // Convertimos la lista de texto en la lista vinculada (Listas)
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            Listas lista = new Listas();

            // Insertamos los números en la lista
            foreach (var numero in numerosTexto)
            {
                lista.InsertBase(numero); // Suponiendo que InsertarFinal agrega nodos a la lista
            }

            // Creamos el cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

           
            stopwatch.Stop();

            // Mostramos los resultados ordenados
            txtOrdenado.Text = lista.ToString(); // Asegúrate de tener un método ToString() en la clase Listas para representar la lista ordenada

            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
