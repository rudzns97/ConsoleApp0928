using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class Encoding1
    {
        static void Main()
        {
            string str = "Hello 안녕";
            Console.WriteLine("기본문장 : " + str);

            //UTF-8 형식으로 인코딩한 배열로 변환
            byte[] result = Encoding.UTF8.GetBytes(str);
            PrintByteArray(result);
            Console.WriteLine(Encoding.UTF8.GetString(result));

            byte[] result2 = Encoding.Unicode.GetBytes(str);
            PrintByteArray(result2);
            Console.WriteLine(Encoding.Unicode.GetString(result2));

        }

        private static void PrintByteArray(byte[] result)
        {
            foreach (byte b in result)
            {
                Console.Write($"{b},");
            }
            Console.WriteLine();
        }
    }
}
