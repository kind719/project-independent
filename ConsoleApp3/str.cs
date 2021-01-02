using System;
using System.Text;

namespace ConsoleApp3
{
    class strmethod
    {

        static void Main(string[] args)
        {
            int[] nave = new int[5];
            Array.Fill<int>(nave, 4,3,2);
            int a = 'C'; // 아스키코드값
            nave[1] = a;

            int i = 0;
            string s = "108";
            bool result = int.TryParse(s, out i); //i now = 108
            
            int result1 = compareStr("102", "100");
            
            string result2 = strconcat("abc", "def", "hij");
            string wow = "The LAST of us";
            string wow2 = "us";
            bool result3 = strcontain(wow,wow2);
            

        }
        static int compareStr(string a, string b)
        {
            int q = int.Parse(a);
            int w = int.Parse(b);
            return q - w;   //compareTo()//CompareTo메서드는 정렬 또는 사전순 정렬 작업에 주로 사용 하도록 디자인 되었습니다.
           //소문자를 앞으로 처줌
        }
        static string strconcat(string a, string b, string c)
        {

            return a + b + c;
        }

        static bool strcontain(string some , string some2)    // 문자열이 다른 문자열에 있는지를 확인하는 함수
        {
            int[] ascii = new int[some.Length];
            int[] ascii2 = new int[some2.Length];
            for (int j = 0; j < some2.Length; j++)
            {
                ascii2[j] = some2[j];

            }
            int index = 0;            
            int count = 0;
            for (int i = 0; i < some.Length; i++)
            {
                ascii[i] = some[i];         
            }
            while ( true )
            {
               if (count < some2.Length)
                {
                    if (ascii2[count] != ascii[index])
                    {
                        index++;
                    }
                    else
                    {                        
                        count++;
                        for (int w =0; w < some2.Length - 1; w++)
                        {
                            index++;
                            if (ascii[index] == ascii2[count])
                            {
                                count++;
                            }
                        }                        
                    }                            
                }
                if (count == some2.Length)
                {
                    break;
                }
            }
            if (count == some2.Length)
            {
                return true;
            }
            if (count < 2)
            {
                return false;
            }
            return false;

        }

        

    }
    
}
    

