using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    [Table("Members")]

    public class MembersOfTeam
    {
        [Key]
        public int JoinId { get; set; }
        public int PId { get; set; }
        public int TId { get; set; }
        [ForeignKey("PId")]
        public virtual Person P_Id { get; set; }
        [ForeignKey("TId")]
        public virtual Team team_Id { get; set; }
    }
}
