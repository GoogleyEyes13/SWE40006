using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RandomBookGenerator.Pages
{
    public class HealthModel : PageModel
    {
        public string Status { get; set; } = "";

        public void OnGet()
        {
            Status = "Healthy";
        }
    }
}

