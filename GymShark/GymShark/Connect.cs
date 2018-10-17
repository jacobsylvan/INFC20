using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace GymShark
{
    public class Connect
    {

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.Server = "212.97.132.78";
                conn_string.UserID = "solidsc_gymshark";
                conn_string.Password = "fanta123";
                conn_string.Database = "solidsc_gymshark";

                MySqlConnection conn = new MySqlConnection(conn_string.ToString());
                conn.Open();
                return conn;
            }
            catch (MySqlException e)
            {
                throw new Exception("Kunde inte ansluta till databasen, vänligen kontakta receptionen för vidare hjälp.", e);
            } 
            catch (Exception e)
            {
                throw new Exception("Kunde inte ansluta till databasen, vänligen kontakta receptionen för vidare hjälp.", e);
            }
            
           
        }
    }
}
