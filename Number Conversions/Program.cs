using System;

class Program
{
    // Main method to execute the program
    static void Main()
    {
        // Test cases
        // One Hundred Forty-Nine
        Console.WriteLine(NumberToWords(149));
        // One Thousand One Hundred Forty-Nine
        Console.WriteLine(NumberToWords(1149));
        // Forty-Two
        Console.WriteLine(NumberToWords(42));
        // Eight Hundred Ninety
        Console.WriteLine(NumberToWords(890));     
    }

    // This NumberToWords Method converts a number to words
    static string NumberToWords(int number)
    {
        //No conversions needed if the number is zero,it will return zero
        if (number == 0)
            return "Zero";

        // Arrays for number words
        string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };//Array holds words for single digits
        string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };//array holds words for numbers 10-19
        string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };//array holds words for multiples of ten

        // initialize empty string to build final word representation of the number
        string result = "";

        // Check for thousands place by dividing with 1000
        if (number / 1000 > 0)
        {
            result += ones[number / 1000] + " Thousand ";
            number %= 1000; // Reduce number by thousands place
        }

        // Check for hundreds place by dividing with 100
        if (number / 100 > 0)
        {
            result += ones[number / 100] + " Hundred ";
            number %= 100; // Reduce number by hundreds place
        }

        // Check for tens place specifically handling numbers from 10 to 19 
        if (number >= 10 && number <= 19)
        {
            result += teens[number - 10];//appends the teen number to result
        }
        else
        {
            if (number / 10 > 0)
            {
                result += tens[number / 10] + " ";
                number %= 10; // Reduce number by tens place
            }

            // Add single digit to result
            if (number > 0)
            {
                result += ones[number];
            }
        }

        // trim removes any whitespace and returns it as the final output
        return result.Trim();
    }
}
