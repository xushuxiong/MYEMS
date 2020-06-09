using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYEMS.service
{
    interface EmployeeService
    {
        List<Employee> selectAllEmployee();
        Employee selectEmployeeByNo(string emp_no);
        int insertEmployee(Employee emp);
        int deleteEmployeeByNo(string emp_no);
        int updateEmployeeByNo(Employee emp);
        List<Employee> selectEmplyeeByName(string emp_name);
        List<Employee> selectEmployeeByDept(string dept_no);
        Employee login_check(string emp_name, string emp_pwd);
        List<Employee> selectEmployeeByPage(int currentPage, int pageSize);
        int getTotalCount();
    }
}
