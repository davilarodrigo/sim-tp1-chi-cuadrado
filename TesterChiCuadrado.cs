using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TesterChiCuadrado
    {


        public List<double> rangosIntervalos;

        public List<int> obtenerFrecuencia(List<double> muestra)
        {
            //esta sobrecarga es para que, si no se especifica un numero de intervalos, se calcula
            //automaticamente la cantidad recomendada, que es k = raiz cuadrada de n

            int k;
            int n;
            n = muestra.Count;
            k = (int) Math.Ceiling(Math.Sqrt(n));
            
            return obtenerFrecuencia(muestra, k);
        }

        public List<int> obtenerFrecuencia(List<double> muestra, int intervalos)
        {
            int n = muestra.Count;
            int k = intervalos;
            //double limiteDelIntervalo; 

            List<int> frecuenciaObservada = new List<int>();
            rangosIntervalos = new List<double>();
                       
            //la lista frec observada tiene q tener la misma longitud q la de intervalos
            //y se inicializa con todo en cero
            for (int i = 0; i < k; i++)
            {//este for se puede hacer en un solo reglon?¿¿
                frecuenciaObservada.Add(0);
            }

            //i deberia empezar en 1
            for (int i = 1; i <= k; i++)
            {
                double dividendo = Convert.ToDouble(i);
                double divisor = Convert.ToDouble(k);
                
                double limiteDelIntervalo = (double) ((double) i) / ((double) k);
              
                rangosIntervalos.Add(limiteDelIntervalo);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {

                    //rango intervalos guarda el valor "limite" donde termina cada intervalo
                    //aca lo que se hace es, si el valor "i" de la muestra, es menor al valor "j" del rango
                    //de intervalos (es decir, es menor al valor maximo del intervalo), entonces al valor "j"
                    //de la lista de frecuencia observada, se le suma uno

                    if (muestra[i]<rangosIntervalos[j])
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
