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
            LoadTable();
            LoadCategory();
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tables = TableDao.Instance.LoadTableList();
            foreach (Table item in tables)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Click += Btn_Click;
                btn.Tag = item;
                if (item.status==0)
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
            List<Food> foods = FoodDAO.Instance.ListFoodByFoodCategory(id);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (DTO.Menu menu in listBillInfo)
            {
                ListViewItem item = new ListViewItem(menu.foodName.ToString());
                item.SubItems.Add(menu.count.ToString());
                item.SubItems.Add(menu.price.ToString());
                item.SubItems.Add(menu.totalPrice.ToString());
                totalPrice += menu.totalPrice;
                lsvBill.Items.Add(item);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c",culture);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void LogoutToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void accountProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountProfile accountProfile = new FormAccountProfile();
            accountProfile.ShowDialog();

        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
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
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.id);
            int foodId = (cbFood.SelectedItem as Food).id;
            int count = (int)numFoodCount.Value;
            if (idBill==-1)
            {
                BillDAO.Instance.InsertBill(table.id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodId, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
            }
            ShowBill(table.id);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.id);
            if (idBill != 1)
            {
                DialogResult dialog = MessageBox.Show("Bạn có thanh toán cho " + table.name, "Thông báo", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.id);
                    LoadTable();
                }
            }
        }

    }
}
