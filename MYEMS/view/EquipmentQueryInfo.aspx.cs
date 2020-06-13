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
    public partial class EquipmentQueryInfo : System.Web.UI.Page
    {
        public List<Equipment> equs = new List<Equipment>();
        public EmployeeServiceImpl employeeService=new EmployeeServiceImpl();
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            if (username != null)
            {
                 if (Session["equs"] != null)
                {
                    equs = (List<Equipment>)Session["equs"];
                    Session.Remove("equs");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }     
        }
    }
}