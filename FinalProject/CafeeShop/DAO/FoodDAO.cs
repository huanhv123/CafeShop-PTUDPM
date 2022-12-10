using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DAO
{
    internal class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new FoodDAO(); }
                return FoodDAO.instance;
            }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        private Food newFood(DataRow row)
        {
            Food food = new Food()
            {
                id = (int)row["id"],
                name = row["name"].ToString(),
                idFoodCate = (int)row["idFoodCate"],
                price=(double)row["price"],
                image=(byte[])row["image"],
            };
            return food;
        }
        public List<Food> LoadFoodList()
        {
            List<Food> foods = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Food");
            foreach (DataRow item in data.Rows)
            {
                Food food = newFood(item);
                foods.Add(food);
            }
            return foods;
        }
        public List<Food> ListFoodByFoodCategory(int id)
        {
            List<Food> foods = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Food where idFoodCate= @id",
                new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Food food = newFood(item);
                foods.Add(food);
            }
            return foods;
        }
        public bool AddFood(Food newFood)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Food(name,idFoodCate,price,image) VALUES( @name , @idFoodCate , @price , @image )",
                new object[] { newFood.name, newFood.idFoodCate, newFood.price,newFood.image, newFood.id });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateFood(Food newFood)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Food SET name= @name ,idFoodCate= @idFoodCate ,price= @price ,image= @image where id= @ID",
                new object[] { newFood.name,newFood.idFoodCate,newFood.price, newFood.image, newFood.id});
            if (result == true)
                return true;
            return false;
        }
        public bool DeteleFood(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM Food where id= @id ",
                new object[] {id });
            if (result == true)
                return true;
            return false;
        }
        public List<Food> ListFoodByKeyWord(string keyword)
        {
            string kw = "%" + keyword + "%";
            List<Food> foods = new List<Food>();
            String query = "SELECT * FROM Food WHERE name LIKE @KeyWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { kw });
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    Food item = newFood(row);
                    foods.Add(item);
                }
            }
            return foods;
        }
    }
}
