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
    public partial class DepartmentIndex : System.Web.UI.Page
    {
        public DepartmentServiceImpl departmentService = new DepartmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public PageHelper<Department> page = null;
        public string error;
        public static int current = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (page == null)
            {
                page = new PageHelper<Department>();
                page.PageSize = 3;
                page.TotalCount = departmentService.getTotalCount();
                page.TotalPage = page.TotalCount % page.PageSize == 0 ? page.TotalCount / page.PageSize : page.TotalCount / page.PageSize + 1;
                page.CurrentPage = 1;
                List<Department> depts = departmentService.selectDepartmentByPage(page.CurrentPage, page.PageSize);
                page.PT1 = depts;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            page.PT1 = departmentService.selectDepartmentByPage(1, page.PageSize);
            current = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (current < page.TotalPage)
            {
                current = current + 1;
                page.PT1 = departmentService.selectDepartmentByPage(current, page.PageSize);
            }
            else
            {
                error = "当前已经是最后一页！";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (current  > 1)
            {
                current = current - 1;
                page.PT1 = departmentService.selectDepartmentByPage(current, page.PageSize);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            page.PT1 = departmentService.selectDepartmentByPage(page.TotalPage, page.PageSize);
            current = page.TotalPage;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string dept_no = Request["del_no"];
            int count = departmentService.deleteDepartmentByNo(dept_no);
            if (count == -1)
            {
                error = "不存在该部门";
            }
            else if (count == 0)
            {
                error = "删除失败";
            }
            else if (count == -2)
            {
                error = "该部门还有员工，目前不可删除！";
            }
            else
            {
                error = "删除成功";
            }
        }
    }
}