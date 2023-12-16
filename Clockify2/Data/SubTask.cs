using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    [Table("SubTasks")]

    public class SubTask
    {
        [Key]
        public int st_id { get; set; }
        public int TId { get; set; }
        [Required]
        public string st_name { get; set;}
        public ICollection<ActivityLog> Activities { get; set; }
        [ForeignKey("TId")]
        public virtual Task task_Id { get; set; }

    }
}
