using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eGender { male, female }
    public enum eHMO { klalit, Macabi, Leumit, Meuchedet, Private }

    [Index(nameof(User.Tz), IsUnique = true)]
    public class User
    {
       // [Key, Required]
        public int UserId { get; set; }
        [Required]
        //[StringLength(9)]
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGender  Gender { get; set; }
        public eHMO HMO { get; set; }

    }
}
