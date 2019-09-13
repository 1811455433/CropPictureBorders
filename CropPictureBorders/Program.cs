using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CropPictureBorders
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // 当拖动文件或者文件夹到此程序以打开程序时，args是拖动文件的绝对路径的集合

            // 如果是双击打开程序
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                // 如果是拖动文件或者文件夹打开程序
                foreach(string path in args)
                {
                    try
                    {
                        new Thread(new ParameterizedThreadStart(CropImageAndSaveAs)).Start(path);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// 剪切图片并另存
        /// </summary>
        /// <param name="path">图片路径</param>
        private static void CropImageAndSaveAs(object path)
        {
            string filePath = (string)path;
            Image result = Image.FromStream(File.OpenRead(filePath));
            int x = Properties.Settings.Default.leftValue;
            int y = Properties.Settings.Default.topValue;
            int width = result.Width - x - Properties.Settings.Default.rightValue;
            int height = result.Height - y - Properties.Settings.Default.bottomValue; ;
            result = ImageHelper.CutPicture(result, x, y, width, height);
            result.Save(GetSuitablePath(filePath));
            result.Dispose();
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

    }
}
