using System.ComponentModel.DataAnnotations;

namespace PersonDetails.Models;

public class AddressModel
{
    [Required]
    public string? StreetNameAddress { get; set; }

    [Required]
    [StringLength(10, MinimumLength = 3)]
    public string? PostCode { get; set; }

    [Required]
    public string? City { get; set; }
}  