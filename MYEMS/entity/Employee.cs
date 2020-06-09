using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYEMS.entity
{
    public class Employee
    {
        private int emp_id;
        private string emp_no;
        private string emp_pwd;
        private string emp_name;
        private string emp_mobile;
        private bool emp_is_manager;
        private string emp_dept;

        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_no { get => emp_no; set => emp_no = value; }
        public string Emp_pwd { get => emp_pwd; set => emp_pwd = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Emp_mobile { get => emp_mobile; set => emp_mobile = value; }
        public bool Emp_is_manager { get => emp_is_manager; set => emp_is_manager = value; }
        public string Emp_dept { get => emp_dept; set => emp_dept = value; }

        public Employee(int emp_id, string emp_no, string emp_pwd, string emp_name, string emp_mobile, bool emp_is_manager, string emp_dept)
        {
            this.Emp_id = emp_id;
            this.Emp_no = emp_no;
            this.Emp_pwd = emp_pwd;
            this.Emp_name = emp_name;
            this.Emp_mobile = emp_mobile;
            this.Emp_is_manager = emp_is_manager;
            this.Emp_dept = emp_dept;
        }

        public Employee(string emp_no, string emp_pwd, string emp_name, string emp_mobile, bool emp_is_manager, string emp_dept)
        {
            Emp_no = emp_no;
            Emp_pwd = emp_pwd;
            Emp_name = emp_name;
            Emp_mobile = emp_mobile;
            Emp_is_manager = emp_is_manager;
            Emp_dept = emp_dept;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            string str= this.emp_id + " " + this.emp_no + " " + this.emp_name + " " + this.emp_mobile + " " + this.emp_pwd + " " + this.emp_is_manager + " " + this.emp_dept;
            return str;
        }

        public static implicit operator Employee(string v)
        {
            throw new NotImplementedException();
        }
    }
}