using System;
using System.Buffers;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Pow(ref num);

            Console.WriteLine(num);

            int[] nums = { 3, 6, 70 };
            Pow(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            string text = "  salam   ncesen  ?";
            RemoveSpace(ref text);
            Console.WriteLine(text);

            int[] arr = { 10, 20, 30 };
            AddArr(ref arr, 40);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
        static void Pow(ref int num)
        {
            num *= num;
        }
        static void Pow(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }
        }

        //Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod

        static void RemoveSpace( ref string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') newStr += str[i];
            }

            str = newStr;
        }

        //Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod
        static void AddArr(ref int[] arr,int elem)
        {
            int[] newArr = new int[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = elem;
            arr = newArr;
        }



    }
}
