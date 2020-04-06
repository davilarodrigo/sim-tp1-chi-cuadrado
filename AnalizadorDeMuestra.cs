using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AnalizadorDeMuestra
    {

        List<double> limitesInferioresDeIntervalos;
        List<double> limitesSuperioresDeIntervalos;
        List<double> muestra;
        List<int> frecuenciaObservada;  //no se usa

        public List<double> LimitesInferioresDeIntervalos { get => limitesInferioresDeIntervalos; }
        public List<double> LimitesSuperioresDeIntervalos { get => limitesSuperioresDeIntervalos; }
        
        public List<double> Muestra { get => muestra; }
        
        int n; //tamaño de la muestra
        int k; //cantidad de intervalos

        public AnalizadorDeMuestra(List<double> muestra)
        {
            this.muestra = muestra;
            n = muestra.Count;
        }

        public double calcularChiCuadrado()
        {
            int frecuenciaEsperada = obtenerFrecuenciaEsperada();

            double sumatoria = 0;

            for (int i = 0; i < k; i++)
            {
                sumatoria += (Math.Pow(frecuenciaObservada[i] - (double)frecuenciaEsperada, 2)) / (double)frecuenciaEsperada;
            }

            return Math.Truncate(sumatoria* 100000)/100000;
        }

        public int obtenerFrecuenciaEsperada(int k)
        {
            return (int)Math.Floor((double)n / (double)k);
        }

        public int obtenerFrecuenciaEsperada()
        {
            return (int) Math.Floor( (double)n / (double)k);
        }
        
        public List<int> obtenerFrecuenciaObservada()
        {
            return obtenerFrecuenciaObservada(0);
        }

        public List<int> obtenerFrecuenciaObservada(int cantidadDeIntervalos)
        {
            k = cantidadDeIntervalos;
            frecuenciaObservada = new List<int>();
            limitesSuperioresDeIntervalos = new List<double>();
            limitesInferioresDeIntervalos = new List<double>();
            n = muestra.Count;

            if (k == 0) k = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 0; i < k; i++)
            {//este for se puede hacer en un solo reglon?¿¿
                frecuenciaObservada.Add(0);
            }

            for (int i = 1; i <= k; i++)
            {
                double limiteDelIntervalo = (double)((double)i) / ((double)k);

                limitesInferioresDeIntervalos.Add(limiteDelIntervalo - (((double)1) / ((double)k)));
                limitesSuperioresDeIntervalos.Add(limiteDelIntervalo);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (muestra[i] < limitesSuperioresDeIntervalos[j])
                    {
                        frecuenciaObservada[j]++;
                        break;
                    }
                }
            }
            return frecuenciaObservada;
        }


    }
}
