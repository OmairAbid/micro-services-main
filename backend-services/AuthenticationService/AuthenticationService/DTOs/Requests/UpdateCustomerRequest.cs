﻿using System.ComponentModel.DataAnnotations;
using AuthenticationService.Interfaces;

namespace AuthenticationService.DTOs.Requests;

public class UpdateCustomerRequest : UpdateUserRequest
{
    [MaxLength(50)] public string? FullName { get; set; }

    [MaxLength(255)] public string? Address { get; set; }

    [MaxLength(20)] public string? PhoneNumber { get; set; }
}