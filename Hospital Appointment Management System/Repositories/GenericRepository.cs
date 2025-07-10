using Hospital_Appointment_Management_System.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hospital_Appointment_Management_System.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly HospitalDbContext _hospitalDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(HospitalDbContext hospitalDbContext)
        {
            _hospitalDbContext = hospitalDbContext;
            _dbSet = _hospitalDbContext.Set<T>();
        }

        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

       public async Task<T> GetByIdAsync(int id)
         {
             return await _dbSet.FindAsync(id);
         }
    

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _hospitalDbContext.SaveChangesAsync();
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
        public async Task<T> GetByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _hospitalDbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

      
    }
}
