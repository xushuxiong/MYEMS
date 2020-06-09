using MYEMS.dao;
using MYEMS.entity;
using MYEMS.service;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            EmployeeService employeeService = new EmployeeServiceImpl();
            List<Employee> emps = employeeService.selectEmployeeByPage(2,3);
            foreach(Employee emp in emps){
                Response.Write(emp.ToString());
            }
            //GridView1.DataSource = emps;
            DepartmentService departmentService = new DepartmentServiceImpl();
            int count=departmentService.getTotalCount();
            Response.Write("xsx" + count);
        }

        
    }
}