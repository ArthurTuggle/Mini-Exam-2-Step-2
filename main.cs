using System;

class MainClass {
  public static void Main (string[] args) {
     {
            
            double side1, side2, hypotenuse;

            Console.Write("Enter Side 1 : ");
            side1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Side 2 : ");
            side2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            
            Console.WriteLine("Hypotenuse : "+hypotenuse);
            
            Console.ReadKey();
        }
  }
}