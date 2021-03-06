﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();  //创建数据操作类的对象

        private bool ValidateInput() //验证用户输入
        {
            if(txtID.Text.Trim()=="") //如果输入的账号为空（Trim方法去掉空白值）
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtID.Focus();  //txtID文本框获取焦点
                return false;
            }

            else if(int.Parse(txtID.Text.Trim())>65535)  //如果用户输入的账号超出范围
            {                                                                           //parse方法将字符串转换为int类型
                MessageBox.Show("请输入正确的账号", "登录提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtID.Focus();  //获取焦点
                return false;
            }
            else if(txtPwd.Text.Trim()=="")//密码为空
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPwd.Focus(); //获取焦点
                return false;
            }
            return true;
        }
        

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入是否是数字
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))
                e.Handled = false;  //显示该字符（不处理该字符）
            else
                e.Handled = true;  //不显示该字符（处理该字符）
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')  //如果在密码框文本输入回车，调用点击登录按钮的函数
                pboxLogin_Click(sender, e);
        }

        private void pboxLogin_Click(object sender, EventArgs e)  //点击登录按钮
        {
            if(ValidateInput())  //验证用户输入
            {
                string sql = "select count(*) from tb_User where ID=" +
                    int.Parse(txtID.Text.Trim()) + " and Pwd = '" + txtPwd.Text.Trim() + "'";
                int num = dataOper.ExecSQL(sql);
                if(num==1)  //验证通过 
                {
                    PublicClass.loginID = int.Parse(txtID.Text.Trim()); //设置登录的账号
                    if (cboxRemember.Checked)  //如果勾选了记住密码
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where ID="
                            + int.Parse(txtID.Text.Trim())); //将该用户记住密码值设为1
                        if (cboxAutoLogin.Checked) //如果也勾选了自动登录
                        {
                            dataOper.ExecSQLResult("update tb_User set AutoLogin=1 where ID="
                                + int.Parse(txtID.Text.Trim())); //将该用户自动登录值为1
                        }
                    }
                    else
                    {   //如果没有勾选记住密码和自动登录，则将该两项值设置为0
                        dataOper.ExecSQLResult("update tb_User set Remember=0 where ID="
                            + int.Parse(txtID.Text.Trim()));
                        dataOper.ExecSQLResult("update tb_User set AutoLogin=0 where ID="
                            + int.Parse(txtID.Text.Trim()));
                    }
                        dataOper.ExecSQLResult("update tb_User set Flag=1 where ID="
                            + int.Parse(txtID.Text.Trim()));  //登录后将在线状态设置为1
                        Frm_Main frmMain = new Frm_Main();  //创建主界面
                        frmMain.Show(); //显示主界面
                        this.Visible = false; //隐藏登录主窗体
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码有误", "登录提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxRemember.Checked)  //如果记住密码复选框不打勾，那自动登录就不能打勾
                cboxAutoLogin.Checked = false;
        }

        private void cboxAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAutoLogin.Checked)  //如果自动登录打勾，那记住密码就要打勾
                cboxRemember.Checked = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e) //在账号文本框输入的时候触发
        {
            //ValidateInput();
            if (txtID.Text!="")  //如果账号文本框不为空（先输入再清除的情况）
            {
                string sql = "select Pwd,Remember,AutoLogin from tb_User where ID=" +
                    int.Parse(txtID.Text.Trim()) + " ";
                DataSet ds = dataOper.GetDataSet(sql);  //获取查询结果
                if (ds.Tables[0].Rows.Count > 0) //如果有该用户
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1) //判断是否记住密码
                    {
                        cboxRemember.Checked = true;
                        txtPwd.Text = ds.Tables[0].Rows[0][0].ToString(); //自动输入密码
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1) //判断是否自动登录
                        {
                            cboxAutoLogin.Checked = true;
                            pboxLogin_Click(sender, e); //自动登录
                        }
                    }
                }
            }
        }
        
        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //点击申请账号按钮
        {
            frm_Register frmRegister = new frm_Register();
            frmRegister.Show();
        }

        private void pboxMin_Click(object sender, EventArgs e) //点击最小化按钮
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxClose_Click(object sender, EventArgs e) //点击关闭按钮
        {
            Application.ExitThread();
        }
    }
}
