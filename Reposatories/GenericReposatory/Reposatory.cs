namespace Library_Management_System.Reposatories.GenericReposatory
{
    public class Reposatory<T> : IReposatory<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbset;
        public Reposatory(ApplicationDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }
        public T GetOne(int id)
        {
            return _dbset.Find(id);
        }
        public Task AddNew(T item)
        {
            throw new NotImplementedException();
        }
        public Task Update(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
