using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment2.Models;

public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50)]
    [Required]
    public string? Name { get; set; }

    [Column("last_name")]
    [MaxLength(255)]
    [Required]
    public string? LastName { get; set; }

    [Column("date_born")]
    [Required]
    public DateTime DateBorn { get; set; }


    [Column("phone_number")]
    [MaxLength(20)]
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string? PhoneNumber { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

  
}
