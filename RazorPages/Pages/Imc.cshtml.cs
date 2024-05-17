using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class ImcModel : PageModel
    {
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";
        public double imc = 0;

        public void OnPost()
        { 
            double num1 = double.Parse(peso);
            double num2 = double.Parse(altura);
            
            imc = num1 / Math.Pow(num2/100,2);
            imc = Math.Round(imc, 2);

            ModelState.Clear();

        }

    }
}
