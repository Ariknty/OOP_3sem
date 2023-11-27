using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Задание 1");
            Console.WriteLine("\n Типы переменных");
            bool boolVar = false;                          
            byte byteVar = 10;
            sbyte sbyteVar = 20;
            char charVar = 'A';
            decimal decimalVar = 123.456m;
            double doubleVar = 1.23456;
            float floatVar = 3.14f;
            int intVar = -30;
            uint uintVar = 40;
            nint nintVar = 50;
            nuint nuintVar = 60;
            long longVar = 70;
            ulong ulongVar = 80;
            short shortVar = 90;
            ushort ushortVar = 100;
            string stringVar = "A";
            object objectVar = 10;

            Console.WriteLine("bool: " + boolVar);
            Console.WriteLine("byte: " + byteVar);
            Console.WriteLine("sbyte: " + sbyteVar);
            Console.WriteLine("char: " + charVar);
            Console.WriteLine("decimal: " + decimalVar);
            Console.WriteLine("double: " + doubleVar);
            Console.WriteLine("float: " + floatVar);
            Console.WriteLine("int: " + intVar);
            Console.WriteLine("uint: " + uintVar);
            Console.WriteLine("nint: " + nintVar);
            Console.WriteLine("nuint: " + nuintVar);
            Console.WriteLine("long: " + longVar);
            Console.WriteLine("ulong: " + ulongVar);
            Console.WriteLine("short: " + shortVar);
            Console.WriteLine("ushort: " + ushortVar);
            Console.WriteLine("string: " + stringVar);
            Console.WriteLine("object: " + objectVar);
            bool isValidInput1 = false;


            Console.Write("string: ");
            stringVar = Console.ReadLine() ?? "";
            Console.WriteLine("string: " + stringVar);

            Console.Write("int: ");
            intVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("short: " + shortVar);

            Console.Write("long: ");
            longVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bool: " + longVar);

            Console.Write("short: ");
            shortVar = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("bool: " + shortVar);


            Console.WriteLine("\n Операции приведения");

            double doubleValue = 123.45;
            int intValue = (int)doubleValue;
            long longValue = 9876543210;
            int intValue2 = (int)longValue;
            char charValue = 'A';
            int intValue3 = (int)charValue;
            int intValue4 = 42;
            double doubleValue2 = (double)intValue4;
            int intValue5 = 1000;
            byte byteValue = (byte)intValue5;

            int intValue6 = 10;               
            double doubleValue3 = intValue6;     
            int intValue7 = 55;
            long longValue2 = intValue7;
            byte byteValue2 = 127;
            int intValue8 = byteValue2;
            char charValue2 = 'B';
            int intValue9 = charValue2;
            float floatValue = 3.14f;
            double doubleValue4 = floatValue;


            Console.WriteLine("\n упаковка и распоковка значимых типов");  
            int intVar3 = 120;
            object objVar1 = intVar3;
            Console.WriteLine("упаковка: ");
            Console.WriteLine("int: " + intVar3);
            Console.WriteLine("obj: " + objVar1);
            int intVar4 = (int)objVar1;
            Console.WriteLine("распаковка: ");
            Console.WriteLine("int: " + intVar4);
            Console.WriteLine("obj: " + objVar1);


            Console.WriteLine("\n неявно типизированная переменная");  
            var var1 = 50;             
            var var2 = "Welcome!";
            var var3 = 340;
            Console.WriteLine("неявно типизированные переменные:", var1, var2, var3);


            Console.WriteLine("\nработа с Nullble переменной");
            int? nullable = null;
            if (nullable == null)
            {
                Console.WriteLine("nullable: ");
            }


            Console.WriteLine("\nЗадание f:");
            var myVar = 42;
            //myVar = "Hello";
            Console.WriteLine("myVar:" + myVar);


            Console.WriteLine("\nСтроки:");
            string helloString = "hello";
            string hellString = "hell";
            Console.WriteLine("{0} {1} {2}", helloString, helloString == hellString ? "=" : "!=", hellString);

           

            string str1 = "Привет";
            string str2 = "Как дела?";
            string str3 = "Пока.";

            string str4 = str1 + " " + str2;
            string str5 = string.Concat(str4, "тук тук");

            string copyStr1 = str1;
            Console.WriteLine("скопированная строка: " + copyStr1);

            string substr3 = str3.Substring(0, 5); 
            Console.WriteLine("выделенная подстрока: " + substr3);

            string[] words = str2.Split(' ');
            Console.WriteLine("Разделение str2 на слова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string original = "The quick brown jumps over the lazy dog.";
            string insertion = "fox ";
            int position = 16;
            string result = original.Insert(position, insertion);
            Console.WriteLine("Результат вставки: " + result);

            string text = "This is an example text.";
            string toRemove = "example ";
            string cleaned = text.Replace(toRemove, "");
            Console.WriteLine("Результат удаления: " + cleaned);



            Console.WriteLine("\nСоздание пустой строки");
            string nString = "";
            string nullString = null;

            if (string.IsNullOrEmpty(nString))
            {
                Console.WriteLine("\nПустая строка nString");
            }
            if (string.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("Null строка nullString");
            }

            if (nString == nullString)
            {
                Console.WriteLine("Пустая и null равны.");
            }
            else
            {
                Console.WriteLine("Пустая и null не равны.");
            }

            string nonNstring = nullString ?? "";

            StringBuilder strBuild = new StringBuilder("Привет мир");
            strBuild.Remove(0, 2);
            strBuild.Insert(0, "Последние слова ");
            strBuild.Append(" сегодня мой последний день)");
            Console.WriteLine("\nНовая строка: " + strBuild);


            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.Length / rows;



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }


            string[] myArray = { "Матем", "Физика", "Физра", "География", "История" };
            Console.WriteLine("содержимое массива:");
            foreach (string item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"длина массива: {myArray.Length}");
            Console.Write("введите позицию элемента, который хотите изменить: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            if (position >= 0 && pos < myArray.Length)
            {
                Console.Write("введите новое значение: ");
                string newValue = Console.ReadLine();
                myArray[pos] = newValue;
                Console.WriteLine("новое содержимое массива:");
                foreach (string item in myArray)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("вне диапазона массива!");
            }



            double[][] jaggedArray = new double[3][];
            bool tr = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int col;
                do
                {
                    Console.Write($"введите количество столбцов для строки {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out col) || col <= 0)
                    {
                        Console.WriteLine("некорректный ввод.");
                    }
                    else
                    {
                        tr = true;
                    }
                } while (!tr);

                jaggedArray[i] = new double[col];
            }
            tr = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    double value;

                    do
                    {
                        Console.Write($"введите значение для элемента [{i}][{j}]: ");
                        if (!double.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("некорректный ввод. введите числовое значение.");
                        }
                        else
                        {
                            tr = true;
                        }
                    } while (!tr);

                    jaggedArray[i][j] = value;
                }
            }
            
            Console.WriteLine("ступенчатый массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

            var implicitString = "hello";
            var implicitArray = new[] { 1, 2, 3 };

            
            (double, string, char, string, ulong) myTuple = (42, "Hello", 'A', "World", 1234567890UL);

            Console.WriteLine("второй и четвертый: " + myTuple.Item2 + " " + myTuple.Item4);

            (double a, string b, char c, string d, ulong e) = myTuple;
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
            (_, string _, char _, string _, _) = myTuple;
            

            var t2 = (5, "Привет");
            var t3 = (5, "Привет");
            var t4 = (5, "Пока");
            Console.WriteLine("сравнение t2 и t3: " + (t2 == t3));
            Console.WriteLine("сравнение t2 и t4: " + (t2 == t4));

         


                int[] num;
                string inputString;
                do
                {
                    Console.Write("введите элементы массива через пробел: ");
                    string numInput = Console.ReadLine();
                    string[] numArray = numInput.Split(' ');

                    if (int.TryParse(numArray[0], out int firstNumber))
                    {
                        num = new int[numArray.Length];
                        num[0] = firstNumber;

                        for (int i = 1; i < numArray.Length; i++)
                        {
                            if (!int.TryParse(numArray[i], out num[i]))
                            {
                                Console.WriteLine("ошибка! введите корректные элементы массива.");
                                num= null;
                                break;
                            }
                        }

                        if (num != null)
                            break;
                    }
                    else
                    {
                        Console.WriteLine("ошибка! введите корректные элементы массива.");
                    }

                } while (true);
                do
                {
                    Console.Write("введите строку: ");
                    inputString = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(inputString))
                        break;
                    else
                        Console.WriteLine("ошибка! строка не может быть пустой.");
                } while (true);
                (int max, int min, int sum, char firstChar) res = CalculateValues(num, inputString);
                Console.WriteLine($"максимальный: {res.max}");
                Console.WriteLine($"минимальный: {res.min}");
                Console.WriteLine($"сумма: {res.sum}");
                Console.WriteLine($"первая буква: {res.firstChar}");

            
         
                Console.WriteLine("использование checked:");
                CheckedFunction();

                Console.WriteLine("\nиспользование unchecked:");
                UncheckedFunction();

            }

        

            static (int max, int min, int sum, char firstChar) CalculateValues(int[] numbers, string inputString)
            {
                int max = numbers[0];
                int min = numbers[0];
                int sum = 0;

                foreach (int number in numbers)
                {
                    if (number > max)
                        max = number;

                    if (number < min)
                        min = number;

                    sum += number;
                }

                char firstChar = inputString.Length > 0 ? inputString[0] : '\0';

                return (max, min, sum, firstChar);
            }



            static void CheckedFunction()
            {
                try
                {
                    checked
                    {
                        int maxValue = int.MaxValue;
                        Console.WriteLine($"максимальное int: {maxValue}");
                        maxValue++;
                        Console.WriteLine($"после инкремента: {maxValue}");
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"исключение: {ex.Message}");
                }

            }

            static void UncheckedFunction()
            {
                unchecked
                {
                    int maxValue = int.MaxValue;
                    Console.WriteLine($"максимальное int: {maxValue}");
                    maxValue++;
                    Console.WriteLine($"после инкремента: {maxValue}");
                }
            }
        }
    }
