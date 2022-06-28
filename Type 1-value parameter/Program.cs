using System;

namespace Type_1_value_parameter
{
    class Program
    {
        public void show(int x, int y)
        {
            Console.WriteLine(x + " " + y);
            int z = x;
            x = y;
            y = z;
            Console.WriteLine(x+" "+y);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the  first number :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the  secound number :");
            int b = int.Parse(Console.ReadLine());
            Program obj = new Program();
            obj.show(a,b);
            Console.WriteLine(a+ " "+b);

        }
    }
}
