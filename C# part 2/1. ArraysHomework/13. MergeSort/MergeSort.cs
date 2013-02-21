using System;

class MergeSort
{

    static int[] MergeArrays(int[] leftArray, int[] rightArray)
    {
        int[] result = new int[leftArray.Length + rightArray.Length];
        int left = 0, right = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (right == rightArray.Length || ((left < leftArray.Length) && (leftArray[left] <= rightArray[right])))
            {
                result[i] = leftArray[left];
                left++;
            }
            else if (left == leftArray.Length || ((right < rightArray.Length) && (rightArray[right] <= leftArray[left])))
            {
                result[i] = rightArray[right];
                right++;
            }
        }
        return result;
    }

    static int[] MergeSorter(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];
        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, num = 0; i < array.Length; i++, num++)
        {
            rightArray[num] = array[i];
        }

        leftArray = MergeSorter(leftArray);
        rightArray = MergeSorter(rightArray);

        return MergeArrays(leftArray, rightArray);
    }

    static void Main()
    {
        int[] arr = { -1, 2, -3, 4, -5, 6, -7 };
        int[] array = MergeSorter(arr);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
