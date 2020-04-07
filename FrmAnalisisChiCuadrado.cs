using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.dgvMuestra.Rows.Clear();
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

            this.configurarDataGridViews();
            this.cargarGridMuestra();
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

     
        private void btnTestChi_Click(object sender, EventArgs e)
        {
            if (muestra.Count == 0)
            {
                MessageBox.Show("Se debe generar una muestra antes de analizarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLista.Focus();
                return;
            }

            dgvFrecuencia.Rows.Clear();

            this.buttonExportarExcel.Enabled = true;
            this.btnMostrarGrafico.Enabled = true;

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

            this.lblMediaEsperada.Text += " 0.5";
            this.lblVarianzaEsperada.Text += " 0.0833";
            double media;
            double sumatoria = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria += muestra[i];
            }
            media = Math.Truncate(sumatoria / Convert.ToDouble(muestra.Count())*10000)/10000;
            this.lblMediaObservada.Text += " " + media.ToString();

            double sumatoria2 = 0;
            for (int i = 0; i < muestra.Count(); i++)
            {
                sumatoria2 += (Math.Pow(muestra[i] - (double)media, 2));
            }
            double varianza = Math.Truncate(sumatoria2 / Convert.ToDouble(muestra.Count()-1) * 10000) / 10000;
            this.lblVarianzaObservada.Text += " " + varianza.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!muestraAnalizada)
            {
                MessageBox.Show("Debe Generar y Analizar la muestra antes de generar el grafico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmGrafico grafico = new FrmGrafico(frecuenciasObservada, frecuenciaEsperada);
            //grafico.recibirParametro();
            grafico.ShowDialog();
        }

        #region otros

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
            btnTestChiCuadrado.Enabled = false;
        }

        private void btnGenerarNumerosAleatorios_Click(object sender, EventArgs e)
        {
            generarMuestraAleatoria();
            btnTestChiCuadrado.Enabled = true;
        }

        private void grpIntervalos_Enter(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblChiCuadrado_DoubleClick(object sender, EventArgs e)
        {
            btnTestChiCuadrado.Enabled = true;
            //limpiarMuestra();
            //btnTestChiCuadrado.Enabled = false;
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            FrmGrafico grafico = new FrmGrafico(frecuenciasObservada, frecuenciaEsperada);
            //grafico.recibirParametro();
            var chart1 = grafico.devolverGrafico();
            grafico.Dispose();
            chart1.SaveImage("E:\\Rodolfo\\FACULTAD\\4 Año\\Simulación\\parte2-TP1\\hola.png", ChartImageFormat.Png);

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Lista Aleatoria";
            // storing header part in Excel  
            for (int i = 1; i < this.dgvMuestra.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = this.dgvMuestra.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < this.dgvMuestra.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dgvMuestra.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = this.dgvMuestra.Rows[i].Cells[j].Value.ToString();
                }
            }

            worksheet.Shapes.AddPicture("E:\\Rodolfo\\FACULTAD\\4 Año\\Simulación\\parte2 - TP1\\hola.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50, 300, 45);
            // save the application
            //workbook.SaveAs("E:\\Rodolfo\\FACULTAD\\4 Año\\Simulación\\TP1\\SimulacionTP1\\ExcelOutput\\output"+documentoExcel.ToString()+".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //documentoExcel += 1;
            // Exit from the application  
            //app.Quit();
        }
    }
}
#endregion