using System.Windows.Forms;

namespace Cafee
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.largeilFood = new System.Windows.Forms.ImageList(this.components);
            this.smallILFood = new System.Windows.Forms.ImageList(this.components);
            this.ilCategory = new System.Windows.Forms.ImageList(this.components);
            this.tpCategoryFood = new System.Windows.Forms.TabPage();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdateFoodC = new System.Windows.Forms.Button();
            this.btnDeleteFoodC = new System.Windows.Forms.Button();
            this.btnAddFoodC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvFood = new System.Windows.Forms.ListView();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.tbSearchAccount = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel24 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbResetAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.cbTypeAcount = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.la1 = new System.Windows.Forms.Label();
            this.txtAccountUserName = new System.Windows.Forms.TextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.cbTableStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTableId = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCategoryId = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dagvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpToData = new System.Windows.Forms.DateTimePicker();
            this.dtpFromData = new System.Windows.Forms.DateTimePicker();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpCategoryFood.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.tpAccount.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel24.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // largeilFood
            // 
            this.largeilFood.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeilFood.ImageStream")));
            this.largeilFood.TransparentColor = System.Drawing.Color.Transparent;
            this.largeilFood.Images.SetKeyName(0, "cafe-sua.jpg");
            this.largeilFood.Images.SetKeyName(1, "cafe.jpg");
            this.largeilFood.Images.SetKeyName(2, "nuoc-loc.jpg");
            this.largeilFood.Images.SetKeyName(3, "banh-ngot.png");
            this.largeilFood.Images.SetKeyName(4, "capu.jpg");
            this.largeilFood.Images.SetKeyName(5, "7up.jpg");
            this.largeilFood.Images.SetKeyName(6, "banh_quy_sua.jpeg");
            this.largeilFood.Images.SetKeyName(7, "banh-bong-lan.jpg");
            this.largeilFood.Images.SetKeyName(8, "coca-cola.jpg");
            this.largeilFood.Images.SetKeyName(9, "nuoc_cam.jpg");
            this.largeilFood.Images.SetKeyName(10, "nuoc_mia.jpg");
            this.largeilFood.Images.SetKeyName(11, "pho_mai_nuong.jpg");
            this.largeilFood.Images.SetKeyName(12, "pepsi-vi-chanh-ko-calo.jpg");
            this.largeilFood.Images.SetKeyName(13, "rrr.jpg");
            this.largeilFood.Images.SetKeyName(14, "pepsi-light.jpg");
            // 
            // smallILFood
            // 
            this.smallILFood.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallILFood.ImageStream")));
            this.smallILFood.TransparentColor = System.Drawing.Color.Transparent;
            this.smallILFood.Images.SetKeyName(0, "cafe-sua.jpg");
            this.smallILFood.Images.SetKeyName(1, "cafe.jpg");
            this.smallILFood.Images.SetKeyName(2, "nuoc-loc.jpg");
            this.smallILFood.Images.SetKeyName(3, "banh-ngot.png");
            this.smallILFood.Images.SetKeyName(4, "capu.jpg");
            this.smallILFood.Images.SetKeyName(5, "nuoc_mia.jpg");
            this.smallILFood.Images.SetKeyName(6, "pho_mai_nuong.jpg");
            this.smallILFood.Images.SetKeyName(7, "banh_quy_sua.jpeg");
            this.smallILFood.Images.SetKeyName(8, "7up.jpg");
            this.smallILFood.Images.SetKeyName(9, "coca-cola.jpg");
            this.smallILFood.Images.SetKeyName(10, "banh-bong-lan.jpg");
            this.smallILFood.Images.SetKeyName(11, "nuoc_cam.jpg");
            this.smallILFood.Images.SetKeyName(12, "pepsi-vi-chanh-ko-calo.jpg");
            this.smallILFood.Images.SetKeyName(13, "rrr.jpg");
            this.smallILFood.Images.SetKeyName(14, "pepsi-light.jpg");
            // 
            // ilCategory
            // 
            this.ilCategory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCategory.ImageStream")));
            this.ilCategory.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCategory.Images.SetKeyName(0, "drink.png");
            this.ilCategory.Images.SetKeyName(1, "food.png");
            this.ilCategory.Images.SetKeyName(2, "banh_ngot.png");
            this.ilCategory.Images.SetKeyName(3, "banh_quy.png");
            this.ilCategory.Images.SetKeyName(4, "coffee.png");
            this.ilCategory.Images.SetKeyName(5, "nuoc_ep.png");
            this.ilCategory.Images.SetKeyName(6, "nuoc_ngot.png");
            // 
            // tpCategoryFood
            // 
            this.tpCategoryFood.Controls.Add(this.panel29);
            this.tpCategoryFood.Controls.Add(this.lvFood);
            this.tpCategoryFood.Controls.Add(this.tvCategory);
            this.tpCategoryFood.Location = new System.Drawing.Point(4, 29);
            this.tpCategoryFood.Name = "tpCategoryFood";
            this.tpCategoryFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategoryFood.Size = new System.Drawing.Size(887, 549);
            this.tpCategoryFood.TabIndex = 5;
            this.tpCategoryFood.Text = " Món ăn";
            this.tpCategoryFood.UseVisualStyleBackColor = true;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.Peru;
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Controls.Add(this.panel5);
            this.panel29.Controls.Add(this.panel4);
            this.panel29.Controls.Add(this.label1);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel29.Location = new System.Drawing.Point(512, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(372, 543);
            this.panel29.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnUpdateFoodC);
            this.panel5.Controls.Add(this.btnDeleteFoodC);
            this.panel5.Controls.Add(this.btnAddFoodC);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 73);
            this.panel5.TabIndex = 3;
            // 
            // btnUpdateFoodC
            // 
            this.btnUpdateFoodC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFoodC.Location = new System.Drawing.Point(135, 6);
            this.btnUpdateFoodC.Name = "btnUpdateFoodC";
            this.btnUpdateFoodC.Size = new System.Drawing.Size(111, 55);
            this.btnUpdateFoodC.TabIndex = 9;
            this.btnUpdateFoodC.Text = "Sửa";
            this.btnUpdateFoodC.UseVisualStyleBackColor = true;
            this.btnUpdateFoodC.Click += new System.EventHandler(this.btnUpdateFoodC_Click);
            // 
            // btnDeleteFoodC
            // 
            this.btnDeleteFoodC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFoodC.Location = new System.Drawing.Point(256, 6);
            this.btnDeleteFoodC.Name = "btnDeleteFoodC";
            this.btnDeleteFoodC.Size = new System.Drawing.Size(110, 55);
            this.btnDeleteFoodC.TabIndex = 10;
            this.btnDeleteFoodC.Text = "Xóa";
            this.btnDeleteFoodC.UseVisualStyleBackColor = true;
            this.btnDeleteFoodC.Click += new System.EventHandler(this.btnDeleteFoodC_Click);
            // 
            // btnAddFoodC
            // 
            this.btnAddFoodC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodC.Location = new System.Drawing.Point(3, 6);
            this.btnAddFoodC.Name = "btnAddFoodC";
            this.btnAddFoodC.Size = new System.Drawing.Size(110, 55);
            this.btnAddFoodC.TabIndex = 8;
            this.btnAddFoodC.Text = "Thêm";
            this.btnAddFoodC.UseVisualStyleBackColor = true;
            this.btnAddFoodC.Click += new System.EventHandler(this.btnAddFoodC_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnUploadImage);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.pbFood);
            this.panel4.Controls.Add(this.txtFoodId);
            this.panel4.Controls.Add(this.txtFoodName);
            this.panel4.Controls.Add(this.txtFoodPrice);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 417);
            this.panel4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "id:";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(270, 241);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(88, 73);
            this.btnUploadImage.TabIndex = 12;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(134, 76);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(224, 28);
            this.cbFood.TabIndex = 13;
            // 
            // pbFood
            // 
            this.pbFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFood.Location = new System.Drawing.Point(20, 241);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(232, 145);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 11;
            this.pbFood.TabStop = false;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(134, 18);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(224, 28);
            this.txtFoodId.TabIndex = 0;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(134, 132);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(224, 28);
            this.txtFoodName.TabIndex = 2;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(134, 189);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(224, 28);
            this.txtFoodPrice.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Thể loại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin chi tiết món ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvFood
            // 
            this.lvFood.BackColor = System.Drawing.Color.GhostWhite;
            this.lvFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFood.FullRowSelect = true;
            this.lvFood.HideSelection = false;
            this.lvFood.LargeImageList = this.largeilFood;
            this.lvFood.Location = new System.Drawing.Point(181, 3);
            this.lvFood.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(703, 543);
            this.lvFood.SmallImageList = this.smallILFood;
            this.lvFood.TabIndex = 1;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.List;
            this.lvFood.SelectedIndexChanged += new System.EventHandler(this.lvFood_SelectedIndexChanged);
            // 
            // tvCategory
            // 
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvCategory.ImageIndex = 0;
            this.tvCategory.ImageList = this.ilCategory;
            this.tvCategory.Location = new System.Drawing.Point(3, 3);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.SelectedImageKey = "water-bottle.png";
            this.tvCategory.Size = new System.Drawing.Size(178, 543);
            this.tvCategory.TabIndex = 0;
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.btnSearchAccount);
            this.tpAccount.Controls.Add(this.tbSearchAccount);
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Controls.Add(this.panel24);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Location = new System.Drawing.Point(4, 29);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(887, 549);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(776, 25);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(103, 34);
            this.btnSearchAccount.TabIndex = 2;
            this.btnSearchAccount.Text = "Tìm kiếm";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // tbSearchAccount
            // 
            this.tbSearchAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tbSearchAccount.Location = new System.Drawing.Point(522, 25);
            this.tbSearchAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearchAccount.Name = "tbSearchAccount";
            this.tbSearchAccount.Size = new System.Drawing.Size(247, 34);
            this.tbSearchAccount.TabIndex = 2;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.dgvAccount);
            this.panel23.Location = new System.Drawing.Point(7, 81);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(507, 461);
            this.panel23.TabIndex = 13;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(507, 461);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dagvAccount_SelectionChanged);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.button8);
            this.panel24.Controls.Add(this.button7);
            this.panel24.Controls.Add(this.panel3);
            this.panel24.Controls.Add(this.btnResetPass);
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Controls.Add(this.panel26);
            this.panel24.Controls.Add(this.panel27);
            this.panel24.Location = new System.Drawing.Point(521, 82);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(359, 459);
            this.panel24.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(20, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 39);
            this.button8.TabIndex = 0;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(249, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "Sửa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbResetAccount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(5, 165);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 48);
            this.panel3.TabIndex = 13;
            // 
            // tbResetAccount
            // 
            this.tbResetAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResetAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tbResetAccount.Location = new System.Drawing.Point(143, 7);
            this.tbResetAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResetAccount.Name = "tbResetAccount";
            this.tbResetAccount.ReadOnly = true;
            this.tbResetAccount.Size = new System.Drawing.Size(204, 34);
            this.tbResetAccount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đặt mật khẩu:";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(214, 219);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(141, 45);
            this.btnResetPass.TabIndex = 12;
            this.btnResetPass.Text = "Đặt lại mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.cbTypeAcount);
            this.panel25.Controls.Add(this.label9);
            this.panel25.Location = new System.Drawing.Point(5, 111);
            this.panel25.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(350, 48);
            this.panel25.TabIndex = 11;
            // 
            // cbTypeAcount
            // 
            this.cbTypeAcount.FormattingEnabled = true;
            this.cbTypeAcount.Location = new System.Drawing.Point(143, 10);
            this.cbTypeAcount.Name = "cbTypeAcount";
            this.cbTypeAcount.Size = new System.Drawing.Size(204, 28);
            this.cbTypeAcount.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(4, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label10);
            this.panel26.Controls.Add(this.txtDisplayName);
            this.panel26.Location = new System.Drawing.Point(5, 57);
            this.panel26.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(350, 48);
            this.panel26.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(4, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên hiển thị:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtDisplayName.Location = new System.Drawing.Point(143, 7);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(204, 34);
            this.txtDisplayName.TabIndex = 0;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.la1);
            this.panel27.Controls.Add(this.txtAccountUserName);
            this.panel27.Location = new System.Drawing.Point(5, 3);
            this.panel27.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(350, 48);
            this.panel27.TabIndex = 9;
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.la1.Location = new System.Drawing.Point(4, 11);
            this.la1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(132, 23);
            this.la1.TabIndex = 1;
            this.la1.Text = "Tên tài khoản:";
            // 
            // txtAccountUserName
            // 
            this.txtAccountUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtAccountUserName.Location = new System.Drawing.Point(143, 7);
            this.txtAccountUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccountUserName.Name = "txtAccountUserName";
            this.txtAccountUserName.ReadOnly = true;
            this.txtAccountUserName.Size = new System.Drawing.Size(204, 34);
            this.txtAccountUserName.TabIndex = 0;
            // 
            // panel28
            // 
            this.panel28.Location = new System.Drawing.Point(8, 6);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(507, 70);
            this.panel28.TabIndex = 11;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel13);
            this.tpTable.Controls.Add(this.panel16);
            this.tpTable.Controls.Add(this.panel21);
            this.tpTable.Location = new System.Drawing.Point(4, 29);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(887, 549);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgvTable);
            this.panel13.Location = new System.Drawing.Point(7, 81);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(507, 461);
            this.panel13.TabIndex = 10;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.Size = new System.Drawing.Size(507, 461);
            this.dgvTable.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel22);
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.panel20);
            this.panel16.Location = new System.Drawing.Point(521, 82);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(359, 459);
            this.panel16.TabIndex = 9;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.cbTableStatus);
            this.panel22.Controls.Add(this.label8);
            this.panel22.Location = new System.Drawing.Point(5, 111);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(350, 48);
            this.panel22.TabIndex = 11;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new System.Drawing.Point(143, 10);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new System.Drawing.Size(204, 28);
            this.cbTableStatus.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trạng thái:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label4);
            this.panel19.Controls.Add(this.txbTableName);
            this.panel19.Location = new System.Drawing.Point(5, 57);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(350, 48);
            this.panel19.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên bàn:";
            // 
            // txbTableName
            // 
            this.txbTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTableName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txbTableName.Location = new System.Drawing.Point(143, 7);
            this.txbTableName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(204, 34);
            this.txbTableName.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label5);
            this.panel20.Controls.Add(this.txbTableId);
            this.panel20.Location = new System.Drawing.Point(5, 3);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(350, 48);
            this.panel20.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // txbTableId
            // 
            this.txbTableId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTableId.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txbTableId.Location = new System.Drawing.Point(143, 7);
            this.txbTableId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbTableId.Name = "txbTableId";
            this.txbTableId.ReadOnly = true;
            this.txbTableId.Size = new System.Drawing.Size(204, 34);
            this.txbTableId.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnShowTable);
            this.panel21.Controls.Add(this.btnDeleteTable);
            this.panel21.Controls.Add(this.btnEditTable);
            this.panel21.Controls.Add(this.btnAddTable);
            this.panel21.Location = new System.Drawing.Point(8, 6);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(507, 70);
            this.panel21.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(403, 3);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(101, 64);
            this.btnShowTable.TabIndex = 3;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(271, 3);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(106, 64);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(141, 3);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(103, 64);
            this.btnEditTable.TabIndex = 1;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(3, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(111, 64);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel12);
            this.tpCategory.Controls.Add(this.panel18);
            this.tpCategory.Controls.Add(this.panel11);
            this.tpCategory.Controls.Add(this.panel17);
            this.tpCategory.Location = new System.Drawing.Point(4, 29);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(887, 549);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Danh mục";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dgvCategory);
            this.panel12.Location = new System.Drawing.Point(6, 82);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(507, 461);
            this.panel12.TabIndex = 7;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 29;
            this.dgvCategory.Size = new System.Drawing.Size(507, 461);
            this.dgvCategory.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dataGridView1);
            this.panel18.Location = new System.Drawing.Point(6, 82);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(507, 461);
            this.panel18.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(507, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(520, 83);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(359, 459);
            this.panel11.TabIndex = 6;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label6);
            this.panel14.Controls.Add(this.txbCategoryName);
            this.panel14.Location = new System.Drawing.Point(5, 57);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(350, 48);
            this.panel14.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên danh mục:";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoryName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txbCategoryName.Location = new System.Drawing.Point(145, 7);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(202, 34);
            this.txbCategoryName.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label7);
            this.panel15.Controls.Add(this.txbCategoryId);
            this.panel15.Location = new System.Drawing.Point(5, 3);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(350, 48);
            this.panel15.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID:";
            // 
            // txbCategoryId
            // 
            this.txbCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoryId.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txbCategoryId.Location = new System.Drawing.Point(145, 7);
            this.txbCategoryId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbCategoryId.Name = "txbCategoryId";
            this.txbCategoryId.ReadOnly = true;
            this.txbCategoryId.Size = new System.Drawing.Size(202, 34);
            this.txbCategoryId.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnShowCategory);
            this.panel17.Controls.Add(this.btnDeleteCategory);
            this.panel17.Controls.Add(this.btnEditCategory);
            this.panel17.Controls.Add(this.btnAddCategory);
            this.panel17.Location = new System.Drawing.Point(7, 7);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(507, 70);
            this.panel17.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(403, 3);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(101, 64);
            this.btnShowCategory.TabIndex = 3;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(271, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(106, 64);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(141, 3);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(103, 64);
            this.btnEditCategory.TabIndex = 1;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(111, 64);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.dateTimePicker1);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 29);
            this.tpBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpBill.Size = new System.Drawing.Size(887, 549);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dagvBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 502);
            this.panel2.TabIndex = 1;
            // 
            // dagvBill
            // 
            this.dagvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dagvBill.Location = new System.Drawing.Point(0, 0);
            this.dagvBill.Name = "dagvBill";
            this.dagvBill.RowHeadersWidth = 51;
            this.dagvBill.RowTemplate.Height = 29;
            this.dagvBill.Size = new System.Drawing.Size(879, 502);
            this.dagvBill.TabIndex = 0;
            this.dagvBill.SelectionChanged += new System.EventHandler(this.dagvAccount_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpToData);
            this.panel1.Controls.Add(this.dtpFromData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(391, 3);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(94, 28);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpToData
            // 
            this.dtpToData.Location = new System.Drawing.Point(585, 4);
            this.dtpToData.Name = "dtpToData";
            this.dtpToData.Size = new System.Drawing.Size(290, 28);
            this.dtpToData.TabIndex = 1;
            // 
            // dtpFromData
            // 
            this.dtpFromData.Location = new System.Drawing.Point(4, 3);
            this.dtpFromData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFromData.Name = "dtpFromData";
            this.dtpFromData.Size = new System.Drawing.Size(286, 28);
            this.dtpFromData.TabIndex = 0;
            this.dtpFromData.Value = new System.DateTime(2022, 10, 1, 13, 30, 28, 0);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Controls.Add(this.tpCategoryFood);
            this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(895, 582);
            this.tcAdmin.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 582);
            this.Controls.Add(this.tcAdmin);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tpCategoryFood.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.tpTable.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dagvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList ilCategory;
        private ImageList largeilFood;
        private ImageList smallILFood;
        private TabPage tpCategoryFood;
        private Panel panel29;
        private ComboBox cbFood;
        private Button btnUploadImage;
        private PictureBox pbFood;
        private Button btnDeleteFoodC;
        private Button btnUpdateFoodC;
        private Button btnAddFoodC;
        private Label label14;
        private TextBox txtFoodPrice;
        private Label label13;
        private Label label12;
        private TextBox txtFoodName;
        private Label label11;
        private TextBox txtFoodId;
        private ListView lvFood;
        private TreeView tvCategory;
        private TabPage tpAccount;
        private Panel panel23;
        private DataGridView dgvAccount;
        private Panel panel24;
        private Button btnResetPass;
        private Panel panel25;
        private ComboBox cbTypeAcount;
        private Label label9;
        private Panel panel26;
        private Label label10;
        private TextBox txtDisplayName;
        private Panel panel27;
        private Label la1;
        private TextBox txtAccountUserName;
        private Panel panel28;
        private Button button7;
        private Button button8;
        private TabPage tpTable;
        private Panel panel13;
        private DataGridView dgvTable;
        private Panel panel16;
        private Panel panel22;
        private ComboBox cbTableStatus;
        private Label label8;
        private Panel panel19;
        private Label label4;
        private TextBox txbTableName;
        private Panel panel20;
        private Label label5;
        private TextBox txbTableId;
        private Panel panel21;
        private Button btnShowTable;
        private Button btnDeleteTable;
        private Button btnEditTable;
        private Button btnAddTable;
        private TabPage tpCategory;
        private Panel panel12;
        private DataGridView dgvCategory;
        private Panel panel18;
        private DataGridView dataGridView1;
        private Panel panel11;
        private Panel panel14;
        private Label label6;
        private TextBox txbCategoryName;
        private Panel panel15;
        private Label label7;
        private TextBox txbCategoryId;
        private Panel panel17;
        private Button btnShowCategory;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private TabPage tpBill;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private DataGridView dagvBill;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpToData;
        private DateTimePicker dtpFromData;
        private TabControl tcAdmin;
        private Label label1;
        private Button btnSearchAccount;
        private TextBox tbSearchAccount;
        private Panel panel3;
        private TextBox tbResetAccount;
        private Label label2;
        private Panel panel5;
        private Panel panel4;
    }
}