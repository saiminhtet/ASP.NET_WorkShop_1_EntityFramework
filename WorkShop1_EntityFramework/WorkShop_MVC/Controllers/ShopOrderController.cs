using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkShop_MVC.Models;
using WorkShop_MVC.Models.ViewModels;

namespace WorkShop_MVC.Controllers
{
    public class ShopOrderController : Controller
    {
        ShopOrders _db = new ShopOrders();
        ShopOrdersViewModel SO_View = new ShopOrdersViewModel();
        // GET: ShopOrder

        public ActionResult Index()
        {

            //ViewBag.FoodList = new SelectList(BusinessLogic.ListFood(), "ID", "Name");
            SO_View.FoodList = BusinessLogic.ListFood();
            SO_View.SizeList = BusinessLogic.ListSize();

            return View(SO_View);
        }

        [HttpPost]
        public ActionResult Index(ShopOrdersViewModel SO_View)
        {
            string username = SO_View.Order.Username;
            int foodid = SO_View.SelectedFoodID;
            string foodname = BusinessLogic.GetFood(foodid);
            string size = SO_View.Size;
            string chilli = SO_View.Chilli == true ? "Y" : "N";
            string moresalt = SO_View.MoreSalt == true ? "Y" : "N";
            string pepper = SO_View.Pepper == true ? "Y" : "N";

            BusinessLogic.AddOrder(username, foodid, foodname, size, chilli, moresalt, pepper);
            return RedirectToAction("OrderList", "ShopOrder", new { user = username });
        }


        public ActionResult OrderList(string user)
        {
            List<Order> order = BusinessLogic.ListOrdersBy(user);
            return View(order);
        }

        public ActionResult Details(int id)
        {
            Order order = _db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }


        public ActionResult Edit(int id, ShopOrdersViewModel SO_View)
        {
            Order order = _db.Orders.Find(id);
            SO_View.User = order.Username;
            SO_View.OrderId = id;
            SO_View.FoodList = BusinessLogic.ListFood();
            SO_View.SizeList = BusinessLogic.ListSize();
            SO_View.SelectedFoodID = order.FoodID;

            SO_View.Size = order.Size;
            SO_View.Chilli = order.Chilli == "Y" ? true : false;
            SO_View.MoreSalt = order.MoreSalt == "Y" ? true : false;
            SO_View.Pepper = order.Pepper == "Y" ? true : false;

            return View(SO_View);
        }

        //POST /ShopOrder/Edit/1

        [HttpPost]
        public ActionResult Edit(ShopOrdersViewModel SO_View)
        {
            string user = SO_View.User;
            int foodid = SO_View.SelectedFoodID;
            int orderid = SO_View.OrderId;
            string size = SO_View.Size;
            string chilli = SO_View.Chilli == true ? "Y" : "N";
            string moresalt = SO_View.MoreSalt == true ? "Y" : "N";
            string pepper = SO_View.Pepper == true ? "Y" : "N";
            BusinessLogic.UpdateOrder(orderid, foodid, size, chilli, moresalt, pepper);
            return RedirectToAction("OrderList", "ShopOrder", new { user = user });
        }
    }
}