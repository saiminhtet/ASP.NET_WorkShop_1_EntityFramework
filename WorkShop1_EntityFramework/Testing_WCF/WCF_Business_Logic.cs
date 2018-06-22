using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testing_WCF
{
    using ServiceReference;
    public class WCF_Business_Logic
    {
        ServiceClient servclient = new ServiceClient();
        public List<Food> ListFood()
        {
            return servclient.ListFood().ToList();             
        }

        public string GetFood(int id)
        {
            return servclient.GetFood(id);
        }

        public void AddOrder(string user, int foodID, string foodname,
            string size, string chilli, string salt, string pepper)
        {
            servclient.AddOrder(user, foodID, foodname, size,chilli,salt,pepper);
        }

        public void UpdateOrder(int orderId, int foodid,
        string size, string chilli, string salt, string pepper)
        {
            servclient.UpdateOrder(orderId, foodid, size, chilli, salt, pepper);
        }

        public void DeleteOrder(int orderId)
        {
            servclient.DeleteOrder(orderId);
        }

        public List<Order> ListOrdersBy(string name)
        {
            return servclient.ListOrdersBy(name).ToList();
        }

        public List<Size> ListSize()
        {
            return servclient.ListSize().ToList();
        }

        public List<Order> GetOrder(int orderId)
        {
            return servclient.GetOrder(orderId).ToList();
        }
        
    }
}