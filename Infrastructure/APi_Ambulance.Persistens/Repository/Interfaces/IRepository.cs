

namespace APi_Ambulance.Persistens.Repository.Interfaces
{
    public interface IRepository<T>
    {
        void AddNewCommandAsync(T create);
        Task<IEnumerable<T>> GetAllCommandAsync();
        Task<T> GetCommandIdAsync(int id);
        Task UpdateCommandAsync(T update);
        
    }
}
