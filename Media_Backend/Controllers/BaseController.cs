using AutoMapper;
using backend.Data;
using Media_Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Media_Backend.Controllers
{
    public class BaseController<T> : Controller, IRepository<T> where T : class
    {

       protected readonly ILogger _logger;
       protected readonly IMapper _mapper;
       protected readonly MediaListDbContext _dbContext;
       protected readonly DbSet<T> _dbSet;

        public BaseController(ILogger logger, IMapper mapper, MediaListDbContext dbcontext )
        {
              _logger = logger;
              _mapper = mapper;
              _dbContext = dbcontext;
              _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<List<T>> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IRepository<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
