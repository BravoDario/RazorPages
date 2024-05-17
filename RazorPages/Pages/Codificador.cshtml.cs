using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace RazorPages.Pages
{
    public class CodificadorModel : PageModel
    {

        [BindProperty]
        public string texto { get; set; } = "";
        [BindProperty]
        public string codificacion { get; set; } = "";
        public string mensaje { get; set; } = "";
        public void OnPost()
        {
            string[] abc = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
            
            if(codificacion=="cod") {
                texto = texto.ToUpper();
                for (int i = 0; i < texto.Length; i++)
                {
                    switch (texto[i])
                    {
                        case 'X':
                            mensaje += 'A';
                            break;
                        case 'Y':
                            mensaje += 'B';
                            break;
                        case 'Z':
                            mensaje += 'C';
                            break;
                        case ' ':
                            mensaje += ' ';
                            break;
                        default:
                            string letra = Char.ToString(texto[i]);
                            int position = Array.IndexOf(abc, letra) + 3;
                            mensaje += @abc[position];
                            break;
                    }
                }
            }
            else {
                texto = texto.ToUpper();
                for (int i = 0; i < texto.Length; i++)
                {
                    switch (texto[i])
                    {
                        case 'A':
                            mensaje += 'X';
                            break;
                        case 'B':
                            mensaje += 'Y';
                            break;
                        case 'C':
                            mensaje += 'Z';
                            break;
                        case ' ':
                            mensaje += ' ';
                            break;
                        default:
                            string letra = Char.ToString(texto[i]);
                            int position = Array.IndexOf(abc, letra) - 3;
                            mensaje += @abc[position];
                            break;
                    }
                }
            }

            ModelState.Clear();
        }
    }
}
