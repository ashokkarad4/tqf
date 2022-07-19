using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class FrqDuolelements
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 2, 4, 5, 1, 8, 7 };
            for(int i=0;i<arr.Length;i++)
            {
                int count = 0;
                bool isVisit = false;
                for(int j=i-1;j>=0;j--)

                {
                    if(arr[i]==arr[j])
                    {
                        isVisit = true;
                        break;
                    }
                }
                if (isVisit = false)
                {

                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(arr[i] + " " + count);
                    }
                }
              
            }
        }
    }
}
