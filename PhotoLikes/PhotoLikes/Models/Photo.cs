using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhotoLikes.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string PhotoUrl { get; set; }

        public virtual ICollection<PhotoRating> PhotoRatings { get; set; }
    }
}