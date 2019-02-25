﻿namespace MyQQ
{
    partial class frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Register));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboxBloodType = new System.Windows.Forms.ComboBox();
            this.cboxStar = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpBaseInfo.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::MyQQ.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 310);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.txtPwdAgain);
            this.grpBaseInfo.Controls.Add(this.txtPwd);
            this.grpBaseInfo.Controls.Add(this.rbtnFemale);
            this.grpBaseInfo.Controls.Add(this.rbtnMale);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtNickName);
            this.grpBaseInfo.Controls.Add(this.lblPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblPwd);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblNickName);
            this.grpBaseInfo.Location = new System.Drawing.Point(114, 10);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Size = new System.Drawing.Size(259, 180);
            this.grpBaseInfo.TabIndex = 1;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本信息";
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(85, 138);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(142, 21);
            this.txtPwdAgain.TabIndex = 10;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(85, 110);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(142, 21);
            this.txtPwd.TabIndex = 9;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(139, 85);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(85, 85);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(85, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(35, 21);
            this.txtAge.TabIndex = 6;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(85, 26);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(142, 21);
            this.txtNickName.TabIndex = 5;
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(23, 147);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(53, 12);
            this.lblPwdAgain.TabIndex = 4;
            this.lblPwdAgain.Text = "重复密码";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(47, 119);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(47, 87);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(47, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "年龄";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(47, 30);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(29, 12);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "昵称";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.cboxBloodType);
            this.grpDetails.Controls.Add(this.cboxStar);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblBloodType);
            this.grpDetails.Controls.Add(this.lblStar);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Location = new System.Drawing.Point(114, 206);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(259, 116);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "选填详细信息";
            // 
            // cboxBloodType
            // 
            this.cboxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBloodType.FormattingEnabled = true;
            this.cboxBloodType.Items.AddRange(new object[] {
            "A 型",
            "B 型",
            "O 型",
            "AB 型"});
            this.cboxBloodType.Location = new System.Drawing.Point(85, 76);
            this.cboxBloodType.Name = "cboxBloodType";
            this.cboxBloodType.Size = new System.Drawing.Size(142, 20);
            this.cboxBloodType.TabIndex = 5;
            // 
            // cboxStar
            // 
            this.cboxStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStar.FormattingEnabled = true;
            this.cboxStar.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.cboxStar.Location = new System.Drawing.Point(85, 47);
            this.cboxStar.Name = "cboxStar";
            this.cboxStar.Size = new System.Drawing.Size(142, 20);
            this.cboxStar.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(47, 84);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(29, 12);
            this.lblBloodType.TabIndex = 2;
            this.lblBloodType.Text = "血型";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(47, 55);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(29, 12);
            this.lblStar.TabIndex = 1;
            this.lblStar.Text = "星座";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "真实姓名";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(234, 326);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(63, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(303, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请账号";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboxBloodType;
        private System.Windows.Forms.ComboBox cboxStar;
        private System.Windows.Forms.TextBox txtName;
    }
}