using System.Windows.Forms;

namespace Cafee
{
    partial class FormTestcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestcs));
            this.plSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebarTime = new System.Windows.Forms.Timer(this.components);
            this.plSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plSidebar
            // 
            this.plSidebar.BackColor = System.Drawing.Color.DimGray;
            this.plSidebar.Controls.Add(this.btnLogout);
            this.plSidebar.Controls.Add(this.btnHome);
            this.plSidebar.Controls.Add(this.btnAdmin);
            this.plSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.plSidebar.Location = new System.Drawing.Point(0, 0);
            this.plSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plSidebar.MaximumSize = new System.Drawing.Size(186, 707);
            this.plSidebar.MinimumSize = new System.Drawing.Size(43, 707);
            this.plSidebar.Name = "plSidebar";
            this.plSidebar.Size = new System.Drawing.Size(186, 707);
            this.plSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(4, 171);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 41);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.logOut_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 77);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 41);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DimGray;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(4, 124);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(178, 41);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.SandyBrown;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(186, 59);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1173, 648);
            this.plMain.TabIndex = 2;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(186, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 59);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Cafee.Properties.Resources.menu;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 47);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidebarTime
            // 
            this.sidebarTime.Interval = 10;
            this.sidebarTime.Tick += new System.EventHandler(this.sidebarTime_Tick);
            // 
            // FormTestcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(1359, 707);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plSidebar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTestcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTestcs";
            this.plSidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plSidebar;
        private Panel plMain;
        private Button btnHome;
        private Button btnAdmin;
        private Button btnLogout;
        private Panel panel2;
        private System.Windows.Forms.Timer sidebarTime;
        private Button button2;
    }
}