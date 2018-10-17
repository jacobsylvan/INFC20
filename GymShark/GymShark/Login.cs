using System;
namespace GymShark
{
    public class Login
    {
        private string userName;
        private string password;

        public string UserName{
            get { return userName; }
            set { userName = value; }
        }
        public string Password{
            get { return password; }
            set { password = value; }
        }
        public Login()
        {
        }
    }
}
