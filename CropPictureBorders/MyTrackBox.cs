using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CropPictureBorders
{

    public partial class MyTrackBox : UserControl
    {
        /// <summary>
        /// 控件的方向
        /// </summary>
        public Orientation Orientation
        {
            get
            {
                return this.trackBar1.Orientation;
            }
            set
            {
                // 默认是水平的，如果值改变了而且不是水平的，则调整控件
                if(value != this.trackBar1.Orientation && value != Orientation.Horizontal)
                {
                    // 
                    // trackBar1
                    // 
                    this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                    this.trackBar1.LargeChange = 2;
                    this.trackBar1.Location = new System.Drawing.Point(0, 15);
                    this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
                    this.trackBar1.Size = new System.Drawing.Size(20, 220);
                    // 
                    // lbTitle
                    // 
                    this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
                    this.lbTitle.Location = new System.Drawing.Point(0, 238);
                    this.lbTitle.Size = new System.Drawing.Size(17, 12);
                    // 
                    // lbUnit
                    // 
                    this.lbUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
                    this.lbUnit.Location = new System.Drawing.Point(3, 0);
                    this.lbUnit.Size = new System.Drawing.Size(17, 12);
                    this.lbUnit.Text = "0";
                    // 
                    // MyTrackBoxV
                    // 
                    this.MaximumSize = new System.Drawing.Size(20, 0);
                    this.MinimumSize = new System.Drawing.Size(20, 250);
                    this.Size = new System.Drawing.Size(20, 250);
                }
            }
        }

        /// <summary>
        /// 滑块的标题
        /// </summary>
        public string Title
        {
            get
            {
                return this.lbTitle.Text;
            }
            set
            {
                this.lbTitle.Text = value;
            }
        }

        /// <summary>
        /// 滑块的值
        /// </summary>
        public int Value
        {
            get
            {
                return this.trackBar1.Value;
            }
            set
            {
                this.trackBar1.Value = value;
            }
        }

        /// <summary>
        /// 滑块值改变后的调用此函数
        /// </summary>
        public event EventHandler ValueChanged
        {
            add
            {
                this.trackBar1.ValueChanged += value;
            }
            remove
            {
                this.trackBar1.ValueChanged -= value;
            }
        }

        public MyTrackBox()
        {
            InitializeComponent();
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.lbUnit.Text = this.trackBar1.Value + (this.Orientation == Orientation.Vertical ? "" : " 像素");
        }
    }
}
