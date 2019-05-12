using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoLikes.Models
{
    public class PhotoRating
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PhotoID { get; set; }
        public string Rating { get; set; }

        public virtual Photo Photo { get; set; }
        public virtual User User { get; set; }

        public PhotoRating () { }

        public PhotoRating(int UserID, int PhotoID, string PhotoRating)
        {
            this.UserID = UserID;
            this.PhotoID = PhotoID;
            this.Rating = PhotoRating;
        }


    }
}