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

        Frm_Chat frmChat;  //聊天窗体对象
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)  //双击打开聊天窗体
        {
            if(lvFriend.SelectedItems.Count>0)  //判断是否有选中项
            {
                if(frmChat==null)  //判断聊天窗体对象是否为空
                {
                    frmChat = new Frm_Chat();  //创建聊天窗体对象
                    //记录聊天的账号
                    frmChat.friendID = Convert.ToInt32(lvFriend.SelectedItems[0].Name);
                    frmChat.nickName = dataOper.GetDataSet("select NickName from tb_User where ID=" +
                        frmChat.friendID).Tables[0].Rows[0][0].ToString();  //记录昵称
                    frmChat.headID = Convert.ToInt32(dataOper.GetDataSet("select HeadID from tb_User where ID=" +
                        frmChat.friendID).Tables[0].Rows[0][0]) + 1;  //记录头像ID
                    frmChat.ShowDialog();  //以对话框显示聊天窗体对象
                    frmChat = null;  //将聊天窗体对象设置为空
                }
                if(tmChat.Enabled==true)  //如果聊天定时器处于可用状态
                {
                    tmChat.Stop();  //停止聊天定时器
                    lvFriend.SelectedItems[0].ImageIndex = friendHeadID;  //将选中项的头像显示为正常状态
                }
            }
        }

        private void pboxClose_Click(object sender, EventArgs e)  //点击叉叉
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)  //点击最小化
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool HasShowUser(int ID)  //判断某个用户是否在列表中
        {
            //是否在当前显示出的用户列表中找到了该用户
            bool find = false;
            //循环lvfriend中的两个组，寻找发消息的人是否在列表中
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<lvFriend.Groups[i].Items.Count;j++)
                {
                    if(Convert.ToInt32(lvFriend.Groups[i].Items[j].Name)==ID)
                    {
                        find = true;
                    }
                }
            }
            return find;
        }

        private void UpdateStranger(int ID)  //显示陌生人列表
        {
            lvFriend.Items.Clear();  //清空原来的列表
            //获取指定用户的昵称及头像ID
            string sql = "select NickName, HeadID from tb_User where ID=" + ID;
            SqlDataReader dataReader = dataOper.GetDataReader(sql);  //执行查询
            int i = lvFriend.Items.Count;  //记录添加到ListView中的项索引
            while(dataReader.Read())  //循环添加陌生人列表
            {
                string strTemp = dataReader["NickName"].ToString();  //记录好友昵称
                //对好友昵称进行处理
                string strName = strTemp;
                if (strTemp.Length < 9)
                    strName = strTemp.PadLeft(9, ' ');
                else
                    strName = (strTemp.Substring(0, 2) + ". . .").PadLeft(9, ' ');
                //向ListView中添加项，Name：用户ID，值：昵称、要显示的头像
                lvFriend.Items.Add(fromUserID.ToString(), strName, (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[1];  //设置项的分组为陌生人
                i++;
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }

        //主要实现实时获取未读消息的功能，在有未读消息时，进行相应的声音提示
        private void tmMessage_Tick(object sender, EventArgs e)
        {
            if(lvFriend.SelectedItems.Count>0)  //判断好友列表中有选中项
            {
                if(lvFriend.SelectedItems[0].Group==lvFriend.Groups[0])  //如果选中项属于第一组
                {
                    tsMenuDel.Visible = true;  //显示右键删除好友按钮
                    tsMenuAdd.Visible = false; //显示右键添加好友按钮s\
                }
                else if(lvFriend.SelectedItems[0].Group == lvFriend.Groups[1])
                {
                    tsMenuDel.Visible = false;
                    tsMenuAdd.Visible = true;
                }
            }
            int messageTypeID = 1;  //消息类型
            int messageState = 1;  //消息状态
            //top 1 表示查询结果只返回最上面（前面）的1项结果
            string sql = "select top 1 FromUserID, MessageTypeID, MessageState from tb_Message where ToUserID=" +
                PublicClass.loginID + " and MessageState=0";  //查找未读消息对应的好友ID
            SqlDataReader dataReader = dataOper.GetDataReader(sql);  //执行查询
            if(dataReader.Read())  //读取未读消息
            {
                fromUserID = (int)dataReader["FromUserID"];  //记录消息发送者
                messageTypeID = (int)dataReader["MessageTypeID"];  //记录消息类型
                messageState = (int)dataReader["MessageState"];  //记录消息状态
            }
            dataReader.Close();
            DataOperator.connection.Close();
            //消息有两种类型，聊天消息和添加好友消息
            //判断消息类型，如果是添加好友消息，启动消息提示器
            if(messageTypeID==2&&messageState==0)
            {
                SoundPlayer player = new SoundPlayer("system.wav");  //系统消息提示
                player.Play();  //播放指定声音文件
                tmAddFriend.Start();  //启动消息提示定时器
            }
            //如果是聊天消息，启动聊天定时器，使好友头像闪烁
            else if(messageTypeID==1&&messageState==0)
            {
                sql = "select HeadID from tb_User where ID=" + fromUserID;  //获取消息发送者的ID
                friendHeadID = dataOper.ExecSQL(sql);  //设置发消息好友头像ID
                //如果发消息的人不再好友列表中，将其添加到陌生人列表中
                if(!HasShowUser(fromUserID))
                {
                    UpdateStranger(fromUserID);  //显示陌生人列表
                }
                SoundPlayer player = new SoundPlayer("msg.wav");  //聊天消息提示
                player.Play();
                tmChat.Start();
            }
        }

        //主要实现获取系统消息图像索引，并显示在工具栏中
        private void tmAddFriend_Tick(object sender, EventArgs e)
        {
            messageImageIndex = messageImageIndex == 0 ? 1 : 0;  //实时获取系统消息图像索引
            //工具栏中显示消息读取状态图像
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
        }

        //主要实现有好友发送消息时，使好友头像闪烁的功能
        private void tmChat_Tick(object sender, EventArgs e)
        {
            //循环好友列表两个组的每一项，找到消息发送者，使其头像闪烁
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<lvFriend.Groups[i].Items.Count;j++)
                {
                    //判断是否为消息发送者
                    if(Convert.ToInt32(lvFriend.Groups[i].Items[j].Name)==fromUserID)
                    {
                        if(frmChat!=null&&frmChat.friendID!=0)  //如果已经打开了聊天窗体
                        {
                            //直接显示头像。避免闪烁效果
                            lvFriend.SelectedItems[0].ImageIndex = friendHeadID;
                        }
                        else
                        {
                            if(lvFriend.Groups[i].Items[j].ImageIndex<100)
                            {
                                //索引为100的图片是一张空白图片，为了实现闪烁效果
                                lvFriend.Groups[i].Items[j].ImageIndex = 100;
                            }
                            else
                            {
                                //要显示的消息发送者头像索引
                                lvFriend.Groups[i].Items[j].ImageIndex = friendHeadID;
                            }
                        }
                    }
                }
            }
        }
    }
}
