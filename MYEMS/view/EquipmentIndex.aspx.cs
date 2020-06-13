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
    public partial class EquipmentIndex : System.Web.UI.Page
    {
        public EquipmentServiceImpl equipmentService = new EquipmentServiceImpl();
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
        public PageHelper<Equipment> page = null;
        public string error;
        public static int current = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            bool b = (bool)Session["manager"];
            if (username != null)
            {
                if (page == null)
                {
                    page = new PageHelper<Equipment>();
                    page.PageSize = 3;
                    page.TotalCount = equipmentService.getTotalCount();
                    page.TotalPage = page.TotalCount % page.PageSize == 0 ? page.TotalCount / page.PageSize : page.TotalCount / page.PageSize + 1;
                    page.CurrentPage = 1;
                    List<Equipment> equs = equipmentService.selectEquipmentByPage(page.CurrentPage, page.PageSize);
                    page.PT1 = equs;
                }
                if (!b)
                {
                    Button9.Enabled = false;
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            page.PT1 = equipmentService.selectEquipmentByPage(1, page.PageSize);
            current = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (current < page.TotalPage)
            {
                current = current + 1;
                page.PT1 = equipmentService.selectEquipmentByPage(current, page.PageSize);
            }
            else
            {
                error = "当前已经是最后一页！";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                current = current - 1;
                page.PT1 = equipmentService.selectEquipmentByPage(current, page.PageSize);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            page.PT1 = equipmentService.selectEquipmentByPage(page.TotalPage, page.PageSize);
            current = page.TotalPage;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string equ_no = Request["del_no"];
            bool b=(bool)Session["manager"];
            if (b)
            {
                int count = equipmentService.deleteEquipmentByNo(equ_no);
                if (count == -1)
                {
                    error = "不存在该设备";
                }
                else if (count == 0)
                {
                    error = "删除失败";
                }
                else
                {
                    error = "删除成功";
                }
            }
            else
            {
                error = "您并没有执行该操作的权限";
            }   
        }
    }
}