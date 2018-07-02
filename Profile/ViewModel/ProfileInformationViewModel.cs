using Profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile.ViewModel
{
    public class ProfileInformationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string CurrentOccupation { get; set; }
        public string PreviousOccupation { get; set; }
        public string Education { get; set; }
        public string MaritalStatus { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string DoB { get; set; }
        public ProfileInformation PI { get; set; }
    }
}