using Calculator.BLL;
using Calculator.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.UI.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		[BindProperty]
        public float FirstNumber { get; set; }
        [BindProperty]
        public float SecondNumber { get; set; }

        public float result { get; set; }

        public string? CalcMethod { get; set; }
        

        public void OnGet()
		{
			new DataAccess().GetData();
		}

		public void OnPost()
		{
			result = new Calculations().Add(FirstNumber, SecondNumber);
		}
	}
}