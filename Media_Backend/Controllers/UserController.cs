using AutoMapper;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Media_Backend.Repositories;
using backend.Models;

namespace Media_Backend.Controllers{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
     
        public UserController(ILogger<UserController> logger, IMapper mapper, MediaListDbContext dbcontext) 
            : base(logger, mapper, dbcontext)
        {
        }

  
    }
}
