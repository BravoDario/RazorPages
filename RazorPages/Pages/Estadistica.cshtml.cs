using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace RazorPages.Pages
{
    public class EstadisticaModel : PageModel
    {
        public int[] numeros = new int[20];
        public double suma = 0;
        public double media = 0;
        public double moda = 0;
        public double mediana = 0;
        public void OnPost()
        {
            int maxRepeticion = 0;
            for (int i = 0; i < 20; i++)
            {
                int locNumero = RandomNumberGenerator.GetInt32(100);
                numeros[i] = locNumero;
                suma += locNumero;
            }
            Array.Sort(numeros);

            for (int i = 0; i < 20; i++)
            {
                int repeticion = 0;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        repeticion++;
                    }
                }

                if (repeticion > maxRepeticion)
                {
                    moda = numeros[i];
                    maxRepeticion = repeticion;
                }
            }

            media = suma / numeros.Length;
            mediana = (numeros[9] + numeros[10])/2;

            ModelState.Clear();
        }
    }
}
