using GymShark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebbserviceUppgift2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://ics.lu.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Session> GetSessionsDate(string date)
        {
            return Dal.GetSessionsForDate(date);
        }
        [WebMethod]
        public List<Session> GetSessionsForUser(string customerid)
        {
            return Dal.GetSessionsForUser(customerid);

        }
    }
}
