using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
            MySqlConnection conn = null;
            string query = "insert into customer(firstname, lastname, socialsecuritynumber, email, phonenumber) " +
                    "values('" + firstName + "', '" + lastName + "', '" + ssn + "', '" + email + "', '" + phoneNumber + "');";
            try
            {
                conn = Connect.GetConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

              
                return "Konto för " + firstName + " " + lastName + " lades till.";

            }
            catch (MySqlException e)
            {
                throw new Exception("Det finns redan ett konto med detta personnummer och email", e);
            
            }
            catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);

            }
            finally
            {
                conn.Dispose();
            }
        }

        public static Customer FindCustomer(string ssn)
        {
            MySqlConnection conn = null;
            string query = "select * from customer where socialsecuritynumber='" + ssn + "';";

            try
            {
                conn = Connect.GetConnection();
                  MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                Customer c = new Customer();
                
                while (reader.Read())
                {
                    c = Customer.Create(reader);
                }
                return c;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static String RemoveCustomer(string ssn)
        {
            MySqlConnection conn = null;
            string query = "delete from customer where `socialsecuritynumber`='" + ssn + "';";

            try
            {
                conn = Connect.GetConnection();

                if (FindCustomer(ssn) != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
            catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);

            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
        }

        public static Account GetAccount(string username, string password)
        {
            MySqlConnection conn = null;
            string query = "select * from account where username='" + username + "' and password='" + password + "';";

            try
            {
                conn = Connect.GetConnection();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                Account owner = new Account();
                Customer customerOwner = new Customer();
                while (reader.Read())
                {
                    owner.UserName = reader[0].ToString();
                    customerOwner.Id = reader[3].ToString();
                    owner.CustomerId = customerOwner;
                }
                return owner;
            }
            catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            } finally
            {
                conn.Dispose();
            }

        }

        public static Boolean CheckLogin(string username, string password)
        {
            MySqlConnection conn = null;
            string query = "select * from account where username='" + username + "' and password='" + password + "';";

            try
            {
                conn = Connect.GetConnection();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Boolean loginStatus = reader.HasRows;
                conn.Close();
                conn.Dispose();
                if (loginStatus)
                {
                    return true;
                }
                else return false;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
            }

        public static String AddAccount(string username, string password, string customer_id)
        {
            MySqlConnection conn = null;
            string query = "insert into account(username, password, customer_id) " +
                 "values('" + username.ToLower() + "', '" + password + "', '" + customer_id + "');";

            try
            {
                conn = Connect.GetConnection();
                   

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                
                return "Konto med användarnamn: " + username + " lades till.";

            }


            catch (MySqlException e)
            {
                throw new Exception("Det angivna personnumret och email finns redan i systemet", e);

            }
            catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);

            } finally
            {
                conn.Dispose();
            }
        }

        public static Customer FindCustomerWithUsername(string username)
        {
            MySqlConnection conn = null;
            string query = "select * from customer c join account a on c.id = a.customer_id where username='" + username + "';";

            try
            {
                conn = Connect.GetConnection();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                Customer c = new Customer();

                while (reader.Read())
                {
                    c = Customer.Create(reader);
                }
                
                return c;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
               
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static List<Session> GetSessionsForUser(string userId)
        {
            string query = "select cs.session_id, s.date, s.time, s.duration, s.isfinished, i.id, i.name, p.id, p.name, st.id, st.name " +
                "from customer_session cs " +
                "join customer c " +
                "on cs.customer_id = c.id " +
                "join session s " +
                "on cs.session_id = s.id " +
                "join instructor i " +
                "on s.instructor_id = i.id " +
                "join place p " +
                "on s.place_id = p.id " +
                "join sessiontype st " +
                "on s.type_id = st.id " +
                "where cs.customer_id = '" + userId + "'" +
                "order by s.date, s.time asc;";
            MySqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Session> sessionList = new List<Session>();
                while (reader.Read())
                {
                    sessionList.Add(Session.Create(reader));
                }
              
                return sessionList;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static List<Session> GetSessionsForDate(string selectedDate)
        {
            string query = "select s.id, s.date, s.time, s.duration, s.isfinished, i.id, i.name, p.id, p.name, t.id, t.name " +
                    "from session s " +
                    "join instructor i " +
                    "on s.instructor_id = i.id " +
                    "join sessiontype t " +
                    "on s.type_id = t.id " +
                    "join place p " +
                    "on s.place_id=p.id                " +
                    "where s.date = '" + selectedDate + "'" +
                    "order by s.time asc;";
            MySqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Session> sessionList = new List<Session>();

                while (reader.Read())
                {
                    sessionList.Add(Session.Create(reader));
                }
                return sessionList;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                 conn.Dispose();
                
                
            }
        }
 
        public static Boolean IsBookedOnSession(string sessionId, string customerId)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                string query = "select * from customer_session where customer_id='" + customerId + "' and session_id='" + sessionId + "';";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Boolean bookedOnSessionStatus = reader.HasRows;
                conn.Close();
                conn.Dispose();
                if (bookedOnSessionStatus)
                {
                    return true;
                }
                else return false;
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static void BookSession(string sessionId, string customerId)
        {
            MySqlConnection conn = null;
            try
            {

                conn = Connect.GetConnection();
                string query = "insert into customer_session (customer_id, session_id) " +
                               " values('" + customerId + "', '" + sessionId + "');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static void CancelSession(string sessionId, string customerId)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Connect.GetConnection();
                string query = "delete from `customer_session` where `session_id` = " + sessionId + " and `customer_id` = " + customerId;


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            } catch (MySqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public static List<News> GetNewsfeed()
        {
            MySqlConnection conn = null;
            string query = "SELECT * FROM newsfeed order by date LIMIT 3";

            try
            {
                conn = Connect.GetConnection();
                List<News> newsfeed = new List<News>();
                News n = new News();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    newsfeed.Add(News.Create(reader));
                }
              
                return newsfeed;
            } catch (SqlException e)
            {
                throw new Exception(standardErrorMessage, e);
            } catch (Exception e)
            {
                throw new Exception(standardErrorMessage, e);
            }
            finally
            {
                conn.Dispose();
            }
            }
        }
    }