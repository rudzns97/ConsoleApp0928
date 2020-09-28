using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class FileInfo1
    {
        static void Main()
        {
            string from = "ConsoleApp0928.exe.config";
            string to = "myConfig.txt";

            FileInfo fromFile = new FileInfo(from);

            if (fromFile.Exists)
            {
                FileInfo toFile = fromFile.CopyTo(to, true);

                string to2222 = "C:/Temp3/MyForder/myConfig_33333.txt";
                if(!Directory.Exists("C:/Temp3/MyFolder"))
                {
                    Directory.Delete("C:/Temp3/MyForder", true);
                }
                foreach(string item in Directory.GetFiles("./"))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
