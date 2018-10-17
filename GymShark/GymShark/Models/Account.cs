using System;
namespace GymShark
{
    public class Account
    {
        private string userName;
        private string creationDate;
        private Customer customerId;

        public string CreationDate{
            get { return creationDate; }
            set { creationDate = value; }
        }
        public string UserName{
            get { return userName; }
            set { userName = value; }
        }
        public Customer CustomerId{
            get { return customerId; }
            set { customerId = value; }
        }
       
        public Account()
        {
        }
    }
}
