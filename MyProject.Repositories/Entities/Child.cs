using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
   public class Child
    {
      //  [Key, Required]
        public int ChildId { get; set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        //public User User { get; set; }

    }
}
