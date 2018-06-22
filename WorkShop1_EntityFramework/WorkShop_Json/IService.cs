using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WorkShop_Json
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Food/{id}", ResponseFormat = WebMessageFormat.Json)]
        string GetFood(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/Foods", ResponseFormat = WebMessageFormat.Json)]
        List<Food> ListFood();
       
        [OperationContract]
        [WebInvoke(UriTemplate = "/AddOrder", Method = "POST", RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json)]
        void AddOrder(WCF_Order_Contract order);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateOrder", Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateOrder(WCF_Order_Contract order);


        [OperationContract]
        [WebGet(UriTemplate = "/Delete/{id}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteOrder(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/ListOrderByName/{name}", ResponseFormat = WebMessageFormat.Json)]
        List<Order> ListOrdersBy(string name);

        [OperationContract]
        [WebGet(UriTemplate = "/Sizes", ResponseFormat = WebMessageFormat.Json)]
        List<Size> ListSize();

        [OperationContract]
        [WebGet(UriTemplate = "/Order/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<Order> GetOrder(string id);
    }
    [DataContract]
    public class WCF_Order_Contract
    {
        [DataMember]
        public string User;

        [DataMember]
        public int OrderID;

        [DataMember]
        public int FoodID;

        [DataMember]
        public string FoodName;

        [DataMember]
        public string Size;

        [DataMember]
        public string Chilli;

        [DataMember]
        public string Salt;

        [DataMember]
        public string Pepper;

        public WCF_Order_Contract(string user,int orderId, int foodID, string foodname,
        string size, string chilli, string salt, string pepper)
        {

            this.User = user;
            this.OrderID = orderId;
            this.FoodID = foodID;
            this.FoodName = foodname;
            this.Size = size;
            this.Chilli = chilli;
            this.Salt = salt;
            this.Pepper = pepper;
        }


        //[DataMember]
        //public int OrderId { get; set; }

        //[DataMember]
        //public string User { get; set; }

        //[DataMember]
        //public int FoodId { get; set; }

        //[DataMember]
        //public string FoodName { get; set; }

        //[DataMember]
        //public string Size { get; set; }

        //[DataMember]
        //public string Chilli { get; set; }

        //[DataMember]
        //public string Salt { get; set; }

        //[DataMember]
        //public string Pepper { get; set; }
    }
}
