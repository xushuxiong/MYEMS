using MYEMS.entity;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS.view
{
    public partial class EquipmentDayQuery : System.Web.UI.Page
    {
        public string error;
        EquipmentServiceImpl equipmentService = new EquipmentServiceImpl();
        List<Equipment> equs = new List<Equipment>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            if (username == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int year=Convert.ToInt32( TextBox1.Text);
            int month = Convert.ToInt32(TextBox2.Text);
            int day = Convert.ToInt32(TextBox3.Text);
            DateTime date=new DateTime(year, month, day);
            try
            {
                equs=equipmentService.selectEquipmentByDate(date);
                Session.Add("equs", equs);
            }
            catch(Exception ex)
            {
                error = "输入有误，请检查！";
            }
            Server.Transfer("EquipmentQueryInfo.aspx");
        }
    }
}