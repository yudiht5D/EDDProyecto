using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public int Dato { get; private set; }

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miArbol.InsertaNodo(dato, ref miRaiz);
                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
                int altura = miArbol.alturaArbol(miRaiz);
                txtAltura.Text = altura.ToString();
            }
            else
            {
                MessageBox.Show("Inserte un número entero");
            }
            
            txtDato.Text = "";
            ActualizarNumNodos();
            ActualizarNumHojas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            miArbol.PodarArbol();
            ActualizarNumHojas();
            ActualizarNumNodos();
                
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();
            
            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato=rnd.Next(1,100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }
            //leer arbol completo y mostrarlo en cada texto 
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            txtAltura.Text = miArbol.alturaArbol(miRaiz).ToString(); // Se actualiza la altura
            ActualizarNumNodos();
            ActualizarNumHojas();
            txtDato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.BuscaNodo(int.Parse(txtDato.Text));
        }

        private void btnEliminarPrdcsr_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            // Verificar que el valor ingresado sea un número entero
            if (int.TryParse(txtEliminar.Text, out int datoEliminar))
            {
                miArbol.eliminarPredecesor(datoEliminar, ref miRaiz);

                // Leer el árbol completo y mostrarlo en el cuadro de texto
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                // Actualizar la altura, número de nodos y hojas
                txtAltura.Text = miArbol.alturaArbol(miRaiz).ToString();
                ActualizarNumNodos();
                ActualizarNumHojas();
            }
            else
            {
                MessageBox.Show("Inserte un elemento válido");
            }

            txtEliminar.Text = "";
        }

        private void btnEliminarScsr_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            // Verificar que el valor ingresado sea un número entero
            if (int.TryParse(txtEliminar.Text, out int datoEliminar))
            {
                miArbol.eliminarSucesor(datoEliminar, ref miRaiz);

                // Leer el árbol completo y mostrarlo en el cuadro de texto
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                // Actualizar la altura, número de nodos y hojas
                txtAltura.Text = miArbol.alturaArbol(miRaiz).ToString();
                ActualizarNumNodos();
                ActualizarNumHojas();
            }
            else
            {
                MessageBox.Show("Inserte un elemento válido");
            }

            txtEliminar.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verificar si el árbol es lleno o completo
            bool esArbolLleno = miArbol.ArbolLleno(miRaiz);
            bool esArbolCompleto = miArbol.ArbolCompleto(miRaiz);

            // Generar mensaje según el estado del árbol
            string mensaje;
            if (esArbolLleno && esArbolCompleto)
            {
                mensaje = "El árbol es completo y lleno";
            }
            else if (esArbolLleno)
            {
                mensaje = "El árbol es lleno pero no completo";
            }
            else if (esArbolCompleto)
            {
                mensaje = "El árbol es completo pero no lleno";
            }
            else
            {
                mensaje = "El árbol no es completo ni lleno";
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje, "Estado del Árbol");
        }
        private void ActualizarNumHojas()
        {
            txtHojas.Text = miArbol.cantidadHojas().ToString();
        }
        private void ActualizarNumNodos()
        {
            txtNodos.Text = miArbol.cantidadNodos().ToString();
        }
        public void btnVerificar_click(object sender, EventArgs e)
        {
            // Verificar si el árbol es lleno o completo
            bool esArbolLleno = miArbol.ArbolLleno(miRaiz);
            bool esArbolCompleto = miArbol.ArbolCompleto(miRaiz);

            // Generar mensaje según el estado del árbol
            string mensaje;
            if (esArbolLleno && esArbolCompleto)
            {
                mensaje = "El árbol es completo y lleno";
            }
            else if (esArbolLleno)
            {
                mensaje = "El árbol es lleno pero no completo";
            }
            else if (esArbolCompleto)
            {
                mensaje = "El árbol es completo pero no lleno";
            }
            else
            {
                mensaje = "El árbol no es completo ni lleno";
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje, "Estado del Árbol");
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }
    }
    
}
