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
using EDDemo.MetodosdeBusqueda;

namespace EDDemo.MetodosdeBusqueda
{
    public partial class FormHash : Form
    {
        private MetodoHash.HashTable tablaHash;
        public FormHash()
        {
            InitializeComponent();
            tablaHash = new MetodoHash.HashTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se obtiene el input
            string input = textBox1.Text;

            // Se genera un hash mediante la funcion hash polinomial
            int claveHash = MetodoHash.HashTable.FuncionHashPolinomial(input, 100);  // Usamos el tamaño de tabla 100

            // Se inserta el valor en la tabla hash
            tablaHash.Insertar(input);

            textBox2.AppendText($"Clave: {claveHash} Valor: {input}\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Se verifica si el valor de la búsqueda (clave) es numérico
            if (int.TryParse(textBox3.Text, out int claveBuscada))
            {
                // Se busca el valor asociado a la clave en la tabla hash
                string resultado = tablaHash.Buscar(claveBuscada);

                // Se muestra el resultado de la búsqueda en txtEncontrado
                if (resultado != null)
                {
                    textBox4.Text = $"Valor {resultado}";
                }
                else
                {
                    textBox4.Text = $"Valor {claveBuscada} no encontrado";
                }
                stopwatch.Stop();

                textBox5.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingresa un número a buscar");
            }
        }
    }
}
