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
    public class DeleteModel : PageModel
    {
        private readonly ShowReviewWebsite.Data.ShowReviewWebsiteContext _context;

        public DeleteModel(ShowReviewWebsite.Data.ShowReviewWebsiteContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Show.FindAsync(id);

            if (Show != null)
            {
                _context.Show.Remove(Show);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
