using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment2.Models;

[Table("appointments")]

public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("date_time")]
    [Required]
    public DateTime DateTime { get; set; }

    [Column("status")]
    [MaxLength(10)]
    [Required]
    public string? Status { get; set; }

    [ForeignKey("patient_id")]
    public required Patient Patient { get; set; }

    [ForeignKey("doctor_id")]
    public required Doctor Doctor { get; set; }

   

    [Column("reason")]
    [MaxLength(10)]
    [Required]
    public string? Reason { get; internal set; }
}
