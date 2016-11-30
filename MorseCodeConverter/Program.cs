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
            //var allcode = new List<Morse>();
            var CodeToLetter = File.ReadLines(filePath).Select(line => line.Split(',')).ToDictionary(data => data[0], data => data[1]);
            foreach (var item in CodeToLetter)
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
            Console.ReadLine();
            Console.WriteLine($"Hello user, would you like to practice morse code?\nPlease give me a letter or sentence and I'll give you each letter translated into morse code!");
            var input = Console.ReadLine();
            input = input.ToUpper();

            // Loop through all the characters in the string 'input'
            // for each character
            //   lookup that character in CodeToLetter
            //   print whatever we find from that lookup
            foreach (char item in input)
            {
                var itemStr = item.ToString();
                var morse = CodeToLetter[itemStr];
                Console.WriteLine(morse);
            }
            Console.ReadLine();
        }
    }
}
