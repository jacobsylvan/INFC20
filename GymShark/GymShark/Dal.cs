using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GymShark
{
    public class Dal
    {
        public Dal()
        {
        }
        private static string standardErrorMessage = "Ett oväntat fel inträffade, vänligen kontakta receptionen för vidare hjälp.";
        public string StandardErrorMessage
        {
            get { return standardErrorMessage; }
            set { standardErrorMessage = value; }
        }
        public static String AddCustomer(string firstName, string lastName, string ssn, string email, string phoneNumber)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            ////        "values('" + firstName + "', '" + lastName + "', '" + ssn + "', '" + email + "', '" + phoneNumber + "');";
            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_AddCustomer", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@firstName", firstName);
                workParam = cmd.Parameters.AddWithValue("@lastName", lastName);
                workParam = cmd.Parameters.AddWithValue("@socialSecurityNumber", ssn);
                workParam = cmd.Parameters.AddWithValue("@email", email);
                workParam = cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                int rows = cmd.ExecuteNonQuery();
                /*SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

    */
                return "Konto för " + firstName + " " + lastName + " lades till.";

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception("Det finns redan ett konto med detta personnummer och email", e);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);

            }
            finally
            {
                conn.Dispose();
            }
        }

        public static Customer FindCustomer(string ssn)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;

            string query = "select * from customer where socialsecuritynumber='" + ssn + "';";

            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_FindCustomerSsn", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@socialSecurityNumber", ssn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                Customer c = new Customer();

                while (reader.Read())
                {
                    c = Customer.Create(reader);
                }
                return c;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static String RemoveCustomer(string ssn)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            string query = "delete from customer where `socialsecuritynumber`='" + ssn + "';";

            try
            {
                conn = Connect.GetConnection();

                if (FindCustomer(ssn) != null)
                {
                    conn = Connect.GetConnection();
                    SqlCommand cmd = new SqlCommand("dbo.user_DeleteCustomerSsn", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    workParam = cmd.Parameters.AddWithValue("@socialSecurityNumber", ssn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    return "Ditt konto med personnummer " + ssn + " togs bort.";
                }

                else
                {
                    return "Finns ingen kund med personnummer: " + ssn + ".";
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
        }

        public static Account GetAccount(string username, string password)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            string query = "select * from account where customerUsername='" + username + "' and customerPassword='" + password + "';";

            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_GetAccount", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@customerUsername", username);
                workParam = cmd.Parameters.AddWithValue("@customerPassword", password);
                SqlDataReader reader = cmd.ExecuteReader();
                Account owner = new Account();
                Customer customerOwner = new Customer();
                while (reader.Read())
                {
                    owner.UserName = reader[0].ToString();
                    customerOwner.Id = reader[2].ToString();
                    owner.CustomerId = customerOwner;
                }
                return owner;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }

        }

        public static Boolean CheckLogin(string username, string password)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            string query = "select * from account where customerUsername='" + username + "' and customerPassword='" + password + "';";

            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_GetAccount", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@customerUsername", username);
                workParam = cmd.Parameters.AddWithValue("@customerPassword", password);
                SqlDataReader reader = cmd.ExecuteReader();

                Boolean loginStatus = reader.HasRows;
                conn.Close();
                conn.Dispose();
                if (loginStatus)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static String AddAccount(string username, string password, string customerId)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            string query = "insert into account(customerUsername, customerPassword, customerId) " +
                 "values('" + username.ToLower() + "', '" + password + "', '" + customerId + "');";

            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_AddAccount", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@customerUsername", username.ToLower());
                workParam = cmd.Parameters.AddWithValue("@customerPassword", password);
                workParam = cmd.Parameters.AddWithValue("@customerId", customerId);

                cmd.ExecuteNonQuery();

                return "Konto med användarnamn: " + username + " lades till.";

            }


            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception("Det angivna personnumret och email finns redan i systemet", e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);

            }
            finally
            {
                conn.Dispose();
            }
        }

        public static Customer FindCustomerWithUsername(string username)
        {
            SqlConnection conn = null;
            SqlParameter workParam = null;
            string query = "select * from customer c join account a on c.customerId = a.customerId where customerUsername='" + username + "';";

            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_FindCustomerWithUsername", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@username", username.ToLower());
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                Customer c = new Customer();

                while (reader.Read())
                {
                    c = Customer.Create(reader);
                }

                return c;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static List<Session> GetSessionsForUser(string userId)
        {
            string query = "select cs.sessionId, s.sessionDate, s.sessionTime, s.isfinished, i.instructorId, i.instructorName, p.placeId, p.placeName, st.sessionTypeId, st.sessionTypeName " +
                "from customerSession cs " +
                "join customer c " +
                "on cs.customerId = c.customerI " +
                "join session s " +
                "on cs.sessionId = s.sessionId " +
                "join instructor i " +
                "on s.instructorId = i.instructorId " +
                "join place p " +
                "on s.placeId = p.placeId " +
                "join sessiontype st " +
                "on s.sessionTypeId = st.sessionTypeId " +
                "where cs.customerId = '" + userId + "'" +
                "order by s.sessionDate, s.sesssionTime asc;";
            SqlConnection conn = null;
            SqlParameter workParam = null;
            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_GetSessionsForUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@customerId", userId);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Session> sessionList = new List<Session>();
                while (reader.Read())
                {
                    sessionList.Add(Session.Create(reader));
                }

                return sessionList;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static List<Session> GetSessionsForDate(string selectedDate)
        {
            string query = "select s.sessionId, s.sessionDate, s.sessionTime, s.isfinished, i.instructorId, i.instructorName, p.placeId, p.placeName, t.sessionTypeId, t.sessionName " +
                    "from session s " +
                    "join instructor i " +
                    "on s.instructorId = i.instructorId " +
                    "join sessiontype t " +
                    "on s.sessionTypeId = t.sessionTypeId " +
                    "join place p " +
                    "on s.placeId=p.placeId                " +
                    "where s.sessionDate = '" + selectedDate + "'" +
                    "order by s.sessionTime asc;";
            SqlConnection conn = null;
            SqlParameter workParam = null;
            try
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_GetSessionsDate", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@searchDate", selectedDate);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Session> sessionList = new List<Session>();

                while (reader.Read())
                {
                    sessionList.Add(Session.Create(reader));
                }
                return sessionList;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();


            }
        }

        public static Boolean IsBookedOnSession(string sessionId, string customerId)
        {
            SqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                string query = "select * from customerSession where customerId='" + customerId + "' and sessionId='" + sessionId + "';";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Boolean bookedOnSessionStatus = reader.HasRows;
                conn.Close();
                conn.Dispose();
                if (bookedOnSessionStatus)
                {
                    return true;
                }
                else return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static void BookSession(string sessionId, string customerId)
        {
            SqlConnection conn = null;
            try
            {

                conn = Connect.GetConnection();
                string query = "insert into customerSession (customerId, sessionId) " +
                               " values('" + customerId + "', '" + sessionId + "');";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static void CancelSession(string sessionId, string customerId)
        {
            SqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                string query = "delete from `customerSession` where `sessionId` = " + sessionId + " and `customerId` = " + customerId;


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}