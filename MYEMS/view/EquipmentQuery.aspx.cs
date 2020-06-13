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
    public partial class EquipmentQuery : System.Web.UI.Page
    {
        EquipmentServiceImpl equipmentService = new EquipmentServiceImpl();
        DepartmentServiceImpl DepartmentService = new DepartmentServiceImpl();
        EmployeeServiceImpl employeeServiceImpl = new EmployeeServiceImpl();
        public string error=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];
            if (username == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Equipment> equs = new List<Equipment>();
            string thing = Request["query_thing"];
            string content = Request["query_content"];
            try
            {
                if (thing == "1")
                {
                    equs.Add(equipmentService.selectEquipmentByNo(content));
                }
                else if (thing == "2")
                {
                    equs = equipmentService.selectEquipmentByName(content);
                }
                else if (thing == "4")
                {
                    equs = equipmentService.selectEquipmentByPosition(content);
                }
                else if (thing == "5")
                {
                    equs = equipmentService.selectEquipmentByEmpName(content);
                }
                else if (thing == "6")
                {
                    equs = equipmentService.selectEquipmentBySpecification(content);
                }
                else if (thing == "7")
                {

                    equs = equipmentService.selectEquipmentByDeptName(content);
                }
                Session.Add("equs", equs);

            }
            catch (Exception ex)
            {
                error = "输入有误，请检查！";
            }

            Server.Transfer("EquipmentQueryInfo.aspx");
        }
    }
}