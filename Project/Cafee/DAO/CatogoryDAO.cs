using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafee.DTO;

namespace Cafee.DAO
{
    internal class CatogoryDAO
    {
        private static CatogoryDAO instance;

        public static CatogoryDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new CatogoryDAO(); }
                return CatogoryDAO.instance;
            }
            private set { CatogoryDAO.instance = value; }
        }
        private CatogoryDAO() { }
        private Category newCategory(DataRow row)
        {
            Category category = new Category()
            {
                id = (int)row["id"],
                name = row["name"].ToString(),
            };
            return category;
        }
        public List<Category> LoadCategoryList()
        {
            List<Category> categories = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Category");
            foreach (DataRow item in data.Rows)
            {
                Category category = newCategory(item);
                categories.Add(category);
            }
            return categories;
        }
    }
}
