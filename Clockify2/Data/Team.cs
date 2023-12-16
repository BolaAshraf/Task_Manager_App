using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    [Table("Teams")]

    public class Team
    {
        [Key]
        public int teamId { get; set; }
        [Required]
        public string teamName { get; set; }
        public ICollection<MembersOfTeam> Members { get; set; }
        //public ICollection<Task> Tasks { get; set; }


    }
}
