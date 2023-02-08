using System;

namespace _06022023task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = { "Murad Ibrahimov", "Araz Huseynov", "Ayxan Ezimli", "Elgun Ceferli" };
            string opt;
            do
            {
                Console.WriteLine("\n1. Butub telebelere bax");
                Console.WriteLine("2. Yeni telebeler elave");
                Console.WriteLine("3. Telebelere uzre axtaris et");
                Console.WriteLine("4. Telebelerin adlarina bax");
                Console.WriteLine("5. Siyahida adin olub olmadigina bax");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "0":
                        Console.WriteLine("Menudan cix");
                        break;
                    case "1":
                        Console.WriteLine("Telebe elave et");
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":

                        string studentFullName;
                        do
                        {
                            Console.WriteLine("Telebe ad soyadi:");
                            studentFullName = Console.ReadLine();
                        } while (studentFullName.Length < 3);

                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = ToCapitalize(studentFullName.Trim());
                        break;
                    case "3":
                        Console.WriteLine("Axtaris deyeri:");
                        string search = Console.ReadLine();

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].Contains(search, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(students[i]);
                            }
                        }
                        break;
                    case "4":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i].Substring(0, students[i].IndexOf(' ')));
                        }
                        break;
                    case "5":
                        Console.WriteLine("Soyad sonlugunu daxil edin");
                        string surnameEnding = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].EndsWith(surnameEnding))
                                Console.WriteLine(students[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt != "0");
        }
        static string ToCapitalize(string fullname)
        {
            var arr = fullname.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                var word = arr[i];

                if (word != "")
                {
                    arr[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
            }

            return String.Join(' ', arr);

        }
    }
}
