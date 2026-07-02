using System.ComponentModel.DataAnnotations;

namespace InternJob.Core.DTOs.Application;

public class ApplyJobRequest
{
    [Required]
    public int CVId { get; set; }
}