using System;
using System.ComponentModel.DataAnnotations;
namespace ShowReviewWebsite.Models
{
    public class Show
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int EpisodeNumber { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }

    }
}
