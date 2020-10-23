namespace LM.UI
{
    partial class frmBookType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookType));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddRootNode = new System.Windows.Forms.Button();
            this.btnAddSubNode = new System.Windows.Forms.Button();
            this.btnUpdateNode = new System.Windows.Forms.Button();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtDESC = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.txtParentTypeName = new System.Windows.Forms.TextBox();
            this.txtParentTypeId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvBookType = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前位置：图书类别管理";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddRootNode
            // 
            this.btnAddRootNode.BackColor = System.Drawing.Color.Blue;
            this.btnAddRootNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRootNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddRootNode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddRootNode.Location = new System.Drawing.Point(350, 113);
            this.btnAddRootNode.Name = "btnAddRootNode";
            this.btnAddRootNode.Size = new System.Drawing.Size(133, 43);
            this.btnAddRootNode.TabIndex = 3;
            this.btnAddRootNode.Text = "添加根节点";
            this.btnAddRootNode.UseVisualStyleBackColor = false;
            this.btnAddRootNode.Click += new System.EventHandler(this.btnAddRootNode_Click);
            // 
            // btnAddSubNode
            // 
            this.btnAddSubNode.BackColor = System.Drawing.Color.Blue;
            this.btnAddSubNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSubNode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSubNode.Location = new System.Drawing.Point(350, 208);
            this.btnAddSubNode.Name = "btnAddSubNode";
            this.btnAddSubNode.Size = new System.Drawing.Size(133, 43);
            this.btnAddSubNode.TabIndex = 3;
            this.btnAddSubNode.Text = "添加子节点";
            this.btnAddSubNode.UseVisualStyleBackColor = false;
            this.btnAddSubNode.Click += new System.EventHandler(this.btnAddSubNode_Click_1);
            // 
            // btnUpdateNode
            // 
            this.btnUpdateNode.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateNode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateNode.Location = new System.Drawing.Point(350, 305);
            this.btnUpdateNode.Name = "btnUpdateNode";
            this.btnUpdateNode.Size = new System.Drawing.Size(133, 43);
            this.btnUpdateNode.TabIndex = 3;
            this.btnUpdateNode.Text = "修改节点";
            this.btnUpdateNode.UseVisualStyleBackColor = false;
            this.btnUpdateNode.Click += new System.EventHandler(this.btnUpdateNode_Click);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.BackColor = System.Drawing.Color.Blue;
            this.btnDeleteNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteNode.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteNode.Location = new System.Drawing.Point(350, 402);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(133, 43);
            this.btnDeleteNode.TabIndex = 3;
            this.btnDeleteNode.Text = "删除节点";
            this.btnDeleteNode.UseVisualStyleBackColor = false;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.txtDESC);
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(this.txtTypeId);
            this.groupBox1.Controls.Add(this.txtParentTypeName);
            this.groupBox1.Controls.Add(this.txtParentTypeId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(520, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "节点信息";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(435, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommit.Location = new System.Drawing.Point(330, 289);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(89, 34);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtDESC
            // 
            this.txtDESC.BackColor = System.Drawing.Color.White;
            this.txtDESC.Location = new System.Drawing.Point(131, 180);
            this.txtDESC.Multiline = true;
            this.txtDESC.Name = "txtDESC";
            this.txtDESC.Size = new System.Drawing.Size(393, 80);
            this.txtDESC.TabIndex = 1;
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.White;
            this.txtTypeName.Location = new System.Drawing.Point(386, 119);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(138, 23);
            this.txtTypeName.TabIndex = 1;
            // 
            // txtTypeId
            // 
            this.txtTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTypeId.Location = new System.Drawing.Point(131, 120);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(138, 23);
            this.txtTypeId.TabIndex = 1;
            // 
            // txtParentTypeName
            // 
            this.txtParentTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtParentTypeName.Location = new System.Drawing.Point(386, 57);
            this.txtParentTypeName.Name = "txtParentTypeName";
            this.txtParentTypeName.Size = new System.Drawing.Size(138, 23);
            this.txtParentTypeName.TabIndex = 1;
            // 
            // txtParentTypeId
            // 
            this.txtParentTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtParentTypeId.Location = new System.Drawing.Point(131, 56);
            this.txtParentTypeId.Name = "txtParentTypeId";
            this.txtParentTypeId.Size = new System.Drawing.Size(138, 23);
            this.txtParentTypeId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "节点名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "父节点名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "节点描述：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "节点编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "父节点编号：";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Blue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.MintCream;
            this.btnClose.Location = new System.Drawing.Point(1011, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BOOK01.ICO");
            this.imageList1.Images.SetKeyName(1, "BOOK02.ICO");
            // 
            // tvBookType
            // 
            this.tvBookType.ImageIndex = 0;
            this.tvBookType.ImageList = this.imageList1;
            this.tvBookType.Location = new System.Drawing.Point(33, 113);
            this.tvBookType.Name = "tvBookType";
            this.tvBookType.SelectedImageIndex = 1;
            this.tvBookType.Size = new System.Drawing.Size(280, 662);
            this.tvBookType.TabIndex = 6;
            this.tvBookType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBookType_AfterSelect);
            // 
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 614);
            this.Controls.Add(this.tvBookType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteNode);
            this.Controls.Add(this.btnUpdateNode);
            this.Controls.Add(this.btnAddSubNode);
            this.Controls.Add(this.btnAddRootNode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookType";
            this.Text = "frmBookType";
            this.Load += new System.EventHandler(this.frmBookType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddRootNode;
        private System.Windows.Forms.Button btnAddSubNode;
        private System.Windows.Forms.Button btnUpdateNode;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtDESC;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.TextBox txtParentTypeName;
        private System.Windows.Forms.TextBox txtParentTypeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvBookType;
    }
}