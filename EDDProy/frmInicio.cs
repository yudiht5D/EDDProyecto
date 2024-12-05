using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_Ordenamientos;
using EDDemo.Recursividad;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void arregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArreglo mArreglo = new FormArreglo();
            mArreglo.MdiParent = this;
            mArreglo.Show();
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBinario mBinario = new FormBinario();
            mBinario.MdiParent = this;
            mBinario.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExponente mExponente = new FormExponente();
            mExponente.MdiParent = this;
            mExponente.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactorial mFactorial = new FormFactorial();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci mFibonacci = new FormFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void hanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHanoi mHanoi = new FormHanoi();
            mHanoi.MdiParent = this;
            mHanoi.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBurbuja mBurbuja = new FormBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIntercalacion mIntercalacion = new FormIntercalacion();
            mIntercalacion.MdiParent = this;
            mIntercalacion.Show();

        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMezclaDirecta mMezclaD = new FormMezclaDirecta();
            mMezclaD.MdiParent = this;
            mMezclaD.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMezclaNatural mMezclaN = new FormMezclaNatural();
            mMezclaN.MdiParent = this;
            mMezclaN.Show();
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuicksort mQuicksort = new FormQuicksort();
            mQuicksort.MdiParent = this;
            mQuicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRadix mRadix = new FormRadix();
            mRadix.MdiParent = this;
            mRadix.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShellsort mShellsort = new FormShellsort();
            mShellsort.MdiParent = this;
            mShellsort.Show();
        }
    }
}
