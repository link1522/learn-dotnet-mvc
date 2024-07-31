using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloMVC.Models;

public class Book
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public uint id { get; set; }

  [Required]
  [StringLength(255)]
  public string name { get; set; } = null!;

  [Required]
  [StringLength(255)]
  public string url { get; set; } = null!;

}
