using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.BUS
{
    internal class CategoryBUS
    {
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new CategoryBUS(); }
                return CategoryBUS.instance;
            }
            private set { CategoryBUS.instance = value; }
        }
        private CategoryBUS() { }
        public List<Category> ListAllCategory()
        {
            List<Category> categories = CatogoryDAO.Instance.LoadCategoryList();
            return categories;
        }
    }
}
