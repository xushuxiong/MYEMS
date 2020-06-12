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
    public partial class EmployeeQueryInfo : System.Web.UI.Page
    {
        public List<Employee> emps = new List<Employee>();
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emps"] != null)
                emps = (List<Employee>)Session["emps"];
        }
    }
}