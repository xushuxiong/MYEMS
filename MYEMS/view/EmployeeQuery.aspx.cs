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
    public partial class EmployeeQuery : System.Web.UI.Page   
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
            string thing=Request["query_thing"];
            string content = Request["query_content"];
            try
            {
                if (thing == "1")
                {
                    emps.Add(employeeService.selectEmployeeByNo(content));
                }else if (thing == "2")
                {
                    emps=employeeService.selectEmplyeeByName(content);
                }else if (thing == "3")
                {
                    depts=departmentService.selectDepartmentByName(content);
                    emps=employeeService.selectEmployeeByDept(depts.First<Department>().Dept_no);
                }else if (thing == "4")
                {
                    emps=employeeService.selectEmployeeByMobile(content);
                }else if (thing == "5")
                {
                    bool b= Convert.ToBoolean(content);
                    emps=employeeService.selectEmployeeByManager(b);
                }
                Session.Add("emps", emps);
            }catch(Exception ex)
            {
                error = "输入有误，请检查！";
            }
            
            Server.Transfer("EmployeeQueryInfo.aspx");
        }
    }
}