using MYEMS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYEMS.service
{
    interface EquipmentService
    {
        List<Equipment> selectAllEquipment();
        Equipment selectEquipmentByNo(string equ_no);
        int insertEquipment(Equipment equ);
        int deleteEquipmentByNo(string equ_no);
        int updateEquipmentByNo(Equipment equ);
        List<Equipment> selectEquipmentByName(string equ_name);
        List<Equipment> selectEquipmentByPage(int currentPage, int pageSize);
        int getTotalCount();
        List<Equipment> selectEquipmentByDate(DateTime date);
        List<Equipment> selectEquipmentByPosition(string position);
        List<Equipment> selectEquipmentByDeptName(string dept_name);
        List<Equipment> selectEquipmentByEmpName(string emp_name);


    }
}
