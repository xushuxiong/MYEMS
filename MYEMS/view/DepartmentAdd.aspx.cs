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
    public partial class DepartmentAdd : System.Web.UI.Page
    {
        public List<Employee> emps;
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            emps = employeeService.selectAllEmployee();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dept_no=Request["dept_no"];
            string dept_name=Request["dept_name"];
            string dept_manager = Request["dept_manager"];
            Department dept = new Department(dept_no, dept_name, dept_manager);
            int count=departmentService.insertDepartment(dept);
            if (count == -1)
            {
                error = "该部门已存在，请检查编号和部门名字是否正确！";
            }
            else if (count == 0)
            {
                error = "系统错误，插入失败!";
            }
            else
            {
                Response.Redirect("DepartmentIndex.aspx");
            }
        }
    }
}