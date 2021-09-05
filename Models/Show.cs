﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowReviewWebsite.Models
{
    public class Show
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number of Episodes")]
        public int EpisodeNumber { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rating { get; set; }

    }
}
