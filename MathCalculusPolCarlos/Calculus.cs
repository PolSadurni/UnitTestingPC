using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculusPolCarlos
{
    class Calculus
    {
        public int GenerarAleatorio(int minimo, int maximo)
        {
            Random aleatorio = new Random();
            int numeroaleatorio;
            numeroaleatorio = aleatorio.Next(minimo,maximo);
            return numeroaleatorio;
        }

        public int generarMCD(int num1, int num2)
        {
            int remanent;

            while (num2 != 0)
            {
                remanent = num1 % num2;
                num1 = num2;
                num2 = remanent;
            }

            return num1;
        }

        public int generarMCM(int a, int b)
        {
            return (a / MCMCalculus(a, b)) * b;
        }
        public int MCMCalculus(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public List<int> setCalculs(int num1, int num2)
        {
            List<int> lista = new List<int>();
            int sumaNumeros, PrimeroMenosSegundo, SegundoMenosPrimero, 
                MultiplicacionNumeros, PrimeroEntreSegundo, SegundoEntrePrimero;

            
            lista.Add(sumaNumeros = num1 + num2);
            lista.Add(PrimeroMenosSegundo = num1 - num2);
            lista.Add(SegundoMenosPrimero = num2 - num1);
            lista.Add(MultiplicacionNumeros = num1 * num2);
            if (num1 == 0|| num2 == 0)
            {
               DivideByZeroException ex = new DivideByZeroException("You can't divide by Zero!");
               MessageBox.Show(ex.ToString());

            }
            else
            {

                lista.Add(PrimeroEntreSegundo = Convert.ToInt32(num1 / num2));
                lista.Add(SegundoEntrePrimero = Convert.ToInt32(num2 / num1));
            }

            return lista;
        }
    }
}
