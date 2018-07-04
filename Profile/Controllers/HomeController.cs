using Profile.Models;
using Profile.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Profile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProfileInformation PI = ProfileInformation.PI();
            var dateofbirth = Convert.ToDateTime(PI.DateOfBirth);
            string date = "";
            Date(ref date, dateofbirth);
            var viewModel = new ProfileInformationViewModel()
            {
                FirstName = PI.FirstName,
                LastName = PI.LastName,
                Bio = PI.Bio,
                PreviousOccupation = PI.PreviousOccupation,
                MaritalStatus = PI.MaritalStatus,
                Location = PI.Location,
                Education = PI.Education,
                CurrentOccupation = PI.CurrentOccupation,
                Email = PI.Email,
                DoB = date
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(string FirstName, string LastName, string Email,
            string MaritalStatus, string CurrentOccupation, string PrevOccupation,
            string Education, DateTime dateofbirth, string bio, string country, string city)
        {
            string date = "";
            Date(ref date, dateofbirth);
            ProfileInformation PI = ProfileInformation.PI();
            var viewModel = new ProfileInformationViewModel()
            {
                Bio = bio,
                Email = Email,
                MaritalStatus = MaritalStatus,
                CurrentOccupation = CurrentOccupation,
                Education = Education,
                FirstName = FirstName,
                LastName = LastName,
                Location = country + " " + city,
                PreviousOccupation = PrevOccupation,
                DoB = date
            };
            return View(viewModel);
        }
        public static void Date(ref string result, DateTime date)
        {
            var month = date.ToString("MMMM", CultureInfo.InvariantCulture);
            var year = date.ToString("yyyy");
            var day = date.ToString("dd");
            month = char.ToUpper(month[0]) + month.ToLower().Substring(1);
            if (day.Equals("01") || day.Equals("21"))
            {
                if (day.Equals("01"))
                    result = month + " " + day.Remove(0, 1) + "st, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 01ST - INSTEAD, IT WILL BE 1ST)
                else
                    result = month + " " + day + "st, " + year; //IF ITS NOT 1ST - THEN IT WILL BE 21ST AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else if (day.Equals("02") || day.Equals("22"))
            {
                if (day.Equals("02"))
                    result = month + " " + day.Remove(0, 1) + "nd, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 02ND - INSTEAD, IT WILL BE 2ND)
                else
                    result = month + " " + day + "nd, " + year; //IF ITS NOT 2ND - THEN IT WILL BE 22ND AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else if (day.Equals("03") || day.Equals("23"))
            {
                if (day.Equals("03"))
                    result = month + " " + day.Remove(0, 1) + "rd, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 03RD - INSTEAD, IT WILL BE 3RD)
                else
                    result = month + " " + day + "rd, " + year; //IF ITS NOT 3RD - THEN IT WILL BE 23RD AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else
            {
                if (Convert.ToInt32(day) <= 9 && Convert.ToInt32(day) >= 4) //IF THE DAY IS EQUAL/MORE THAN 4 OR EQUAL/LESS THAN 9 (NUMBERS 4 TO 9 BECAUSE ALL OF THESE NUMBERS ENDS WITH 'TH' - EXAMPLE: 4TH TO 9TH)
                    result = month + " " + day.Remove(0, 1) + "th, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 06TH - INSTEAD, IT WILL BE 6TH)
                else
                {
                    result = month + " " + day + "th, " + year; //ANY DAY BETWEEN 10 TO 20 AND 24 TO 30 - BECAUSE THEY ALL END WITH 'TH'
                }
            }
        }
        public JsonResult GetPersonalInfo()
        {
            ProfileInformation PI = ProfileInformation.PI();
            var viewModel = new ProfileInformationViewModel()
            {
                FirstName = PI.FirstName,
                LastName = PI.LastName,
                Bio = PI.Bio,
                PreviousOccupation = PI.PreviousOccupation,
                MaritalStatus = PI.MaritalStatus,
                Location = PI.Location,
                Education = PI.Education,
                CurrentOccupation = PI.CurrentOccupation,
                Email = PI.Email,
                DoB = PI.DateOfBirth
            };
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetExperience()
        {
            List<Experience> exp = Experience.Exp();
            return Json(exp, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}