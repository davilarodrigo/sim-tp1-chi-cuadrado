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
    public partial class FrmGeneradorPseudoAleatorio : Form
    {          
        #region declaracion variables
        
        // nose si van
        List<double> lista=new List<double>();
        bool listaGenerada = false;
        int indiceLista = 0;
        int longitudLista = 20;
        double valorTruncado;
        //---
        
        bool modoMultiplicativo = false;
        bool modoKyG = true;

        SecuenciaPseudoAleatoria secuencia;

        int valorRaiz;
        int k;
        int g;
        int c;
        int m;
        int a;
        #endregion

        #region funciones

       

        bool validarTextBoxs()
        {
            if (txtLongitudLista.Text == "") return false;
            longitudLista= Convert.ToInt32(txtLongitudLista.Text);

            if (txtValorRaiz.Text == "") return false;
            valorRaiz = Convert.ToInt32(txtValorRaiz.Text);

            if (modoKyG)
            {
                if (txtG.Text == "") return false;
                g = Convert.ToInt32(txtG.Text);

                if (txtK.Text == "") return false;
                k = Convert.ToInt32(txtK.Text);
            }
            else
            {
                if (txtA.Text == "") return false;
                a = Convert.ToInt32(txtA.Text);

                if (txtM.Text == "") return false;
                m = Convert.ToInt32(txtM.Text);
            }

            if (!modoMultiplicativo)
            {
                if (txtC.Text == "") return false;
                c = Convert.ToInt32(txtC.Text);
            }
            else
            {
                if (valorRaiz % 2 == 0)
                {
                    txtValorRaiz.Text = "ingrese valor impar";
                    return false;
                }
            }

            return true;
        }

        void actualizarValoresEInterfaz()
        {

            modoMultiplicativo = radioMultiplicativo.Checked;
            txtC.Enabled = !modoMultiplicativo;

            modoKyG = radioKyG.Checked;
                                             
            txtA.Enabled = !modoKyG;         
            txtM.Enabled = !modoKyG;         
            txtG.Enabled = modoKyG;          
            txtK.Enabled = modoKyG;          

            if (modoMultiplicativo)
            {
                lblMetodo.Text = "Metodo: Multiplicativo";
            }
            else
            {
                lblMetodo.Text = "Metodo: Lineal";
            }

        }

        void definirValores()
        {

            if (modoKyG)
            {                

                if (modoMultiplicativo) a = 3 + 8 * k;                
                else a = 1 + (4 * k);

                m = 1;

                for (int i = 0; i < g; i++)
                {
                    m *= 2;
                }
            }
                       
        }
        /// funciones
       /* int generarNumero(int x)
        {
            if (modoMultiplicativo)
            {

                x = ((a) * x) % (m);
            }
            else
            {

                x = ((a) * x + c) % (m);
            }
            return x;
        }
        
        List<double> generarLista()
        {
            List<double> lista = new List<double>();
            for (int i = 0; i < longitudLista; i++)
            {
                valorRaiz = generarNumero(valorRaiz);
                //lista.Add(Math.Round(valorRaiz / (m - 1),4));

                valorTruncado = (Math.Truncate(Convert.ToDouble(valorRaiz)/(m - 1) * 10000) )/ 10000;

                lista.Add(valorTruncado);
            }
            //MessageBox.Show("Lista generada", "Lista generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return lista;
        }*/

        void generarSiguienteNumero()
        {

            indiceLista++;
            lblIteracion.Text = "Iteracion: " + indiceLista.ToString();

            int ultimoValor = secuencia.obtenerSiguienteNumero();

            double valorTruncado = (Math.Truncate(Convert.ToDouble(ultimoValor) / (m - 1) * 10000)) / 10000;

            dataGridViewValoresLista.Rows.Add(indiceLista, valorTruncado);

            lista.Add(valorTruncado);

            lblNumero.Text = "Ultimo numero generado: " + valorTruncado.ToString();
                                 
            /*if (indiceLista == longitudLista)
            {
                lblNumero.Text = "Fin lista";
                btnGenerarNuevaLista.Enabled = true;
                btnSiguiente.Enabled = false;
            }
            else
            {
                lblNumero.Text = lista[indiceLista].ToString();
                indiceLista++;
            }*/


        }

        #endregion

        #region click botones        

        private void btnGenerarNuevaLista_Click(object sender, EventArgs e)
        {
            btnGenerarNuevaLista.Enabled = false;
            btnGenerar.Enabled = true;
            lblNumero.Text = "";
            indiceLista = 0;
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            txtValorRaiz.Text = "";
            txtC.Text = "";
            txtK.Text = "";
            txtG.Text = "";
            txtM.Text = "";
            txtA.Text = "";
            txtLongitudLista.Text = "";
            dataGridViewValoresLista.ColumnCount = 2;
            dataGridViewValoresLista.Columns[0].HeaderText = "Iterac.";
            dataGridViewValoresLista.Columns[1].HeaderText = "Valor";
            dataGridViewValoresLista.Columns[0].Width = 50;
            dataGridViewValoresLista.Columns[1].Width = 100;
            dataGridViewValoresLista.Rows.Clear();
            txtLongitudLista.Text = "";
            txtLongitudLista.Enabled = true;
            button1.Enabled = false;
            txtValorRaiz.Enabled = true;
            label2.Text = "Raiz Utilizada:";
            lblIteracion.Text = "Iteracion: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si se esta en modo multiplicativo, el valor raiz tiene q ser impar, y no se usa C
            //a es 3+8k       
            //if (!modoMultiplicativo)
            //k = Convert.ToInt32(txtK.Text);
            //g = Convert.ToInt32(txtG.Text);
            
            if (!validarTextBoxs())            
            {
                MessageBox.Show("Porfavor ingrese un valor", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //generacion lista
            definirValores();
            label2.Text = "Valor Raiz Utilizado: " + valorRaiz.ToString();

            if (modoMultiplicativo) secuencia = new SecuenciaPseudoAleatoria(valorRaiz, a, m);
            else secuencia = new SecuenciaPseudoAleatoria(valorRaiz, a, m,c);
            
            //lista = generarLista();
            listaGenerada = true;
            indiceLista = 1;

            for (int i = 0; i < longitudLista; i++)
            {
                generarSiguienteNumero();
            }


            //ajuste botones
            //btnSiguiente.Enabled = true;
            txtValorRaiz.Enabled = false;
            btnGenerar.Enabled = false;
            if (indiceLista == (longitudLista + 1))
            {
                button1.Enabled = true;
                btnGenerarNuevaLista.Enabled = true;
                txtLongitudLista.Enabled = false;
                groupBox4.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;
            }
                                         }        

     

        #endregion

        #region otros

        public FrmGeneradorPseudoAleatorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarValoresEInterfaz();
            lblNumero.Text = "";
            btnGenerarNuevaLista.Enabled = false;

            dataGridViewValoresLista.ColumnCount = 2;
            dataGridViewValoresLista.Columns[0].HeaderText = "Iterac.";
            dataGridViewValoresLista.Columns[1].HeaderText = "Valor";
            dataGridViewValoresLista.Columns[0].Width = 50;
            dataGridViewValoresLista.Columns[1].Width = 100;

        }

        private void radioKyG_CheckedChanged(object sender, EventArgs e)
        {
            actualizarValoresEInterfaz();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            actualizarValoresEInterfaz();
        }

        private void radioMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarValoresEInterfaz();
        }

        #endregion

        #region vacios

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (listaGenerada)
            {

            }

        }

        private void txtLongitudLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParam1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void txtParam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }



        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

  
        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtLongitudLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMetodo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            generarSiguienteNumero();
        }

        private void btnAnalisiChi_Click(object sender, EventArgs e)
        {
            if (lista != null)
            {
                FrmAnalisisChiCuadrado form = new FrmAnalisisChiCuadrado(lista);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha generado una lista de valores", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
#endregion