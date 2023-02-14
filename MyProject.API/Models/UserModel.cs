using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers.Models
{
    public enum eHMOModel { Klalit=1, Macabi=2, Leumit=3, Meuchedet=4,Private =5}
    public enum eGenderModel {
        male=0, 
        female =1
    }
    public class UserModel
    {
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenderModel Gender { get; set; }
        public eHMOModel HMO { get; set; }
    }
}
