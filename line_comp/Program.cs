using System.ComponentModel.DataAnnotations;

namespace line_comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is line comparison program ");
            Line l1 = new Line(1, 1, 3, 4);
            Line l2 = new Line(3, 5, 2, 2);
            Line l3 = new Line(3, 4, 2, 2);
            Console.WriteLine($"Length of l1 is {l1.length()}");
            Console.WriteLine($"Length of l2 is {l2.length()}");
            Console.WriteLine($"Length of l3 is {l3.length()}");
            l1.compare(l2);
            l2.compare(l1);
            l1.equality(l2);
            l3.equality(l1);
        }
    }
}