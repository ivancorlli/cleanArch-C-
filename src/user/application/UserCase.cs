using ApiWeb.src.user.domain;

namespace ApiWeb.src.user.application
{
    public class UserCase
    {
        private readonly IUserRepository _User;

        public UserCase(IUserRepository userRepository)
        {
            _User = userRepository;
        }


        public void createNewUser(User user)
        { 
            _User.Create(user);
        }
    }
}
