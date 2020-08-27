using System.Collections.Generic;
using System.Linq;

namespace Informatica.Negocio
{
    public class Ordenacion
    {
        public List<int> Burbuja(int[] valores)
        {
            int contiene = 0;
            var numeros = new List<int>();

            for (int f = 1; f < valores.Length; f++)
            {
                for (int g = 0; g < valores.Length - f; g++)
                {
                    if (valores[g] > valores[g + 1])
                    {
                        contiene = valores[g];
                        valores[g] = valores[g + 1];
                        valores[g + 1] = contiene;
                    }
                }
                numeros = valores.ToList(); /*OfType<int>().ToList();*/
            }
            return numeros;
        }

        public List<int> QuickSort(int[] valores, int inicial, int final)
        {
            var numeros = new List<int>();
            int i, j, central;
            double pivote;
            central = (inicial + final) / 2;
            pivote = valores[central];
            i = inicial;
            j = final;
            do
            {
                while (valores[i] < pivote) i++;
                while (valores[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = valores[i];
                    valores[i] = valores[j];
                    valores[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicial < j)
            {
                QuickSort(valores, inicial, j);
            }
            if (i < final)
            {
                QuickSort(valores, i, final);
            }
            numeros = valores.OfType<int>().ToList();

            return numeros;
        }

        public List<int> ShellShort(int[] valores)
        {
            var numeros = new List<int>();
            int salto, sw, au, e = 0;

            salto = valores.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (valores.Length - salto))
                    {
                        if (valores[e - 1] > valores[(e - 1) + salto])
                        {
                            au = valores[(e - 1) + salto];
                            valores[(e - 1) + salto] = valores[e - 1];
                            valores[(e - 1)] = au;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
                numeros = valores.OfType<int>().ToList();
            }
            return numeros;
        }
    }
}