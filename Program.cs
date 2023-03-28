using System;

namespace NumericTypes;
public class Program
  {
        public static void Main()
    
        {
         
           
            
            Console.WriteLine("What is the the length");
           double Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the width");
           double Width = Convert.ToInt32(Console.ReadLine());
        
           double area = Length * Width;  
         Console.WriteLine("This is the area of the rectangle: " + area);
           Console.ReadKey();
        }

    }
    
