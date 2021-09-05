using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowReviewWebsite.Models
{
    public class Show
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number of Episodes")]
        [Range(1, 100)]
        public int EpisodeNumber { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rating { get; set; }

        public string Description { get; set; }
    }
}
