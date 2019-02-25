using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        DataOperator dataOper = new DataOperator();  //创建数据操作类的对象

        private void frm_Register_Load(object sender, EventArgs e)  //窗体加载时
        {
            cboxStar.SelectedIndex = cboxBloodType.SelectedIndex = 0; //设置星座和血型的默认选项
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtNickName.Text.Trim()=="" || txtNickName.Text.Length>20) //验证昵称
            {
                MessageBox.Show("昵称输入有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return;
            }

            if(txtAge.Text.Trim()=="")  //验证年龄
            {
                MessageBox.Show("请输入年龄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return;
            }

            if(!rbtnMale.Checked&&!rbtnFemale.Checked)   //验证性别
            {
                MessageBox.Show("请选择性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSex.Focus();
                return;
            }

            if(txtPwd.Text.Trim()=="")  //验证密码
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }

            if(txtPwdAgain.Text.Trim()=="")  //验证确认密码
            {
                MessageBox.Show("请输入确认密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }

            if(txtPwdAgain.Text.Trim()!=txtPwd.Text.Trim())  //再次验证确认密码（？
            {
                MessageBox.Show("两次输入的密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }

            int myQQnum = 0;  //QQ号码
            string message;  //弹出的消息
            string sex = rbtnMale.Checked ? rbtnMale.Text : rbtnFemale.Text;  //获取选中的性别
            string sql = string.Format("insert into tb_User (Pwd, NickName, Sex, Age, Name, Star, BloodType) " +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');select @@Identity from tb_User", txtPwd.Text.Trim(),
                txtNickName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), cboxStar.Text,
                cboxBloodType.Text);   //sql语句，string.Format方法可在帮助文档中查询到; @@IDENTITY 中包含语句生成的最后一个标识值

            SqlCommand command = new SqlCommand(sql, DataOperator.connection); //制定要执行的SQL语句
            DataOperator.connection.Open();  //打开数据库连接
            int result = command.ExecuteNonQuery();  //执行SQL语句
            if(result==1)
            {
                sql = "select SCOPE_IDENTITY() from tb_User";  //查询新增加的记录的标识号
                command = new SqlCommand(sql, DataOperator.connection);  //执行查询
                myQQnum = Convert.ToInt32(command.ExecuteScalar());  //获取最新增加的账号
                message = string.Format("注册成功！你的MyQQ账号是：" + myQQnum);
            }
            else
            {
                message = "注册失败，请重试";
            }

            DataOperator.connection.Close();  //关闭数据库连接

            //上面的查询不能用dataOper对象调用其函数的方法来完成，因为要调用两次，数据库连接会打开、关闭两次，
            //这样在查询新增加的记录的标识号时查询结果为空，就会报错（是SCOPE_IDENTITY函数的问题吗？）

            MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();  //关闭当前窗体
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
