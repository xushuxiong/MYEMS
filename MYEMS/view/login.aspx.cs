using MYEMS.entity;
using MYEMS.service;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS.view
{
    public partial class login : System.Web.UI.Page
    {
        private EmployeeService employeeService = new EmployeeServiceImpl();
        public string msg="";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username=Request["username"];
            string password = Request["password"];
            Employee emp=employeeService.login_check(username, password);
            if (emp == null)
            {
                msg = "你输入的用户名密码有误，请检查重试！";
            }
            else
            {
                Session.Add("username", emp.Emp_name);
                Session.Add("manager", emp.Emp_is_manager);
                Response.Redirect("Index.aspx");
            }
            
        }
    }
}