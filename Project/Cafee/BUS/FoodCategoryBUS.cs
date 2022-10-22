using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.BUS
{
    internal class FoodCategoryBUS
    {
        private static FoodCategoryBUS instance;

        public static FoodCategoryBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new FoodCategoryBUS(); }
                return FoodCategoryBUS.instance;
            }
            private set { FoodCategoryBUS.instance = value; }
        }
        private FoodCategoryBUS() { }
        public List<FoodCategory> ListAllFoodCategory()
        {
            List<FoodCategory> foodCategories = FoodCategoryDAO.Instance.LoadFoodCategoryList();
            return foodCategories;
        }
        public FoodCategory GetFoodCategoryByFood(int id)
        {
            FoodCategory foodCategory = FoodCategoryDAO.Instance.FoodCategoryByFood(id);
            return foodCategory;
        }
        public List<FoodCategory> ListFoodCategoryByCategory(int id)
        {
            List<FoodCategory> foodCategories = FoodCategoryDAO.Instance.ListFoodCategoryByCategory(id);
            return foodCategories;
        }
    }
}
