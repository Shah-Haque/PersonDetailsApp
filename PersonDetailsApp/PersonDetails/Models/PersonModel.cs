using System.ComponentModel.DataAnnotations;

namespace PersonDetails.Models;

public class PersonModel
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public int Age { get; set; }

}