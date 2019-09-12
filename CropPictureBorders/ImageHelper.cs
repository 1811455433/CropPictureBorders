using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace CropPictureBorders
{
    /*  图片坐标方式
    0-------------------x
    |
    |
    |
    |
    |
    |
    |
    y
    */

    /*  裁剪方式
     ********************                    ******         ******
     ********************                    ******         ******
     ********************                    ******         ******                       ************
     ********************      取四个角                                拼接四张图片        ************
     ******************** ================>                         ================>    ************
     ********************                                                                ************
     ********************                    ******         ******                       ************
     ********************                    ******         ******                       ************
     ********************                    ******         ******
             ||
           多||
           步||
           处||
           理||
             ||
     ************
     ************
     ************
     ************
     ************
     ************
    */





    /// <summary>
    /// 处理图片的工具类
    /// </summary>
    public static class ImageHelper
    {
        /// <summary>
        /// 获取按照需要裁剪后的图片
        /// </summary>
        /// <param name="path">原图片的路径</param>
        /// <returns></returns>
        public static Image CropPicture(string path)
        {
            // 打开图片
            Image image = Image.FromStream(File.OpenRead(path));

            return CropPicture(image);
        }
        
        /// <summary>
        /// 获取按照需要裁剪后的图片
        /// </summary>
        /// <param name="image">原图片</param>
        /// <returns></returns>
        public static Image CropPicture(Image image)
        {
            // 如果图片比较小，就不裁剪
            if (image.Width <= 300 || image.Height <= 300)
            {
                return image;
            }

            int width = 90, height = 90;  //截取的每小块图片的宽和高
            // 1. 获取左上100*100像素的图片
            Image leftTopImage = CutPicture(image, 0, 0, width, height);

            // 2. 获取右上100*100像素的图片
            Image rightTopImage = CutPicture(image, image.Width - width, 0, width, height);

            // 3. 获取左下100*100像素的图片
            Image leftBottomImage = CutPicture(image, 0, image.Height - height, width, height);

            // 4. 获取右下100*100像素的图片
            Image rightBottomImage = CutPicture(image, image.Width - width, image.Height - height, width, height);

            // 5. 拼接左上和右上图片，得到上半部分图片
            Image topImage = JoinImage(20, JoinMode.Horizontal, leftTopImage, rightTopImage);
            leftTopImage.Dispose();         rightTopImage.Dispose();

            // 6. 拼接左下和右下图片，得到下半部分图片
            Image bottomImage = JoinImage(20, JoinMode.Horizontal, leftBottomImage, rightBottomImage);
            leftBottomImage.Dispose();      rightBottomImage.Dispose();

            // 7. 拼接上半部分图片和下半部分图片，得到最终裁剪的结果
            return JoinImage(20, JoinMode.Vertical, topImage, bottomImage);
        }

        /// <summary>
        /// 图片裁剪，生成新图，保存在同一目录下,名字加_new，格式1.png  新图1_new.png
        /// </summary>
        /// <param name="image">要修改的图片</param>
        /// <param name="x">修改起点x坐标</param>
        /// <param name="y">修改起点y坐标</param>
        /// <param name="width">新图宽度</param>
        /// <param name="height">新图高度</param>
        public static Image CutPicture(Image image, int x, int y, int width, int height)
        {
            //定义截取矩形
            System.Drawing.Rectangle cropArea = new System.Drawing.Rectangle(x, y, width, height);

            //判断超出的位置否
            if ((image.Width < x + width) || image.Height < y + height)
            {
                image.Dispose();
                string errorMessage = "裁剪尺寸超出原有尺寸！";
                int horizontal = image.Width - x - width;
                int vertical = image.Height - y - height;
                // 判断是否是超出图片的宽度
                if(horizontal < 0)
                {
                    errorMessage += $"  宽度超出{-horizontal}!";
                }
                if(vertical < 0)
                {
                    errorMessage += $"  高度超出{-vertical}!";
                }
                throw new Exception(errorMessage);
            }

            //定义Bitmap对象
            System.Drawing.Bitmap bmpImage = new System.Drawing.Bitmap(image);

            //进行裁剪
            System.Drawing.Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            return bmpCrop;
        }

        /// <summary>
        /// 拼接图片
        /// </summary>
        /// <param name="mode">拼接方式</param>
        /// <param name="images">图片数组</param>
        /// <returns></returns>
        private static Image JoinImage(JoinMode mode, params Image[] images)
        {
            // 如果是0张或者1张图片，返回其本身
            if (images.Length <= 1)
                return images[0];

            if (mode == JoinMode.Horizontal)
            {
                //横向拼接
                int width = 0;
                //计算总长度
                foreach (Image i in images)
                {
                    width += i.Width;
                }
                //高度不变
                int height = images.Max(x => x.Height);
                //构造最终的图片白板
                Bitmap tableChartImage = new Bitmap(width, height);
                Graphics graph = Graphics.FromImage(tableChartImage);
                //初始化这个大图
                graph.DrawImage(tableChartImage, width, height);
                //初始化当前宽
                int currentWidth = 0;
                foreach (Image i in images)
                {
                    //拼图
                    graph.DrawImage(i, currentWidth, 0);
                    //拼接改图后，当前宽度
                    currentWidth += i.Width;
                }
                return tableChartImage;
            }
            else if (mode == JoinMode.Vertical)
            {
                //纵向拼接
                int height = 0;
                //计算总长度
                foreach (Image i in images)
                {
                    height += i.Height;
                }
                //宽度不变
                int width = images.Max(x => x.Width);
                //构造最终的图片白板
                Bitmap tableChartImage = new Bitmap(width, height);
                Graphics graph = Graphics.FromImage(tableChartImage);
                //初始化这个大图
                graph.DrawImage(tableChartImage, width, height);
                //初始化当前宽
                int currentHeight = 0;
                foreach (Image i in images)
                {
                    //拼图
                    graph.DrawImage(i, 0, currentHeight);
                    //拼接改图后，当前宽度
                    currentHeight += i.Height;
                }
                return tableChartImage;
            }

            return null;
        }
        
        /// <summary>
        /// 拼接图片
        /// </summary>
        /// <param name="lineWidth">拼接两张图片连接处的间隔宽度</param>
        /// <param name="mode">拼接方式</param>
        /// <param name="images">图片数组</param>
        /// <returns></returns>
        private static Image JoinImage(int lineWidth, JoinMode mode, params Image[] images)
        {
            // 如果是0张或者1张图片，返回其本身
            if (images.Length <= 1)
                return images[0];

            if (mode == JoinMode.Horizontal)
            {
                //横向拼接
                int width = lineWidth;
                //计算总长度
                foreach (Image i in images)
                {
                    width += i.Width;
                }
                //高度不变
                int height = images.Max(x => x.Height);
                //构造最终的图片白板
                Bitmap tableChartImage = new Bitmap(width, height);
                Graphics graph = Graphics.FromImage(tableChartImage);
                //初始化这个大图
                graph.DrawImage(tableChartImage, width, height);
                //初始化当前宽
                int currentWidth = 0;
                foreach (Image i in images)
                {
                    //拼图
                    graph.DrawImage(i, currentWidth, 0);
                    //拼接改图后，当前宽度
                    currentWidth += i.Width;
                    if(i != images[images.Length - 1])
                    {
                        // 添加空白的间隔块
                        graph.DrawImage(new Bitmap(lineWidth, height), currentWidth, 0);
                        currentWidth += lineWidth;
                    }
                }
                return tableChartImage;
            }
            else if (mode == JoinMode.Vertical)
            {
                //纵向拼接
                int height = lineWidth;
                //计算总长度
                foreach (Image i in images)
                {
                    height += i.Height;
                }
                //宽度不变
                int width = images.Max(x => x.Width);
                //构造最终的图片白板
                Bitmap tableChartImage = new Bitmap(width, height);
                Graphics graph = Graphics.FromImage(tableChartImage);
                //初始化这个大图
                graph.DrawImage(tableChartImage, width, height);
                //初始化当前宽
                int currentHeight = 0;
                foreach (Image i in images)
                {
                    //拼图
                    graph.DrawImage(i, 0, currentHeight);
                    //拼接改图后，当前宽度
                    currentHeight += i.Height;
                    if (i != images[images.Length - 1])
                    {
                        // 添加空白的间隔块
                        graph.DrawImage(new Bitmap(lineWidth, height), 0, currentHeight);
                        currentHeight += lineWidth;
                    }
                }
                return tableChartImage;
            }

            return null;
        }

        /// <summary>
        /// 图片拼接的方式
        /// </summary>
        private enum JoinMode
        {
            /// <summary>
            /// 横向拼接
            /// </summary>
            Horizontal,

            /// <summary>
            /// 纵向拼接
            /// </summary>
            Vertical
        }
    }
}
