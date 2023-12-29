using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    public enum _priority {extremely_important , important , medium , easy}
    [Table("Tasks")]

    public class Task
    {
        [Key]
        public int taskId { get; set; }
        public int PId { get; set; }
        [Required]
        public string taskName { get; set; }
        public _priority priority { get; set; }
        public string description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public ICollection<ActivityLog> Activities { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
        [ForeignKey("PId")]
        public virtual Person P_Id { get; set; }

        //public static implicit operator Task(Task v)
        //{
        //    throw new NotImplementedException();
        //}
        //public virtual Team team_Id { get;  set; }

    }
}
