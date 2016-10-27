using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectXVI.Models
{
    public class Song
    {
        [Display(Name = "Song ID")]
        public Int32 SongID { get; set; }

        [Required(ErrorMessage = "Song name is required.")]
        [Display(Name = "Song Name")]
        public String SongName { get; set; }

        [Required(ErrorMessage = "Song price is required.")]
        [Display(Name = "Song Price")]
        public Int32 SongPrice { get; set; }

        //navigational properties
        public virtual List<Account> Account { get; set; }
        public virtual List<Genre> Genre { get; set; }
        public virtual Album Album { get; set; }
        public virtual List<Artist> Artist { get; set; }
        public virtual List<SongReview> SongReview { get; set; }
        public virtual List<OrderHistory> OrderHistory { get; set; }
        public virtual List<ShoppingCart> ShoppingCart { get; set; }

    }
}
