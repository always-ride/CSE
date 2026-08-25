class ArrayTest
{
    private static int GetIndexOfBiggestValue(int[] arr)
    {
        int biggestVal = int.MinValue;
        int indexOfBiggestVal = -1;
        int index = 0;
        foreach (int val in arr) 
        {
            if (val > biggestVal)
            {
                biggestVal = val;
                indexOfBiggestVal = index;
            }
            index++;
        }
        return indexOfBiggestVal;
    }

    private static int GetIndexOfSmallestValue(int[] arr)
    {
        int smallestVal = int.MaxValue;
        int indexOfSmallestVal = -1;
        int index = 0;
        foreach (int val in arr)
        {
            if (val < smallestVal)
            {
                smallestVal = val;
                indexOfSmallestVal = index;
            }
            index++;
        }
        return indexOfSmallestVal;
    }

    private static int GetSum(int[] arr)
    {
        int sum = 0;
        foreach (int val in arr)
        {
            sum += val;
        }
        return sum;
    }

    private static double GetAverage(int[] arr)
    {
        int sum = GetSum(arr);
        return (double)sum / arr.Length;
    }

    private static int[] SortAscending(int[] arr)
    {
        int[] result = new int[arr.Length];
        Array.Copy(arr, result, arr.Length);
        Array.Sort(result);
        return result;
    }

    public static void Main()
    {
        int[] myArray = new int[5];
        Console.WriteLine("Es werden 5 zufällige Werte ermittel: ");
        for (int i=0;i<5;i++)
        {
            int value = new Random().Next(1, 10);
            Console.WriteLine($"Wert: {value}");
            myArray[i] = value;
        }

        var lines = new string[5];
        lines[0] = "Der grösste Wert ist an Position " +
                          (ArrayTest.GetIndexOfBiggestValue(myArray) + 1);
        lines[1] = "Der kleinste Wert ist an Position " +
                          (ArrayTest.GetIndexOfSmallestValue(myArray) + 1);
        lines[2] = "Die Summe aller Werte ist " +
                          ArrayTest.GetSum(myArray);
        lines[3] = "Der Schnitt über alle Werte ist " +
                          ArrayTest.GetAverage(myArray);
        lines[4] = "Die sortierten Werte sind " +
                          string.Join(", ", ArrayTest.SortAscending(myArray));

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}