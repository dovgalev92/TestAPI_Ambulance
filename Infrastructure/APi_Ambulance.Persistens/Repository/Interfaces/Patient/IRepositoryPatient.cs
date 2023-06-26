namespace APi_Ambulance.Persistens.Repository.Interfaces.Patient
{
    public interface IRepositoryPatient<T>
    {
        void AddNewCommandAsync(T create);
        Task<IEnumerable<T>> GetAllCommandAsync();
        Task<T> GetCommandIdAsync(int id);
        Task UpdateCommandAsync(T update);

    }
}
