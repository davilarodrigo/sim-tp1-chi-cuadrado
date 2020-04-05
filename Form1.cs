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
        List<double> listaIntervalos;

        TesterChiCuadrado tester;

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
            dgvFrecuencia.ColumnCount = 3;
            dgvFrecuencia.Columns[0].HeaderText = "Desde";
            dgvFrecuencia.Columns[1].HeaderText = "Hasta";
            dgvFrecuencia.Columns[2].HeaderText = "Frec. Observada";

            dgvLista.ColumnCount = 1;
            dgvLista.Columns[0].HeaderText = "valor";
            
            //dgvFrecuencia.Columns[0].Width = 50;
            //dgvFrecuencia.Columns[1].Width = 100;


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
            tester = new TesterChiCuadrado();

            frecuenciaObservada = tester.obtenerFrecuencia(lista);
            listaIntervalos = tester.rangosIntervalos;

            for (int i = 0; i < frecuenciaObservada.Count; i++)
            {
                dgvFrecuencia.Rows.Add("", listaIntervalos[i],frecuenciaObservada[i]);
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
    }
}
