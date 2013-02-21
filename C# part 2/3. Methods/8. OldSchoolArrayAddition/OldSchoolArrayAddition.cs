using System;

class OldSchoolArrayAddition
{
    static int[] SequenceAddition(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
        {
            int length = firstArray.Length;
            int[] result = new int[length];
            int counter = length - 1;
            for (int i = 0; i < length; i++)
            {
                if (i >= secondArray.Length)
                {
                    result[counter--] += firstArray[i];
                }
                else
                {
                    if (firstArray[i] + secondArray[i] >= 10)
                    {
                        result[counter - 1] = (firstArray[i] + secondArray[i]) / 10;
                        result[counter--] += (firstArray[i] + secondArray[i]) % 10;
                    }
                    else
                    {
                        result[counter--] += firstArray[i] + secondArray[i];
                    }
                }
            }
            return result;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            int length = secondArray.Length;
            int[] result = new int[length];
            int counter = length - 1;
            for (int i = 0; i < length; i++)
            {
                if (i >= firstArray.Length)
                {
                    result[counter--] += secondArray[i];
                }
                else
                {
                    if (firstArray[i] + secondArray[i] >= 10)
                    {
                        result[counter - 1] = (firstArray[i] + secondArray[i]) / 10;
                        result[counter--] += (firstArray[i] + secondArray[i]) % 10;
                    }
                    else
                    {
                        result[counter--] += firstArray[i] + secondArray[i];
                    }
                }
            }
            return result;
        }
        else
        {
            int length = firstArray.Length;
            int[] result = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] + secondArray[i] >= 10)
                {
                    result[length - i] += (firstArray[i] + secondArray[i]) % 10;
                    result[(length - i) - 1] = (firstArray[i] + secondArray[i]) / 10;
                }
                else
                {
                    result[length - i] += firstArray[i] + secondArray[i];
                }
            }

            return result;
        }
    }

    static int[] ArrayCreator()
    {
        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        if (size < 1)
        {
            Console.WriteLine("The sequence must not be empty");
            return ArrayCreator();
        }
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = size - 1; i >= 0; i--)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void Main()
    {
        int[] firstArray = ArrayCreator();
        int[] secondArray = ArrayCreator();
        int[] result = SequenceAddition(firstArray, secondArray);

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
