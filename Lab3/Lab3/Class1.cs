using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3
{

    class String
    {
      

        public class Production
        {
            private string orgName;
            private int id;

            public Production()
            {
                orgName = "None";
                id = 0;
            }

            public Production(string orgName, int id)
            {
                this.orgName = orgName;
                this.id = id;
            }

            public string Name
            {
                get { return orgName; }
                set { orgName = value; }
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Production: Name = {orgName}, ID = {id};");
            }
        }

        public class Developer
        {
            private string Name;
            private int id;
            private string department;

            public Developer()
            {
                Name = "None";
                id = 0;
                department = "None";
            }

            public Developer(string name, int id, string depart)
            {
                Name = name;
                this.id = id;
                department = depart;
            }

            public string NameV
            {
                get { return Name; }
                set { Name = value; }
            }

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            public string Department
            {
                get { return department; }
                set { department = value; }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Developer: Name = {Name}, ID = {id}, Department = {department};");
            }
        }


        private StringBuilder value;
       
        public String(StringBuilder value)
        {
            this.value = value;
            this.Length = value.Length;
        }
        public char this[int index]
        {
            get { return this.value[index]; }
            set { this.value[index] = value; }
        }
        public StringBuilder Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Length { get; private set; }

        public static String operator+(String str, int num)
        {
            return new String(new StringBuilder(str.value + num.ToString()));
        }

        public static bool operator <(String str1, String str2)
        {
            return str1.Length < str2.Length;
        }

        public static bool operator >(String str1, String str2)
        {
            return str1.Length > str2.Length;
        }
        
        public static String operator -(String str)
        {
            return new String(new StringBuilder (str.value.ToString(0, str.value.Length - 1)));
        }

        public static String operator *(String str, char c)
        {
            return new String(new StringBuilder(c, str.value.Length));
        }
        
        public override string ToString()
        {
            return value.ToString();
        }

    }

    public static class StaticOperations
    {
        public static string DeletePunctuation(this string str1)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str1.Length; i++)
            {
                if (!char.IsPunctuation(str1[i]))
                    result.Append(str1[i]);
            }
            return result.ToString();
        }
        
        public static bool IsThereControlChars(this string str1)
        {
            for (int i = 0; i < str1.Length; i++)
                if (char.IsControl(str1[i]))
                    return true;
            return false;
        }

        public static int Sum(this string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    sum += (int)char.GetNumericValue(c);
            }
            return sum;
        }

        public static int DifferenceMaxMin(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("The string is empty.");

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    int value = (int)char.GetNumericValue(c);
                    max = Math.Max(max, value);
                    min = Math.Min(min, value);
                }
            }

            return max - min;
        }

        public static int CountElements(this string str)
        {
            return str.Length;
        }
    }
}
