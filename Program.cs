using System;
using Balta.ContentContext;

// Teste para o Github
namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();

            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            
            foreach (var item in course.Modules)
            {
            
        }

            

        }
    }
}
