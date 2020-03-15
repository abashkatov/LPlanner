using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPlanner.Entity
{
    [Table("lp_tasks")]
    public class Task
    {
        [Key, Column("id")]
        public int Id { get; protected set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("createdon")]
        public DateTime CreatedOn { get; set; }
        [Column("updatedon")]
        public DateTime UpdatedOn { get; set; }
    }
}
