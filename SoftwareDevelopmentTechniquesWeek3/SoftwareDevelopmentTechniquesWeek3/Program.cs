using System;

namespace SoftwareDevelopmentTechniquesWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }

        public void Go()
        {
            /*MyClass mc = new();
            decimal d = mc.f();*/
            /*Student s = new();
            s.Name = "John";
            s.Country = "USA";
            s.NumBags = 3;
            s.TotalWeight = 75;*/
            //Student s = new Student("John", "Jamaica", 3, 74);
            //Student s = new Student(){ Name = "John", Country = "Jamaica", NumBags = 3, TotalWeight = 74 };
            Student s = new Student() { Name = "John", Country = "Jamaica" };
            s.NumBags = 3;
            s.TotalWeight = 74;

            Console.WriteLine($"Student {s.Name} from {s.Country}, flew with {s.NumBags} bags with average weight of {s.CalculateAverage(i: 1):f2}");

            int[] arr = new int[5];
            int a = 10;
            int[] arr2 = new int[a];
            int[] arr3 = { 1, 2, 3, 4, 5 };
            int[] arr4 = new int[5];
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = i;
                Console.WriteLine($"{i}");
            }
            foreach (int i in arr4)
            {
                Console.WriteLine(i);
            }

            MyClass[] mcArray = new MyClass[5];
            for (int i = 0; i < mcArray.Length; i++)
            {
                mcArray[i] = new MyClass();
            }

            string s1 = string.Empty;
            s1 = "ABCDE";
            Console.WriteLine(s1[3]);

            char c = 'A';
            char[] arrChar = s1.ToCharArray();
            arrChar[4] = 'X';
            Console.WriteLine(arrChar[4]);

            s1 = new string(arrChar);
            Console.WriteLine(s1);
        }
    }

    class Student
    {
        private string name;
        private string country;
        private int numBags;
        private decimal totalWeight;

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public int NumBags { get => numBags; set => numBags = value; }
        public decimal TotalWeight { get => totalWeight; set => totalWeight = value; }

        public decimal CalculateAverage(int i = 0)
        {
            decimal result = 0;
            //if (numBags > 0)
            //{
                result = TotalWeight / NumBags;
            //} else
            //{
            //    result = 0;
            //}
            return result;
        }

        /*public Student(string name, string country, int numBags, decimal totalWeight)
        {
            this.name = name;
            this.country = country;
            this.numBags = numBags;
            this.totalWeight = totalWeight;
        }*/
    }

    struct Student1 {
        private string name;
        private string country;
        private decimal numBags;
        private decimal totalWeight;

        public Student1(string name, string country, decimal numBags, decimal totalWeight)
        {
            this.name = name;
            this.country = country;
            this.numBags = numBags;
            this.totalWeight = totalWeight;
        }

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public decimal NumBags { get => numBags; set => numBags = value; }
        public decimal TotalWeight { get => totalWeight; set => totalWeight = value; }
    }

    }
