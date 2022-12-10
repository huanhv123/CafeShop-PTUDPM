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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Resources;

namespace Cafee
{
    public partial class FormAdmin : Form
    {

        bool hasUploadImage = false;
        string cateNode;
        string typeCate;
        public FormAdmin()
        {
            InitializeComponent();
            cbTypeAcount.Items.Add(1);
            cbTypeAcount.Items.Add(0);
            cbTableStatus.Items.Add(1);
            cbTableStatus.Items.Add(0);
            cbStatus.Items.Add(1);
            cbStatus.Items.Add(0);
            cbEStatus.Items.Add(1);
            cbEStatus.Items.Add(0);
            FormLoadAccount();
            FormLoadTable();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FormLoadTreeNodeCategory();
            FormLoadAccount();
            FormLoadTable();
            FormLoadBill();
            FormLoadEmployees();
        }
        private void FormLoadTable()
        {
            List<Table> tables = TableBUS.Instance.ListALLTable();
            dgvTable.DataSource = tables;
        }
        private void FormLoadAccount()
        {
            List<Account> accounts = AccountBUS.Instance.GetAllAccount();
            dgvAccount.DataSource = accounts;
            dgvAccount.Columns["password"].Visible = false;
        }
        private void FormLoadTreeNodeCategory()
        {
            tvCategory.Nodes.Clear();
            ilCateFood.Images.Clear();
            TreeNode root = new TreeNode();
            root.Tag = root.Index + " root";
            root.Text = "Danh mục";
            ilCateFood.Images.Add(new Bitmap(global::CafeeShop.Properties.Resources.cate));
            root.ImageIndex = 0;
            root.SelectedImageIndex = 0;
            List<Category> categories = CategoryBUS.Instance.ListAllCategory();
            int countCate = 1;
            List<FoodCategory> foodCategorieList = FoodCategoryBUS.Instance.ListAllFoodCategory();
            cbFood.DataSource = foodCategorieList;
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";
            foreach (Category cate in categories)
            {
                TreeNode node = new TreeNode();
                node.Tag = cate.id + " cate";
                node.Text = cate.name;
                ilCateFood.Images.Add(CategoryBUS.Instance.ConvertBinaryToImage(cate.icon));
                node.ImageIndex = countCate;
                node.SelectedImageIndex = countCate;
                List<FoodCategory> foodCateList = FoodCategoryBUS.Instance.ListFoodCategoryByCategory(cate.id);
                foreach (FoodCategory foodCate in foodCateList)
                {
                    TreeNode subNode = new TreeNode();
                    subNode.Text = foodCate.name;
                    ilCateFood.Images.Add(FoodCategoryBUS.Instance.ConvertBinaryToImage(foodCate.icon));
                    subNode.ImageIndex = countCate + 1;
                    subNode.SelectedImageIndex = countCate + 1;
                    subNode.Tag = foodCate.id + " cateFood";
                    node.Nodes.Add(subNode);
                    countCate++;
                }
                root.Nodes.Add(node);
                countCate++;
            }
            tvCategory.Nodes.Add(root);
        }
        private void FormLoadBill()
        {
            List<Bill> bill = BillBUS.Instance.ListALLBill();
            dgvBill.DataSource = bill;
        }
        private void FormLoadEmployees()
        {
            List<Employees> employees = EmployeesBUS.Instance.ListALLEmployees();
            dgvEmployees.DataSource = employees;
        }
        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int ID = int.Parse(dgvTable.SelectedRows[0].Cells["ID"].Value.ToString());
                Table table = TableBUS.Instance.GetDetail(ID);

                if (table != null)
                {
                    txbTableName.Text = table.name;
                    cbTableStatus.Text = table.status.ToString();

                }
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Table table = new Table()
            {
                id = 0,
                name = txbTableName.Text,
                status = (int)cbTableStatus.SelectedItem,
            };
            bool result = TableBUS.Instance.AddTable(table);
            if (result)
            {
                FormLoadTable();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }

        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            Table tables = new Table()
            {
                id = int.Parse(dgvTable.SelectedRows[0].Cells["ID"].Value.ToString()),
                name = txbTableName.Text,
                status = (int)cbTableStatus.SelectedItem,
            };
            bool result = TableBUS.Instance.UpdateTable(tables);
            if (result)
            {
                FormLoadTable();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int ID = int.Parse(dgvTable.SelectedRows[0].Cells["ID"].Value.ToString());
                bool result = TableBUS.Instance.DeteleTable(ID);
                if (result)
                {
                    FormLoadTable();
                }
                else
                {
                    MessageBox.Show("Delet Fail!");
                }
            }
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = 0,
                username = txtAccountUserName.Text,
                displayName = txtDisplayName.Text,
                password = tbPass.Text,
                type = (int)cbTypeAcount.SelectedItem,
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
        private void btn_update_Click(object sender, EventArgs e)
        {

            Account account = new Account()
            {
                id = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString()),
                username = txtAccountUserName.Text,
                displayName = txtDisplayName.Text,
                type = (int)cbTypeAcount.SelectedItem,
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
        private void dgvBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                int ID = int.Parse(dgvBill.SelectedRows[0].Cells["ID"].Value.ToString());
                Bill bill = BillBUS.Instance.GetDetails(ID);
                Console.WriteLine(bill);

                if (bill != null)
                {
                    txtMHD.Text = bill.id.ToString();
                    txtTableId.Text = bill.idTable.ToString();
                    txtTableName.Text = TableBUS.Instance.GetDetail(bill.idTable).name;
                    dtIn.Text = bill.DateCheckIn.ToString();
                    dtOut.Text = bill.DateCheckOut.ToString();
                    cbStatus.Text = bill.status.ToString();
                    txtDiscount.Text = bill.discount.ToString();
                    txtTotal.Text = bill.total.ToString();
                }
            }
        }
        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill()
            {
                id = int.Parse(dgvBill.SelectedRows[0].Cells["ID"].Value.ToString()),
                idTable = int.Parse(txtTableId.Text),
                DateCheckIn = dtIn.Value,
                DateCheckOut = dtOut.Value,
                status = (int)cbStatus.SelectedItem,
                discount = int.Parse(txtDiscount.Text),
                total = int.Parse(txtTotal.Text),
            };
            bool result = BillBUS.Instance.UpdateBill(bill);
            if (result)
            {
                FormLoadBill();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String key = txtKeyword.Text.Trim();
            List<Employees> employees = new List<Employees>();
            if (key.Length > 0)
            {
                employees = EmployeesBUS.Instance.GetDetailByName(key);
            }
            else
            {
                employees = EmployeesBUS.Instance.ListALLEmployees();
            }
            dgvEmployees.DataSource = employees;
        }
        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int ID = int.Parse(dgvEmployees.SelectedRows[0].Cells["ID"].Value.ToString());
                Employees employees = EmployeesBUS.Instance.GetDetail(ID);
                if (employees != null)
                {
                    txtEName.Text = employees.name.ToString();
                    dtEBirthday.Text = employees.birthday.ToString();
                    txtEAdd.Text = employees.address.ToString();
                    txtEPhone.Text = employees.phone.ToString();
                    txtEPosition.Text = employees.position.ToString();
                    cbEStatus.Text = employees.workingstatus.ToString();

                }
            }
        }
        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees()
            {
                id = 0,
                name = txtEName.Text,
                birthday = dtEBirthday.Value,
                address = txtEAdd.Text,
                phone = txtEPhone.Text,
                position = txtEPosition.Text,
                workingstatus = (int)cbEStatus.SelectedItem,
            };

            bool result = EmployeesBUS.Instance.AddEmployees(employees);
            if (result)
            {
                FormLoadEmployees();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }
        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees()
            {
                id = int.Parse(dgvEmployees.SelectedRows[0].Cells["ID"].Value.ToString()),
                name = txtEName.Text,
                birthday = dtEBirthday.Value,
                address = txtEAdd.Text,
                phone = txtEPhone.Text,
                position = txtEPosition.Text,
                workingstatus = (int)cbEStatus.SelectedItem,

            };

            bool result = EmployeesBUS.Instance.UpdateEmployees(employees);
            if (result)
            {
                FormLoadEmployees();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            tbPass.ReadOnly = false;
        }
        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cateNode = tvCategory.SelectedNode.Tag.ToString();
            typeCate = cateNode.Split(' ')[1];
            int foodCateID = Int32.Parse(cateNode.Split(' ')[0]);
            if (tabCategoryFood.SelectedIndex.ToString() == "0")
            {
                List<Category> categorieList = CategoryBUS.Instance.ListAllCategory();
                cbCate.DataSource = categorieList;
                cbCate.DisplayMember = "name";
                cbCate.ValueMember = "id"; 
                if (typeCate == "cateFood")
                {
                    cbCate.Enabled = true;
                    cbFood.Enabled = true;
                    FoodCategory foodCategory = FoodCategoryBUS.Instance.DetailFoodCategory(foodCateID);
                    txtIdCategory.Text = foodCategory.id.ToString();
                    Category categorie = CategoryBUS.Instance.DetailCategory(foodCategory.idCate);
                    cbCate.Text = categorie.name;
                    txtNameCategory.Text = foodCategory.name;
                    pbCategory.Image = FoodCategoryBUS.Instance.ConvertBinaryToImage(foodCategory.icon);
                }
                else if (typeCate == "cate")
                {
                    cbCate.Enabled = false;
                    int cateID = Int32.Parse(cateNode.Split(' ')[0]);
                    Category category = CategoryBUS.Instance.DetailCategory(cateID);
                    txtIdCategory.Text = category.id.ToString();
                    txtNameCategory.Text = category.name;
                    pbCategory.Image = CategoryBUS.Instance.ConvertBinaryToImage(category.icon);
                }
            }
            else
            {
                List<FoodCategory> foodCategorieList = FoodCategoryBUS.Instance.ListAllFoodCategory();
                cbFood.DataSource = foodCategorieList;
                cbFood.DisplayMember = "name";
                cbFood.ValueMember = "id";
                if (typeCate == "cateFood")
                {
                    cbFood.Enabled = true;
                }
                FormLoadListViewFood(foodCateID,false);
            }
        }
        private void FormLoadListViewFood(int foodCateID, bool hasAddFood)
        {
            if (typeCate == "cateFood" || hasAddFood==true)
            {
                smallILFood.Images.Clear();
                lvFood.Items.Clear();
                int count = 0;
                List<Food> foods = FoodBUS.Instance.ListFoodByFoodCategory(foodCateID);
                foreach (Food food in foods)
                {
                    ListViewItem item = new ListViewItem();
                    smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
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
        }
        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count>0)
            {
                cbFood.Enabled = true;
                txtFoodId.Text = lvFood.SelectedItems[0].SubItems[1].Text;
                txtFoodName.Text = lvFood.SelectedItems[0].SubItems[2].Text;
                int id = Int32.Parse(lvFood.SelectedItems[0].SubItems[3].Text);
                //idFoodCateCB = id;
                FoodCategory foodCategorie = FoodCategoryBUS.Instance.DetailFoodCategory(id);
                cbFood.Text = foodCategorie.name;
                txtFoodPrice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
                pbFood.Image = FoodBUS.Instance.ConvertBinaryToImage(
                    Encoding.Default.GetBytes(lvFood.SelectedItems[0].SubItems[5].Text));
            }
        }
        private void btnUploadImageFood_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
                    ValidateNames = true,
                    //Multiselect = false
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = ofd.FileName;
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
        private void btnUpdateFoodC_Click(object sender, EventArgs e)
        {
            byte[] imageFood;
            if (hasUploadImage)
            {
                imageFood = FoodBUS.Instance.ConvertImageToBinary(pbFood.Image);
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
            hasUploadImage = false;
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
                FormLoadListViewFood(Int32.Parse(cateNode.Split(' ')[0]),false); ;
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
                image = FoodBUS.Instance.ConvertImageToBinary(pbFood.Image),
            };
            bool result = FoodBUS.Instance.AddFood(food);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                FormLoadListViewFood(Int32.Parse(cateNode.Split(' ')[0]),true); ;
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
                FormLoadListViewFood(Int32.Parse(cateNode.Split(' ')[0]),false); ;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        private void btnEditCategogy_Click(object sender, EventArgs e)
        {
            if (typeCate == "cate")
            {
                bool hasIconCate = false;
                Category category = new Category();
                category.id = int.Parse(txtIdCategory.Text);
                category.name = txtNameCategory.Text;
                if (hasUploadImage)
                {
                    category.icon = CategoryBUS.Instance.ConvertImageToBinary(pbCategory.Image);
                    hasIconCate = true;
                }
                bool result = CategoryBUS.Instance.UpdateCategory(category, hasIconCate);
                hasUploadImage = false;
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    FormLoadTreeNodeCategory();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else if (typeCate == "cateFood")
            {
                bool hasIconFoodCate = false;
                FoodCategory foodCategory = new FoodCategory();
                foodCategory.id = int.Parse(txtIdCategory.Text);
                foodCategory.idCate = int.Parse(cbCate.SelectedValue.ToString());
                foodCategory.name = txtNameCategory.Text;
                if (hasUploadImage)
                {
                    foodCategory.icon = FoodCategoryBUS.Instance.ConvertImageToBinary(pbCategory.Image);
                    hasIconFoodCate = true;
                }
                bool result = FoodCategoryBUS.Instance.UpdateFoodCategory(foodCategory, hasIconFoodCate);
                hasUploadImage = false;
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    FormLoadTreeNodeCategory();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }
        private void btnAddCategogy_Click(object sender, EventArgs e)
        {
            if (typeCate == "root")
            {
                Category category = new Category()
                {
                    id=0,
                    name = txtNameCategory.Text,
                    icon =  CategoryBUS.Instance.ConvertImageToBinary(pbCategory.Image)
                };
                bool result = CategoryBUS.Instance.AddCategory(category);
                if (result)
                {
                    MessageBox.Show("Thêm thành công");
                    FormLoadTreeNodeCategory();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else if (typeCate == "cate")
            {
                FoodCategory foodCategory = new FoodCategory()
                {
                    id = 0,
                    name = txtNameCategory.Text,
                    idCate = Int32.Parse(cateNode.Split(' ')[0]),
                    icon = FoodCategoryBUS.Instance.ConvertImageToBinary(pbCategory.Image),
                };
                bool result = FoodCategoryBUS.Instance.AddFoodCategory(foodCategory);
                if (result)
                {
                    MessageBox.Show("Thêm thành công");
                    FormLoadTreeNodeCategory();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }
        private void btnHideCategogy_Click(object sender, EventArgs e)
        {
            tvCategory.SelectedNode.Remove();
        }
        private void btnUploadIconCate_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png",
                    ValidateNames = true,
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = ofd.FileName;
                        pbCategory.Image = Image.FromFile(fileName);
                        pbCategory.Refresh();
                        hasUploadImage = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn hình lỗi");
            }
        }
        private void tabCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCategoryFood.SelectedIndex.ToString() == "0")
            {
                cbFood.Enabled = false;
                lvFood.Clear();
                txtFoodId.Text = "";
                txtFoodName.Text = "";
                txtFoodPrice.Text = "";
                pbFood.Image = null;
            }
            else
            {
                cbCate.Enabled = false;
                txtIdCategory.Text = "";
                txtNameCategory.Text = "";
                pbCategory.Image = null;
            }
        }
    }
}
