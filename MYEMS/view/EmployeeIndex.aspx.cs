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
        protected void Page_Load(object sender, EventArgs e)
        {
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
            String emp_no = Request["emp_no"];
            Session.Add("emp_no", emp_no);
            Response.Redirect("update.aspx");
        }
    }
}