using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MYEMS.dao
{
    public class EmployeeDao
    {
        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\C#\\MYEMS\\MYEMS\\App_Data" +
            "\\EMS.mdf;Integrated Security=True";
        /**
         *获取所有员工的信息
         */
        public List<Employee> selectAllEmployee()
        {
            List<Employee> emps = new List<Employee>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [employee]", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee emp= new Employee();
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"];
                    emps.Add(emp);
                }
                dr.Close();
            }
            return emps;
        }

        /**
         * 登陆查询
         */ 
         public Employee loginCheck(string emp_name,string emp_pwd)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [employee] where emp_name=N'{0}' and emp_pwd=N'{1}'", emp_name,emp_pwd);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Employee emp = null;
                if (dr.Read())
                {
                    emp = new Employee();
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"];
                }
                return emp;
            }
        }
        /**
         *添加员工信息
         */
        public int insertEmployee(Employee emp)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("INSERT INTO [employee](emp_no,emp_name,emp_pwd,emp_mobile,emp_is_manager,emp_dept)" +

                   "VALUES('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", emp.Emp_no,emp.Emp_name,emp.Emp_pwd,emp.Emp_mobile,emp.Emp_is_manager,emp.Emp_dept);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count=cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 判断员工是否存在
         */
        public bool isExist(string no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [employee] where emp_no='{0}'", no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool b = dr.HasRows;
                return b;
            }
        }
        /**
         * 根据员工编号获取员工信息
         */
        public Employee selectEmployeeByNo(string emp_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [employee] where emp_no='{0}'", emp_no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Employee emp = null;
                if (dr.Read())
                {
                    emp = new Employee();
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"]; 
                }
                return emp;
            }
        }
        /**
         * 根据员工名字查询员工信息
         */ 
         public List<Employee> selectEmployeeByName(String emp_name)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [employee] where emp_name='{0}'", emp_name);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Employee> emps = new List<Employee>();
                while (dr.Read())
                {
                    Employee emp = new Employee(); ;
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"];
                    emps.Add(emp);
                }
                return emps;
            }
        }
        /**
         * 根据部门编号查询所有
         */ 
        public List<Employee> selectEmployeeBydept(string dept_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [employee] where emp_dept='{0}'", dept_no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Employee> emps = new List<Employee>();
                while (dr.Read())
                {
                    Employee emp = new Employee(); ;
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"];
                    emps.Add(emp);
                }
                return emps;
            }
        }
        /**
         * 分页查询员工
         */ 
         public List<Employee> selectEmployeeByPage(int currentPage,int pageSize)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM employee ORDER BY emp_id OFFSET "+ ((currentPage - 1) * pageSize) + " ROWS FETCH NEXT "+ pageSize + " ROWS only");
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Employee> emps = new List<Employee>();
                while (dr.Read())
                {
                    Employee emp = new Employee(); ;
                    emp.Emp_id = (int)dr["emp_id"];
                    emp.Emp_no = (string)dr["emp_no"];
                    emp.Emp_name = (string)dr["emp_name"];
                    emp.Emp_pwd = (string)dr["emp_pwd"];
                    emp.Emp_mobile = (string)dr["emp_mobile"];
                    emp.Emp_is_manager = (bool)dr["emp_is_manager"];
                    emp.Emp_dept = (string)dr["emp_dept"];
                    emps.Add(emp);
                }
                return emps;
            }
        }
        /**
         * 根据员工编号删除员工信息
         */
        public int deleteEmployeeByNo(string emp_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("delete from [employee] where emp_no='{0}'",emp_no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count=cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 根据员工编号更新员工信息
         */
       public int updateEmployeeByNo(Employee emp)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("UPDATE [employee] set emp_name=N'{0}',emp_pwd='{1}'" +
                    ",emp_mobile='{2}',emp_is_manager='{3}',emp_dept='{4}' where emp_no='{5}'"
                    ,emp.Emp_name,emp.Emp_pwd,emp.Emp_mobile,emp.Emp_is_manager,emp.Emp_dept,emp.Emp_no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count=cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
        * 获取员工表记录总数
        */
        public int getTotalCount()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select count(*) from employee");
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                int count = 0;
                if (dr.Read())
                {
                    count = (int)dr[0];
                }
                return count;
            }
        }
    }

}