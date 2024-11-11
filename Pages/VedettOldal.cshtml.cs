using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FelhasznaloKezeles.Pages
{
    [Authorize(Roles = "Admin")]
    public class VedettOldalModel : PageModel
    {
        
        public void OnGet()
        {

        }
    }
}
