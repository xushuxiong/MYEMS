using MYEMS.dao;
using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYEMS.service.impl
{
    public class EmployeeServiceImpl : EmployeeService
    {
        private EmployeeDao employeeDao = new EmployeeDao();
       /**
        * 获取所有的员工
        */
        public List<Employee> selectAllEmployee()
        {
            List<Employee> emps = employeeDao.selectAllEmployee();
            return emps;
        }
        /**
         * 根据员工编号查询员工
         */
        public Employee selectEmployeeByNo(string emp_no)
        {
            Employee emp=employeeDao.selectEmployeeByNo(emp_no);
            return emp;
        }
        /**
         *添加员工信息
         */
        public int insertEmployee(Employee emp)
        {
            bool b=employeeDao.isExist(emp.Emp_no);
            if (b == true)
            {
                return -1;
            }
            int count=employeeDao.insertEmployee(emp);
            return count;
        }
       /**
        * 根据员工编号删除员工信息
        */
        public int deleteEmployeeByNo(string emp_no)
        {
            bool b=employeeDao.isExist(emp_no);
            if (!b)
            {
                return -1;
            }
            int count=employeeDao.deleteEmployeeByNo(emp_no);
            return count;
        }
       /**
        * 根据员工编号更新员工信息
        */
        public int updateEmployeeByNo(Employee emp)
        {
            bool b = employeeDao.isExist(emp.Emp_no);
            if (!b)
            {
                return -1;
            }
            int count=employeeDao.updateEmployeeByNo(emp);
            return count;
        }
        /**
         * 根据员工名字查询员工
         */
        public List<Employee> selectEmplyeeByName(string emp_name)
        {
            return employeeDao.selectEmployeeByName(emp_name);
        }
        /**
         * 根据部门编号查询所有员工
         */ 
        public List<Employee> selectEmployeeByDept(string dept_no)
        {
            return employeeDao.selectEmployeeBydept(dept_no);
        }
        /**
         * 登陆检查
         */ 
       public Employee login_check(string emp_name,string emp_pwd)
        {
            return employeeDao.loginCheck(emp_name, emp_pwd);
        }
        /**
         * 分页查询员工
         */ 
        public List<Employee> selectEmployeeByPage(int currentPage, int pageSize)
        {
            return employeeDao.selectEmployeeByPage(currentPage, pageSize);
        }
        public int getTotalCount()
        {
            return employeeDao.getTotalCount();
        }

        public List<Employee> selectEmployeeByMobile(string emp_mobile)
        {
            return employeeDao.selectEmployeeByMobile(emp_mobile);
        }
        public List<Employee> selectEmployeeByManager(bool emp_manager)
        {
            return employeeDao.selectEmployeeByManager(emp_manager);
        }
    }
}