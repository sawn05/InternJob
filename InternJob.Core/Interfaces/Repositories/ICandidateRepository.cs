using InternJob.Core.Entities;

namespace InternJob.Core.Interfaces.Repositories;

public interface ICandidateRepository
{
    Task<CandidateProfile?> GetByUserIdAsync(int userId);
}