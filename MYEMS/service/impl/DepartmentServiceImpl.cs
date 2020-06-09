using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MYEMS.dao;
using MYEMS.entity;

namespace MYEMS.service.impl
{
    public class DepartmentServiceImpl : DepartmentService
    {
        private DepartmentDao departmentDao = new DepartmentDao();
        /**
         * 根据部门编号删除部门信息
         */
        public int deleteDepartmentByNo(string dept_no)
        {
            bool b=departmentDao.isExist(dept_no);
            if (!b)
            {
                return -1;
            }
            int count=departmentDao.deleteDepartmenteByNo(dept_no);
            return count;
        }
        /**
         * 添加部门信息
         */ 
        public int insertDepartment(Department dept)
        {
            bool b=departmentDao.isExist(dept.Dept_no);
            if (b)
            {
                return -1;
            }
            int count=departmentDao.insertDepartment(dept);
            return count;
        }
        /**
         * 查询所有部门信息
         */ 
        public List<Department> selectAllDepartment()
        {
            List<Department> depts=departmentDao.SelectAllDepartment();
            return depts;
        }
        /**
         * 根据部门编号查询部门信息
         */ 
        public Department selectDepartmentByNo(string dept_no)
        {
            bool b=departmentDao.isExist(dept_no);
            if (!b)
            {
                return null;
            }
            Department dept=departmentDao.selectDepartmentByNo(dept_no);
            return dept;
        }
        /**
         * 修改部门信息
         */ 
        public int updateDepartmentByNo(Department dept)
        {
            bool b=departmentDao.isExist(dept.Dept_no);
            if (!b)
            {
                return -1;
            }
            int count=departmentDao.updateDepartmentByNo(dept);
            return count;
        }
        /**
         * 根据部门名字查询部门信息
         */ 
        public List<Department> selectDepartmentByName(string dept_name)
        {
            return departmentDao.selectDepartmentByName(dept_name);
        }
        /**
         * 根据部门主管编号查询部门信息
         */ 
        public List<Department> selectDepartmentByManager(string dept_manager)
        {
            return departmentDao.selectDepartmentByManager(dept_manager);
        }

        public List<Department> selectDepartmentByPage(int currentPage, int pageSize)
        {
            return departmentDao.selectDepartmentByPage(currentPage, pageSize);
        }

        public int getTotalCount()
        {
            return departmentDao.getTotalCount();
        }
    }
}