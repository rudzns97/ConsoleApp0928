using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
            //days 배열의 내용을 콘솔로 출력
            //for(int i=0; i<days.Length; i++)
            //{
            //    Console.Write(days[i] + " ");
            //}
            //Console.WriteLine();
            //foreach(string temp in days)
            //{
            //    Console.Write(temp + ",");
            //}
            string str = string.Empty;
            
            string result1 = string.Join(",", days);
            Console.WriteLine(result1);
            StringBuilder sb = new StringBuilder();
            sb.Append(days);
            

            string fruits = "딸기, 배, 사과, 포도";
            //좋아하는 과일의 내용을 배열에 저장
            string[] arr = fruits.Split(',');
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
            }
            Console.WriteLine();

            //더하고자 하는 숫자들을 콘솔로 입력받아서
            //합을 구하여 콘솔로 출력
            //ex) 10 50 44 55 24 77 => 320
            //string plus = Console.ReadLine();
            //char[] delimiters = { ',', ' ', '-' };
            //string[] arr1 = plus.Split(delimiters);
            //int result=0;
            //for(int i =0; i < arr1.Length; i++)
            //{
            //    int k = int.Parse(arr1[i]);
            //    result += k; 
            //}
            //Console.WriteLine("전체 합: "+result);

            fruits = "이것이 JAVA다.";
            Console.WriteLine(fruits.Contains("Java"));
            Console.WriteLine(fruits.IndexOf("Java", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(fruits.ToLower().IndexOf("Java".ToLower()));

            for(int k = 1; k < 10; k++)
            {
                //Console.WriteLine("5 * {0} = {1 , 2}", k, 5*k);
                Console.WriteLine($"5 * {k} = {5 * k}");
            }

            Console.WriteLine("날짜 : {0, 20:D}, 판매수량: {1,15:N}", DateTime.Now, 1234567);
        }
    }
}
