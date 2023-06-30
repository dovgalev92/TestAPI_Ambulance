

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServicesPatient<in TIn, TOut>
    {
        void AddCommandServices(TIn create);
        Task<IEnumerable<TOut>> GetAllCommandServices();
        Task<TOut> GetCommandIdServices(int id);
        Task UpdateCommandServices(TIn update);
    }
}
