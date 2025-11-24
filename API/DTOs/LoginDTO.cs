using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class LoginDTO
{

    [Required]
    [EmailAddress]
    public required string Email { get; set; } = "";

    [Required]
    [MinLength(8)]
    public required string Password { get; set; } = "";
}
