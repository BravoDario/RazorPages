using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace RazorPages.Pages
{
    public class ecuacionModel : PageModel
    {
        [BindProperty]
        public string numx { get; set; } = "";
        [BindProperty]
        public string numy { get; set; } = "";
        [BindProperty]
        public string numa { get; set; } = "";
        [BindProperty]
        public string numb { get; set; } = "";
        [BindProperty]
        public string numn { get; set; } = "";

        public double total = 0;

        public void OnPost() {

            double a = double.Parse(numa), 
                b = double.Parse(numb), 
                x = double.Parse(numx), 
                y = double.Parse(numy), 
                n = double.Parse(numn);
            total = 0;
            
            for(int k = 0; k <= n; k++) { 
                total += (numeral(n, k)) * Math.Pow((a * x), (n - k)) * Math.Pow((b * y), k);
            }

            ModelState.Clear();
        }


        public double numeral(double n, double k)
        {
            double factorialN = 1;
            double factorialK = 1;
            double factorialDif = 1;

            for(int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK = factorialK * i;
            }
            for(int i = 1;i <= (n - k); i++)
            {
                factorialDif = factorialDif * i;
            }

            return (factorialN) / (factorialK * factorialDif);
        }
    }
}
