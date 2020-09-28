using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class File1
    {
        static void Main()
        {
            string from = "ConsoleApp0928.exe.config";
            string to = "myconfig.txt";

            File.Copy(from, to, true); //파일이 이미 있는 경우, 오류가 발생할 수 있다


            if (File.Exists(from))
            {
                File.Copy(from, to, true);//to 파일이 이미 있는 경우, 오류가 발생할 수 있다.

                string to2222 = "C/Temp2/myConfig_3333.txt";
                if (!Directory.Exists("C:/Temp3/MyFolder"))
                {
                    Directory.CreateDirectory("C:/Temp3/MyFolder");
                }
                File.Move(to, to2222); //원본 파일이 없어진다
            }
        } 
        }
    }

