using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Lanucher
{
    class Program
    {
        static void Main(string[] args)
        {
            string sfile = "";
            if (args.Length < 1)
            {
                Console.WriteLine("请输入文件路径：");
                sfile = Console.ReadLine();
            }
            else
            {
                sfile = args[1];
            }
            using(StreamReader sr = new StreamReader(sfile))
            {
                while (sr.Peek() >= 0)
                {
                    string sLine = sr.ReadLine();
                    string[] sInfo = sLine.Replace("，", ",").Split(',');
                    Process.Start("xsxk.exe", sInfo[0] + " " + sInfo[1] + " " + sInfo[2].Replace("|", ","));
                }
            }
         }
    }
}
