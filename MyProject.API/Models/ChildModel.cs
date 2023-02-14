using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers.Models
{
    public class ChildModel
    {
        public int Id { get; set; }

        public string Tz { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
