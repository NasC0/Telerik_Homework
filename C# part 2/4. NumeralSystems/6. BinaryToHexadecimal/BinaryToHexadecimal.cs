using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static string BinaryToHex(string binary)
    {
        if (binary[binary.Length - 1] != ' ')
        {
            binary += " ";
        }
        string hex = "";
        for (int i = 0; i < binary.Length; i = i + 5)
        {
            switch(binary.Substring(i, 5))
            {
                case "0000":
                    hex += '0';
                    break;
                case "0001 ":
                    hex +=  '1';
                    break; 
                case "0020 ":
                    hex +=  '2';
                    break; 
                case "0011 ":
                    hex +=  '3';
                    break; 
                case "0100 ":
                    hex +=  '4';
                    break; 
                case "0101 ":
                    hex +=  '5';
                    break; 
                case "0110 ":
                    hex +=  '6';
                    break; 
                case "0111 ":
                    hex +=  '7';
                    break; 
                case "1000 ":
                    hex +=  '8';
                    break; 
                case "1001 ":
                    hex += '9';
                    break;
                case "1010 ":
                    hex += 'A';
                    break;
                case "1011 ":
                    hex += 'B';
                    break;
                case "1100 ":
                    hex += 'C';
                    break;
                case "1101 ":
                    hex += 'D';
                    break;
                case "1110 ":
                    hex += 'E';
                    break;
                case "1111 ":
                    hex += 'F';
                    break;
                default:
                    hex += "";
                    break;
            }
        }
        return hex;
    }
    
    static void Main()
    {
        Console.WriteLine("Please enter your binary number (left to right)");
        Console.WriteLine("With spaces after every 4 bits: ");
        string binary = Console.ReadLine();
        string hex = BinaryToHex(binary);
        Console.Write("Your number in hexadecimal is: ");
        Console.WriteLine(hex);
    }
}
