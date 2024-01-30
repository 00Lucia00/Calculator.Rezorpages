using Calculator.BLL;
using Calculator.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.UI.Pages
{
	public class IndexModel : PageModel
	{


		[BindProperty]
        public float firstnumber { get; set; }
        [BindProperty]
        public float secondnumber { get; set; }
		[BindProperty]
        public CalculationResult? calResult { get; set; }
		[BindProperty]
        public string? CalcMethod { get; set; }
        

        public void OnGet()
		{
			
		}

		public void OnPost()
		{
			Calculations calculations = new();

			if (CalcMethod != null)
			{
                calResult = calculations.Calculate(CalcMethod, firstnumber, secondnumber);
            }
		
			
		}
	}
}