using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MorseCodeConverter
{



    class Program
    {
        //public bool query()
        //{
        //    bool wanttolearn = false;
        //    string wanttotype = Console.ReadLine().ToUpper();
        //    if (wanttotype == "y") { wanttolearn = true; }
        //    if (wanttotype == "n") { wanttolearn = false; }
        //    return wanttolearn;

        //}
        static void Main(string[] args)
        {

            var filePath = "Morse.csv";
            var usersPath = "UsersInput.csv";
            var lettertoCode = File.ReadLines(filePath).Select(line => line.Split(',')).ToDictionary(data => data[0], data => data[1]);
            var usersInputKey = new List<string>();
            var usersInputValue = new List<string>();
            string morse = string.Empty;
            bool wantToLearn = false;


            Console.WriteLine($"Hello user, would you like to practice morse code? Y for yes, N for no.");
            string wantToType = Console.ReadLine().ToUpper();
            if (wantToType == "Y") { wantToLearn = true; }
            if (wantToType == "N") { wantToLearn = false; }

            while (wantToLearn == true)
            {
                Console.WriteLine("Please give me a letter or sentence and I'll give you each letter translated into morse code!");
                var input = Console.ReadLine().ToUpper();
                foreach (char item in input)
                {
                    var itemString = item.ToString();
                    morse = lettertoCode[itemString];
                    Console.WriteLine(morse);
                    usersInputKey.Add(itemString);
                    usersInputValue.Add(morse);
                }
                using (StreamWriter sw = new StreamWriter(usersPath))
                {
                    foreach (var item in usersInputKey)
                    {
                        sw.WriteLine($"{item}, {lettertoCode[item]}");
                    }
                }
                Console.WriteLine("Would you like to translate something else?");
                wantToType = Console.ReadLine().ToUpper();
                if (wantToType == "Y") { wantToLearn = true; }
                if (wantToType == "N") { wantToLearn = false; }
            }
        }
    }
}
