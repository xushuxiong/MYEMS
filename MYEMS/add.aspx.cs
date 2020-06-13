using MYEMS.dao;
using MYEMS.entity;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS
{
    public partial class add : System.Web.UI.Page
    {
        EquipmentDao equipmentDao = new EquipmentDao();
        public string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*  List<Equipment> equs = equipmentDao.selectEquipmentByPage(1, 3);
             for(int i = 0; i < equs.Count; i++)
             {
                 Response.Write(equs[i].ToString()+"<br>");
             }
             Equipment equ = new Equipment("201927", "sc00126", "Images\me.jpg", 23.4, DateTime.Now, "实验室三楼", "201824","A4纸");
             equipmentDao.updateEquipmentByNo(equ);*/
            date = new DateTime(2019,08,21).ToString();
            /*List<Equipment>equs=equipmentDao.selectEquipmentByEmpName("许树雄");
            for (int i = 0; i < equs.Count; i++)
            {
                Response.Write(equs[i].ToString() + "<br>");
            }
            //Response.Write(equ.ToString());*/
           /* EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
            List<Employee> emps= employeeService.selectEmplyeeByName("许树雄");
            for (int i = 0; i < emps.Count; i++)
            {
                Response.Write(emps[i].ToString() + "<br>");
            }*/
        }
    }
}