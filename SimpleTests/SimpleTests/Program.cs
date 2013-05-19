using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleTests
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = @"07/14/2007";
            //string pattern = @"(-)|(/)";
            //Regex regex = new Regex(pattern);
            //foreach (string result in regex.Split(input, 2))
            //{
            //    Console.WriteLine("'{0}'", result);
            //}




            //string pattern = @"0_æ92081004";
            //Regex rgx = new Regex(pattern);
            //string input = "6307100_æ920810041910911143109111431055352083630020812_";

            //string[] result = rgx.Split(input, 3);
            //for (int ctr = 0; ctr < result.Length; ctr++)
            //{
            //    Console.Write("'{0}'", result[ctr]);
            //    if (ctr < result.Length - 1)
            //        Console.Write(", ");
            //}
            //Console.WriteLine();


            TestClass method = new TestClass();


            //string[] stringArray = method.SpliceText("19109111431055352083630020812_", 10);
            //foreach (var s in stringArray)
            //{
            //    Console.WriteLine(s);
            //}


            ////string lastChar = method.ReturnLastCharInString("ABCD");
            ////Console.WriteLine(lastChar);




            //string[] split = method.StringSplitter("6307100_æ920810041910911143109111431055352083630020812_");
            //split = method.SpliceText(split[1], 10);

            //foreach (var s in split)
            //{
            //    Console.WriteLine(s);
            //}

            string cpr = method.CprnrReturn("6307100_æ920810041910911143109111431055352083630020812_");
            Console.WriteLine(cpr);

            Console.ReadLine();
        }
    }

    public class TestClass
    {
        public string ReturnLastCharInString(string tekstStreng)
        {
            string output;
            output = tekstStreng.Substring(tekstStreng.Length - 1, 1);

            return output;
        }


        public string CprnrReturn(string tekstStreng)
        {
            string output;
            output = tekstStreng.Substring(17, 10);

            return output;
        }

        public string[] StringSplitter(string input)
        {
            string[] parts1 = input.Split(new string[] { "0_æ92081004" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(input, @"0_æ92081004");

            return parts2;
        }

        public string[] SpliceText(string text, int lineLength)
        {
            return Regex.Matches(text, ".{1," + lineLength + "}").Cast<Match>().Select(m => m.Value).ToArray();
        }
    }

}
