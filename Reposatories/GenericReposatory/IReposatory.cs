namespace Library_Management_System.Reposatories.GenericReposatory
{
    public interface IReposatory<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetOne(int id);

        Task AddNew(T item);
        Task Update(int id);
        void Delete(int id);
    }
}
