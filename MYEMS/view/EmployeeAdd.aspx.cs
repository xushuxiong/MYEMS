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
    public partial class EmployeeAdd : System.Web.UI.Page
    {
        public List<Department> depts;
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            depts = departmentService.selectAllDepartment();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string emp_no=Request["emp_no"];
            string emp_name=Request["emp_name"];
            string emp_mobile=Request["emp_mobile"];
            string emp_pwd = Request["emp_pwd"];
            bool emp_is_manager = Convert.ToBoolean(Request["emp_manager"]);
            string emp_dept = Request["emp_dept"];
            Employee emp=new Employee(emp_no, emp_pwd, emp_name, emp_mobile, emp_is_manager, emp_dept);
            int count=employeeService.insertEmployee(emp);
            if (count == -1)
            {
                error = "该员工已存在，请检查编号是否正确！";
            }else if (count == 0)
            {
                error = "系统错误，插入失败!";
            }
            else
            {
                Response.Redirect("EmployeeIndex.aspx");
            }
        }
    }
}