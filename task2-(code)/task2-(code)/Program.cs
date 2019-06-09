using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2__code_
{
    class Program
    {
        //найти минимальное значение
        static int[] Min(int S,int K)
        {
            int[] min = new int[K];
            int sum = S - 1;
            for(int i = K - 1; i >= 0; i--)
            {
                min[i] = Math.Min(9, sum);
                sum -= min[i];
            }
            min[0]++;
            return min;

        }
        
        //найти максимальное значение
        static int[] Max(int S, int K)
        {
            int[] max = new int[K];
            int sum = S;

            for (int i = 0; i < max.Length; i++)
            {
                max[i] = Math.Min(9, sum);
                sum -= max[i];
            }
            return max;
        }

        //преобразовать массив в строку
        static string InString(int[]arr)
        {
            string str="";
            for(int i = 0; i < arr.Length; i++)
            {
                str = str + arr[i];
            }
            return str;
        }
        static void Main(string[] args)
        {
            //программа решает задачу https://acmp.ru/index.asp?main=task&id_task=301

            int S, K;//сумма и количество цифр
            StreamReader sr = new StreamReader("input.txt");//входной файл
            StreamWriter sw = new StreamWriter("output.txt");//выходной файл

            string[] s = sr.ReadLine().Split();
            S = Convert.ToInt32(s[0]);
            K = Convert.ToInt32(s[1]);

            int[] max = Max(S, K);//набольшее значение
            int[] min = Min(S, K);//наименьшее значение
            
            sw.WriteLine(InString(max) + " " + InString(min));
            sr.Close();
            sw.Close();


        }
    }
}
