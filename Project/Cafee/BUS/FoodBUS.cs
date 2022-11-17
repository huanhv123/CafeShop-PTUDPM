using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.BUS
{
    internal class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new FoodBUS(); }
                return FoodBUS.instance;
            }
            private set { FoodBUS.instance = value; }
        }
        private FoodBUS() { }
        public List<Food> ListALLFood()
        {
            List<Food> foods = FoodDAO.Instance.LoadFoodList();
            return foods;
        }
        public List<Food> ListFoodByFoodCategory(int id)
        {
            List<Food> foods = FoodDAO.Instance.ListFoodByFoodCategory(id);
            return foods;
        }
        public bool AddFood(Food newFood)
        {
            return FoodDAO.Instance.AddFood(newFood);
        }
        public bool UpdateFood(Food newFood)
        {
            return FoodDAO.Instance.UpdateFood(newFood);
        }
        public bool DeteleFood(int id)
        {
            return FoodDAO.Instance.DeteleFood(id);
        }
        public byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms, true);
            }
        }
    }
}
