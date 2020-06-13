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
    public partial class index : System.Web.UI.Page
    {
        public List<Employee> emps = null;
        public Employee emp = null;
        public PageHelper<Employee> page1 = null;
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public string error;
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public static int current=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username=(string)Session["username"];
            if (username != null)
            {
                bool b=(bool)Session["manager"];
                if (!b)
                {
                    Button9.Enabled = false;
                }
                if (page1 == null)
                {
                    page1 = new PageHelper<Employee>();
                    page1.PageSize = 3;
                    page1.TotalCount = employeeService.getTotalCount();
                    page1.TotalPage = page1.TotalCount % page1.PageSize == 0 ? page1.TotalCount / page1.PageSize : (page1.TotalCount / page1.PageSize) + 1;
                    page1.CurrentPage = 1;
                    List<Employee> emps = employeeService.selectEmployeeByPage(page1.CurrentPage, page1.PageSize);
                    page1.PT1 = emps;
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            page1.PT1 = employeeService.selectEmployeeByPage(1, page1.PageSize);
            current = 1;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                current = current - 1;
                page1.PT1 = employeeService.selectEmployeeByPage(current, page1.PageSize);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (current < page1.TotalPage)
            {
                current = current + 1;
                page1.PT1 = employeeService.selectEmployeeByPage(current, page1.PageSize);             
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            page1.PT1 = employeeService.selectEmployeeByPage(page1.TotalPage, page1.PageSize);
            current = page1.TotalPage;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            String emp_no = Request["emp_no"];
            Session.Add("emp_no", emp_no);
            Response.Redirect("update.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            bool b=(bool)Session["manager"];
            if (b)
            {
                string emp_no=Request["del_no"];
                int count=employeeService.deleteEmployeeByNo(emp_no);
                 if (count == -1)
                 {
                     error = "不存在该员工";
                 }else if (count == 0)
                 {
                     error = "删除失败";
                 }else if (count == -2)
                {
                    error = "该员工是某个部门主管，目前不可删除！";
                }
                 else
                 {
                     error = "删除成功";
                    Response.Write(emp_no);
                 }
            }
            else
            {
                error = "您并没有执行该操作的权限";
            }
            
        }
    }
}