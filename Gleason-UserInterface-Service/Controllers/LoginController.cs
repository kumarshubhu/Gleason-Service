using System;
using Gleason_UserInterface_Service.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gleason_UserInterface_Service.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;
        private readonly IGleasonRepository _gleasonRepository;

        public LoginController(ILogger<LoginController> logger, IGleasonRepository gleasonRepository)
        {
            _logger = logger;
            _gleasonRepository = gleasonRepository;
        }


        [HttpGet]
        public ActionResult<Boolean> Get([FromQuery]Models.User user)
        {
            return Ok(_gleasonRepository.ValidateUser(user));
        }
    }
}
