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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Employee> emps = null;
        public Employee emp = null;
        public PageHelper<Department> page=null;
        public PageHelper<Employee> page1 = null;
        public DepartmentServiceImpl departmentService=new DepartmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
           
           /* emps = employeeService.selectAllEmployee();
            emp=employeeService.login_check("许树雄", "qwert123456");
            Console.Write(emp);*/
            //Response.Write(emp.ToString());
           
            if (page == null)
            {
                page = new PageHelper<Department>();
                page.PageSize = 3;
                page.TotalCount = departmentService.getTotalCount();
                page.TotalPage=  page.TotalCount % page.PageSize == 0 ? page.TotalCount / page.PageSize : page.TotalCount / page.PageSize + 1;
                page.CurrentPage = 1;
                List<Department> depts = departmentService.selectDepartmentByPage(page.CurrentPage, page.PageSize);
                page.PT1 = depts;
            }
            if (page1 == null)
            {
                page1 = new PageHelper<Employee>();
                page1.PageSize = 3;
                page1.TotalCount = employeeService.getTotalCount();
                page1.TotalPage = page1.TotalCount % page1.PageSize == 0 ? page1.TotalCount / page1.PageSize : page1.TotalCount / page1.PageSize + 1;
                page1.CurrentPage = 1;
                List<Employee> emps = employeeService.selectEmployeeByPage(page1.CurrentPage, page1.PageSize);
                page1.PT1 = emps;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            page.PT1 = departmentService.selectDepartmentByPage(1, page.PageSize);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (page.CurrentPage <= page.TotalPage)
            {
                page.PT1 = departmentService.selectDepartmentByPage(page.CurrentPage + 1, page.PageSize);
            }
            else
            {
                error = "当前已经是最后一页！";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (page.CurrentPage - 1 > 1)
            {
                page.PT1 = departmentService.selectDepartmentByPage(page.CurrentPage - 1, page.PageSize);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            page.PT1 = departmentService.selectDepartmentByPage(page.TotalPage, page.PageSize);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            page1.PT1 = employeeService.selectEmployeeByPage(1, page1.PageSize);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (page1.CurrentPage - 1 > 1)
            {
                page1.PT1 = employeeService.selectEmployeeByPage(page1.CurrentPage - 1, page1.PageSize);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (page1.CurrentPage <= page1.TotalPage)
            {
                page1.PT1 = employeeService.selectEmployeeByPage(page1.CurrentPage + 1, page1.PageSize);
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            page1.PT1 = employeeService.selectEmployeeByPage(page1.TotalPage, page1.PageSize);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            /*String emp_no=Request["emp_no"];
            Session.Add("emp_no",emp_no);
            Response.Redirect("update.aspx");**/
        }
    }
}