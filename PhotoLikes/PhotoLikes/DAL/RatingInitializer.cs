using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhotoLikes.Models;

namespace PhotoLikes.DAL
{
    public class RatingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RatingContext>
    {
        protected override void Seed(RatingContext context)
        {
            var photos = new List<Photo>
            {
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/04/24/15/31/rotterdam-4152380__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/04/29/01/00/zoo-4164889__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2018/03/27/21/43/startup-3267505__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/03/29/21/21/bleed-4090095__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2018/06/09/15/57/aircraft-3464648__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/04/24/12/35/ivy-4152057__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2017/07/26/18/50/lighthouse-2542726__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/05/01/09/56/drop-of-water-4170406__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2014/08/08/21/02/iceland-413702__340.jpg"},
                new Photo{PhotoUrl="https://cdn.pixabay.com/photo/2019/04/26/23/07/duisburg-4158910__340.jpg"}
            };
            photos.ForEach(s => context.Photos.Add(s));

            context.SaveChanges();
        }
    }
}