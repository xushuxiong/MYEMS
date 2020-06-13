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
    public partial class DepartmentQuery : System.Web.UI.Page
    {
        EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public string error = null;
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
            List<Employee> emps = new List<Employee>();
            List<Department> depts = new List<Department>();
            string thing = Request["query_thing"];
            string content = Request["query_content"];
            try
            {
                if (thing == "1")
                {
                    depts.Add(departmentService.selectDepartmentByNo(content));
                }
                else if (thing == "2")
                {
                    depts = departmentService.selectDepartmentByName(content);
                }
                else if (thing == "3")
                {
                    emps = employeeService.selectEmplyeeByName(content);
                    depts = departmentService.selectDepartmentByManager(emps.First<Employee>().Emp_no);
                }
                Session.Add("depts", depts);

            }
            catch (Exception ex)
            {
                error = "输入有误，请检查！";
            }

            Server.Transfer("DepartmentQueryInfo.aspx");
        }
    }
}