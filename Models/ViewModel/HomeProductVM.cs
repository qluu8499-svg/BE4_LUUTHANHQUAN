using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
namespace BE4_LUUTHANHQUAN.Models.ViewModel
{
    public class HomeProductVM
    {
        public string SearchTerm { get; set; }
         public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public List<Product> FeaturedProducts { get; set; }

        // Danh sách sản phẩm mới đã phân trang
        public PagedList.IPagedList<Product> NewProducts { get; set; }


    }
}