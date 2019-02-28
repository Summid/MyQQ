namespace MyQQ
{
    partial class Frm_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.lblFriend = new System.Windows.Forms.Label();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.rtxtChat = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tmShowMessage = new System.Windows.Forms.Timer(this.components);
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxHead
            // 
            this.pboxHead.Location = new System.Drawing.Point(7, 3);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(44, 42);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxHead.TabIndex = 0;
            this.pboxHead.TabStop = false;
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(647, 2);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 28);
            this.pboxMin.TabIndex = 1;
            this.pboxMin.TabStop = false;
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(704, 2);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 28);
            this.pboxClose.TabIndex = 2;
            this.pboxClose.TabStop = false;
            // 
            // pboxInfo
            // 
            this.pboxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pboxInfo.Location = new System.Drawing.Point(504, 480);
            this.pboxInfo.Name = "pboxInfo";
            this.pboxInfo.Size = new System.Drawing.Size(89, 20);
            this.pboxInfo.TabIndex = 3;
            this.pboxInfo.TabStop = false;
            this.pboxInfo.Click += new System.EventHandler(this.pboxInfo_Click);
            // 
            // lblFriend
            // 
            this.lblFriend.BackColor = System.Drawing.Color.LightGray;
            this.lblFriend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriend.Location = new System.Drawing.Point(57, 6);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(519, 24);
            this.lblFriend.TabIndex = 4;
            this.lblFriend.Text = "label1";
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BackColor = System.Drawing.Color.White;
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMessage.Location = new System.Drawing.Point(0, 51);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(594, 427);
            this.rtxtMessage.TabIndex = 5;
            this.rtxtMessage.Text = "";
            // 
            // rtxtChat
            // 
            this.rtxtChat.BackColor = System.Drawing.Color.White;
            this.rtxtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtChat.Location = new System.Drawing.Point(0, 502);
            this.rtxtChat.Name = "rtxtChat";
            this.rtxtChat.Size = new System.Drawing.Size(594, 76);
            this.rtxtChat.TabIndex = 6;
            this.rtxtChat.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(505, 584);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSend_KeyDown);
            // 
            // tmShowMessage
            // 
            this.tmShowMessage.Enabled = true;
            this.tmShowMessage.Interval = 2000;
            this.tmShowMessage.Tick += new System.EventHandler(this.tmShowMessage_Tick);
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistHead.Images.SetKeyName(0, "1.bmp");
            this.imglistHead.Images.SetKeyName(1, "2.bmp");
            this.imglistHead.Images.SetKeyName(2, "3.bmp");
            this.imglistHead.Images.SetKeyName(3, "4.bmp");
            this.imglistHead.Images.SetKeyName(4, "5.bmp");
            this.imglistHead.Images.SetKeyName(5, "6.bmp");
            this.imglistHead.Images.SetKeyName(6, "7.bmp");
            this.imglistHead.Images.SetKeyName(7, "8.bmp");
            this.imglistHead.Images.SetKeyName(8, "9.bmp");
            this.imglistHead.Images.SetKeyName(9, "10.bmp");
            this.imglistHead.Images.SetKeyName(10, "11.bmp");
            this.imglistHead.Images.SetKeyName(11, "12.bmp");
            this.imglistHead.Images.SetKeyName(12, "13.bmp");
            this.imglistHead.Images.SetKeyName(13, "14.bmp");
            this.imglistHead.Images.SetKeyName(14, "15.bmp");
            this.imglistHead.Images.SetKeyName(15, "16.bmp");
            this.imglistHead.Images.SetKeyName(16, "17.bmp");
            this.imglistHead.Images.SetKeyName(17, "18.bmp");
            this.imglistHead.Images.SetKeyName(18, "19.bmp");
            this.imglistHead.Images.SetKeyName(19, "20.bmp");
            this.imglistHead.Images.SetKeyName(20, "21.bmp");
            this.imglistHead.Images.SetKeyName(21, "22.bmp");
            this.imglistHead.Images.SetKeyName(22, "23.bmp");
            this.imglistHead.Images.SetKeyName(23, "24.bmp");
            this.imglistHead.Images.SetKeyName(24, "25.bmp");
            this.imglistHead.Images.SetKeyName(25, "26.bmp");
            this.imglistHead.Images.SetKeyName(26, "27.bmp");
            this.imglistHead.Images.SetKeyName(27, "28.bmp");
            this.imglistHead.Images.SetKeyName(28, "29.bmp");
            this.imglistHead.Images.SetKeyName(29, "30.bmp");
            this.imglistHead.Images.SetKeyName(30, "32.bmp");
            this.imglistHead.Images.SetKeyName(31, "33.bmp");
            this.imglistHead.Images.SetKeyName(32, "34.bmp");
            this.imglistHead.Images.SetKeyName(33, "35.bmp");
            this.imglistHead.Images.SetKeyName(34, "36.bmp");
            this.imglistHead.Images.SetKeyName(35, "37.bmp");
            this.imglistHead.Images.SetKeyName(36, "38.bmp");
            this.imglistHead.Images.SetKeyName(37, "40.bmp");
            this.imglistHead.Images.SetKeyName(38, "41.bmp");
            this.imglistHead.Images.SetKeyName(39, "42.bmp");
            this.imglistHead.Images.SetKeyName(40, "43.bmp");
            this.imglistHead.Images.SetKeyName(41, "44.bmp");
            this.imglistHead.Images.SetKeyName(42, "45.bmp");
            this.imglistHead.Images.SetKeyName(43, "46.bmp");
            this.imglistHead.Images.SetKeyName(44, "47.bmp");
            this.imglistHead.Images.SetKeyName(45, "48.bmp");
            this.imglistHead.Images.SetKeyName(46, "49.bmp");
            this.imglistHead.Images.SetKeyName(47, "50.bmp");
            this.imglistHead.Images.SetKeyName(48, "51.bmp");
            this.imglistHead.Images.SetKeyName(49, "52.bmp");
            this.imglistHead.Images.SetKeyName(50, "53.bmp");
            this.imglistHead.Images.SetKeyName(51, "54.bmp");
            this.imglistHead.Images.SetKeyName(52, "55.bmp");
            this.imglistHead.Images.SetKeyName(53, "56.bmp");
            this.imglistHead.Images.SetKeyName(54, "57.bmp");
            this.imglistHead.Images.SetKeyName(55, "58.bmp");
            this.imglistHead.Images.SetKeyName(56, "59.bmp");
            this.imglistHead.Images.SetKeyName(57, "60.bmp");
            this.imglistHead.Images.SetKeyName(58, "61.bmp");
            this.imglistHead.Images.SetKeyName(59, "62.bmp");
            this.imglistHead.Images.SetKeyName(60, "63.bmp");
            this.imglistHead.Images.SetKeyName(61, "64.bmp");
            this.imglistHead.Images.SetKeyName(62, "65.bmp");
            this.imglistHead.Images.SetKeyName(63, "66.bmp");
            this.imglistHead.Images.SetKeyName(64, "67.bmp");
            this.imglistHead.Images.SetKeyName(65, "68.bmp");
            this.imglistHead.Images.SetKeyName(66, "69.bmp");
            this.imglistHead.Images.SetKeyName(67, "70.bmp");
            this.imglistHead.Images.SetKeyName(68, "71.bmp");
            this.imglistHead.Images.SetKeyName(69, "72.bmp");
            this.imglistHead.Images.SetKeyName(70, "73.bmp");
            this.imglistHead.Images.SetKeyName(71, "74.bmp");
            this.imglistHead.Images.SetKeyName(72, "75.bmp");
            this.imglistHead.Images.SetKeyName(73, "76.bmp");
            this.imglistHead.Images.SetKeyName(74, "77.bmp");
            this.imglistHead.Images.SetKeyName(75, "78.bmp");
            this.imglistHead.Images.SetKeyName(76, "79.bmp");
            this.imglistHead.Images.SetKeyName(77, "80.bmp");
            this.imglistHead.Images.SetKeyName(78, "81.bmp");
            this.imglistHead.Images.SetKeyName(79, "82.bmp");
            this.imglistHead.Images.SetKeyName(80, "83.bmp");
            this.imglistHead.Images.SetKeyName(81, "84.bmp");
            this.imglistHead.Images.SetKeyName(82, "85.bmp");
            this.imglistHead.Images.SetKeyName(83, "86.bmp");
            this.imglistHead.Images.SetKeyName(84, "87.bmp");
            this.imglistHead.Images.SetKeyName(85, "88.bmp");
            this.imglistHead.Images.SetKeyName(86, "89.bmp");
            this.imglistHead.Images.SetKeyName(87, "90.bmp");
            this.imglistHead.Images.SetKeyName(88, "91.bmp");
            this.imglistHead.Images.SetKeyName(89, "92.bmp");
            this.imglistHead.Images.SetKeyName(90, "93.bmp");
            this.imglistHead.Images.SetKeyName(91, "94.bmp");
            this.imglistHead.Images.SetKeyName(92, "95.bmp");
            this.imglistHead.Images.SetKeyName(93, "96.bmp");
            this.imglistHead.Images.SetKeyName(94, "97.bmp");
            this.imglistHead.Images.SetKeyName(95, "98.bmp");
            this.imglistHead.Images.SetKeyName(96, "99.bmp");
            this.imglistHead.Images.SetKeyName(97, "100.bmp");
            this.imglistHead.Images.SetKeyName(98, "back.bmp");
            this.imglistHead.Images.SetKeyName(99, "31.bmp");
            this.imglistHead.Images.SetKeyName(100, "39.bmp");
            // 
            // Frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.chat;
            this.ClientSize = new System.Drawing.Size(737, 610);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtxtChat);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.pboxInfo);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.pboxHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Chat";
            this.Text = "Frm_Chat";
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxInfo;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.RichTextBox rtxtChat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer tmShowMessage;
        private System.Windows.Forms.ImageList imglistHead;
    }
}