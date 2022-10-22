using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DAO
{
    internal class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new FoodCategoryDAO(); }
                return FoodCategoryDAO.instance;
            }
            private set { FoodCategoryDAO.instance = value; }
        }
        private FoodCategoryDAO() { }
        private FoodCategory newFoodCategory(DataRow row)
        {
            FoodCategory foodCategory = new FoodCategory()
            {
                id = (int)row["id"],
                idCate = (int)row["idCate"],
                icon = row["Icon"].ToString(),
                name = row["name"].ToString(),
            };
            return foodCategory;
        }
        public List<FoodCategory> LoadFoodCategoryList()
        {
            List<FoodCategory> foodCategories = new List<FoodCategory>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory");
            foreach (DataRow item in data.Rows)
            {
                FoodCategory foodCate = newFoodCategory(item);
                foodCategories.Add(foodCate);
            }
            return foodCategories;
        }
        public FoodCategory FoodCategoryByFood(int id)
        {
            FoodCategory foodCategory = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where id= @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                foodCategory = newFoodCategory(item);
            }
            return foodCategory;
        }
        public List<FoodCategory> ListFoodCategoryByCategory(int id)
        {
            List<FoodCategory> foodCategories = new List<FoodCategory>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where idCate= @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                FoodCategory foodCate = newFoodCategory(item);
                foodCategories.Add(foodCate);
            }
            return foodCategories;
        }
    }
}
