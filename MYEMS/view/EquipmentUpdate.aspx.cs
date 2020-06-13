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
    public partial class EquipmentUpdate : System.Web.UI.Page
    {
        public string equ_no = null;
        EquipmentServiceImpl equipmentService = new EquipmentServiceImpl();
        public Equipment equ = new Equipment();
        public string msg;
        public List<Employee> emps;
        public EmployeeServiceImpl employeeService = new EmployeeServiceImpl();
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
                equ_no = (string)Request["equ_no"];
                emps = employeeService.selectAllEmployee();
                if (equ_no != null)
                {
                    equ = equipmentService.selectEquipmentByNo(equ_no);
                    this.Image1.ImageUrl = this.Request.ApplicationPath + equ.Equ_picture;
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

      
        protected void Button1_Click1(object sender, EventArgs e)
        {
            int equ_id = Convert.ToInt16(Request["equ_id"]);
            string equ_no = Request["equ_no"];
            string equ_name = Request["equ_name"];
            string equ_specification = Request["equ_specification"];
            double equ_price = Convert.ToDouble(Request["equ_price"]);
            string equ_emp = Request["equ_emp"];
            string equ_position = Request["equ_position"];
            bool bok = false;//默认为false
            string path = null;//储存文件夹路径
            string filename = null;
            if (FileUpload1.HasFile)//检测是否有上传文件
            {
                string file = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();//获取文件夹下的文件路径
                string[] allow = new string[] { ".png", ".jpg", ".gif", ".bmp", ".jpeg" };//后缀名数组


                foreach (string s in allow)//读取后缀名数组
                {
                    if (s == file) //如果符合数组里的类型
                    {
                        bok = true;//bool值为true
                    }
                }


                if (bok)//如果为true
                {
                    try
                    {
                        Random random = new Random();
                        int rand = random.Next(01, 99);
                        filename = DateTime.Now.ToString("yyMMddhhmmss") + rand;
                        path = Server.MapPath("") + "/Images/" + filename;
                        this.FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);//上传文件
                        string url = "view/Images/" + filename+ FileUpload1.FileName;
                        Equipment equ = new Equipment(equ_id, equ_no, equ_specification, url, equ_price, equ_position, equ_emp, equ_name);
                        int count = equipmentService.updateEquipmentByNo(equ);
                        if (count == -1)
                        {
                            msg = "不存在该用户！";
                        }
                        else if (count == 0)
                        {
                            msg = "修改失败！";
                        }
                        Response.Redirect("EquipmentIndex.aspx");
                    }
                    catch (Exception ex)
                    {
                        msg = "文件上传失败!" + ex.Message;
                    }
                }
                else
                {
                    msg = "上传的图片格式不正确：只能上传.png,jpg,.gif,.bmp,.jpeg";
                }
            }
            else
            {
                Equipment equ1 = new Equipment(equ_id, equ_no, equ_specification, equ.Equ_picture, equ_price, equ_position, equ_emp, equ_name);
                int count = equipmentService.updateEquipmentByNo(equ1);
                if (count == -1)
                {
                    msg = "不存在该用户！";
                }
                else if (count == 0)
                {
                    msg = "修改失败！";
                }
                Response.Redirect("EquipmentIndex.aspx");
            }
        }
       
    }
}