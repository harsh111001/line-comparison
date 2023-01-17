namespace line_comp
{
    internal class Program
    {
        static int findlength(int x1,int x2,int y1,int y2)
        {
            return (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is line comparison program ");
            int x1, x2, y1, y2;
            int ctr = 1;
            int firstline=0, secondline=0;
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter values for line "+ctr+Environment.NewLine);
                Console.WriteLine("Enter value for coordinate x1 ");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for coordinate x2 ");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for coordinate y1 ");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for coordinate y2 ");
                y2 = Convert.ToInt32(Console.ReadLine());
                if(ctr==1 ) { firstline = findlength(x1, x2, y1, y2); }
                else
                {
                    secondline = findlength(x1, x2, y1, y2);
                }
                ctr++;
            }
            //Console.WriteLine($"length of line1 is {firstline} and length of line2is {secondline}");
            if (firstline == secondline)
            {
                Console.WriteLine("both the lines are equal");
            }else if(secondline > firstline) 
            {
                Console.WriteLine("line1 is smaller than line2");
            }
            else
            {
                Console.WriteLine("line1 is greater than line2");
            }
        }
    }
}