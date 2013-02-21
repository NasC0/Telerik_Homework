using System;
using System.Linq;

class FloatToBinary
{
    static string ByteConvert(float number)
    {
        byte[] byteArray = BitConverter.GetBytes(number);
        Array.Reverse(byteArray);
        string result = BitConverter.ToString(byteArray);
        return result;
    }

    static string HexToBinary(float number)
    {
        string hex = ByteConvert(number);
        hex = hex.ToUpper();
        string binary = "";
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    binary += "0000";
                    break;
                case '1':
                    binary += "0001";
                    break;
                case '2':
                    binary += "0010";
                    break;
                case '3':
                    binary += "0011";
                    break;
                case '4':
                    binary += "0100";
                    break;
                case '5':
                    binary += "0101";
                    break;
                case '6':
                    binary += "0110";
                    break;
                case '7':
                    binary += "0111";
                    break;
                case '8':
                    binary += "1000";
                    break;
                case '9':
                    binary += "1001";
                    break;
                case 'A':
                    binary += "1010";
                    break;
                case 'B':
                    binary += "1011";
                    break;
                case 'C':
                    binary += "1100";
                    break;
                case 'D':
                    binary += "1101";
                    break;
                case 'E':
                    binary += "1110";
                    break;
                case 'F':
                    binary += "1111";
                    break;
                default:
                    binary += "";
                    break;
            }
        }
        return binary;
    }

    static void PrintFloatToBinary(string binary)
    {
        Console.WriteLine("Sing: {0}", binary[0]);
        Console.Write("Exponent: ");
        for (int i = 1; i <= 8; i++)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
        Console.Write("Mantissa: ");
        for (int i = 9; i < binary.Length; i++)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("Enter your number: ");
        float number = float.Parse(Console.ReadLine());
        string binary = HexToBinary(number);
        PrintFloatToBinary(binary);
    }
}