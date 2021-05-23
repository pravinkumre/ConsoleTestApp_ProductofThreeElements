using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
			
			/// Prduct of max three numbers
            // int[] input = new int[] { 6, 1, 4, 5, 0, 1, 8 }; // 8,6,5 = 240
            int[] input = new int[] { 7, 1, 4, 5, 0, 1, 8, 9, 5,10 }; // 10,9,8 = 720
            int fstMax = 0, scndMax = 0, thrdMax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > fstMax)
                {
                    thrdMax = scndMax;
                    scndMax = fstMax;
                    fstMax = input[i];
                }
                else if (input[i] > scndMax)
                {
                    thrdMax = scndMax;
                    scndMax = input[i];
                }
            }

            Console.Write("o/p : " + fstMax * scndMax * thrdMax);
			

            // 1.Input: aaabbcca Output: a3b2c2a1

            //2.String reverse by special character intact:
            // Input: 	ad&g%dj$$cqa
            //Output: aq&c%jd$$gda


            string str = "ad&g%dj$$cqa";
            char[] specialCharArr = new char[] { '&', '%', '$' };

            char[] tempArr = str.ToCharArray();

            for (int i = 0; i < tempArr.Length; i++)
            {
                if (!specialCharArr.Contains(tempArr[i]))
                    tempArr[i] = '0';
            }    

            for (int j = str.Length-1; j >= 0; j--)
            {
                for (int i = 0; i < tempArr.Length; i++)
                {
                    if (tempArr[i].Equals('0') && !specialCharArr.Contains(str[j]))
                    {
                        tempArr[i] = str[j];
                        break;
                    }
                    else
                        continue;
                }
            }

            string tempStr = new string(tempArr);

            Console.Write("Output : " + tempStr);

            //string str = "aaabbcca";
            //StringBuilder sb = new StringBuilder();
            //int tempCount = 1;
            //for (int i = 0; i < str.Length; i++)
            //{

            //    if (i + 1 == str.Length)
            //    {
            //        sb.Append(str[i].ToString() + tempCount);
            //        break;
            //    }

            //    if (str[i] == str[i + 1])
            //        tempCount++;
            //    else
            //    {
            //        sb.Append(str[i].ToString() + tempCount);
            //        tempCount = 1;
            //    }
            //}

            //Console.Write("Output : " + sb);
            Console.ReadKey();
        }
    }
}
