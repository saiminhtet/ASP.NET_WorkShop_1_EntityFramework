using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WorkShop_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string GetFood(int id)
        {
            return BusinessLogic.GetFood(id);
        }

        public List<Food> ListFood()
        {
            return BusinessLogic.ListFood();
        }

        public void AddOrder(string user, int foodID, string foodname,
            string size, string chilli, string salt, string pepper)
        {
            BusinessLogic.AddOrder(user,foodID,foodname,size,chilli,salt,pepper);
        }

        public void UpdateOrder(int orderId, int foodid,
        string size, string chilli, string salt, string pepper)
        {
            BusinessLogic.UpdateOrder(orderId,foodid,size,chilli,salt,pepper);
        }

        public void DeleteOrder(int orderId)
        {
            BusinessLogic.DeleteOrder(orderId);
        }

        public List<Order> ListOrdersBy(string name)
        {
            return BusinessLogic.ListOrdersBy(name);
        }

        public List<Size> ListSize()
        {
            return BusinessLogic.ListSize();
        }

        public List<Order> GetOrder(int orderId)
        {
            return BusinessLogic.GetOrder(orderId);
        }




    }
}
