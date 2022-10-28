using System.ComponentModel.DataAnnotations;

namespace liteThinkingBe.Data;

public class Company
{
    [Key]
    [Required]
    public string Nit { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(500)]
    public string Address { get; set; }
    
    [Required]
    public int Phone { get; set; }
}