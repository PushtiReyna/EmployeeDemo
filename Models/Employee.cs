using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDBFirstDemo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }
    [Required(ErrorMessage = "Please enter your Employee name"), MaxLength(50)]
    public string Employeename { get; set; } = null!;
    [Required(ErrorMessage = "Please enter your Employee Gender"), MaxLength(50)]
    public string Gender { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Department { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int Pincode { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; } = null!;

    public int Mobile1 { get; set; }

    public int Mobile2 { get; set; }
}
