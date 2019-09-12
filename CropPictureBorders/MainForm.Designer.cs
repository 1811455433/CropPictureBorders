namespace CropPictureBorders
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveAsDefault = new System.Windows.Forms.Button();
            this.rightTrackBox = new CropPictureBorders.MyTrackBox();
            this.leftTrackBox = new CropPictureBorders.MyTrackBox();
            this.bottomTrackBox = new CropPictureBorders.MyTrackBox();
            this.topTrackBox = new CropPictureBorders.MyTrackBox();
            this.pbBefore = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAfter = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveAsDefault);
            this.groupBox1.Controls.Add(this.rightTrackBox);
            this.groupBox1.Controls.Add(this.leftTrackBox);
            this.groupBox1.Controls.Add(this.bottomTrackBox);
            this.groupBox1.Controls.Add(this.topTrackBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "调整";
            // 
            // saveAsDefault
            // 
            this.saveAsDefault.Enabled = false;
            this.saveAsDefault.Location = new System.Drawing.Point(193, 161);
            this.saveAsDefault.Name = "saveAsDefault";
            this.saveAsDefault.Size = new System.Drawing.Size(75, 23);
            this.saveAsDefault.TabIndex = 3;
            this.saveAsDefault.Text = "保存为默认";
            this.saveAsDefault.UseVisualStyleBackColor = true;
            this.saveAsDefault.Click += new System.EventHandler(this.SaveAsDefault_Click);
            // 
            // rightTrackBox
            // 
            this.rightTrackBox.Location = new System.Drawing.Point(6, 97);
            this.rightTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.rightTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.rightTrackBox.Name = "rightTrackBox";
            this.rightTrackBox.Size = new System.Drawing.Size(250, 20);
            this.rightTrackBox.TabIndex = 2;
            this.rightTrackBox.Title = "右";
            this.rightTrackBox.Value = 0;
            this.rightTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // leftTrackBox
            // 
            this.leftTrackBox.Location = new System.Drawing.Point(6, 71);
            this.leftTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.leftTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.leftTrackBox.Name = "leftTrackBox";
            this.leftTrackBox.Size = new System.Drawing.Size(250, 20);
            this.leftTrackBox.TabIndex = 1;
            this.leftTrackBox.Title = "左";
            this.leftTrackBox.Value = 0;
            this.leftTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // bottomTrackBox
            // 
            this.bottomTrackBox.Location = new System.Drawing.Point(6, 45);
            this.bottomTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.bottomTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.bottomTrackBox.Name = "bottomTrackBox";
            this.bottomTrackBox.Size = new System.Drawing.Size(250, 20);
            this.bottomTrackBox.TabIndex = 2;
            this.bottomTrackBox.Title = "下";
            this.bottomTrackBox.Value = 0;
            this.bottomTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // topTrackBox
            // 
            this.topTrackBox.Location = new System.Drawing.Point(6, 19);
            this.topTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.topTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.topTrackBox.Name = "topTrackBox";
            this.topTrackBox.Size = new System.Drawing.Size(250, 20);
            this.topTrackBox.TabIndex = 1;
            this.topTrackBox.Title = "上";
            this.topTrackBox.Value = 0;
            this.topTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // pbBefore
            // 
            this.pbBefore.AllowDrop = true;
            this.pbBefore.BackColor = System.Drawing.Color.Turquoise;
            this.pbBefore.Location = new System.Drawing.Point(33, 19);
            this.pbBefore.Name = "pbBefore";
            this.pbBefore.Size = new System.Drawing.Size(200, 200);
            this.pbBefore.TabIndex = 4;
            this.pbBefore.TabStop = false;
            this.pbBefore.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbBefore_DragDrop);
            this.pbBefore.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbBefore_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnSaveResult);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbAfter);
            this.groupBox2.Controls.Add(this.pbBefore);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 230);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片预览";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Enabled = false;
            this.btnSaveResult.Location = new System.Drawing.Point(506, 201);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(75, 23);
            this.btnSaveResult.TabIndex = 6;
            this.btnSaveResult.Text = "保存";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.BtnSaveResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "拖动图片到此区域";
            // 
            // pbAfter
            // 
            this.pbAfter.BackColor = System.Drawing.Color.Turquoise;
            this.pbAfter.Location = new System.Drawing.Point(252, 19);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(200, 200);
            this.pbAfter.TabIndex = 4;
            this.pbAfter.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.Location = new System.Drawing.Point(538, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 23);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "批量图片边框裁剪工具";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBefore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbAfter;
        private MyTrackBox rightTrackBox;
        private MyTrackBox leftTrackBox;
        private MyTrackBox bottomTrackBox;
        private MyTrackBox topTrackBox;
        private System.Windows.Forms.Button saveAsDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

