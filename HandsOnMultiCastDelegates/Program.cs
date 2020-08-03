using System;

namespace HandsOnMultiCastDelegates
{
    class Program

    { 
  
     public delegate void rectDelegate(double height, double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            rectDelegate rectdele = new rectDelegate(obj.area);
            rectdele += obj.perimeter;
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();
            rectdele.Invoke(16.3, 10.3);


        }
    }
}
