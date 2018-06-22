using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WorkShop_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetFood(int id);

        [OperationContract]
        List<Food> ListFood();

        [OperationContract]
        void AddOrder(string user, int foodID, string foodname,
            string size, string chilli, string salt, string pepper);

        [OperationContract]
        void UpdateOrder(int orderId, int foodid,
        string size, string chilli, string salt, string pepper);

        [OperationContract]
        void DeleteOrder(int orderId);

        [OperationContract]
        List<Order> ListOrdersBy(string name);

        [OperationContract]
        List<Size> ListSize();

        [OperationContract]
        List<Order> GetOrder(int orderId);


    }
}
