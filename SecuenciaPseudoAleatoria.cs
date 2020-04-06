using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SecuenciaPseudoAleatoria
    {        
        private int m, a, c, ultimaRaiz;
        private bool modoMultiplicativo;
 
        //constructores
        public SecuenciaPseudoAleatoria(int raiz, int a, int m)
        {
            modoMultiplicativo = true;
            this.m = m;
            this.a = a;
            ultimaRaiz = raiz;
        }
               
        public SecuenciaPseudoAleatoria(int raiz, int a, int m, int c)
        {
            modoMultiplicativo = false;
            this.m = m;
            this.a = a;
            this.c = c;
            ultimaRaiz = raiz;
        }

        public string obtenerSiguienteNumeroEnString()
        {
            return obtenerSiguienteNumero().ToString();
        }

        public int obtenerSiguienteNumero()
        {
            int x = ultimaRaiz;

            if (modoMultiplicativo)
            {
                x = ((a) * x) % (m);
            }
            else
            {
                x = ((a) * x + c) % (m);
            }

            ultimaRaiz = x;
            return x;
        }

    }
}
