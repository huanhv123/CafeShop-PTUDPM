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
    public partial class FormTestcs : Form
    {
        bool sidebarExpand;
        public FormTestcs()
        {
            InitializeComponent();
        }
        public void loadForm(object Form,string subform)
        {
            if(this.plMain.Controls.Count>0)
            {
                this.plMain.Controls.RemoveAt(0);
            }
            if (subform=="Home")
            {
                this.btnAdmin.BackColor = Color.DimGray;
                this.btnHome.BackColor = Color.SaddleBrown;
            }
            if (subform=="Admin")
            {
                this.btnAdmin.BackColor = Color.SaddleBrown;
                this.btnHome.BackColor = Color.DimGray;
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.plMain.Controls.Add(f);
            this.plMain.Tag = f;
            f.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            loadForm(new FormHome(),"Home");
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            loadForm(new FormAdmin(),"Admin");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                plSidebar.Width -= 10;
                if (plSidebar.Width == plSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                plSidebar.Width += 10;
                if (plSidebar.Width == plSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //   MessageBox.Show("dong:" + (e.RowIndex + 1).ToString() + " Cot:" + (e.ColumnIndex + 1).ToString()+ "value:" +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        //    if (e.ColumnIndex == 0)
        //    {
        //        Category cate = new Category();
        //        cate.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        cate.Description = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        //        cate.Picture = ConvertImageToBinary(pictureBox1.Image);

        //        bool rs = cateBus.Insert(cate);
        //        MessageBox.Show("ket qua:" + rs.ToString());
        //        dataGridView1.DataSource = cateBus.GetAllCategories();
        //    }

        //}

        //byte[] ConvertImageToBinary(Image img)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}

        //string fileName;
        //private void btnOpenFile_Click(object sender, EventArgs e)
        //{
        //    //Read image file
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
        //    {
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            fileName = ofd.FileName;
        //            lblFilename.Text = fileName;
        //            pictureBox1.Image = Image.FromFile(fileName);
        //            pictureBox1.Refresh();
        //        }
        //    }
        //}

    }
}
