using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cafee.BUS;
using System.IO;

namespace Cafee
{
    public partial class FormAdmin : Form
    {
        int idFoodCateCB = 0;
        byte[] imageFood ;
        bool hasUploadImage=false;
        public FormAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
            cbTypeAcount.Items.Add("1");
            cbTypeAcount.Items.Add("0");
            FormLoadAccount();

        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FormLoadAccount();
            FormLoadCategory();
        }
        private void FormLoadAccount()
        {
            List<Account> accounts = AccountBUS.Instance.GetAllAccount();
            dgvAccount.DataSource = accounts;
            dgvAccount.Columns["password"].Visible = false;
        }
        private void FormLoadCategory()
        {
            List<FoodCategory> foodCategorieList = FoodCategoryBUS.Instance.ListAllFoodCategory();
            cbFood.DataSource = foodCategorieList;
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";

            List<Category> categories = CategoryBUS.Instance.ListAllCategory() ;
            int count = 0;
            foreach (Category cate in categories)
            {
                TreeNode node = new TreeNode();
                node.Text = cate.name;
                node.ImageIndex = count;
                node.SelectedImageIndex = count;
                List<FoodCategory> foodCateList = FoodCategoryBUS.Instance.ListFoodCategoryByCategory(cate.id);
                foreach (FoodCategory foodCate in foodCateList)
                {
                    TreeNode subNode = new TreeNode();
                    subNode.Text = foodCate.name;
                    subNode.ImageKey = foodCate.icon;
                    subNode.SelectedImageKey = foodCate.icon;
                    subNode.Tag = foodCate.id;
                    node.Nodes.Add(subNode);
                }
                tvCategory.Nodes.Add(node);
                count++;
            }
            //smallILFood.Images.Add("pepsi-vi-chanh-ko-calo.jpg", Image.FromFile("D:\\hoc tap\\chuyen nganh\\PTUDPM\\CafeShop-PTUDPM\\Project\\Cafee\\Resources\\pepsi-vi-chanh-ko-calo.jpg"));
            //largeilFood.Images.Add("pepsi-vi-chanh-ko-calo.jpg", Image.FromFile("D:\\hoc tap\\chuyen nganh\\PTUDPM\\CafeShop-PTUDPM\\Project\\Cafee\\Resources\\pepsi-vi-chanh-ko-calo.jpg"));
            //treeView1.SelectedNode = treeView1.Nodes[2];
        }
        private void dagvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                int ID = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString());
                Account account = AccountBUS.Instance.GetDetail(ID);
                if (account != null)
                {
                    txtAccountUserName.Text = account.username;
                    txtDisplayName.Text = account.displayName;
                    cbTypeAcount.Text = account.type.ToString();
                }
            }
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            tbResetAccount.ReadOnly = false;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int ID = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString());
                bool result = AccountBUS.Instance.Delete(ID);
                if (result)
                {
                    FormLoadAccount();
                }
                else
                {
                    MessageBox.Show("Delet Fail!");
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString()),
                username = txtAccountUserName.Text,
                displayName = txtDisplayName.Text,
                type = cbTypeAcount.SelectedIndex,
            };
            bool result = AccountBUS.Instance.Update(account);
            if (result)
            {
                FormLoadAccount();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = 0,
                username = txtAccountUserName.Text,
                displayName = txtDisplayName.Text,
                type = cbTypeAcount.SelectedIndex,
            };
            bool result = AccountBUS.Instance.AddNew(account);
            if (result)
            {
                FormLoadAccount();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            smallILFood.Images.Clear();
            lvFood.Items.Clear();
            int foodCateID = Int32.Parse(e.Node.Tag.ToString());
            int count = 0;
            List<Food> foods = FoodBUS.Instance.ListFoodByFoodCategory(foodCateID);
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem();
                smallILFood.Images.Add(ConvertBinaryToImage(food.image));
                item.ImageIndex = count;
                item.Text = food.name;
                //item.ImageKey = Encoding.Default.GetString(food.image);
                item.SubItems.Add(food.id.ToString());
                item.SubItems.Add(food.name);
                item.SubItems.Add(food.idFoodCate.ToString());
                item.SubItems.Add(food.price.ToString());
                item.SubItems.Add(Encoding.Default.GetString(food.image));
                lvFood.Items.Add(item);
                count++;
            }
        }
        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count>0)
            {
                txtFoodId.Text = lvFood.SelectedItems[0].SubItems[1].Text;
                txtFoodName.Text = lvFood.SelectedItems[0].SubItems[2].Text;
                int id = Int32.Parse(lvFood.SelectedItems[0].SubItems[3].Text);
                idFoodCateCB = id;
                FoodCategory foodCategorie = FoodCategoryBUS.Instance.GetFoodCategoryByFood(id);
                cbFood.Text = foodCategorie.name;
                txtFoodPrice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
                pbFood.Image = ConvertBinaryToImage(
                    Encoding.Default.GetBytes(lvFood.SelectedItems[0].SubItems[5].Text));
            }
        }
        private void lvCategoryReload()
        {
            if (tvCategory.SelectedNode.Tag.ToString()!="" || tvCategory.SelectedNode.Tag.ToString()!=null)
            {
                smallILFood.Images.Clear();
                lvFood.Items.Clear();
                int foodCateID = Int32.Parse(tvCategory.SelectedNode.Tag.ToString());
                int count = 0;
                List<Food> foods = FoodBUS.Instance.ListFoodByFoodCategory(foodCateID);
                foreach (Food food in foods)
                {
                    ListViewItem item = new ListViewItem();
                    smallILFood.Images.Add(ConvertBinaryToImage(food.image));
                    item.ImageIndex = count;
                    item.Text = food.name;
                    item.SubItems.Add(food.id.ToString());
                    item.SubItems.Add(food.name);
                    item.SubItems.Add(food.idFoodCate.ToString());
                    item.SubItems.Add(food.price.ToString());
                    item.SubItems.Add(Encoding.Default.GetString(food.image));
                    lvFood.Items.Add(item);
                    count++;
                }
            }
        }
        string fileName;
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                //    string path = Path.Combine(
                //        @"D:\hoc tap\chuyen nganh\PTUDPM\CafeShop-PTUDPM\Project\Cafee\Resources\");
                //    if (!Directory.Exists(path))
                //    {
                //        Directory.CreateDirectory(path);
                //    }
                //    var fileName = Path.GetFileName(openFile.FileName);
                //    path = path + fileName;
                //    File.Copy(openFile.FileName, path);
                //    if (imageFood != "")
                //    {
                //        pbFood.Image=null;
                //        //File.Delete(Path.Combine(@"D:\hoc tap\chuyen nganh\PTUDPM\CafeShop-PTUDPM\Project\Cafee\Resources\" , imageFood));
                //    //smallILFood.Images.RemoveByKey(imageFood);
                //    //largeilFood.Images.RemoveByKey(imageFood);

                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
                    ValidateNames = true,
                    //Multiselect = false
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                        //pbFood.Text = fileName;
                        pbFood.Image = Image.FromFile(fileName);
                        pbFood.Refresh();
                        hasUploadImage = true;

                    }
                }
            }
            catch 
            {
                MessageBox.Show("Chọn hình lỗi");
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms, true);
            }
        }
        private void btnUpdateFoodC_Click(object sender, EventArgs e)
        {
            byte[] imageFood;
            if (hasUploadImage)
            {
                imageFood = ConvertImageToBinary(pbFood.Image);
            }
            else
            {
                imageFood = Encoding.Default.GetBytes(lvFood.SelectedItems[0].SubItems[5].Text);
            }
            Food food = new Food()
            {
                id = int.Parse(txtFoodId.Text),
                name = txtFoodName.Text,
                idFoodCate = int.Parse(cbFood.SelectedValue.ToString()),
                price = Double.Parse(txtFoodPrice.Text),
                image = imageFood,
            };
            bool result = FoodBUS.Instance.UpdateFood(food);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
                lvCategoryReload();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        private void btnAddFoodC_Click(object sender, EventArgs e)
        {
            Food food = new Food()
            {
                name = txtFoodName.Text,
                idFoodCate = int.Parse(cbFood.SelectedValue.ToString()),
                price = Double.Parse(txtFoodPrice.Text),
                image = ConvertImageToBinary(pbFood.Image),
            };
            bool result = FoodBUS.Instance.AddFood(food);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                lvCategoryReload();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnDeleteFoodC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFoodId.Text);
            bool result = FoodBUS.Instance.DeteleFood(id);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                lvCategoryReload();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
