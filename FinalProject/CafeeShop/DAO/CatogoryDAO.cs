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
            Category category = new Category();
            category.id = (int)row["id"];
            category.name = row["name"].ToString();
            if (row["icon"].ToString() != "")
                category.icon = (byte[])row["icon"];
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
        public Category DetailCategory(int id)
        {
            Category category = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Category where id= @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                category = newCategory(item);
            }
            return category;
        }
        public bool AddCategory(Category newCate)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Category(name,icon) VALUES( @name , @icon )",
                new object[] { newCate.name, newCate.icon });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateCategory(Category newCate,bool hasIconCate)
        {
            bool result=false;
            if (hasIconCate)
            {
                result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Category SET name= @name ,icon= @icon  where id= @ID",
                new object[] { newCate.name, newCate.icon, newCate.id });
            }
            else
            {
                result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Category SET name= @name where id= @ID",
                new object[] { newCate.name, newCate.id });
            }
            if (result == true)
                return true;
            return false;
        }
    }
}
