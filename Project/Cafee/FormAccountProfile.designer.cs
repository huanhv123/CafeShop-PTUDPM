using System.Windows.Forms;

namespace Cafee
{
    partial class FormAccountProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.texUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.txtDispalyName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.texUserName);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 61);
            this.panel1.TabIndex = 8;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(4, 18);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(171, 25);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Tên đăng nhập:";
            // 
            // texUserName
            // 
            this.texUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texUserName.Location = new System.Drawing.Point(183, 13);
            this.texUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.texUserName.Name = "texUserName";
            this.texUserName.ReadOnly = true;
            this.texUserName.Size = new System.Drawing.Size(443, 34);
            this.texUserName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDisplayName);
            this.panel2.Controls.Add(this.txtDispalyName);
            this.panel2.Location = new System.Drawing.Point(22, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 61);
            this.panel2.TabIndex = 9;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDisplayName.Location = new System.Drawing.Point(4, 18);
            this.lbDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(138, 25);
            this.lbDisplayName.TabIndex = 1;
            this.lbDisplayName.Text = "Tên hiển thị:";
            // 
            // txtDispalyName
            // 
            this.txtDispalyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDispalyName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDispalyName.Location = new System.Drawing.Point(183, 13);
            this.txtDispalyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDispalyName.Name = "txtDispalyName";
            this.txtDispalyName.Size = new System.Drawing.Size(443, 34);
            this.txtDispalyName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbNewPass);
            this.panel3.Location = new System.Drawing.Point(22, 213);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 61);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // txbNewPass
            // 
            this.txbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNewPass.Location = new System.Drawing.Point(183, 13);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(443, 34);
            this.txbNewPass.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbPass);
            this.panel4.Location = new System.Drawing.Point(22, 146);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 61);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPass.Location = new System.Drawing.Point(183, 13);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(443, 34);
            this.txbPass.TabIndex = 0;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbReEnterPass);
            this.panel5.Location = new System.Drawing.Point(22, 280);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(631, 61);
            this.panel5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại:";
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbReEnterPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbReEnterPass.Location = new System.Drawing.Point(183, 13);
            this.txbReEnterPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(443, 34);
            this.txbReEnterPass.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(459, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormAccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(673, 395);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbUsername;
        private TextBox texUserName;
        private Panel panel2;
        private Label lbDisplayName;
        private TextBox txtDispalyName;
        private Panel panel3;
        private Label label1;
        private TextBox txbNewPass;
        private Panel panel4;
        private Label label2;
        private TextBox txbPass;
        private Panel panel5;
        private Label label3;
        private TextBox txbReEnterPass;
        private Button btnExit;
        private Button btnUpdate;
    }
}