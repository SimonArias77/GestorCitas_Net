using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment2.Models;

public class Availability
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("date_time")]
    [Required]
    public DateTime DateTime { get; set; }

    [ForeignKey("doctor_id")]
    public required Doctor Doctor { get; set; }
}
