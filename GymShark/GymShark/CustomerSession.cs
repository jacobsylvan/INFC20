using System;
namespace GymShark
{
    public class CustomerSession
    {
        private Customer customer;
        private Session session;

        public Customer Customer{
            get { return customer; }
            set { customer = value; }
        }
        public Session Session{
            get { return session; }
            set { session = value; }
        }
        public CustomerSession()
        {
        }
    }
}
