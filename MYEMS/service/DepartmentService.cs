using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYEMS.service
{
    interface DepartmentService
    {
        List<Department> selectAllDepartment();
        Department selectDepartmentByNo(string dept_no);
        int insertDepartment(Department dept);
        int deleteDepartmentByNo(string dept_no);
        int updateDepartmentByNo(Department dept);
        List<Department> selectDepartmentByName(string dept_name);
        List<Department> selectDepartmentByManager(string dept_manager);
        List<Department> selectDepartmentByPage(int currentPage,int pageSize);
        int getTotalCount();
    }
}
