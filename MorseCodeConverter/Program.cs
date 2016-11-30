using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MorseCodeConverter
{
    //class Morse
    //{
    //    //public string Code { get; set; }
    //    //public string Letter { get; set; }
    //    //public override string ToString()
    //    //{
    //    //    return $"{Letter}, {Code}";
    //    //}

    //   new Dictionary<char, string>(); 
    //}

    class Program
    {
        static void Main(string[] args)
        {

            var filePath = "Morse.csv";
            var usersPath = "UsersInput.csv";
            //var allcode = new List<Morse>();
            var lettertoCode = File.ReadLines(filePath).Select(line => line.Split(',')).ToDictionary(data => data[0], data => data[1]);
            var usersInput = new Dictionary<string, string>();
            string morse = string.Empty;
            bool wantToLearn = false;
            foreach (var item in lettertoCode)
            {
                Console.WriteLine(item);
            }
            //using (var sr = new StreamReader(filePath))
            //{
            //    while (sr.Peek() > 0)
            //    {
            //        var line = sr.ReadLine().Split(',');
            //        //var letter = line[0];
            //        //var code = line[1];
            //        //var temp1 = new string { letter };
            //        //var temp2 = new string { code };
            //        //dictionary.Add(temp1, temp2);
            //    }

            //var character = "R";
            //var morse = CodeToLetter[character];
            //Console.WriteLine(morse);

            //}
            Console.WriteLine($"Hello user, would you like to practice morse code?");
            // Loop through all the characters in the string 'input'
            // for each character
            //   lookup that character in CodeToLetter
            //   print whatever we find from that lookup
            while (wantToLearn == true)
            {
                Console.WriteLine("Please give me a letter or sentence and I'll give you each letter translated into morse code!");

            var input = Console.ReadLine().ToUpper();
                foreach (char item in input)
                {
                    var itemString = item.ToString();
                    morse = lettertoCode[itemString];
                    Console.WriteLine(morse);
                    usersInput.Add(itemString, morse);
                }
                using (StreamWriter sw = new StreamWriter(usersPath))
                {
                    foreach (var item in usersInput)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
