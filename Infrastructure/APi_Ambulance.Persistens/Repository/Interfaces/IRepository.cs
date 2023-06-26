

namespace APi_Ambulance.Persistens.Repository.Interfaces
{
    public interface IRepository<in Tin, TOut>
    {
        void AddNewCommandAsync(Tin create);
        Task<IEnumerable<TOut>> GetAllCommandAsync();
        Task<TOut> GetCommandIdAsync(int id);
        Task UpdateCommandAsync(Tin update);
        
    }
}
