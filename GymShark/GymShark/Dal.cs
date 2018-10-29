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
            SqlParameter workParam = null;
            try
                
            {
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_IsBookedOnSession", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@sessionId", sessionId);
                workParam = cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.ExecuteNonQuery();
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
            SqlParameter workParam = null;

            try
            {

                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_BookSession", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@customerId", customerId);
                workParam = cmd.Parameters.AddWithValue("@sessionId", sessionId);
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
            SqlParameter workParam = null;
            try
            {
               
                conn = Connect.GetConnection();
                SqlCommand cmd = new SqlCommand("dbo.user_CancelSession", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                workParam = cmd.Parameters.AddWithValue("@sessionId", sessionId);
                workParam = cmd.Parameters.AddWithValue("@customerId", customerId);
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