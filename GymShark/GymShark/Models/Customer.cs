using System;
using System.Data;

namespace GymShark
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private string email;
        private string phoneNumber;
        private string id;

        public Customer(string firstName, string lastName, string ssn, string email, string phoneNumber){
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string Id{
            get { return id; }
            set { id = value; }
        }
        public string FirstName{
            get { return firstName; }
            set { firstName = value;}
        }
        public string LastName{
            get { return lastName; }
            set { lastName = value; }
        }
        public string SSN{
            get { return ssn; }
            set { ssn = value; }
        }
        public string Email{
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber{
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public static Customer Create(IDataRecord record)
        {
            return new Customer
            {
                Id = record["id"].ToString(),
                FirstName = record["firstname"].ToString(),
                LastName = record["lastname"].ToString(),
                Email = record["email"].ToString(),
                SSN = record["socialsecuritynumber"].ToString(),
                PhoneNumber = record["phonenumber"].ToString()
            };
        }

        public Customer()
        {
        }
    }
}
