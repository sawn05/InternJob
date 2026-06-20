using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternJob.Core.Entities
{
    public enum UserRole
    {
        Candidate = 1,
        Recruiter = 2,
        Admin = 3
    }

    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Role { get; set; } = null!; // "Candidate", "Employer", "Admin"
        public string FullName { get; set; } = null!;
        public string? Phone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public CandidateProfile? CandidateProfile { get; set; }
        public EmployerProfile? EmployerProfile { get; set; }
    }
}
