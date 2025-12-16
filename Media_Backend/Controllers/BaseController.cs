using AutoMapper;
using backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Media_Backend.Controllers
{
    public class BaseController : Controller
    {

       protected readonly ILogger _logger;
       protected readonly IMapper _mapper;
       protected readonly MediaListDbContext _dbContext;

        public BaseController(ILogger logger, IMapper mapper, MediaListDbContext dbcontext)
        {
              _logger = logger;
              _mapper = mapper;
              _dbContext = dbcontext;
        }

    }
}
