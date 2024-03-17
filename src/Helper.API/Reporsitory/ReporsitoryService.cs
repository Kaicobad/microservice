using Helper.API.DataContext;
using System.Linq.Expressions;

namespace Helper.API.Reporsitory
{
    public class ReporsitoryService<T> : IRepositoryService<T> where T : class
    {
        private readonly HelperDbContext _dbContext;

        public ReporsitoryService(HelperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(in T sender)
        {
            try
            {
                _dbContext.Add(sender);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByIdWithIncludes(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdWithIncludesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public T Select(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(in T sender)
        {
            throw new NotImplementedException();
        }
    }
}
