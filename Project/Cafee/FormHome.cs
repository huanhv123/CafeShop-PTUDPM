using Cafee.BUS;
using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            dgvFoodHome.Columns["id"].Visible = false;
            LoadTable();
            LoadComboBoxTable();
            LoadCategory();
            LoadListFood();
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tables = TableDao.Instance.LoadTableList();
            foreach (Table item in tables)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Tag = item;
                if (item.status == 0)
                {
                    btn.Text = item.name + Environment.NewLine + "Có người";
                    btn.BackColor = Color.OrangeRed;
                }
                else
                {
                    btn.Text = item.name + Environment.NewLine + "Trống";
                    btn.BackColor = Color.MediumSpringGreen;
                }
                this.flpTable.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }
        void LoadTableReload(int tableID)
        {
            flpTable.Controls.Clear();
            List<Table> tables = TableDao.Instance.LoadTableList();
            foreach (Table item in tables)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Tag = item;
                btn.Click += Btn_Click;
                if (item.status == 0)
                {
                    btn.Text = item.name + Environment.NewLine + "Có người";
                    if (item.id == tableID)
                    {
                        btn.BackColor = Color.DarkOrange;
                    }
                    else
                    {
                        btn.BackColor = Color.OrangeRed;
                    }
                }
                else
                {
                    btn.Text = item.name + Environment.NewLine + "Trống";
                    if (item.id == tableID)
                    {
                        btn.BackColor = Color.DarkOrange;
                    }
                    else
                    {
                        btn.BackColor = Color.MediumSpringGreen;
                    }
                }
                this.flpTable.Controls.Add(btn);
            }
        }
        void LoadCategory()
        {
            List<FoodCategory> foodCategories = FoodCategoryDAO.Instance.LoadFoodCategoryList();
            cbCategory.DataSource = foodCategories;
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "id";
        }
        void LoadListFoodByCategory(int id)
        {
            smallILFood.Images.Clear();
            lvFoodHome.Items.Clear();
            int count = 0;
            List<Food> foods = FoodBUS.Instance.ListFoodByFoodCategory(id);
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem();
                smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
                item.ImageIndex = count;
                //item.Text = food.name;
                item.SubItems.Add(food.name);
                item.SubItems.Add(food.id.ToString());
                item.SubItems.Add(food.idFoodCate.ToString());
                item.SubItems.Add(food.price.ToString());
                item.SubItems.Add(Encoding.Default.GetString(food.image));
                lvFoodHome.Items.Add(item);
                count++;
            }
        }
        void LoadListFood()
        {
            smallILFood.Images.Clear();
            lvFoodHome.Items.Clear();
            int count = 0;
            List<Food> foods = FoodBUS.Instance.ListALLFood();
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem();
                smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
                item.ImageIndex = count;
                item.SubItems.Add(food.name);
                item.SubItems.Add(food.id.ToString());
                item.SubItems.Add(food.idFoodCate.ToString());
                item.SubItems.Add(food.price.ToString());
                item.SubItems.Add(Encoding.Default.GetString(food.image));
                lvFoodHome.Items.Add(item);
                count++;
            }
        }
        void LoadComboBoxTable()
        {
            cbSwitchTable.DataSource = TableDao.Instance.LoadTableList();
            cbSwitchTable.DisplayMember = "name";
        }
        void ShowBill(int id)
        {
            dgvFoodHome.Rows.Clear();
            Table table = TableDao.Instance.GetDetailTable(id);
            if (table != null)
            {
                lbNameTable.Text = table.name;
            }
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            int count = 0;
            foreach (DTO.Menu menu in listBillInfo)
            {
                dgvFoodHome.Rows.Add();
                dgvFoodHome.Rows[count].Cells["stt"].Value = (count + 1).ToString();
                dgvFoodHome.Rows[count].Cells["id"].Value = menu.id.ToString();
                dgvFoodHome.Rows[count].Cells["foodName"].Value = menu.foodName.ToString();
                dgvFoodHome.Rows[count].Cells["count"].Value = menu.count.ToString();
                dgvFoodHome.Rows[count].Cells["price"].Value = menu.price.ToString();
                dgvFoodHome.Rows[count].Cells["totalPrice"].Value = menu.totalPrice.ToString();
                totalPrice += menu.totalPrice;
                count++;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).id;
            dgvFoodHome.Tag = (sender as Button).Tag;
            LoadTableReload(tableID);
            ShowBill(tableID);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            { return; }
            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.id;
            LoadListFoodByCategory(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = dgvFoodHome.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.id);
            int foodId = Int32.Parse(lvFoodHome.SelectedItems[0].SubItems[2].Text);
            int count = (int)numFoodCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodId, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
            }
            ShowBill(table.id);
            LoadTableReload(table.id);
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = dgvFoodHome.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.id);
            int discount = (int)numDiscount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != 1)
            {
                DialogResult dialog = MessageBox.Show("Bạn có in hóa đơn không?",
                "Thông báo", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    FormPrintBill printBill = new FormPrintBill(discount, table.id, table.name, finalTotalPrice);
                    printBill.ShowDialog();
                    //BillDAO.Instance.CheckOut(idBill, discount);
                    //ShowBill(table.id);
                    //LoadTable();
                }
                //DialogResult dialog = MessageBox.Show(
                //    string.Format("Bạn có thanh toán cho {0}" +
                //    " Tổng tiền -" +
                //    " (Tổng tiền/100)*Giảm giá {1} -({1}/100x{2})" +
                //    "={1})",
                //    table.name, finalTotalPrice.ToString()),
                //    "Thông báo", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.Cancel)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(table.id);
                    LoadTable();
                }
            }
        }
        private void lvFoodHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvFood.SelectedItems.Count > 0)
            //{
            //    txtFoodId.Text = lvFood.SelectedItems[0].SubItems[1].Text;
            //    txtFoodName.Text = lvFood.SelectedItems[0].SubItems[2].Text;
            //    int id = Int32.Parse(lvFood.SelectedItems[0].SubItems[3].Text);
            //    idFoodCateCB = id;
            //    FoodCategory foodCategorie = FoodCategoryBUS.Instance.GetFoodCategoryByFood(id);
            //    cbFood.Text = foodCategorie.name;
            //    txtFoodPrice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
            //    pbFood.Image = ConvertBinaryToImage(
            //        Encoding.Default.GetBytes(lvFood.SelectedItems[0].SubItems[5].Text));
            //}
        }
        private void pbSearchFood_Click(object sender, EventArgs e)
        {
            smallILFood.Images.Clear();
            lvFoodHome.Items.Clear();
            int count = 0;
            List<Food> foods = FoodDAO.Instance.ListFoodByKeyWord(tbSearchFood.Text);
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem();
                smallILFood.Images.Add(FoodBUS.Instance.ConvertBinaryToImage(food.image));
                item.ImageIndex = count;
                //item.Text = food.name;
                //item.ImageKey = Encoding.Default.GetString(food.image);
                item.SubItems.Add(food.name);
                item.SubItems.Add(food.id.ToString());
                item.SubItems.Add(food.idFoodCate.ToString());
                item.SubItems.Add(food.price.ToString());
                item.SubItems.Add(Encoding.Default.GetString(food.image));
                lvFoodHome.Items.Add(item);
                count++;
            }
        }
        private void dgvFoodHome_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoodHome.SelectedRows.Count > 0)
            {
                //int id = int.Parse(dgvLaptop.SelectedRows[0].Cells["id"].Value.ToString());
                //Laptop laptop = new LaptopBUS().GetDetail(id);
                //if (laptop != null)
                //{
                //    txtId.Text = laptop.id.ToString();
                //    txtName.Text = laptop.name;
                //    txtPrice.Text = laptop.price.ToString();
                //    txtBrand.Text = laptop.brand;
                //    txtQuantity.Text = laptop.quantity.ToString();
                //}
                MessageBox.Show("heee");
            }
        }
        private void dgvFoodHome_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened " + anError.Context.ToString());
            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
        private void dgvFoodHome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //MessageBox.Show("Cập nhật");
                int idBilInfo = int.Parse(dgvFoodHome.Rows[e.RowIndex].Cells["id"].Value.ToString());
                int count = int.Parse(dgvFoodHome.Rows[e.RowIndex].Cells["count"].Value.ToString());
                bool result = MenuDAO.Instance.UpdateBillInfo(idBilInfo, count);
                if (result)
                {
                    Table table = dgvFoodHome.Tag as Table; ;
                    ShowBill(table.id);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else if (e.ColumnIndex == 7)
            {
                //MessageBox.Show("Xóa");
                int idBilInfo = int.Parse(dgvFoodHome.Rows[e.RowIndex].Cells["id"].Value.ToString());
                bool result = BillInfoDAO.Instance.Delete(idBilInfo);
                if (result)
                {
                    Table table = dgvFoodHome.Tag as Table; ;
                    ShowBill(table.id);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private void cbSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int idTableFirst = (dgvFoodHome.Tag as Table).id;
            int idTableSecound = (cbSwitchTable.SelectedItem as Table).id;
            DialogResult dialog = MessageBox.Show(string.Format(
                "Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}",
                (dgvFoodHome.Tag as Table).name, (cbSwitchTable.SelectedItem as Table).name),
                "Thông báo", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {

                bool result = TableDao.Instance.SwitchTable(idTableFirst, idTableSecound); ;
                if (result)
                {
                    MessageBox.Show("Chuyển bàn thành công");
                }
                else
                {
                    MessageBox.Show("Chuyển bàn thất bại");
                }
                LoadTableReload(idTableFirst);
                ShowBill(idTableFirst);
            }
        }

    }
}
