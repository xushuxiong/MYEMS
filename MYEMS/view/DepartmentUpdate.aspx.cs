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
    public partial class DepartmentUpdate : System.Web.UI.Page
    {
        public string dept_no = null;
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public Department dept = new Department();
        public string msg;
        public List<Employee> emps;
        DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
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
                dept_no = (string)Request["dept_no"];
                emps = employeeService.selectAllEmployee();
                if (dept_no != null)
                {
                    dept = departmentService.selectDepartmentByNo(dept_no);
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
            int dept_id=Convert.ToInt16(Request["dept_id"]);
            string dept_no=Request["dept_no"];
            string dept_name = Request["dept_name"];
            string dept_manager = Request["dept_manager"];
            Department dept = new Department(dept_id, dept_no, dept_name, dept_manager);
            int count=departmentService.updateDepartmentByNo(dept);
            if (count == -1)
            {
                msg = "该员工不存在";
            }
            else if (count == 0)
            {
                msg = "修改失败";
            }
            else
            {
                msg = "修改成功";
                Response.Redirect("DepartmentIndex.aspx");
            }
        }
    }
}