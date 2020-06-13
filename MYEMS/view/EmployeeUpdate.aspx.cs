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
    public partial class EmployeeUpdate : System.Web.UI.Page
    {
        public string emp_no = null;
        EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public Employee emp = new Employee();
        public string msg;
        public List<Department> depts = new List<Department>();
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            if (username != null)
            {
                bool b = (bool)Session["manager"];
                if (!b)
                {
                    Button1.Enabled = false;
                    msg = "您并没有执行该操作的权限！";
                }
                emp_no = (string)Request["emp_no"];
                if (emp_no != null)
                {
                    emp = employeeService.selectEmployeeByNo(emp_no);
                    depts = departmentService.selectAllDepartment();
                }
                else
                {
                    msg = "无法直接访问该页面！";
                    Button1.Enabled = false;
                }  
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int emp_id=Convert.ToInt32(Request["emp_id"]);
            string emp_no = Request["emp_no"];
            string emp_name = Request["emp_name"];
            string emp_mobile = Request["emp_mobile"];
            string emp_pwd = Request["emp_pwd"];
            bool emp_is_manager =Convert.ToBoolean(Request["emp_manager"]);
            string emp_dept = Request["emp_dept"];
            Employee emp = new Employee(emp_id, emp_no, emp_pwd ,emp_name, emp_mobile, emp_is_manager, emp_dept);
            int count=employeeService.updateEmployeeByNo(emp);
            if (count == -1)
            {
                msg = "该员工不存在";
            }
            else if(count==0)
            {
                msg = "修改失败";
            }
            else
            {
                msg = "修改成功";
                Response.Redirect("EmployeeIndex.aspx");
            }
        }
    }
}