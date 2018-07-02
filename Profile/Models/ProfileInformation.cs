using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile.Models
{
    public class ProfileInformation
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
        public string DateOfBirth { get; set; }

        public static ProfileInformation PI()
        {
            var profileInformation = new ProfileInformation { Bio = "Hello, my name is Abel and I am 25 years old. I am currently looking for a job as a .NET web developer. I live in Stockholm, Sweden.", CurrentOccupation = "PostNord AB", Education = "EC Utbildning, Webbutveckling inom .NET", FirstName = "Abel", LastName = "Abraha", MaritalStatus = "Single", PreviousOccupation = "They Care Hammarbygård AB", Location = "Sweden, Stockholm", Email = "AbelAbraha@hotmail.com", DateOfBirth = "1993-05-06" };
            return profileInformation;
        }
    }
}