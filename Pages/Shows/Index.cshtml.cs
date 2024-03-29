﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<Show> Show { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShowGenre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from s in _context.Show
                                            orderby s.Genre
                                            select s.Genre;

            var shows = from s in _context.Show
                        select s;

            if(!string.IsNullOrEmpty(SearchString))
            {
                shows = shows.Where(s => s.Title.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(ShowGenre))
            {
                shows = shows.Where(x => x.Genre == ShowGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Show = await shows.ToListAsync();
        }
    }
}
