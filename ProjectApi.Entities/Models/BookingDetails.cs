﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectApi.Entities.Models;

public class BookingDetails
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Booking")]
    public int BookingId { get; set; }
    public Booking Booking { get; set; } = null!;

    [Required]
    [ForeignKey("SubService")]
    public int SubServiceId { get; set; }
    public SubService SubService { get; set; } = null!;

    [Required]
    [ForeignKey("ServiceProviders")]
    public int ServiceProviderId { get; set; }
    public ServiceProviders? ServiceProvider { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required]
    public int Quantity { get; set; }
}
