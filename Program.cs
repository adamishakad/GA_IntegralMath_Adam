namespace GA_IntegralMath_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring C# Integral Types and Math Operations!");
            int myInt = 2147483647; // Int32: Ranges from -2,147,483,648 to 2,147,483,647. Commonly used for general counting.
            long myLong = 9223372036854775807L; // Int64: Larger range for big numbers, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            byte myByte = 255; // Byte: Ranges from 0 to 255, often used for small counts or data manipulation.
            short myShort = 32767; // Int16: Useful for numbers between -32,768 and 32,767, when int is more than needed.
            int sum = myInt + 120; // Addition: Combines two numbers into a larger sum.
            int difference = myInt - 70; // Subtraction: Removes a quantity from another.
            int product = myShort * 10; // Multiplication: Scales a number by another number.
            int quotient = myInt / 4; // Division: Splits a number into equal parts.
            int remainder = myByte % 20; // Modulus: Finds the remainder after division.
            int result1 = 5 + 3;
            Console.WriteLine(result1);
            int result2 = 10 - 4;
            Console.WriteLine(result2);
            int result3 = 7 * 2;
            Console.WriteLine(result3);
            int result4 = 20 / 4;
            Console.WriteLine(result4);
            int result5 = 9 % 2;
            Console.WriteLine(result5);
            int result6 = 15 + 6;
            Console.WriteLine(result6);
            int result7 = 12 - 7;
            Console.WriteLine(result7);
            int result8 = 4 * 3;
            Console.WriteLine(result8);
            int result9 = 30 / 5;
            Console.WriteLine(result9);
            int result10 = 16 % 3;
            Console.WriteLine(result10);
            int result11 = 8 + 10;
            Console.WriteLine(result11);
            int result12 = 20 - 8;
            Console.WriteLine(result12);
            int result13 = 6 * 7;
            Console.WriteLine(result13);
            int result14 = 45 / 9;
            Console.WriteLine(result14);
            int result15 = 25 % 4;
            Console.WriteLine(result15);

            // Assuming the declarations of 'number' and 'shortNumber' variables
            int number = 20; // Example value
            short shortNumber = 30; // Example value

            int complexOperation1 = (number / 2) + 3 * shortNumber; // Combines division, multiplication, and addition.
                                                                    // Explanation: First, 'number' is divided by 2, then the result is multiplied by 3 and added to 'shortNumber'.

            int complexOperation2 = 5 * (shortNumber - 1000) / 2; // Combines subtraction, multiplication, and division.
                                                                  // Explanation: First, 'shortNumber' is subtracted by 1000, then the result is multiplied by 5 and divided by 2.
            int resultA = (5 + 3) * 2;
            Console.WriteLine(resultA);
            int resultB = (10 - 4) + 7 * 3;
            Console.WriteLine(resultB);
            int resultC = 7 * (2 + 6) / 4;
            Console.WriteLine(resultC);
            int resultD = (20 / 4) + 15 - 3;
            Console.WriteLine(resultD);
            int resultE = (9 % 2) + 12 / 4;
            Console.WriteLine(resultE);

            Console.WriteLine($"Equation 1 Result: {complexOperation1}");
            Console.WriteLine($"Equation 2 Result: {complexOperation2}");






        }
    }
}
