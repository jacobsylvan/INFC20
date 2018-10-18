using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GymShark
{

    class Controller
        {
       

        private Account currentUser;

        public Account CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }


        Dal d = new Dal();

        public static Boolean CheckLogin(String username, String password)
        {
            return Dal.CheckLogin(username, password);
        }
        public static Boolean IsBookedOnSession(string sessionId, string customerId)
        {
            return Dal.IsBookedOnSession(sessionId, customerId);
        }


        public static String AddCustomer(string firstName, string lastName, string sSN, string email, string phoneNumber)
        {
            return Dal.AddCustomer(firstName, lastName, sSN, email, phoneNumber);
        }

        public static String AddAccount(string username, string password, string customer_id)
        {
            return Dal.AddAccount(username, password, customer_id);
        }
        public static Account GetAccount(string username, string password)
        {
            return Dal.GetAccount(username, password);
        }

        public static Customer FindCustomer(string ssn)
        {
            return Dal.FindCustomer(ssn);
        }
        public static Customer FindCustomerWithUsername(string username)
        {
            return Dal.FindCustomerWithUsername(username);
        }

        public static String RemoveCustomer(string ssn)
        {
            return Dal.RemoveCustomer(ssn);
        }
        public static List<Session> GetSessionsForUser(string userId)
        {
            return Dal.GetSessionsForUser(userId);
        }

        public static List<Session> GetSessionsForDate(string selectedDate)
        {
            return Dal.GetSessionsForDate(selectedDate);

        }

        public static void BookSession(string sessionId, string customerId)
        {
            Dal.BookSession(sessionId, customerId);
        }

        public static void CancelSession(string sessionId, string customerId)
        {
            Dal.CancelSession(sessionId, customerId);
        }
       
        
    }
}