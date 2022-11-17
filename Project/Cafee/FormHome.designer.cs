using System.Windows.Forms;

namespace Cafee
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("22", 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("sdas", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvFoodHome = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lvFoodHome = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeilFood = new System.Windows.Forms.ImageList(this.components);
            this.smallILFood = new System.Windows.Forms.ImageList(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.numFoodCount = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pbSearchFood = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbSearchFood = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodHome)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flpTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFood)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 53);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panel2.Size = new System.Drawing.Size(540, 625);
            this.panel2.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgvFoodHome);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(540, 613);
            this.panel13.TabIndex = 1;
            // 
            // dgvFoodHome
            // 
            this.dgvFoodHome.AllowUserToAddRows = false;
            this.dgvFoodHome.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFoodHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.foodName,
            this.count,
            this.price,
            this.totalPrice,
            this.update,
            this.delete});
            this.dgvFoodHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodHome.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodHome.Name = "dgvFoodHome";
            this.dgvFoodHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFoodHome.RowHeadersVisible = false;
            this.dgvFoodHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvFoodHome.RowTemplate.Height = 24;
            this.dgvFoodHome.Size = new System.Drawing.Size(540, 613);
            this.dgvFoodHome.TabIndex = 0;
            this.dgvFoodHome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodHome_CellClick);
            this.dgvFoodHome.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvFoodHome_DataError);
            this.dgvFoodHome.SelectionChanged += new System.EventHandler(this.dgvFoodHome_SelectionChanged);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stt.HeaderText = "";
            this.stt.MinimumWidth = 3;
            this.stt.Name = "stt";
            this.stt.Width = 23;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 2;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // foodName
            // 
            this.foodName.HeaderText = "Tên món";
            this.foodName.MinimumWidth = 6;
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            this.foodName.Width = 125;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.count.HeaderText = "Số lượng";
            this.count.MinimumWidth = 4;
            this.count.Name = "count";
            this.count.Width = 103;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.price.HeaderText = "Đơn giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 95;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 116;
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update.HeaderText = "Cập nhật";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Text = "Lưu";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 80;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete.HeaderText = "Xóa";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 68;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.numDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(6, 678);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(540, 72);
            this.panel3.TabIndex = 3;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(152, 35);
            this.btnSwitchTable.TabIndex = 4;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 39);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(152, 28);
            this.cbSwitchTable.TabIndex = 7;
            this.cbSwitchTable.SelectedIndexChanged += new System.EventHandler(this.cbSwitchTable_SelectedIndexChanged);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotalPrice.Location = new System.Drawing.Point(286, 36);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(134, 30);
            this.txbTotalPrice.TabIndex = 8;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(161, 38);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(119, 28);
            this.numDiscount.TabIndex = 4;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(161, -1);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(119, 35);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckOut.Location = new System.Drawing.Point(426, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(107, 60);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(556, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(6);
            this.panel5.Size = new System.Drawing.Size(554, 758);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbNameTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(7);
            this.panel4.Size = new System.Drawing.Size(540, 47);
            this.panel4.TabIndex = 4;
            // 
            // lbNameTable
            // 
            this.lbNameTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameTable.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.ForeColor = System.Drawing.Color.Red;
            this.lbNameTable.Location = new System.Drawing.Point(7, 7);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(524, 31);
            this.lbNameTable.TabIndex = 0;
            this.lbNameTable.Text = "Chọn bàn";
            this.lbNameTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddFood.Location = new System.Drawing.Point(201, 5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(97, 56);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(5, 10);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(293, 28);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Controls.Add(this.button1);
            this.flpTable.Controls.Add(this.button2);
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Padding = new System.Windows.Forms.Padding(5);
            this.flpTable.Size = new System.Drawing.Size(556, 758);
            this.flpTable.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1110, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(319, 758);
            this.panel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 744);
            this.panel7.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lvFoodHome);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 94);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(305, 650);
            this.panel11.TabIndex = 3;
            // 
            // lvFoodHome
            // 
            this.lvFoodHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvFoodHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFoodHome.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFoodHome.FullRowSelect = true;
            this.lvFoodHome.GridLines = true;
            this.lvFoodHome.HideSelection = false;
            this.lvFoodHome.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvFoodHome.LargeImageList = this.largeilFood;
            this.lvFoodHome.Location = new System.Drawing.Point(0, 0);
            this.lvFoodHome.Name = "lvFoodHome";
            this.lvFoodHome.Size = new System.Drawing.Size(305, 582);
            this.lvFoodHome.SmallImageList = this.smallILFood;
            this.lvFoodHome.TabIndex = 1;
            this.lvFoodHome.UseCompatibleStateImageBehavior = false;
            this.lvFoodHome.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hình ảnh";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên món";
            this.columnHeader6.Width = 217;
            // 
            // largeilFood
            // 
            this.largeilFood.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.largeilFood.ImageSize = new System.Drawing.Size(90, 90);
            this.largeilFood.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallILFood
            // 
            this.smallILFood.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallILFood.ImageStream")));
            this.smallILFood.TransparentColor = System.Drawing.Color.Transparent;
            this.smallILFood.Images.SetKeyName(0, "7up.jpg");
            this.smallILFood.Images.SetKeyName(1, "banh_quy_sua.jpeg");
            this.smallILFood.Images.SetKeyName(2, "banh-bong-lan.jpg");
            this.smallILFood.Images.SetKeyName(3, "banh-ngot.png");
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.numFoodCount);
            this.panel12.Controls.Add(this.btnAddFood);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 582);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(5);
            this.panel12.Size = new System.Drawing.Size(305, 68);
            this.panel12.TabIndex = 2;
            // 
            // numFoodCount
            // 
            this.numFoodCount.Location = new System.Drawing.Point(143, 19);
            this.numFoodCount.Name = "numFoodCount";
            this.numFoodCount.Size = new System.Drawing.Size(52, 28);
            this.numFoodCount.TabIndex = 3;
            this.numFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbCategory);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 47);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel6.Size = new System.Drawing.Size(305, 47);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(305, 47);
            this.panel8.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pbSearchFood);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(251, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(8);
            this.panel10.Size = new System.Drawing.Size(52, 45);
            this.panel10.TabIndex = 1;
            // 
            // pbSearchFood
            // 
            this.pbSearchFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchFood.Image")));
            this.pbSearchFood.Location = new System.Drawing.Point(8, 8);
            this.pbSearchFood.Name = "pbSearchFood";
            this.pbSearchFood.Size = new System.Drawing.Size(36, 29);
            this.pbSearchFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchFood.TabIndex = 2;
            this.pbSearchFood.TabStop = false;
            this.pbSearchFood.Click += new System.EventHandler(this.pbSearchFood_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbSearchFood);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(7);
            this.panel9.Size = new System.Drawing.Size(251, 45);
            this.panel9.TabIndex = 0;
            // 
            // tbSearchFood
            // 
            this.tbSearchFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchFood.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchFood.Location = new System.Drawing.Point(7, 7);
            this.tbSearchFood.Multiline = true;
            this.tbSearchFood.Name = "tbSearchFood";
            this.tbSearchFood.Size = new System.Drawing.Size(237, 31);
            this.tbSearchFood.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 758);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodHome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flpTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFood)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private NumericUpDown numDiscount;
        private Button btnDiscount;
        private Button btnCheckOut;
        private TextBox txbTotalPrice;
        private Panel panel1;
        private Panel panel5;
        private ListView lvFoodHome;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel9;
        private TextBox tbSearchFood;
        private Panel panel12;
        private PictureBox pbSearchFood;
        private Label lbNameTable;
        private ImageList largeilFood;
        private ImageList smallILFood;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button button2;
        private Panel panel13;
        private DataGridView dgvFoodHome;
        private Panel panel11;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn foodName;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn update;
        private DataGridViewButtonColumn delete;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
        private NumericUpDown numFoodCount;
    }
}