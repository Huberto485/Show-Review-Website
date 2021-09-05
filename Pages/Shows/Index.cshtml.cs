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
    public class IndexModel : PageModel
    {
        private readonly ShowReviewWebsite.Data.ShowReviewWebsiteContext _context;

        public IndexModel(ShowReviewWebsite.Data.ShowReviewWebsiteContext context)
        {
            _context = context;
        }

        public IList<Show> Show { get;set; }

        public async Task OnGetAsync()
        {
            Show = await _context.Show.ToListAsync();
        }
    }
}
