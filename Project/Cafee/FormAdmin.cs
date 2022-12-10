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

        bool hasUploadImage = false;
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
            FormLoadAccount();
            FormLoadCategory();
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
        private void FormLoadCategory()
        {
            List<FoodCategory> foodCategorieList = FoodCategoryBUS.Instance.ListAllFoodCategory();
            cbFood.DataSource = foodCategorieList;
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";

            List<Category> categories = CategoryBUS.Instance.ListAllCategory();
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

        }

        //Table

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

        //Account 
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

        //Bill

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
                    txtTotal.Text = bill.Total.ToString();


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
                Total = int.Parse(txtTotal.Text),
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


        //Employees

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
                Employees employees = EmployeesBUS.Instance.GetDetails(ID);
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

        //Food

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
                smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
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
        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count > 0)
            {
                txtFoodId.Text = lvFood.SelectedItems[0].SubItems[1].Text;
                txtFoodName.Text = lvFood.SelectedItems[0].SubItems[2].Text;
                int id = Int32.Parse(lvFood.SelectedItems[0].SubItems[3].Text);

                FoodCategory foodCategorie = FoodCategoryBUS.Instance.GetFoodCategoryByFood(id);
                cbFood.Text = foodCategorie.name;
                txtFoodPrice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
                pbFood.Image = FoodBUS.Instance.ConvertBinaryToImage(
                    Encoding.Default.GetBytes(lvFood.SelectedItems[0].SubItems[5].Text));
            }
        }
        private void lvCategoryReload()
        {
            if (tvCategory.SelectedNode.Tag.ToString() != "" || tvCategory.SelectedNode.Tag.ToString() != null)
            {
                smallILFood.Images.Clear();
                lvFood.Items.Clear();
                int foodCateID = Int32.Parse(tvCategory.SelectedNode.Tag.ToString());
                int count = 0;
                List<Food> foods = FoodBUS.Instance.ListFoodByFoodCategory(foodCateID);
                foreach (Food food in foods)
                {
                    ListViewItem item = new ListViewItem();
                    smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
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
                image = FoodBUS.Instance.ConvertImageToBinary(pbFood.Image),
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
