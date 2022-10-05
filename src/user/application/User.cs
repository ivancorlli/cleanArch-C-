using ApiWeb.src.user.domain;

namespace ApiWeb.src.user.application
{
    public class User : IUser
    {
        #region Id
        private Guid _id = Guid.Empty;
        public Guid Id
        {
            get
            {
                 return _id;
            }
            set
            {

                    _id = value;
               
            }
        }
        #endregion
        #region Email
        private string _email = string.Empty;
        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(_email))
                {
                    return string.Empty;
                }
                else return _email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _email = value;
                }
                else _email = string.Empty;
            }

        }
        #endregion
        #region Username
        private string _username = string.Empty;
        public string Username
        {
            get
            {
                if (string.IsNullOrEmpty(_username))
                {
                    return string.Empty;
                }
                else return _username;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _username = value;
                }
                else _username = string.Empty;
            }

        }
        #endregion
        #region Passoword
        private string _password = string.Empty;
        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(_password))
                {
                    return string.Empty;
                }
                else return _password;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _password = value;
                }
                else _password = string.Empty;
            }

        }
        #endregion

        #region EmailVerified
        private bool _emailVerified = false;
        public bool EmailVerified
        {
            get
            {
                return _emailVerified;
            }
            set
            {
                _emailVerified = value;
            }
        }
        #endregion
        #region Status
        private string _status = string.Empty;
        public string status
        {
            get
            {
                if (string.IsNullOrEmpty(_status))
                {
                    return string.Empty;
                }
                else return _status;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _status = value;
                }
                else _status = string.Empty;
            }
        }
        #endregion
        #region Name
        private string _name = string.Empty;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return string.Empty;
                }
                else return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else _name = string.Empty;
            }
        }
        #endregion
        #region Surname
        private string _surname = string.Empty;
        public string Surname
        {
            get
            {
                if (string.IsNullOrEmpty(_surname))
                {
                    return string.Empty;
                }
                else return _surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _surname = value;
                }
                else _surname = string.Empty;
            }
        }
        #endregion
        #region Birthday
        private string _birthday = string.Empty;
        public string Birthday
        {
            get
            {
                if (string.IsNullOrEmpty(_birthday))
                {
                    return string.Empty;
                }
                else return _birthday;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _birthday = value;
                }
                else _birthday = string.Empty;
            }
        }
        #endregion
        #region Gender
        private string _gender = string.Empty;
        public string Gender
        {
            get
            {
                if (string.IsNullOrEmpty(_gender))
                {
                    return string.Empty;
                }
                else return _gender;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _gender = value;
                }
                else _gender = string.Empty;
            }
        }
        #endregion
    }
}
