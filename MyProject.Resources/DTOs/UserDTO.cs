using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eHMODTO { Klalit, Macabi, Leumit, Meuchedet,Private }
    public enum eGender { male, female }
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGender Gender { get; set; }
        public eHMODTO HMO { get; set; }
    }
}