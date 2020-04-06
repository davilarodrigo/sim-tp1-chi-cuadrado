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
    public partial class FrmAnalisisChiCuadrado : Form
    {
        #region declaracion variables

        bool muestraAnalizada=false;

        List<int> frecuenciasObservada;
        List<double> limitesInferioresDeIntervalos;
        List<double> limitesSuperioresDeIntervalos;
        int frecuenciaEsperada;

        bool cantidadIntervalosManual;

        AnalizadorDeMuestra analizadorDeMuestra;

        List<double> muestra = new List<double>();

        #endregion

        void generarMuestraAleatoria() {
            Random random = new Random();
            if (txtTamañoMuestraAGenerar.Text=="")
            {
                MessageBox.Show("Ingrese la cantidad de valores a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDecimales.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad maxima de decimales que los numeros generados podran tener", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = Convert.ToInt32(txtTamañoMuestraAGenerar.Text); // tamaño muestra
            int d = Convert.ToInt32(txtDecimales.Text); // max numero de decimales

            if (d==0)
            {
                MessageBox.Show("Ingrese una cantidad valida de decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (d >= 16)
            {
                MessageBox.Show("El numero de decimales debe ser igual o menor a 15", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n == 0)
            {
                MessageBox.Show("Ingrese una cantidad de numeros a generar valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            limpiarMuestra();

            for (int i = 0; i < n; i++) muestra.Add(Math.Round(random.NextDouble(), d));

            cargarGridMuestra();
        }

        void cargarGridMuestra()
        {
            dgvMuestra.Rows.Clear();
            for (int i = 0; i < muestra.Count; i++)
            {
                dgvMuestra.Rows.Add(muestra[i]);
            }

        }

        void limpiarMuestra()
        {
            dgvMuestra.Rows.Clear();
            dgvFrecuencia.Rows.Clear();


            lblTamañoMuestra.Text = "Tamaño Muestra";
            lblChiCuadrado.Text = "Chi Cuadrado";


            muestraAnalizada = false;

            muestra = null; 
            muestra = new List<double>();
        }

        public FrmAnalisisChiCuadrado(List<double> muestra)
        {
            InitializeComponent();
            this.muestra = muestra;
            grpGeneradorMuestra.Enabled = false;
            grpAgregarValor.Enabled = false;
        }

        public FrmAnalisisChiCuadrado()
        {
            InitializeComponent();
        }

        void configurarGroupBoxIntervalos()
        {
            cantidadIntervalosManual = rdbManual.Checked;
            txtCantidadIntervalos.Enabled = cantidadIntervalosManual;            
        }
               
        void agregarValorAMuestra()
        {
            string texto=txtLista.Text.ToString();
            double numero = Convert.ToInt32(texto);

            for (int i = 0; i < texto.Length; i++) numero /= 10;

            txtLista.Clear();
            muestra.Add(numero);
            dgvMuestra.Rows.Add(numero);
        }

        void configurarDataGridViews() {
            dgvFrecuencia.ColumnCount = 4;
            dgvFrecuencia.Columns[0].HeaderText = "Inicio del Intervalo";
            dgvFrecuencia.Columns[1].HeaderText = "Fin del Intervalo";
            dgvFrecuencia.Columns[2].HeaderText = "Frecuencia Observada";
            dgvFrecuencia.Columns[3].HeaderText = "Frecuencia Esperada";

            dgvFrecuencia.Columns[0].Width = 60;
            dgvFrecuencia.Columns[1].Width = 60;

            dgvMuestra.ColumnCount = 1;
            dgvMuestra.Columns[0].HeaderText = "Muestra";
            dgvMuestra.Columns[0].Width = 115;
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
            agregarValorAMuestra();
        }

        private void btnTestChi_Click(object sender, EventArgs e)
        {
            dgvFrecuencia.Rows.Clear();

            analizadorDeMuestra = new AnalizadorDeMuestra(muestra);


            if (cantidadIntervalosManual)
            {
                if (txtCantidadIntervalos.Text=="")
                {
                    MessageBox.Show("Ingrese Una Cantidad de intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int cantidadIntervalos = Convert.ToInt32( txtCantidadIntervalos.Text);

                frecuenciasObservada = analizadorDeMuestra.obtenerFrecuenciaObservada(cantidadIntervalos);
            }
            else
            {
            frecuenciasObservada = analizadorDeMuestra.obtenerFrecuenciaObservada();
                
            }


            limitesSuperioresDeIntervalos = analizadorDeMuestra.LimitesSuperioresDeIntervalos;
            limitesInferioresDeIntervalos = analizadorDeMuestra.LimitesInferioresDeIntervalos;

            frecuenciaEsperada = analizadorDeMuestra.obtenerFrecuenciaEsperada();

            for (int i = 0; i < frecuenciasObservada.Count; i++)
            {
                dgvFrecuencia.Rows.Add(limitesInferioresDeIntervalos[i], limitesSuperioresDeIntervalos[i],frecuenciasObservada[i],frecuenciaEsperada);
            }

            lblTamañoMuestra.Text = "Tamaño Muestra = " + muestra.Count.ToString();
            lblChiCuadrado.Text = "Chi Cuadrado = "+ analizadorDeMuestra.calcularChiCuadrado().ToString();

            muestraAnalizada = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!muestraAnalizada)
            {
                MessageBox.Show("Debe Generar y Analizar la muestra antes de generar el grafico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Grafico grafico = new Grafico(frecuenciasObservada, frecuenciaEsperada);
            grafico.ShowDialog();
        }

        #region otros
        private void txtLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;              
        }

        private void txtLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtLista.Text!="")
                {
                agregarValorAMuestra();
                }
            }
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            configurarGroupBoxIntervalos();
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            configurarGroupBoxIntervalos();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtCantidadIntervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminarMuestra_Click(object sender, EventArgs e)
        {
            limpiarMuestra();
        }

        private void btnGenerarNumerosAleatorios_Click(object sender, EventArgs e)
        {
            generarMuestraAleatoria();
        }

        private void grpIntervalos_Enter(object sender, EventArgs e)
        {

        }
    }
}
#endregion