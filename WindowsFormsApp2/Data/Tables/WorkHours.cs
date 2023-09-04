using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqliteCodeFirst.Data.Tables
{
    [Table("WorkHours")]
    public class WorkHours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("EmployeeById")]
        public long? EmployeeId { get; set; }

        public Employee EmployeeById{ get; set; }

        public override string ToString()
        {
            return $"{Id}";// -{Age}"
        }

    }
}