using System;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullnames = { "Hikmet Abbasov", "Nermin Abbasli", "Elmar Qarayev", "Anar ismayilzade", "Nurlan Nuruzade" };
            byte[] ages = { 25, 35, 6, 20, 20 };
            string opt;
            do
            {
                Console.WriteLine("\n=========== Menu ==========");
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Secilmis teebeye bax");
                Console.WriteLine("3. Telebe adini deyis");
                Console.WriteLine("4. Yeni telebe elave et");
                Console.WriteLine("0. Cix");

                Console.Write("Emeliyyat secin: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n=========== Telebeler ==========");
                        ShowAllStudents(fullnames, ages);
                        break;
                    case "2":
                        Console.WriteLine("\nIndexi daxil et");
                        string indexStr = Console.ReadLine();
                        try
                        {
                            int index = Convert.ToInt32(indexStr);
                            Console.WriteLine($"fullname: {fullnames[index]} - age: {ages[index]}");
                        }
                        catch
                        {
                            Console.WriteLine("Xeta bas verdi!");
                        }
                        break;
                    case "3":
                        bool hasProblem;
                        Console.WriteLine("\n=========== Telebeler ==========");
                        ShowAllStudents(fullnames,ages);
                        do
                        {
                            hasProblem = false;
                            try
                            {
                                EditStudent(fullnames);
                            }
                            catch
                            {
                                Console.WriteLine("Xeta bas verdi!");
                                hasProblem= true;
                            }
                        }
                        while (hasProblem);
                        break;
                    case "4":

                        Console.WriteLine("\n=========== Yeni telebe ==========");
                        Console.Write("Fullname: ");
                        string fullname = Console.ReadLine();

                        Console.Write("Age: ");
                        string ageStr = Console.ReadLine();
                        byte age = Convert.ToByte(ageStr);

                        AddElement(ref fullnames, fullname);
                        AddElement(ref ages, age);
                        break;
                    default:
                        Console.WriteLine("Yanlis emeliyyat!");
                        break;
                }
            }
            while (opt != "0");
        }

        static void ShowAllStudents(string[] arr, byte[] ages)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"{i}.{arr[i]} - {ages[i]}");
        }

        static void EditStudent(string[] students)
        {
            Console.Write("Telebeni secin: ");
            string indexStr = Console.ReadLine();

            int index = Convert.ToInt32(indexStr);
            Console.Write("Yeni daxi daxil edin: ");
            students[index] = Console.ReadLine();
        }

        static void AddElement(ref string[] arr, string elem)
        {
            string[] newArr = new string[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = elem;
            arr = newArr;
        }

        static void AddElement(ref byte[] arr, byte elem)
        {
            byte[] newArr = new byte[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = elem;
            arr = newArr;
        }
    }

}
