
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            //InitializeComponent();
        }

        //private void frmTreeView_Load(object sender, EventArgs e)
        //{
        //    listView1.View = View.Details;
        //    listView1.SmallImageList = imageList1;




        //    treeView1.CheckBoxes = true;
        //    CategoryBUS cateBUS = new CategoryBUS();
        //    List<Category> cateList = cateBUS.GetAllCatgories();
        //    foreach (Category cate in cateList) {
        //        TreeNode node = new TreeNode();
        //        node.Text = cate.CategoryName;
        //        node.Tag = cate.CategoryID;
        //        TreeNode subNode = new TreeNode();
        //        subNode.Text = cate.CategoryName + "- 1";
        //        node.Nodes.Add(subNode);
        //        treeView1.Nodes.Add(node);
        //    }
        //    treeView1.SelectedNode = treeView1.Nodes[2];
        //    treeView1.SelectedNode.Expand();

           

        //    ProductBUS proBUS = new ProductBUS();
        //    int cateID = Int32.Parse(treeView1.SelectedNode.Tag.ToString());
        //    List<Product> proList = proBUS.GetProductByCategoryID(cateID);
        //    int count = 0;
        //    foreach (Product pro in proList) {
        //        ListViewItem item = new ListViewItem(pro.ProductName);
        //        item.ImageIndex = count;
        //        item.SubItems.Add(pro.ProductID.ToString());
        //        item.SubItems.Add(pro.ProductName);
        //        item.SubItems.Add(pro.Price.ToString());
        //        item.SubItems.Add(pro.CategoryID.ToString());
        //        listView1.Items.Add(item);
        //        count++;

        //    }


        //}

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
        //        txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
        //        txtPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
        //        txtCategoryID.Text = listView1.SelectedItems[0].SubItems[3].Text;
        //    }

        //}

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    //TreeNode node = treeView1.SelectedNode;
        //    //int cateID = Int32.Parse(node.Tag.ToString());
        //    listView1.Items.Clear();

        //    ProductBUS proBUS = new ProductBUS();
        //    int cateID = Int32.Parse(treeView1.SelectedNode.Tag.ToString());
        //    List<Product> proList = proBUS.GetProductByCategoryID(cateID);
        //    int count = 0;
        //    foreach (Product pro in proList)
        //    {
        //        ListViewItem item = new ListViewItem(pro.ProductName);
        //        item.ImageIndex = count;
        //        item.SubItems.Add(pro.ProductID.ToString());
        //        item.SubItems.Add(pro.ProductName);
        //        item.SubItems.Add(pro.Price.ToString());
        //        item.SubItems.Add(pro.CategoryID.ToString());
        //        listView1.Items.Add(item);
        //        count++;

        //    }

        //}
    }
}
