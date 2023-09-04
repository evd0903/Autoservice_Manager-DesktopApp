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
    [Table("SaledDetail")]
    public class SaledDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]

        [ForeignKey("DetailById")]
        public long? DetailId { get; set; }

        public Detail DetailById { get; set; }

        [ForeignKey("ClientById")]
        public long? ClientId { get; set; }

        public Client ClientById { get; set; }

        [ForeignKey("VehicleById")]
        public long? VehicleId { get; set; }

        public Vehicle VehicleById { get; set; }

        public long SaleCount { get; set; }

        public DateTime SaleDateTime { get; set; }

        public double Income { get; set; }

    }
}