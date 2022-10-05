using ApiWeb.src.user.application;
using ApiWeb.src.user.domain;

namespace ApiWeb.src.user.infrastructure.db
{
    public class UserDb : User

    {

        private readonly List<UserDb> _users = new List<UserDb>();

        public void addUser(UserDb user)
        {
            {
                if (user != null) { 
                
                    this._users.Add(user);
                }

            }
        }
        
}

}
