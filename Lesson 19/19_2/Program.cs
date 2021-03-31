using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            userStorage.CreateFile("Gmail.txt");
            string[] files = userStorage.GetFileNames("Gmail.txt");

            using (StreamWriter sw = new StreamWriter(files[0], true, Encoding.Default))
             {
                 string[] label = { "gmail.com", "yandex.ru", "ukr.net" };

                 for (int i = 0; i < 1000000; i++)
                 {
                     for (int z = 0; z < 3; z++)
                     {
                         StringBuilder gmail = new StringBuilder($"https://@{label[z]}");
                         gmail.Insert(8, Convert.ToChar(rnd.Next('A', 'Z')))
                                          .Insert(9, Convert.ToByte(rnd.Next('0', '9')))
                                          .Insert(10, Convert.ToChar(rnd.Next('a', 'z')))
                                          .Insert(11, Convert.ToChar(rnd.Next('A', 'Z')))
                                          .Insert(12, Convert.ToByte(rnd.Next('0', '9')));



                         sw.WriteLine(gmail.ToString());
                         Console.WriteLine($"Количество записей = {i}");
                     }
                 }

             }

            
            using (StreamReader sr = new StreamReader(files[0]))
            {

                Regex regexGmail = new Regex(@"gmail", RegexOptions.IgnoreCase);
                MatchCollection arr = regexGmail.Matches(sr.ReadToEnd());
                Console.WriteLine($"Почтовых Ящиков Gmail : {arr.Count}");
            }
            using (StreamReader sr = new StreamReader(files[0]))
            {
                Regex regexUkr = new Regex(@"ukr", RegexOptions.IgnoreCase);
                MatchCollection arr =  regexUkr.Matches(sr.ReadToEnd());           
                Console.WriteLine($"Почтовых Ящиков ukr : {arr.Count}");
            }
            using (StreamReader sr = new StreamReader(files[0]))
            {
                Regex regexYandex = new Regex(@"yandex", RegexOptions.IgnoreCase);
                MatchCollection arr =regexYandex.Matches(sr.ReadToEnd());
                Console.WriteLine($"Почтовых Ящиков Yandex : {arr.Count}");
            }
            Console.Read();
        }
    }
}
