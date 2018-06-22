using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WorkShop1_EF
{
    /// <summary>
    /// Summary description for ShopOrdersWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShopOrdersWS : System.Web.Services.WebService
    {
       
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetFood(int id)
        {
            
            return BusinessLogic.GetFood(id);
        }

        [WebMethod]
        public void AddOrder(string user, int foodID, string foodname,
            string size, string chilli, string salt, string pepper)
        {
             BusinessLogic.AddOrder(user, foodID, foodname, size, chilli, salt, pepper);
        }

        [WebMethod]
        public void UpdateOrder(int orderId, int foodid,
        string size, string chilli, string salt, string pepper)
        {
            BusinessLogic.UpdateOrder(orderId, foodid, size, chilli, salt, pepper);
        }

        [WebMethod]
        public void DeleteOrder(int orderId)
        {
            BusinessLogic.DeleteOrder(orderId);
        }

        [WebMethod]
        public List<Order> ListOrdersBy(string name)
        {
            return BusinessLogic.ListOrdersBy(name);
        }

    }
}
