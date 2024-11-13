using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FelhasznaloKezeles.Pages
{
    [Authorize(Roles = "Admin")]
    //[Authorize(Policy = "CanEditAll")]
    public class VedettOldalModel : PageModel
    {
        
        public void OnGet()
        {

        }
    }
}
