using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InternJob.Core.DTOs.Auth;

public class AuthResponse
{
    public string Token { get; set; } = null!;
    public string Role { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public int UserId { get; set; }
}
