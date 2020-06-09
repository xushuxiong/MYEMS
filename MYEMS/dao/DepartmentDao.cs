using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MYEMS.dao
{
    public class DepartmentDao
    {
        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\C#\\MYEMS\\MYEMS\\App_Data" +
            "\\EMS.mdf;Integrated Security=True";
        /**
        *获取所有部门的信息
        */
        public List<Department> SelectAllDepartment()
        {
            List<Department> depts = new List<Department>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [department]", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Department dept = new Department();
                    dept.Dept_id = (int)dr["dept_id"];
                    dept.Dept_no = (string)dr["dept_no"];
                    dept.Dept_name = (string)dr["dept_name"];
                    dept.Dept_manager = (string)dr["dept_manager"];
                    depts.Add(dept);
                }
                dr.Close();
            }
            return depts;
        }
        /**
         * 判断部门是否存在
         */
        public bool isExist(string no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [department] where dept_no='{0}'", no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool b = dr.HasRows;
                return b;
            }
        }
        /**
         *添加部门信息
         */
        public int insertDepartment(Department dept)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("INSERT INTO [department](dept_no,dept_name,dept_manager)" +

                   "VALUES('{0}',N'{1}',N'{2}')", dept.Dept_no,dept.Dept_name,dept.Dept_manager);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 根据部门编号获取部门信息
         */
        public Department selectDepartmentByNo(string dept_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [department] where dept_no='{0}'", dept_no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Department dept = null;
                if (dr.Read())
                {
                    dept = new Department();
                    dept.Dept_id = (int)dr["dept_id"];
                    dept.Dept_no = (string)dr["dept_no"];
                    dept.Dept_name = (string)dr["dept_name"];
                    dept.Dept_manager = (string)dr["dept_manager"];
                }
                return dept;
            }
        }
        /**
         * 根据部门编号删除部门信息
         */
        public int deleteDepartmenteByNo(string dept_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("delete from [department] where dept_no='{0}'", dept_no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 根据部门编号更新部门信息
         */
        public int updateDepartmentByNo(Department dept)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("UPDATE [department] set dept_name=N'{0}',dept_manager='{1}' where dept_no='{2}'"
                    , dept.Dept_name,dept.Dept_manager,dept.Dept_no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 根据部门名称查询部门信息
         */
        public List<Department> selectDepartmentByName(string dept_name) {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [department] where dept_no='{0}'", dept_name);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Department> depts = new List<Department>();
               
                if (dr.Read())
                {
                    Department dept = new Department();
                    dept.Dept_id = (int)dr["dept_id"];
                    dept.Dept_no = (string)dr["dept_no"];
                    dept.Dept_name = (string)dr["dept_name"];
                    dept.Dept_manager = (string)dr["dept_manager"];
                    depts.Add(dept);
                }
                return depts;
            }
        }
        /**
         * 根据部门主管查询部门信息
         */ 
         public List<Department> selectDepartmentByManager(string dept_manager)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [department] where dept_managet='{0}'", dept_manager);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Department> depts = new List<Department>();

                if (dr.Read())
                {
                    Department dept = new Department();
                    dept.Dept_id = (int)dr["dept_id"];
                    dept.Dept_no = (string)dr["dept_no"];
                    dept.Dept_name = (string)dr["dept_name"];
                    dept.Dept_manager = (string)dr["dept_manager"];
                    depts.Add(dept);
                }
                return depts;
            }
        }
        /**
         * 分页查询部门
         */ 
         public List<Department> selectDepartmentByPage(int currentPage,int pageSize)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM department ORDER BY dept_id OFFSET " + ((currentPage - 1) * pageSize) + " ROWS FETCH NEXT " + pageSize + " ROWS only");
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Department> depts = new List<Department>();

                while (dr.Read())
                {
                    Department dept = new Department();
                    dept.Dept_id = (int)dr["dept_id"];
                    dept.Dept_no = (string)dr["dept_no"];
                    dept.Dept_name = (string)dr["dept_name"];
                    dept.Dept_manager = (string)dr["dept_manager"];
                    depts.Add(dept);
                }
                dr.Close();
                return depts;
            }
        }
        /**
         * 获取部门表记录总数
         */ 
         public int getTotalCount()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select count(*) from department");
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