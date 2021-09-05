using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowReviewWebsite.Models;

namespace ShowReviewWebsite.Data
{
    public class ShowReviewWebsiteContext : DbContext
    {
        public ShowReviewWebsiteContext (DbContextOptions<ShowReviewWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<ShowReviewWebsite.Models.Show> Show { get; set; }
    }
}
