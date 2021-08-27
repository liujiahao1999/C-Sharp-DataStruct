using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    class Bubble
    {
        static void Main(string[] args)
        {
            int[] nums= new int[] {10,9,8,7,6,5,4,3,2,1};
            Console.WriteLine("Before Sorting : ");
            Print(nums);
            Sort(nums);
            Console.WriteLine("After Sorting : ");
            Print(nums);
            Console.ReadKey();
        }

        public static void Sort(int[] nums)
        {
            for (int i = nums.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    //比较相邻两个变量，交换位置sadasdasdas
                    if (nums[j]>nums[j+1])
                    {
                        Exchange(nums,j,j+1);
                    }
                }
            }
        }

        public static void Exchange(int[] a, int i, int j)
        {
            int temp = a[j];
            a[j] = a[i];
            a[i] = temp;
        }

        public static void Print(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                Console.Write(nums[i]+",");
            }
            Console.WriteLine(nums[nums.Length-1]);
        }
    }
}
