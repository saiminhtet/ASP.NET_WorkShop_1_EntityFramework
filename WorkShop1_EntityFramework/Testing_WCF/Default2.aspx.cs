using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Testing_WCF
{
    using ServiceReference;
    public partial class Contact : Page
    {
        string name;
        WCF_Business_Logic bslogic = new WCF_Business_Logic();
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Request.QueryString["username"];
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            GridView1.DataSource = bslogic.ListOrdersBy(name);
            GridView1.DataBind();

            GridView2.DataSource = bslogic.ListOrdersBy(name);
            GridView2.DataBind();

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderId = (int)GridView2.SelectedDataKey.Value;
            //using (shoporders entities = new shoporders())
            //{
            //    order order = entities.orders.where(p => p.orderid == orderid).first<order>();
            //    detailsview1.datasource = new order[] { order };
            //    detailsview1.databind();
            //}
            DetailsView1.DataSource = bslogic.GetOrder(orderId);
            DetailsView1.DataBind();

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView2.Rows[e.RowIndex];
            int orderId = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Values[0]);
            int foodid = Int32.Parse((row.FindControl("DropDownList1") as DropDownList).SelectedValue);
            string size = (row.FindControl("TextBox1") as TextBox).Text;
            string chilli = (row.FindControl("TextBox2") as TextBox).Text;
            string salt = (row.FindControl("TextBox3") as TextBox).Text;
            string pepper = (row.FindControl("TextBox4") as TextBox).Text;

            bslogic.UpdateOrder(orderId, foodid, size, chilli, salt, pepper);
            GridView2.EditIndex = -1;
            BindGrid();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            BindGrid();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int orderId = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Values[0]);
            bslogic.DeleteOrder(orderId);
            BindGrid();
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                Order order = (Order)e.Row.DataItem;
                DropDownList dp = (DropDownList)e.Row.FindControl("DropDownList1");
                if (dp != null)
                {
                    dp.DataSource = bslogic.ListFood();
                    dp.DataTextField = "Name";
                    dp.DataValueField = "ID";
                    dp.DataBind();
                    dp.SelectedValue = order.FoodID.ToString();
                }
            }
        }
    }
}