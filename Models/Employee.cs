using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDBFirstDemo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Please enter your Employee name"), MaxLength(50)]
    public string Employeename { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Employee Gender")]
    public string Gender { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Employee Date Of Birth")]
    public DateTime Dob { get; set; }

    [Required(ErrorMessage = "Please enter your Employee Department"), MaxLength(50)]
    public string Department { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Employee Username"), MaxLength(10)]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Employee Password"), MaxLength(10),MinLength(8)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password must contain Uppercase letter, lowercase letter and special characher.")]
    public string Password { get; set; } = null!;


    [Required(ErrorMessage = "Please enter your Employee Address"), MaxLength(80)]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Pincode")]
    public int Pincode { get; set; }
   

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Mobile No.")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public int Mobile1 { get; set; }

    [Required(ErrorMessage = "Please enter your Alternate Mobile No.")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public int Mobile2 { get; set; }
}
