using System;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = new String(new StringBuilder("Hello"));
            String str2 = new String(new StringBuilder("Hello"));
            String str = new String(new StringBuilder("World"));
            String str3 = str1 + 124;
            Console.WriteLine(str.Value);
            Console.WriteLine(str1.Value);
            Console.WriteLine(str2.Value);
            Console.WriteLine(str3.Value);


            string str5 = "some, string! hello, world!..... wow";
            string str4 = "some string hello world wow\n";
            Console.WriteLine(str5.DeletePunctuation());
            Console.WriteLine("Controls: " + str4.IsThereControlChars());


            Console.WriteLine(str1 < str2); 
            Console.WriteLine(str1 > str2);


            String.Production p = new String.Production("BSTU", 0);
            String.Developer d = new String.Developer("Yudina", 1, "Dis");
            
            string text = "Hello, 12345 World!";

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Text without punctuation: " + text.DeletePunctuation());
            Console.WriteLine("Is there any control characters? " + text.IsThereControlChars());
            Console.WriteLine("Sum of numeric values: " + text.Sum());
            Console.WriteLine("Difference between max and min numbers: " + text.DifferenceMaxMin());
            Console.WriteLine("Number of elements: " + text.CountElements());
        }
    }
}