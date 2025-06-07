using IntelTaskUCR.Domain.Entities;



namespace IntelTaskUCR.Domain.interfaces
{
    public interface IDemoRepository
    {
        Task<IEnumerable<EDemo>> GetAllAsync();

        Task<EDemo?> GetByIdAsync(int id);

        Task AddSync(EDemo demo);

        Task UpdateSync(EDemo demo);

        Task DeleteAsync(int id);
    }
}
