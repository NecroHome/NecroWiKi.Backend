using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NecroWiKi.Application.Models.Database
{
    [Table("EXAMPLE")]
    public class ExampleModel
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("NAME")]
        public string? Name { get; set; }
    }
}
