using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYEMS.entity
{
    public class Department
    {
        private int dept_id;
        private string dept_no;
        private string dept_name;
        private string dept_manager;

        public int Dept_id { get => dept_id; set => dept_id = value; }
        public string Dept_no { get => dept_no; set => dept_no = value; }
        public string Dept_name { get => dept_name; set => dept_name = value; }
        public string Dept_manager { get => dept_manager; set => dept_manager = value; }

        public Department(int dept_id, string dept_no, string dept_name, string dept_manager)
        {
            this.dept_id = dept_id;
            this.dept_no = dept_no;
            this.dept_name = dept_name;
            this.dept_manager = dept_manager;
        }

        public Department(string dept_no, string dept_name, string dept_manager)
        {
            this.dept_no = dept_no;
            this.dept_name = dept_name;
            this.dept_manager = dept_manager;
        }

        public override string ToString()
        {
            return this.dept_id+" "+this.dept_no+" "+this.dept_name+" "+this.dept_manager;
        }

        public Department()
        {
        }
    }
}