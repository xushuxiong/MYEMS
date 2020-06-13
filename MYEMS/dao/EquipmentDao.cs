using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MYEMS.dao
{
    public class EquipmentDao
    {
        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\C#\\MYEMS\\MYEMS\\App_Data" +
            "\\EMS.mdf;Integrated Security=True";
        /**
        *获取所有设备的信息
        */
        public List<Equipment> selectAllEquipment()
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [equipment]", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
        * 分页查询设备
        */
        public List<Equipment> selectEquipmentByPage(int currentPage, int pageSize)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM equipment ORDER BY equ_id OFFSET " + ((currentPage - 1) * pageSize) + " ROWS FETCH NEXT " + pageSize + " ROWS only");
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
        *添加设备信息
        */
        public int insertEquipment(Equipment equ)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("INSERT INTO [equipment](equ_no,equ_name,equ_picture,equ_position,equ_price,equ_day,equ_specification,equ_emp)" +

                   "VALUES('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", 
                   equ.Equ_no,equ.Equ_name,equ.Equ_picture,equ.Equ_position,equ.Equ_price,equ.Equ_day.ToString(),equ.Equ_specification,equ.Equ_emp);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }
        /**
         * 判断设备是否存在
         */
        public bool isExist(string no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sql = string.Format("SELECT * FROM [equipment] where equ_no='{0}'", no);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool b = dr.HasRows;
                return b;
            }
        }
        /**
        * 根据设备编号更新设备信息
        */
        public int updateEquipmentByNo(Equipment equ)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("UPDATE [equipment] set equ_name=N'{0}'" +
                    ",equ_picture=N'{1}',equ_position=N'{2}',equ_price='{3}',equ_specification=N'{4}',equ_emp=N'{5}' where equ_no='{6}'"
                    , equ.Equ_name,equ.Equ_picture,equ.Equ_position,equ.Equ_price,equ.Equ_specification,equ.Equ_emp,equ.Equ_no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }
      /**
       *根据设备编号获取设备信息
       */
        public Equipment selectEquipmentByNo(string no)
        {
            Equipment equ = new Equipment();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select * from [equipment] where equ_no='{0}'", no);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {        
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                }
                dr.Close();
            }
            return equ;
        }
        /**
         *根据设备编号获取设备信息
         */
        public List<Equipment> selectEquipmentByName(string name)
        {         
            List<Equipment> equs=new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select * from [equipment] where equ_name=N'{0}'", name);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
        *根据设备编号获取设备信息
        */
        public List<Equipment> selectEquipmentByDate(DateTime date)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select * from [equipment] where equ_day=N'{0}'", date.ToString());
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        public List<Equipment> selectEquipmentByPosition(string  position)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("select * from [equipment] where equ_position LIKE N'%{0}%'", position);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
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
                string sqlstr = string.Format("select count(*) from equipment");
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
       /**
        * 根据设备编号删除设备信息
        */
        public int deleteEquipmentByNo(string equ_no)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                int count = 0;
                try
                {
                    string sqlstr = string.Format("delete from [equipment] where equ_no='{0}'", equ_no);
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    return -2;
                }
                return count;
            }
        }
        /**
         * 根据部门名字获取设备信息
         */
        public List<Equipment> selectEquipmentByDeptName(string dept_name)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("SELECT eq.*, d.dept_name me, e.emp_name my FROM department d, employee e, equipment eq" +
                    " WHERE e.emp_no = eq.equ_emp AND e.emp_dept = d.dept_no AND d.dept_name = N'{0}'"
                , dept_name);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equ.Emp_name = (string)dr["my"];
                    equ.Dept_name = (string)dr["me"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
         * 根据负责人名字获取设备信息
         */
        public List<Equipment> selectEquipmentByEmpName(string emp_name)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("SELECT eq.*, e.emp_name my FROM employee e, equipment eq WHERE e.emp_no = eq.equ_emp AND  e.emp_name = N'{0}'"
                , emp_name);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equ.Emp_name = (string)dr["my"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
        * 根据价格获取设备信息
        */
        public List<Equipment> selectEquipmentByPrice(double equ_price)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("SELECT * from [equipment] WHERE emp_price ="+equ_price);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
        /**
        * 根据型号获取设备信息
        */
        public List<Equipment> selectEquipmentBySpecification(string equ_specification)
        {
            List<Equipment> equs = new List<Equipment>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = str;
                cn.Open();
                string sqlstr = string.Format("SELECT * from [equipment] WHERE equ_specification = '{0}'",equ_specification);
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipment equ = new Equipment();
                    equ.Equ_id = (int)dr["equ_id"];
                    equ.Equ_no = (string)dr["equ_no"];
                    equ.Equ_name = (string)dr["equ_name"];
                    equ.Equ_picture = (string)dr["equ_picture"];
                    equ.Equ_position = (string)dr["equ_position"];
                    equ.Equ_price = (double)dr["equ_price"];
                    equ.Equ_day = (DateTime)dr["equ_day"];
                    equ.Equ_emp = (string)dr["equ_emp"];
                    equ.Equ_specification = (string)dr["equ_specification"];
                    equs.Add(equ);
                }
                dr.Close();
            }
            return equs;
        }
    }
}