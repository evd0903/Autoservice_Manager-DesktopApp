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
    [Table("Details")]
    public class Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public string Name { get; set; }

        public long Count { get; set; }

        public string Code { get; set; }

        public double BuyPrice { get; set; }

        public double SalePrice { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}";// -{Age}"
        }

    }
}