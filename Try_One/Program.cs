using System;

namespace Try_One
{
    class Info
    {
        public void Information()
        {
            string name,branch;
            int age,marks;
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Branch : ");
            branch = Console.ReadLine();
            Console.WriteLine("Enter Your Marks : ");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Student Information is : ");
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Age is : " + age);
            Console.WriteLine("Branch is : " + branch);
            Console.WriteLine("Marks are : " + marks); 
            if (marks>60)
            {
                Console.WriteLine("You are Eligible ");
            }
            else
            {
                Console.WriteLine("You are Not Eligible");
            }
        }
    }
    class Data
    {
       public void Pavan()
        {
            Console.WriteLine("Hii .Net");
        }
        internal void DD()
        {
            Console.WriteLine("Hii Java");
        }
        private void RX()
        {
            Console.WriteLine("Hii C#");
        }
    }

    class OddEven
    {
        public void check()
        {
            int num;
            Console.WriteLine("Enter the number to check even odd : ");
            num = Convert.ToInt32(Console.ReadLine());
            if ( num %2 == 0)
            {
                Console.WriteLine("The Number {0} is even.", num);
            }
            else
            {
                Console.WriteLine("The Number {0} is odd.", num);
            }
        }
    }
    class Maximum
    {
        public void max()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter Three Numbers : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            int m = num1;
            if(m < num2)
            {
                m = num2;
            }
            if(m < num3)
            {
                m = num3;
            }
            Console.WriteLine("{0} is Greater.",m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Addition of two Numbers
            int a, b, c;
            Console.WriteLine("Enter the Two Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("addition of two numbers {0} and {1} is : {2}",a,b,c);

            //creating the class object and calling it
            Data d = new Data();
            d.Pavan();
            d.DD();

            //information class onject creation and calling
            Info i = new Info();
            i.Information();

            //oddeven class object creation and calling
            OddEven oe = new OddEven();
            oe.check();

            //Maximum of three
            Maximum m = new Maximum();
            m.max();

            Console.WriteLine("Program Done....!");
        }
    }
}
