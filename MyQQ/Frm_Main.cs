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
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        int fromUserID;  //消息发送者
        int friendHeadID; //发消息好友的头像ID
        int messageImageIndex = 0;  //工具栏中的消息图标的索引
        public static string nickName = "";  //自己的昵称
        public static string strFlag = "[离线]";
        DataOperator dataOper = new DataOperator();  //创建数据操作类的对象

        public void ShowInfo()  //显示个人的头像、昵称、账号和个性签名等信息
        {
            int headID = 0;  //头像索引
            //获取当前用户的昵称、头像
            string sql = "select NickName, HeadID, Sign from tb_User where ID=" + PublicClass.loginID + "";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);  //执行查询操作
            if(dataReader.Read())  //读取查询结果
            {
                if(!(dataReader["NickName"] is DBNull))  //判断NickName不为空
                {
                    nickName = dataReader["NickName"].ToString();  //记录自己的昵称
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);  //记录自己的头像ID
                txtSign.Text = dataReader["Sign"].ToString();  //显示个性签名
            }
            dataReader.Close();  //关闭读取器
            DataOperator.connection.Close();
            this.Text = PublicClass.loginID.ToString();  //设置窗体标题为当前用户账号
            pboxHead.Image = imglistHead.Images[headID];  //显示用户头像
            lblName.Text = nickName + "(" + PublicClass.loginID + ")";  //显示昵称及账号
        }

        public void ShowFriendList()  //显示当前登录用户的好友列表信息（好友头像、昵称、是否在线等）
        {
            lvFriend.Items.Clear();  //清空原来的列表
            //定义查找好友的SQL语句
            string sql = "select FriendID, NickName, HeadID, Flag from tb_User, tb_Friend where tb_Friend.HostID=" +
                PublicClass.loginID + " and tb_User.ID=tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);  //执行查询
            int i = lvFriend.Items.Count;  //记录添加到ListView中的项索引
            while(dataReader.Read())   //循环添加好友列表
            {
                if (dataReader["Flag"].ToString() == "0")
                    strFlag = "[离线]";
                else
                    strFlag = "[在线]";
                string strTemp = dataReader["NickName"].ToString();  //记录好友昵称
                //对好友昵称进行处理
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    strFriendName = (strTemp.Substring(0, 2) + ". . .").PadLeft(9, ' ');
                //向ListView中添加项，Name：好友ID，值：昵称，要显示的头像
                lvFriend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[0];  //设置项的分组为我的好友
                i++;  //临时变量+1
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tsbtnMessageReading.Image = imglistMessage.Images[0];  //工具栏的消息图标
            ShowInfo();  //显示个人信息
            ShowFriendList();  //显示好友列表
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmInfo = new Frm_EditInfo();  //创建个人信息窗体对象
            frmInfo.Show();  //显示个人信息窗体
        }

        private void tsbtnSearchFriend_Click(object sender, EventArgs e)  //点击查找好友窗体
        {
            Frm_AddFriend frmAddFriend = new Frm_AddFriend();
            frmAddFriend.Show();
        }

        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)  //更新好友列表
        {
            ShowFriendList();
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)  //点击系统消息按钮
        {
            tmAddFriend.Stop();  //停止消息提醒定时器
            messageImageIndex = 0;  //头像恢复正常
            //显示正常的系统消息提醒图标
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
            Frm_Remind frmRemind = new Frm_Remind();
            frmRemind.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)  //点击退出按钮
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
