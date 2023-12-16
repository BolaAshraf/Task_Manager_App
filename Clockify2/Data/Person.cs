using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    public enum _Gender { Male, Female }
    [Table("Persons")]

    public class Person
    {
        [Key]
        public int P_Id { get; set; }
        [Required]
        public string P_Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string pass { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        [Required]
        public _Gender gender { get; set; }
        public string? imagelocation { get; set; }
        public DateTime registeredAt { get; set; }
        public ICollection<MembersOfTeam> Members { get; set; }
        public ICollection<Task> Tasks { get; set; }

    }
}


