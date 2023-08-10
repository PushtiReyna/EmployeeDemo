using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDBFirstDemo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Please enter your  name"), MaxLength(10)]
    public string Employeename { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Gender")]
    public string Gender { get; set; } = null!;
    [Required(ErrorMessage = "Please enter your  Date Of Birth")]
    public DateTime Dob { get; set; }
    [Required(ErrorMessage = "Please enter your Department"), MaxLength(10)]
    public string Department { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Username"), MaxLength(10)]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Password"),MinLength(6),MaxLength(10)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",ErrorMessage = "Password must contain uppercase letter,lowercase letter and special chararcters.")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Address"), MaxLength(50)]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Pincode")]
    public int Pincode { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Mobile no."), MaxLength(10),MinLength(10)]
    public string? Mobile1 { get; set; }

    [Required(ErrorMessage = "Please enter your Mobile no."), MaxLength(10), MinLength(10)]
    public string? Mobile2 { get; set; }
}
