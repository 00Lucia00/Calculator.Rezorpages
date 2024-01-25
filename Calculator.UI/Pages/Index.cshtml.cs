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
		public int firstnumber { get; set; }
		[BindProperty]
		public int secoundnumber { get; set; }

		public int result { get; set; }

		public void OnGet()
		{
			new DataAccess().GetData();
		}

		public void OnPost()
		{
			result = new Calculations().Add(firstnumber, secoundnumber);
		}
	}
}