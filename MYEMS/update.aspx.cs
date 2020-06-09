using MYEMS.entity;
using MYEMS.service;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS
{
    public partial class update : System.Web.UI.Page
    {
        public string emp_no = null;
        EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public Employee emp = new Employee();
        public string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            emp_no =(string)Request["emp_no"];
            if (emp_no!=null)
            {
                emp=employeeService.selectEmployeeByNo(emp_no);
                Response.Write(emp.ToString());
            }
            else
            {
                msg = "无法直接访问该页面！";
            }
           
        }
    }
}