class ReverseArray
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            return;
        }

        PrintArrayReverse(arr, index + 1);
        Console.Write(arr[index] + " ");
    }

    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        Console.Write($"Array elements (reverse): ");
        PrintArrayReverse(array, 0);
    }
}


