using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternJob.Core.Entities
{
    public class CandidateProfile
    {
        public int CandidateId { get; set; }
        public int UserId { get; set; }
        public string? Skills { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
        public string? AvatarUrl { get; set; }

        // Navigation
        public User User { get; set; } = null!;
    }
}
