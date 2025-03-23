using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectApi.Entities.Models;

public class BookingStatus
{
    [Key]
    public int BookingStatusId { get; set; }

    [Required]
    [StringLength(100)]
    public string StatusName { get; set; } = string.Empty;
}
