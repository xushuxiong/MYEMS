using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYEMS.entity
{
    public class Equipment
    {
        private int equ_id;
        private string equ_no;
        private string equ_specification;
        private string equ_picture;
        private double equ_price;
        private DateTime equ_day;    
        private string equ_position;
        private string equ_emp;
        private string equ_name;
        private string dept_name;
        private string emp_name;

        public int Equ_id { get => equ_id; set => equ_id = value; }
        public string Equ_no { get => equ_no; set => equ_no = value; }
        public string Equ_specification { get => equ_specification; set => equ_specification = value; }
        public string Equ_picture { get => equ_picture; set => equ_picture = value; }
        public double Equ_price { get => equ_price; set => equ_price = value; }
        public DateTime Equ_day { get => equ_day; set => equ_day = value; }
        public string Equ_position { get => equ_position; set => equ_position = value; }
        public string Equ_emp { get => equ_emp; set => equ_emp = value; }
        public string Equ_name { get => equ_name; set => equ_name = value; }
        public string Dept_name { get => dept_name; set => dept_name = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }

        public Equipment(int equ_id, string equ_no, string equ_specification, string equ_picture, double equ_price, DateTime equ_day, string equ_position, string equ_emp, string equ_name, string dept_name, string emp_name) : this(equ_id, equ_no, equ_specification, equ_picture, equ_price, equ_day, equ_position, equ_emp, equ_name)
        {
            this.Dept_name = dept_name;
            this.Emp_name = emp_name;
        }

        public Equipment(int equ_id, string equ_no, string equ_specification, string equ_picture, double equ_price, DateTime equ_day, string equ_position, string equ_emp, string equ_name)
        {
            this.equ_id = equ_id;
            this.equ_no = equ_no;
            this.equ_specification = equ_specification;
            this.equ_picture = equ_picture;
            this.equ_price = equ_price;
            this.equ_day = equ_day;
            this.equ_position = equ_position;
            this.equ_emp = equ_emp;
            this.equ_name = equ_name;
        }

        public Equipment(string equ_no, string equ_specification, string equ_picture, double equ_price, DateTime equ_day, string equ_position, string equ_emp, string equ_name)
        {
            this.equ_no = equ_no;
            this.equ_specification = equ_specification;
            this.equ_picture = equ_picture;
            this.equ_price = equ_price;
            this.equ_day = equ_day;
            this.equ_position = equ_position;
            this.equ_emp = equ_emp;
            this.equ_name = equ_name;
        }

        public Equipment(int equ_id, string equ_no, string equ_specification, string equ_picture, double equ_price, string equ_position, string equ_emp, string equ_name)
        {
            this.equ_id = equ_id;
            this.equ_no = equ_no;
            this.equ_specification = equ_specification;
            this.equ_picture = equ_picture;
            this.equ_price = equ_price;
            this.equ_position = equ_position;
            this.equ_emp = equ_emp;
            this.equ_name = equ_name;
        }

        public Equipment(int equ_id, string equ_no, string equ_specification, double equ_price, string equ_position, string equ_emp, string equ_name)
        {
            this.equ_id = equ_id;
            this.equ_no = equ_no;
            this.equ_specification = equ_specification;
            this.equ_price = equ_price;
            this.equ_position = equ_position;
            this.equ_emp = equ_emp;
            this.equ_name = equ_name;
        }

        public Equipment()
        {
        }

        public override string ToString()
        {
            return this.equ_id+" " +this.equ_no+" "+this.equ_name+" "+this.equ_price+" "+this.equ_specification+" "+this.equ_position
                +this.equ_emp+" "+this.equ_picture+" "+this.equ_day+" "+this.emp_name+" "+this.dept_name;
        }
    }
}