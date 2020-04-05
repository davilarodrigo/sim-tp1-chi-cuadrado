using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> frecuenciaObservada;
        List<double> finIntervalos;
        List<double> comienzoIntervalos;
        

        ListaFrecuenciaObservada tester;

        List<double> lista = new List<double>();

        void agregarValorALista()
        {
            string texto=txtLista.Text.ToString();

            double numero = Convert.ToInt32(texto);

            for (int i = 0; i < texto.Length; i++)
            {
                numero /= 10;
            }
            txtLista.Clear();
            lista.Add(numero);
            dgvLista.Rows.Add(numero);
        }

        void configurarDataGridViews() {
            dgvFrecuencia.ColumnCount = 4;
            dgvFrecuencia.Columns[0].HeaderText = "Desde";
            dgvFrecuencia.Columns[1].HeaderText = "Hasta";
            dgvFrecuencia.Columns[2].HeaderText = "Frec. Observada";
            dgvFrecuencia.Columns[3].HeaderText = "Frec. Esperada";

            dgvFrecuencia.Columns[0].Width = 50;
            dgvFrecuencia.Columns[1].Width = 50;

            dgvLista.ColumnCount = 1;
            dgvLista.Columns[0].HeaderText = "valor";
            


           // LLENAR CON FOR:
            //dataGridViewValoresLista.Rows.Add(iteracion, numeroRandom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configurarDataGridViews();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            agregarValorALista();
        }

        private void btnTestChi_Click(object sender, EventArgs e)
        {
            tester = new ListaFrecuenciaObservada();

            frecuenciaObservada = tester.obtenerFrecuencia(lista);
            finIntervalos = tester.finIntervalos;
            comienzoIntervalos = tester.comienzoIntervalos;
            double frecuenciaEsperada = tester.obtenerFrecuenciaEsperada();

            for (int i = 0; i < frecuenciaObservada.Count; i++)
            {
                dgvFrecuencia.Rows.Add(comienzoIntervalos[i], finIntervalos[i],frecuenciaObservada[i],frecuenciaEsperada);
            }
        }


        private void txtLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;              
        }

        private void txtLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                agregarValorALista();
            }
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tester.obtenerChiCuadrado().ToString();
        }
    }
}
