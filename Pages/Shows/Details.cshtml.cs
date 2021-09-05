using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShowReviewWebsite.Data;
using ShowReviewWebsite.Models;

namespace ShowReviewWebsite.Pages.Shows
{
    public class DetailsModel : PageModel
    {
        private readonly ShowReviewWebsite.Data.ShowReviewWebsiteContext _context;

        public DetailsModel(ShowReviewWebsite.Data.ShowReviewWebsiteContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Show.FirstOrDefaultAsync(m => m.ID == id);

            if (Show == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
