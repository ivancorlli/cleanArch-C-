using ApiWeb.src.user.application;
using ApiWeb.src.user.domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiWeb.src.user.infrastructure.controller
{


    [Route("api/user")]
    [ApiController]

    public class UserController : ControllerBase
    {
    private readonly IUserRepository userRepository;

    public UserController(IUserRepository userRepo) { this.userRepository = userRepo; }



        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            UserCase Case = new UserCase(this.userRepository);
            User newUser = new User();
            newUser.Id = new Guid();
            newUser.Username = "icorlli";

            Case.createNewUser(newUser);

            Ok();
        }
    }
}
