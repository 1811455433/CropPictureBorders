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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveAsDefault = new System.Windows.Forms.Button();
            this.pbBefore = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAfter = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bottomTrackBox = new CropPictureBorders.MyTrackBox();
            this.rightTrackBox = new CropPictureBorders.MyTrackBox();
            this.leftTrackBox = new CropPictureBorders.MyTrackBox();
            this.topTrackBox = new CropPictureBorders.MyTrackBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // saveAsDefault
            // 
            this.saveAsDefault.Enabled = false;
            this.saveAsDefault.Location = new System.Drawing.Point(109, 306);
            this.saveAsDefault.Name = "saveAsDefault";
            this.saveAsDefault.Size = new System.Drawing.Size(75, 23);
            this.saveAsDefault.TabIndex = 3;
            this.saveAsDefault.Text = "保存为默认";
            this.toolTip1.SetToolTip(this.saveAsDefault, "将剪切值保存下来，当作默认值，供下次使用");
            this.saveAsDefault.UseVisualStyleBackColor = true;
            this.saveAsDefault.Click += new System.EventHandler(this.SaveAsDefault_Click);
            // 
            // pbBefore
            // 
            this.pbBefore.AllowDrop = true;
            this.pbBefore.BackColor = System.Drawing.Color.Turquoise;
            this.pbBefore.Location = new System.Drawing.Point(46, 59);
            this.pbBefore.Name = "pbBefore";
            this.pbBefore.Size = new System.Drawing.Size(200, 200);
            this.pbBefore.TabIndex = 4;
            this.pbBefore.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBefore, "显示的图片为了能更好的看到边框，\r\n在显示时对图片进行了处理，只显\r\n示图片的四个角，真正处理得到的\r\n图片并非如此");
            this.pbBefore.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbBefore_DragDrop);
            this.pbBefore.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbBefore_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bottomTrackBox);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.saveAsDefault);
            this.groupBox2.Controls.Add(this.btnSaveResult);
            this.groupBox2.Controls.Add(this.rightTrackBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.leftTrackBox);
            this.groupBox2.Controls.Add(this.pbAfter);
            this.groupBox2.Controls.Add(this.pbBefore);
            this.groupBox2.Controls.Add(this.topTrackBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 356);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片预览";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "切换下面预览框的背景颜色");
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.Location = new System.Drawing.Point(520, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 23);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Enabled = false;
            this.btnSaveResult.Location = new System.Drawing.Point(425, 306);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(75, 23);
            this.btnSaveResult.TabIndex = 6;
            this.btnSaveResult.Text = "保存";
            this.toolTip1.SetToolTip(this.btnSaveResult, "将修改后的图片保存下来");
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.BtnSaveResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.Location = new System.Drawing.Point(87, 152);
            this.label1.TabIndex = 5;
            this.label1.Text = "拖动图片到此区域";
            // 
            // pbAfter
            // 
            this.pbAfter.BackColor = System.Drawing.Color.Turquoise;
            this.pbAfter.Location = new System.Drawing.Point(362, 59);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(200, 200);
            this.pbAfter.TabIndex = 4;
            this.pbAfter.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAfter, "显示的图片为了能更好的看到边框，\r\n在显示时对图片进行了处理，只显\r\n示图片的四个角，真正处理得到的\r\n图片并非如此\r\n");
            // 
            // bottomTrackBox
            // 
            this.bottomTrackBox.Location = new System.Drawing.Point(6, 277);
            this.bottomTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.bottomTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.bottomTrackBox.Name = "bottomTrackBox";
            this.bottomTrackBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bottomTrackBox.Size = new System.Drawing.Size(250, 20);
            this.bottomTrackBox.TabIndex = 3;
            this.bottomTrackBox.Title = "";
            this.bottomTrackBox.Value = 0;
            this.bottomTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // rightTrackBox
            // 
            this.rightTrackBox.Location = new System.Drawing.Point(258, 44);
            this.rightTrackBox.MaximumSize = new System.Drawing.Size(20, 0);
            this.rightTrackBox.MinimumSize = new System.Drawing.Size(20, 250);
            this.rightTrackBox.Name = "rightTrackBox";
            this.rightTrackBox.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rightTrackBox.Size = new System.Drawing.Size(20, 250);
            this.rightTrackBox.TabIndex = 2;
            this.rightTrackBox.Title = "";
            this.rightTrackBox.Value = 0;
            this.rightTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // leftTrackBox
            // 
            this.leftTrackBox.Location = new System.Drawing.Point(17, 44);
            this.leftTrackBox.MaximumSize = new System.Drawing.Size(20, 0);
            this.leftTrackBox.MinimumSize = new System.Drawing.Size(20, 250);
            this.leftTrackBox.Name = "leftTrackBox";
            this.leftTrackBox.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.leftTrackBox.Size = new System.Drawing.Size(20, 250);
            this.leftTrackBox.TabIndex = 1;
            this.leftTrackBox.Title = "";
            this.leftTrackBox.Value = 0;
            this.leftTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // topTrackBox
            // 
            this.topTrackBox.Location = new System.Drawing.Point(6, 23);
            this.topTrackBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.topTrackBox.MinimumSize = new System.Drawing.Size(250, 20);
            this.topTrackBox.Name = "topTrackBox";
            this.topTrackBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.topTrackBox.Size = new System.Drawing.Size(250, 20);
            this.topTrackBox.TabIndex = 0;
            this.topTrackBox.Title = "";
            this.topTrackBox.Value = 0;
            this.topTrackBox.ValueChanged += new System.EventHandler(this.TrackBox_valueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 380);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "批量图片边框裁剪工具";
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

