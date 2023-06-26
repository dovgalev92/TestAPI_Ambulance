

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServices<T>
    {
        Task InsertCommand(int id, T entity);
    }
}
