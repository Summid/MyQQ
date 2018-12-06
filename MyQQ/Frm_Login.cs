using System;
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
        private void Frm_Login_Load(object sender, EventArgs e)
        {

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
                if(num==1)  //验证通过 1->loginID?
                {
                    PublicClass.loginID = int.Parse(txtID.Text.Trim()); //设置登录的账号
                    if(cboxRemember.Checked)  //如果勾选了记住密码
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where ID="
                            + int.Parse(txtID.Text.Trim())); //将该用户记住密码值设为1
                        if(cboxAutoLogin.Checked) //如果也勾选了自动登录
                        {
                            dataOper.ExecSQLResult("update tu_User set AutoLogin=1 where ID="
                                + int.Parse(txtID.Text.Trim())); //将该用户自动登录值为1
                        }
                        else
                        {   //如果没有勾选记住密码和自动登录，则将该两项值设置为0
                            dataOper.ExecSQLResult("update tb_User set Remember=0 where ID="
                                + int.Parse(txtID.Text.Trim()));
                            dataOper.ExecSQLResult("update tu_User set AutoLogin=0 where ID="
                                + int.Parse(txtID.Text.Trim()));
                        }
                        dataOper.ExecSQLResult("update tb_User set Flag=1 where ID="
                            + int.Parse(txtID.Text.Trim()));  //登录后将在线状态设置为1
                        Frm_Main frmMain = new Frm_Main();  //创建主界面
                        frmMain.Show(); //显示主界面
                        this.Visible = false; //隐藏登录主窗体
                    }
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码有误", "登录提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
