namespace InternJob.Core.DTOs.CV;

public class UploadCVResponse
{
    public int CVId { get; set; }
    public string FileName { get; set; } = null!;
    public DateTime UploadedAt { get; set; }
}