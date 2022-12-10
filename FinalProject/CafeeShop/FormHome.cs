using Cafee.BUS;
using Cafee.DAO;
using Cafee.DTO;
using CafeeShop;
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
        int _idEmployees;
        public FormHome(int idEmployees)
        {
            InitializeComponent();
            _idEmployees = idEmployees;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            dgvFoodHome.Columns["id"].Visible = false;
            LoadTable();
            LoadComboBoxTable();
            LoadCategory();
            LoadListFood();
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tables = TableBUS.Instance.ListALLTable();
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
            List<Table> tables = TableBUS.Instance.ListALLTable();
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
            List<FoodCategory> foodCategories = FoodCategoryBUS.Instance.ListAllFoodCategory();
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
            cbSwitchTable.DataSource = TableBUS.Instance.ListALLTable();
            cbSwitchTable.DisplayMember = "name";
        }
        float totalPriceBill = 0;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        void ShowBill(int id)
        {
            dgvFoodHome.Rows.Clear();
            cbSwitchTable.Enabled = true;
            btnCheckOut.Enabled = true;

            Table table = TableBUS.Instance.GetDetailTable(id);
            if (table != null)
            {
                lbNameTable.Text = table.name;
            }
            List<DTO.Menu> listBillInfo = MenuBUS.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            int count = 0;
            foreach (DTO.Menu menu in listBillInfo)
            {
                dgvFoodHome.Rows.Add();
                dgvFoodHome.Rows[count].Cells["stt"].Value = (count + 1).ToString();
                dgvFoodHome.Rows[count].Cells["id"].Value = menu.id.ToString();
                dgvFoodHome.Rows[count].Cells["foodName"].Value = menu.foodName.ToString();
                dgvFoodHome.Rows[count].Cells["count"].Value = menu.count.ToString();
                dgvFoodHome.Rows[count].Cells["price"].Value = menu.price.ToString("#,###", cul.NumberFormat);
                dgvFoodHome.Rows[count].Cells["totalPrice"].Value = menu.totalPrice.ToString("#,###", cul.NumberFormat);
                totalPrice += menu.totalPrice;
                count++;
            }
            totalPriceBill = totalPrice;
            lbTotolPrice.Text = totalPrice.ToString("#,###", cul.NumberFormat);
            finalTotalPrice = totalPrice;
            lbFinalTotalPrice.Text = finalTotalPrice.ToString("#,###", cul.NumberFormat);
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
            int idBill = BillBUS.Instance.GetUnCheckBillIdByTableId(table.id);
            int foodId = Int32.Parse(lvFoodHome.SelectedItems[0].SubItems[2].Text);
            int count = (int)numFoodCount.Value;
            bool result;
            if (idBill == -1)
            {
                result=BillBUS.Instance.InsertBill(table.id,_idEmployees);
                result=BillInfoBUS.Instance.InsertBillInfo(BillBUS.Instance.GetMaxIdBill(), foodId, count);
            }
            else
            {
                result=BillInfoBUS.Instance.InsertBillInfo(idBill, foodId, count);
            }
            if (result)
            {
                ShowBill(table.id);
                LoadTableReload(table.id);
            }
            else
            {
                MessageBox.Show("Thêm món thất bại","Thông báo");
            }
        }
        float finalTotalPrice = 0;
        int discountBill = 0;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = dgvFoodHome.Tag as Table;
            int idBill = BillBUS.Instance.GetUnCheckBillIdByTableId(table.id);
            if (idBill != 1 && tbInputMoneyCus.Text!="0")
            {
                DialogResult dialog = MessageBox.Show("Bạn có thanh toán "+ table.name,
                "Thông báo", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    DialogResult dialogPrint = MessageBox.Show("Bạn có in hóa đơn không?",
               "Thông báo", MessageBoxButtons.OKCancel);
                    bool result = true;
                    DateTime now = DateTime.UtcNow.AddHours(7);
                    Bill billC = new Bill()
                    {
                        id = idBill,
                        DateCheckOut = now,
                        discount = discountBill,
                        idEmployees = _idEmployees,
                        total = finalTotalPrice,
                    };
                    double inputMoney = double.Parse(tbInputMoneyCus.Text);
                    if (dialogPrint == DialogResult.OK)
                    {
                        FormPrint printBill = new FormPrint(billC, table, totalPriceBill, inputMoney);
                        printBill.ShowDialog();
                        //result = BillBUS.Instance.CheckOut(billC);
                    }
                    if (dialogPrint == DialogResult.Cancel)
                    {
                        //result = BillBUS.Instance.CheckOut(billC);
                    }
                    if (result)
                    {
                        ShowBill(table.id);
                        LoadTableReload(table.id);
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại", "Thông báo");
                    }
                }
            }
            else if (tbInputMoneyCus.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa", "Thông báo");
            }
        }
        private void pbSearchFood_Click(object sender, EventArgs e)
        {
            smallILFood.Images.Clear();
            lvFoodHome.Items.Clear();
            int count = 0;
            List<Food> foods = null;
            if (tbSearchFood.Text.Trim() == "")
            {
                foods = FoodBUS.Instance.ListALLFood();
            }
            else
            {
                foods = FoodBUS.Instance.ListFoodByKeyWord(tbSearchFood.Text.Trim());
            }
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
                bool result = MenuBUS.Instance.UpdateBillInfo(idBilInfo, count);
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
                bool result = BillInfoBUS.Instance.Delete(idBilInfo);
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
                //ffffff
                bool result = TableBUS.Instance.SwitchTable(idTableFirst, idTableSecound,1); ;
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
        
        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            discountBill = (int)numDiscount.Value;
            if (lbTotolPrice.Text != "0")
            {
                finalTotalPrice = totalPriceBill - (totalPriceBill / 100) * discountBill;
                lbDiscount.Text = discountBill.ToString()+"%";
                lbFinalTotalPrice.Text = finalTotalPrice.ToString("#,###", cul.NumberFormat);
            }
        }

        private void tbInputMoneyCus_TextChanged(object sender, EventArgs e)
        {
            bool checkNum;
            try
            {
                int.Parse(tbInputMoneyCus.Text);
                checkNum = true;
            }
            catch
            {
                checkNum = false;
            }
            if (checkNum == true && lbTotolPrice.Text!="0")
            {
                lbMoneyRetrun.Text = (float.Parse(tbInputMoneyCus.Text)-finalTotalPrice).ToString("#,###", cul.NumberFormat);
            }
            else if(checkNum == false)
            {
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void btnDeleteBiil_Click(object sender, EventArgs e)
        {
            Table table = dgvFoodHome.Tag as Table;
            int idBill = BillBUS.Instance.GetUnCheckBillIdByTableId(table.id);
            bool result = BillBUS.Instance.DeleteBill(idBill,table.id);
            if (result)
            {
                ShowBill(table.id);
                LoadTableReload(table.id);
            }
            else
            {
                MessageBox.Show("Xóa thất bại","Thông báo");
            }
        }

        private void tbInputMoneyCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            //if (e.KeyChar == (char)13)
            //{
            //    tbInputMoneyCus.Text = string.Format("{0:n0}", double.Parse(tbInputMoneyCus.Text));
            //}
        }
    }
}
