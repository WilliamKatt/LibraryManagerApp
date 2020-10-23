namespace LM.UI
{
    partial class frmBookDetail
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
            this.lblTiele = new System.Windows.Forms.Label();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.btnStartPhoto = new System.Windows.Forms.Button();
            this.btnCloseCamera = new System.Windows.Forms.Button();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBookTypeTwo = new System.Windows.Forms.ComboBox();
            this.cboBookTypeOne = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboBookPress = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInventoryNum = new System.Windows.Forms.NumericUpDown();
            this.txtStorageInNum = new System.Windows.Forms.NumericUpDown();
            this.lblBorrowedNum = new System.Windows.Forms.NumericUpDown();
            this.lblStorageInDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblInventoryNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStorageInNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBorrowedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiele
            // 
            this.lblTiele.AutoSize = true;
            this.lblTiele.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTiele.ForeColor = System.Drawing.Color.Blue;
            this.lblTiele.Location = new System.Drawing.Point(12, 9);
            this.lblTiele.Name = "lblTiele";
            this.lblTiele.Size = new System.Drawing.Size(180, 28);
            this.lblTiele.TabIndex = 14;
            this.lblTiele.Text = "【查看图书详情】";
            this.lblTiele.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose1.Location = new System.Drawing.Point(726, 24);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(33, 28);
            this.btnClose1.TabIndex = 16;
            this.btnClose1.Text = "×";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.BackColor = System.Drawing.Color.Blue;
            this.btnSelectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPhoto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.MintCream;
            this.btnSelectPhoto.Location = new System.Drawing.Point(645, 79);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(114, 35);
            this.btnSelectPhoto.TabIndex = 22;
            this.btnSelectPhoto.Text = "选择图片";
            this.btnSelectPhoto.UseVisualStyleBackColor = false;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.BackColor = System.Drawing.Color.Blue;
            this.btnClearPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPhoto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearPhoto.ForeColor = System.Drawing.Color.MintCream;
            this.btnClearPhoto.Location = new System.Drawing.Point(645, 120);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(114, 35);
            this.btnClearPhoto.TabIndex = 23;
            this.btnClearPhoto.Text = "清除选择";
            this.btnClearPhoto.UseVisualStyleBackColor = false;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // btnStartPhoto
            // 
            this.btnStartPhoto.BackColor = System.Drawing.Color.Blue;
            this.btnStartPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartPhoto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartPhoto.ForeColor = System.Drawing.Color.MintCream;
            this.btnStartPhoto.Location = new System.Drawing.Point(645, 243);
            this.btnStartPhoto.Name = "btnStartPhoto";
            this.btnStartPhoto.Size = new System.Drawing.Size(114, 35);
            this.btnStartPhoto.TabIndex = 24;
            this.btnStartPhoto.Text = "开始拍照";
            this.btnStartPhoto.UseVisualStyleBackColor = false;
            this.btnStartPhoto.Click += new System.EventHandler(this.btnStartPhoto_Click);
            // 
            // btnCloseCamera
            // 
            this.btnCloseCamera.BackColor = System.Drawing.Color.Blue;
            this.btnCloseCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseCamera.ForeColor = System.Drawing.Color.MintCream;
            this.btnCloseCamera.Location = new System.Drawing.Point(645, 202);
            this.btnCloseCamera.Name = "btnCloseCamera";
            this.btnCloseCamera.Size = new System.Drawing.Size(114, 35);
            this.btnCloseCamera.TabIndex = 25;
            this.btnCloseCamera.Text = "关闭摄像头";
            this.btnCloseCamera.UseVisualStyleBackColor = false;
            this.btnCloseCamera.Click += new System.EventHandler(this.btnCloseCamera_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.BackColor = System.Drawing.Color.Blue;
            this.btnStartCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCamera.ForeColor = System.Drawing.Color.MintCream;
            this.btnStartCamera.Location = new System.Drawing.Point(645, 161);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(114, 35);
            this.btnStartCamera.TabIndex = 26;
            this.btnStartCamera.Text = "重启摄像头";
            this.btnStartCamera.UseVisualStyleBackColor = false;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(851, 4);
            this.label2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "图书图片：";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(3, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(851, 4);
            this.label4.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBookISBN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboBookTypeTwo);
            this.groupBox1.Controls.Add(this.cboBookTypeOne);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 119);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重要信息";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.White;
            this.txtBookName.Location = new System.Drawing.Point(354, 71);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(335, 23);
            this.txtBookName.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "图书名称：";
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.BackColor = System.Drawing.Color.White;
            this.txtBookISBN.Location = new System.Drawing.Point(112, 71);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(130, 23);
            this.txtBookISBN.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "ISBN码：";
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.White;
            this.txtBookId.Location = new System.Drawing.Point(539, 26);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(150, 23);
            this.txtBookId.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "图书编号：";
            // 
            // cboBookTypeTwo
            // 
            this.cboBookTypeTwo.FormattingEnabled = true;
            this.cboBookTypeTwo.Location = new System.Drawing.Point(266, 26);
            this.cboBookTypeTwo.Name = "cboBookTypeTwo";
            this.cboBookTypeTwo.Size = new System.Drawing.Size(130, 25);
            this.cboBookTypeTwo.TabIndex = 34;
            // 
            // cboBookTypeOne
            // 
            this.cboBookTypeOne.FormattingEnabled = true;
            this.cboBookTypeOne.Location = new System.Drawing.Point(112, 26);
            this.cboBookTypeOne.Name = "cboBookTypeOne";
            this.cboBookTypeOne.Size = new System.Drawing.Size(130, 25);
            this.cboBookTypeOne.TabIndex = 32;
            this.cboBookTypeOne.SelectedIndexChanged += new System.EventHandler(this.cmbPressName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(47, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "图书类别：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpPublishDate);
            this.groupBox2.Controls.Add(this.txtBookPrice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBookAuthor);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboBookPress);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 119);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本信息";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(468, 72);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(221, 23);
            this.dtpPublishDate.TabIndex = 41;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.BackColor = System.Drawing.Color.White;
            this.txtBookPrice.Location = new System.Drawing.Point(468, 28);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(221, 23);
            this.txtBookPrice.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(394, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "出版日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "图书价格：";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.BackColor = System.Drawing.Color.White;
            this.txtBookAuthor.Location = new System.Drawing.Point(116, 28);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(224, 23);
            this.txtBookAuthor.TabIndex = 36;
            this.txtBookAuthor.TextChanged += new System.EventHandler(this.txtBookAuthor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "图书作者：";
            // 
            // cboBookPress
            // 
            this.cboBookPress.FormattingEnabled = true;
            this.cboBookPress.Location = new System.Drawing.Point(116, 69);
            this.cboBookPress.Name = "cboBookPress";
            this.cboBookPress.Size = new System.Drawing.Size(224, 25);
            this.cboBookPress.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(54, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "出版社：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblInventoryNum);
            this.groupBox3.Controls.Add(this.txtStorageInNum);
            this.groupBox3.Controls.Add(this.lblBorrowedNum);
            this.groupBox3.Controls.Add(this.lblStorageInDate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 119);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "核心信息";
            // 
            // lblInventoryNum
            // 
            this.lblInventoryNum.Location = new System.Drawing.Point(124, 70);
            this.lblInventoryNum.Name = "lblInventoryNum";
            this.lblInventoryNum.Size = new System.Drawing.Size(221, 23);
            this.lblInventoryNum.TabIndex = 42;
            // 
            // txtStorageInNum
            // 
            this.txtStorageInNum.Location = new System.Drawing.Point(124, 28);
            this.txtStorageInNum.Name = "txtStorageInNum";
            this.txtStorageInNum.Size = new System.Drawing.Size(221, 23);
            this.txtStorageInNum.TabIndex = 42;
            // 
            // lblBorrowedNum
            // 
            this.lblBorrowedNum.Location = new System.Drawing.Point(468, 69);
            this.lblBorrowedNum.Name = "lblBorrowedNum";
            this.lblBorrowedNum.Size = new System.Drawing.Size(221, 23);
            this.lblBorrowedNum.TabIndex = 42;
            // 
            // lblStorageInDate
            // 
            this.lblStorageInDate.Location = new System.Drawing.Point(468, 25);
            this.lblStorageInDate.Name = "lblStorageInDate";
            this.lblStorageInDate.Size = new System.Drawing.Size(221, 23);
            this.lblStorageInDate.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "图书价格：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "入库时间：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "入库数量：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(47, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "当前库存：";
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCurrentImage.Location = new System.Drawing.Point(124, 101);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(154, 155);
            this.pbCurrentImage.TabIndex = 43;
            this.pbCurrentImage.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(356, 101);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(146, 155);
            this.pbImage.TabIndex = 43;
            this.pbImage.TabStop = false;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DodgerBlue;
            this.label17.Location = new System.Drawing.Point(3, 711);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(851, 4);
            this.label17.TabIndex = 29;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(192, 737);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(109, 37);
            this.btnCommit.TabIndex = 44;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(463, 737);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(109, 37);
            this.btnClose2.TabIndex = 44;
            this.btnClose2.Text = "取消";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // frmBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 799);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.btnCloseCamera);
            this.Controls.Add(this.btnStartPhoto);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.lblTiele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookDetail";
            this.Text = "frmBookDetail";
            this.Load += new System.EventHandler(this.frmBookDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblInventoryNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStorageInNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBorrowedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTiele;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Button btnStartPhoto;
        private System.Windows.Forms.Button btnCloseCamera;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBookTypeOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBookTypeTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboBookPress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown lblInventoryNum;
        private System.Windows.Forms.NumericUpDown txtStorageInNum;
        private System.Windows.Forms.NumericUpDown lblBorrowedNum;
        private System.Windows.Forms.DateTimePicker lblStorageInDate;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnClose2;
    }
}