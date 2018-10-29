using MySql.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GymShark
{
    public class Connect
    {

        public static SqlConnection GetConnection()
        {
            try
            {

                SqlConnection conn = new System.Data.SqlClient.SqlConnection("Server= localhost; Database= gymshark; Integrated Security=True;");
                conn.Open();
                return conn;
            }
            catch (SqlException e)
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
