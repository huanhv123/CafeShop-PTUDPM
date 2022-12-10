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
        public List<Category> ListAllCategory()
        {
            List<Category> categories = CatogoryDAO.Instance.LoadCategoryList();
            return categories;
        }
        public Category DetailCategory(int id)
        {
            Category categorie = CatogoryDAO.Instance.DetailCategory(id);
            return categorie;
        }
        public bool AddCategory(Category newCate)
        {
            return CatogoryDAO.Instance.AddCategory(newCate);
        }
        public bool UpdateCategory(Category newCate,bool hasIconCate)
        {
            return CatogoryDAO.Instance.UpdateCategory(newCate, hasIconCate);
        }
    }
}
