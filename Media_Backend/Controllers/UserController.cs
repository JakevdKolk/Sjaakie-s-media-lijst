using AutoMapper;
using backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Media_Backend.Controllers{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        public UserController(ILogger logger, IMapper mapper, MediaListDbContext dbcontext) : base(logger, mapper, dbcontext)
        {
        }

     
    }
}
