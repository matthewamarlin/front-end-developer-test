using System;
using System.Globalization;

namespace Question1
{
    class Program
    {
        static bool ShouldRun { get; set; } = true;

        private Classifier _classifier;

        public Program()
        {
            _classifier = new Classifier();
        }

        public void NewClassification()
        {
            Console.WriteLine(Classify(PromptForAge(), PromptForHeight()));
        }

        private int PromptForAge()
        {
            Console.Write("Enter Age: ");
            
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Invalid Age, please enter a positive natural number. E.g 42");
                return PromptForAge();
            }
            else
            {
                return age;
            }
        }

        private decimal PromptForHeight()
        {
            Console.Write("Enter Height: ");
            
            if (!int.TryParse(Console.ReadLine(), out int height) || height < 0)
            {
                Console.WriteLine("Invalid Height, please enter a positive natural or decimal number. E.g 186.74 or 156,34");
                return PromptForHeight();
            }
            else
            {
                return height;
            }
        }

        private string Classify(int age, decimal height)
        {
            return $"{_classifier.Age(age)} & {_classifier.Height(height)}";
        }            

        static void Main(string[] args)
        {  
            var program = new Program();
            
            while (ShouldRun)
            {
                Console.WriteLine("Age & Hight Classifier");

                program.NewClassification();
                Console.WriteLine("Press 'x' to exit or any other key to perform a new classification.");

                ShouldRun = Console.ReadKey().KeyChar != 'x';

                Console.Clear();
            }
        }
    }
}
