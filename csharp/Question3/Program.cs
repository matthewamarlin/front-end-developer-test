using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = "G";
            var actualResult1 = Dna.ToRna(input1);
            var expectedResult1 = "C";

            var input2 = "TAGC";
            var actualResult2 = Dna.ToRna(input2);
            var expectedResult2 = "AUCG";

            var input3 = "ACGTGGTCTTAA";
            var actualResult3 = Dna.ToRna(input3);
            var expectedResult3 = "UGCACCAGAAUU";

            Console.WriteLine("Test Case 1");
            PrintTestCaseResult(input1, actualResult1, expectedResult1);

            Console.WriteLine("Test Case 2");
            PrintTestCaseResult(input2, actualResult2, expectedResult2);

            Console.WriteLine("Test Case 3");
            PrintTestCaseResult(input3, actualResult3, expectedResult3);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void PrintTestCaseResult(string input, string actualResult, string expectedResult)
        {
            Console.WriteLine($"\tInput: {input} \n\tResult: {actualResult} \n\tExpected: {expectedResult} \n\tMatches: {actualResult == expectedResult}");
        }
    }
}
