using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockify2.Data
{
    public enum _Activty {complete , incomplete , delete , add , modify}
    [Table("Activitys")]

    public class ActivityLog
    {
        [Key]
        public int A_id { get; set; }
        public int stId { get; set; }
        public DateTime timeOfActivity { get; set;}
        public _Activty activty { get; set; }
        [ForeignKey("stId")]
        public virtual SubTask st_id { get; set; }
        //public virtual Task task_Id { get; set; }
    }
}
