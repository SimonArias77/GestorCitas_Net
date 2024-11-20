using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment2.Models;

[Table("administrators")]
public class Administrator
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Column("password")]
    [MaxLength(255)]
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
