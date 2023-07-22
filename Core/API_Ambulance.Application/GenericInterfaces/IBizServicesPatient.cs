


using StatusGeneric;

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServicesPatient<in TIn, Y, T, TOut>
    {
        Task AddCommandServices(TIn create);
        Task<IEnumerable<TOut>> GetAllCommandServices();
        Task<Y> GetCommandIdServices(int id);
        Task UpdateCommandServices(int id,T update);
    }
}
