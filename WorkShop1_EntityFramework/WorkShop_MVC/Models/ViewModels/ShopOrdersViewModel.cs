using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkShop_MVC.Models.ViewModels
{
    public class ShopOrdersViewModel
    {
        public int OrderId { get; set; }

        public string User { get; set; }
        public List<Food> FoodList { get; set; }

        public int SelectedFoodID { get; set; }
        public List<Size> SizeList { get; set; }
        public string Size { get; set; }
        public bool Chilli { get; set; }
        public bool MoreSalt { get; set; }

        public bool Pepper { get; set; }
        public Order Order { get; set; }
    }
}