using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Anders","Lundestrædet", "Holbæk",4300);
            
            System.Console.WriteLine(myclass);

        }
    }
}
