using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InternJob.Core.DTOs.Auth;

public class RegisterRequest
{
    [Required]
    [EmailAddress]
    [MaxLength(150)]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = null!;

    [MaxLength(15)]
    public string? Phone { get; set; }

    [Required]
    [RegularExpression("^(Candidate|Employer)$", ErrorMessage = "Role chỉ được là 'Candidate' hoặc 'Employer'")]
    public string Role { get; set; } = null!;

    // Bắt buộc nếu Role = Employer
    public string? CompanyName { get; set; }
}
