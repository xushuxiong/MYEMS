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
    public partial class DepartmentQueryInfo : System.Web.UI.Page
    {
        public List<Department> depts=new List<Department>();
        DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            if (username != null)
            {
                if (Session["depts"] != null)
                {
                    depts = (List<Department>)Session["depts"];
                    Session.Remove("depts");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }                
        }
    }
}