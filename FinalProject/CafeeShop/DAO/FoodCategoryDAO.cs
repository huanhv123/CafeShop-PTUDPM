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
            FoodCategory foodCategory = new FoodCategory();

            foodCategory.id = (int)row["id"];
            foodCategory.idCate = (int)row["idCate"];
            if (row["Icon"].ToString() != "")
                foodCategory.icon = (byte[])row["Icon"];
            foodCategory.name = row["name"].ToString();
            
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
        public FoodCategory DetailFoodCategory(int id)
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
        public bool AddFoodCategory(FoodCategory newFoodCate)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO FoodCategory(name,Icon,idCate) VALUES( @name , @icon , @idCate )",
                new object[] { newFoodCate.name, newFoodCate.icon,newFoodCate.idCate });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateFoodCategory(FoodCategory newFoodCate,bool hasIconFoodCate)
        {
            bool result = false;
            if (hasIconFoodCate)
            {
                result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE FoodCategory SET name= @name ,Icon= @icon ,idCate= @idCate where id= @ID",
                new object[] { newFoodCate.name, newFoodCate.icon,newFoodCate.idCate, newFoodCate.id });
            }
            else
            {
                result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE FoodCategory SET name= @name ,idCate= @idCate where id= @ID",
                new object[] { newFoodCate.name, newFoodCate.idCate, newFoodCate.id });
            }
            if (result == true)
                return true;
            return false;
        }
    }
}
