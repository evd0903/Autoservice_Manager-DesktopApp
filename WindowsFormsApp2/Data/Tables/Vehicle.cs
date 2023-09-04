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
    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public string Name { get; set; }

        [ForeignKey("ClientById")]
        public long? ClientId { get; set; }

        public Client ClientById { get; set; }

    }
}