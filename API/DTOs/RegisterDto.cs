using System.ComponentModel.DataAnnotations;

public class RegisterDto
{
  [Required]
  [MaxLength(100)]
  public required string UserName { get; set; }
  [Required]
  [MinLength(8)]
  public required string Password { get; set; }
}