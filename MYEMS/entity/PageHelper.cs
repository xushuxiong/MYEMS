using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYEMS.entity
{
    /**
     * 分页帮助类
     */
    public class PageHelper<T>
    {
        private int currentPage;
        private int pageSize;
        private List<T> PT;
        private int totalCount;
        private int totalPage;


        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public List<T> PT1 { get => PT; set => PT = value; }
        public int TotalCount { get => totalCount; set => totalCount=value; }
        public int TotalPage { get => totalPage; set => totalPage=value; }

        public PageHelper(int currentPage, int pageSize, List<T> pT, int totalCount, int totalPage)
        {
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            PT = pT;
            this.totalCount = totalCount;
            this.totalPage = totalPage;
        }

        public PageHelper()
        {
        }
    }
}
