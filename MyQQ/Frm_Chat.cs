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
    public partial class Frm_Chat : Form
    {
        public Frm_Chat()
        {
            InitializeComponent();
        }

        public int friendID = 0;  //当前聊天的好友号码
        public string nickName; //当前聊天的好友昵称
        public int headID;  //当前聊天的好友头像ID
        DataOperator dataOper = new DataOperator();  //创建数据操作类的对象

        private void Frm_Chat_Load(object sender, EventArgs e)
        {

        }
    }
}
