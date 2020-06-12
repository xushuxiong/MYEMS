using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MYEMS.dao;
using MYEMS.entity;

namespace MYEMS.service.impl
{
    public class EquipmentServiceImpl : EquipmentService
    {
        EquipmentDao equipmentDao = new EquipmentDao();
        /**
         * 删除设备信息
         */ 
        public int deleteEquipmentByNo(string equ_no)
        {
            bool b=equipmentDao.isExist(equ_no);
            if (!b)
            {
                return -1;
            }
            return equipmentDao.deleteEquipmentByNo(equ_no);
        }
        /**
         * 获取所有的设备数量
         */ 
        public int getTotalCount()
        {
            return equipmentDao.getTotalCount();
        }
        /**
         * 添加设备记录
         */ 
        public int insertEquipment(Equipment equ)
        {
            bool b= equipmentDao.isExist(equ.Equ_no);
            if (b)
            {
                return -1;
            }
            return equipmentDao.insertEquipment(equ);
        }
        /**
         * 获取所有的设备信息
         */ 
        public List<Equipment> selectAllEquipment()
        {
            return equipmentDao.selectAllEquipment();
        }
        /**
         * 通过设备名字获取设备信息
         */ 
        public List<Equipment> selectEquipmentByName(string equ_name)
        {
            return equipmentDao.selectEquipmentByName(equ_name);
        }
        /**
         * 根据设备编号获取设备信息
         */ 
        public Equipment selectEquipmentByNo(string equ_no)
        {
            return equipmentDao.selectEquipmentByNo(equ_no);
        }
        /**
         * 分页获取设备信息
         */ 
        public List<Equipment> selectEquipmentByPage(int currentPage, int pageSize)
        {
            return equipmentDao.selectEquipmentByPage(currentPage, pageSize);
        }
        /**
         * 更新设备信息
         */ 
        public int updateEquipmentByNo(Equipment equ)
        {
            return equipmentDao.updateEquipmentByNo(equ);
        }
        /**
         * 根据时间查询设备信息
         */ 
        public List<Equipment> selectEquipmentByDate(DateTime date)
        {
            return equipmentDao.selectEquipmentByDate(date);
        }
        /**
         * 根据位置查询设备信息
         */ 
        public List<Equipment> selectEquipmentByPosition(string position)
        {
            return equipmentDao.selectEquipmentByPosition(position);
        }
        /**
         * 根据部门名字查询设备信息
         */ 
        public List<Equipment> selectEquipmentByDeptName(string dept_name)
        {
            return equipmentDao.selectEquipmentByDeptName(dept_name);
        }
        /**
         * 根据负责人姓名查询设备信息
         */ 
        public List<Equipment> selectEquipmentByEmpName(string emp_name)
        {
            return equipmentDao.selectEquipmentByEmpName(emp_name);
        }
    }
}