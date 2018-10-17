using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShark
{
    class ErrorHandling : Exception
    {
        private string exceptionMessage;
        private Exception exception;

        public ErrorHandling(string message, Exception e)
        {
            ExceptionMessage = message;
            Exception = e;
        }

        public string ExceptionMessage
        {
            get { return exceptionMessage; }
            set { exceptionMessage = value; }
        }
        public Exception Exception
        {
            get { return exception; }
            set { exception = value; }
        }
        private string ExceptionHandler(SqlException e)
        {
            if (e.GetType() == typeof(SqlException))
            {
                if (e.ErrorCode == 2608)
                {
                    string errorMessage = "Kund finns redan i databas";
                    return errorMessage;
                }
            }
            else if (e.GetType() == typeof(NullReferenceException))
            {
                string errorMessage = "Värde finns ej";
                return errorMessage;
            }
            else if (e.GetType() == typeof(FormatException))
            {

            } 
            else if (e.GetType() == typeof(InvalidCastException))
            {
                string errorMessage = "Fel uppstod, kontakta receptionen";
                return errorMessage;
            }
                string errorMessageGeneral = "Fel uppstod, kontakta receptionen";
                return errorMessageGeneral;
            }
        }
       
       
    }

