using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Entities.Models;

public class Users
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [StringLength(50)]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Password { get; set; } = string.Empty;

    [StringLength(50)]
    public string? Role { get; set; }

    [StringLength(15)]
    public string? TelephoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [Required]
    [StringLength(10)]
    public string Gender { get; set; } = string.Empty;
}
