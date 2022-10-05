using ApiWeb.src.user.domain;
using ApiWeb.src.user.infrastructure.db;

namespace ApiWeb.src.user.infrastructure.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDb _User = new UserDb();
        IUser IUserRepository.Create(IUser newUser)
        {
            _User.Username = newUser.Username;
            _User.Email = newUser.Email;
            _User.Password = newUser.Password;
            _User.addUser(_User);
            return _User;
        }

        IUser IUserRepository.Delete(string id)
        {
            throw new NotImplementedException();
        }

        IUser IUserRepository.Get(string id)
        {
            throw new NotImplementedException();
        }

        List<IUser> IUserRepository.getAll()
        {
            throw new NotImplementedException();
        }

        IUser IUserRepository.Update(string id)
        {
            throw new NotImplementedException();
        }
    }


}
