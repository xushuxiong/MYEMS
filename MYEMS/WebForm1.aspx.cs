using MYEMS.dao;
using MYEMS.entity;
using MYEMS.service;
using MYEMS.service.impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYEMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool bok = false;//默认为false
            string path = null;//储存文件夹路径
            string filename = null;
            if (this.FileUpload1.HasFile)//检测是否有上传文件
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
                        this.lbl.Text = "文件" + FileUpload1.FileName + "上传成功!";
                    }
                    catch (Exception ex)
                    {
                        this.lbl.Text = "文件上传失败!" + ex.Message;
                    }
                }
                else
                {
                    this.lbl.Text = "上传的图片格式不正确：只能上传.png,jpg,.gif,.bmp,.jpeg";
                }
            }
            this.Image1.ImageUrl = this.Request.ApplicationPath + ("Images/" + filename + FileUpload1.FileName);//把上传的图片赋给Image1路径


        }
    }
}