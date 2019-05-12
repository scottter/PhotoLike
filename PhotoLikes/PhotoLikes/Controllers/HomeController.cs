using PhotoLikes.DAL;
using PhotoLikes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoLikes.Controllers
{
    public class HomeController : Controller
    {
        private RatingContext db = new RatingContext();

        public ActionResult Index()
        {
            User user = db.Users.FirstOrDefault(u => u.UserIp == Request.UserHostAddress);
            if (user == null)
            {
                User NewUser = new User(Request.UserHostAddress);
                db.Users.Add(NewUser);
                db.SaveChanges();
                System.Web.HttpContext.Current.Session["UserID"] = NewUser.ID;
            }
            else
            {
                System.Web.HttpContext.Current.Session["UserID"] = user.ID;
            }
            

            Random random = new Random();
            int num = random.Next(1,11);
            Photo photo = db.Photos.Single(ph => ph.ID == num);
            return View(photo);
        }

        [HttpPost]
        public ActionResult RatePhoto(int PhotoId, string PhotoRating)
        {
            int UserID = Convert.ToInt32(Session["UserID"]);
            PhotoRating photoRating = new PhotoRating(UserID, PhotoId, PhotoRating);
            db.PhotoRatings.Add(photoRating);
            db.SaveChanges();
            return View();
        }

        public ActionResult History(int UserID)
        {
            User user = db.Users.FirstOrDefault(u => u.ID == UserID);
            if (user == null)
            {
                ViewBag.Error = "No history found. Please rate some photos.";
                return View();
            }
            else
            {
                System.Web.HttpContext.Current.Session["UserID"] = user.ID;
                return View(user);
            }

            
        }

    }
}