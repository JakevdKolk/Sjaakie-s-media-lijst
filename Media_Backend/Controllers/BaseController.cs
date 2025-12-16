using AutoMapper;

namespace Media_Backend.Controllers
{
    public class BaseController
    {

       protected readonly ILogger _logger;
       protected readonly IMapper _mapper;

        public BaseController(ILogger logger, IMapper mapper)
        {
              _logger = logger;
              _mapper = mapper;
        }



    }
}
