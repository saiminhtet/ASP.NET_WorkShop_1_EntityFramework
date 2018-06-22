﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkShop_MVC.Models;

namespace WorkShop_MVC
{
    public class BusinessLogic
    {
        public static void AddOrder(string user, int foodID, string foodname,
            string size, string chilli, string salt, string pepper)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                Order order = new Order
                {
                    Username = user,
                    FoodID = foodID,
                    FoodName = foodname,
                    Size = size,
                    Chilli = chilli,
                    MoreSalt = salt,
                    Pepper = pepper
                };
                entities.Orders.Add(order);
                entities.SaveChanges();
            }
        }

        public static string GetFood(int id)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                Food f = entities.Foods.Where(p => p.ID == id).First<Food>();
                return (f.Name);
            }
        }
        public static void UpdateOrder(int orderId, int foodid,
        string size, string chilli, string salt, string pepper)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                Order order = entities.Orders.Where(p => p.OrderID == orderId).First<Order>();
                order.FoodID = foodid;
                order.FoodName = GetFood(foodid);
                order.Size = size;
                order.Chilli = chilli;
                order.MoreSalt = salt;
                order.Pepper = pepper;
                entities.SaveChanges();
            }
        }

        public static void DeleteOrder(int orderId)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                Order order = entities.Orders.Where(p => p.OrderID == orderId).First<Order>();
                entities.Orders.Remove(order);
                entities.SaveChanges();
            }
        }


        public static List<Order> ListOrdersBy(string name)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                return entities.Orders.Where(p => p.Username == name).ToList<Order>();
            }
        }

        public static List<Size> ListSize()
        {
            using (ShopOrders entities = new ShopOrders())
            {
                return entities.Sizes.ToList<Size>();
            }
        }

        public static List<Food> ListFood()
        {
            using (ShopOrders entities = new ShopOrders())
            {
                return entities.Foods.ToList<Food>();
            }
        }

        public static List<Order> GetOrder(int orderId)
        {
            using (ShopOrders entities = new ShopOrders())
            {
                return entities.Orders.Where(p => p.OrderID == orderId).ToList<Order>();
            }
        }
    }


}