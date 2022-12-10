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
        public FoodCategory DetailFoodCategory(int id)
        {
            FoodCategory foodCategory = FoodCategoryDAO.Instance.DetailFoodCategory(id);
            return foodCategory;
        }
        
        public List<FoodCategory> ListFoodCategoryByCategory(int id)
        {
            List<FoodCategory> foodCategories = FoodCategoryDAO.Instance.ListFoodCategoryByCategory(id);
            return foodCategories;
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
        public bool AddFoodCategory(FoodCategory newFoodCate)
        {
            return FoodCategoryDAO.Instance.AddFoodCategory(newFoodCate);
        }
        public bool UpdateFoodCategory(FoodCategory newFoodCate,bool hasIconFoodCate)
        {
            return FoodCategoryDAO.Instance.UpdateFoodCategory(newFoodCate, hasIconFoodCate);
        }
    }
}
