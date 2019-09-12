using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CropPictureBorders
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        private string picturePath;

        /// <summary>
        /// 处理后的图片
        /// </summary>
        private Image result;
        public MainForm(params string[] args)
        {
            InitializeComponent();
            LoadDefaultSetting();
            StringBuilder builder = new StringBuilder();
            foreach (string s in args)
            {
                builder.Append(s).Append("\n");
            }
        }

        /// <summary>
        /// 加载默认设置
        /// </summary>
        private void LoadDefaultSetting()
        {
            this.topTrackBox.Value = Properties.Settings.Default.topValue;
            this.bottomTrackBox.Value = Properties.Settings.Default.bottomValue;
            this.leftTrackBox.Value = Properties.Settings.Default.leftValue;
            this.rightTrackBox.Value = Properties.Settings.Default.rightValue;
        }

        private void TopTrackBox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void SaveAsDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.topValue = this.topTrackBox.Value;
            Properties.Settings.Default.bottomValue = this.bottomTrackBox.Value;
            Properties.Settings.Default.leftValue = this.leftTrackBox.Value;
            Properties.Settings.Default.rightValue = this.rightTrackBox.Value;
            Properties.Settings.Default.Save();
            this.saveAsDefault.Enabled = false;
        }

        /// <summary>
        /// 填充预览的图片
        /// </summary>
        private void Preview()
        {
            try
            {
                this.result = Image.FromStream(File.OpenRead(picturePath));
                int x = this.leftTrackBox.Value;
                int y = this.topTrackBox.Value;
                int width = this.result.Width - x - this.rightTrackBox.Value;
                int height =this.result.Height - y - this.bottomTrackBox.Value;
                this.result = ImageHelper.CutPicture(this.result, x, y, width, height);
                this.pbAfter.Image = ImageHelper.CropPicture(this.result);
                this.btnSaveResult.Enabled = true;
            }
            catch {}
        }


        private void PbBefore_DragEnter(object sender, DragEventArgs e)
        {
            //判断该文件是否可以转换到文件放置格式
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;    //放置效果为链接放置
            }
            else
            {
                e.Effect = DragDropEffects.None;    //不接受该数据,无法放置，后续事件也无法触发
            }
        }

        /// <summary>
        /// 滑块值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBox_valueChanged(object sender, EventArgs e)
        {
            this.saveAsDefault.Enabled = true;
            Preview();
        }

        private void PbBefore_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();     //获取文件路径
            this.picturePath = path;
            Preview();
            this.pbBefore.Image = ImageHelper.CropPicture(path);
            Debug.WriteLine("拖动到控件上的文件路径为" + path);
        }

        private void BtnPreviewResult_Click(object sender, EventArgs e)
        {
            Preview();
        }

        private void BtnSaveResult_Click(object sender, EventArgs e)
        {
            this.result.Save(GetSuitablePath(this.picturePath));
            this.btnSaveResult.Enabled = false;
        }

        /// <summary>
        /// 获得合适的路径
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static string GetSuitablePath(string path)
        {
            string directoryName = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            string newPath;
            int i = 1;
            do
            {
                newPath = Path.Combine(directoryName, $"{fileName}({i}){extension}");
                i++;

                // 如果文件不存在，则为合适的文件路径
            } while (File.Exists(newPath));

            return newPath;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //调用系统默认的浏览器 
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/1811455433/CropPictureBorders");
        }
    }
}
