using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;

namespace forSBItrade
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string line = "";
                List<string> list = new List<string>();
                StreamReader sr = new StreamReader(@"config.txt", Encoding.GetEncoding("shift_jis"));
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }

                sr.Close();

                Clipboard.SetDataObject(list[1], true);
                Process.Start(list[0]);
            }
            catch
            {
                Console.WriteLine("例外が発生しました．\n");
                Console.WriteLine("config.txtの1行目にファイルのパス，2行目にパスワードを入力して保存してください．\n");
                Console.WriteLine("Enterで終了します．\n");
                Console.ReadLine();
                //閉じないようにする処理
            }

            
            
        }
    }
}
