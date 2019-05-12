using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoLikes.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserIp { get; set; }

        public virtual ICollection<PhotoRating> PhotoRatings { get; set; }

        public User() { }

        public User(string UserIp)
        {
            this.UserIp = UserIp;
        }
    }

    
}