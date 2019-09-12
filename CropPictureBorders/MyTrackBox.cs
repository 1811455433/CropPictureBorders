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
            this.lbUnit.Text = this.trackBar1.Value + " 像素";
        }


    }
}
