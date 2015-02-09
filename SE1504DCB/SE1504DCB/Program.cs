using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                //處理未捕獲的異常
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //處理UI線程異常
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //處理非UI線程異常
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                string str = "";
                string strDateInfo = "出現應用程序未處理的異常：" + DateTime.Now.ToString() + "\r\n";

                if (ex != null)
                {
                    str = string.Format(strDateInfo + "異常類型：{0}\r\n異常消息：{1}\r\n異常信息：{2}\r\n",
                         ex.GetType().Name, ex.Message, ex.StackTrace);
                }
                else
                {
                    str = string.Format("應用程序線程錯誤:{0}", ex);
                }
                writeLog(str);
                MessageBox.Show("發生致命錯誤，請及時聯繫作者！", "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///這就是我們要在發生未處理異常時處理的方法，我這是寫出錯詳細信息到文本，如出錯後彈出一個漂亮的出錯提示窗體，給大家做個參考
        ///做法很多，可以是把出錯詳細信息記錄到文本、數據庫，發送出錯郵件到作者信箱或出錯後重新初始化等等
        ///這就是仁者見仁智者見智，大家自己做了。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "出現應用程序未處理的異常：" + DateTime.Now.ToString() + "\r\n";
            Exception error = e.Exception as Exception;
            if (error != null)
            {
                str = string.Format(strDateInfo + "異常類型：{0}\r\n異常消息：{1}\r\n異常信息：{2}\r\n",
                     error.GetType().Name, error.Message, error.StackTrace);
            }
            else
            {
                str = string.Format("應用程序線程錯誤:{0}", e);
            }

            writeLog(str);
            MessageBox.Show("發生致命錯誤，請及時聯繫作者！", "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            Exception error = e.ExceptionObject as Exception;
            string strDateInfo = "出現應用程序未處理的異常：" + DateTime.Now.ToString() + "\r\n";
            if (error != null)
            {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆棧信息:{1}", error.Message, error.StackTrace);
            }
            else
            {
                str = string.Format("Application UnhandledError:{0}", e);
            }

            writeLog(str);
            MessageBox.Show("發生致命錯誤，請停止當前操作並及時聯繫作者！", "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 寫文件
        /// </summary>
        /// <param name="str"></param>
        private static void writeLog(string str)
        {
            if (!Directory.Exists("ErrLog"))
            {
                Directory.CreateDirectory("ErrLog");
            }
            using (StreamWriter sw = new StreamWriter(@"ErrLog\ErrLog.txt", true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }
    }
}