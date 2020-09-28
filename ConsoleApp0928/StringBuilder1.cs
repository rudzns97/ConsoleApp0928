using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class StringBuilder1
    {
        static void Main()
        {
            DateTime dtStart = DateTime.Now;
            //string txt = "Hello World";
            //for(int i=0; i < 3000; i++)
            //{
            //    txt += i;
            //}
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World");
            for (int i = 0; i < 3000; i++)
            {
                sb.Append(i);
            }



            DateTime dtEnd = DateTime.Now;
            double interval = (dtEnd - dtStart).TotalSeconds;

            Console.WriteLine(interval);
            //=====================================================
            sb.Clear(); //전체를 삭제할 때 사용
            sb.Remove(0,sb.Length); //일부분을 삭제할 때 사용
            string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
            string str = string.Empty;
            foreach(string temp in days)
            {
                sb.Append(temp + ',');
            }
            Console.WriteLine(sb.ToString().TrimEnd(','));
            Console.WriteLine(sb.Remove(sb.Length-1,1));

            int k = 10;
            Console.WriteLine(k);
            Console.WriteLine(k.ToString());
        }
    }
}
