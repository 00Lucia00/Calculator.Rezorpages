using Calculator.BLL;
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

        public float result { get; set; }

        public string? CalcMethod { get; set; }
        

        public void OnGet()
		{
			
		}

		public void OnPost()
		{
            
		}
	}
}