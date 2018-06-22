using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static WorkShop_Json.IService;

namespace WorkShop_Json
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string GetFood(string id)
        {
            int foodId = Convert.ToInt16(id);
            return BusinessLogic.GetFood(foodId);
        }

        public List<Food> ListFood()
        {
            return BusinessLogic.ListFood();
        }

       
        public void AddOrder(WCF_Order_Contract order)
        {
            BusinessLogic.AddOrder(order.User, order.FoodID, order.FoodName, order.Size, order.Chilli, order.Salt, order.Pepper);
        }

        public void UpdateOrder(WCF_Order_Contract order)
        {
            BusinessLogic.UpdateOrder(order.OrderID, order.FoodID, order.Size, order.Chilli, order.Salt, order.Pepper);
        }

        public void DeleteOrder(string id)
        {
            int orderId = Convert.ToInt16(id);
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

        public List<Order> GetOrder(string id)
        {
            int orderId = Convert.ToInt16(id);
            return BusinessLogic.GetOrder(orderId);
        }
    }
}
