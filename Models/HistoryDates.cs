using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment2.Models;

public class HistoryDates
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("date_time")]
    [Required]
    public DateTime DateTime { get; set; }

    [Column("reason")]
    [MaxLength(50)]
    [Required]
    public string? Reason { get; set; }

    [Column("appointment_id")]
    [ForeignKey("Appointment")]
    public int AppointmentId { get; set; }

    public Appointment? Appointment { get; set; }
}
