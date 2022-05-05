int[] nums = new int[] { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
Array.Sort(nums);

Console.WriteLine("For reference during this exercise, all of the values in the 'nums array' are:");
Console.Write("int[] nums = { ");
for (int i = 0; i < nums.Length; i++)
{
    if (i == nums.Length-1)
    {
        Console.Write($"{nums[i]}");
    }
    else
    {
        Console.Write($"{nums[i]}, ");

    }
}
Console.Write(" }");
Console.WriteLine();
Console.WriteLine();

//Find Minimum Value
Console.WriteLine("Exercise 1:");
int minimumValue = nums.Min((x) => x);
Console.Write($"The MINIMUM value in the nums array is ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(minimumValue);
Console.ResetColor();
Console.Write(".");
Console.WriteLine();
Console.WriteLine();

// Find Maximum Value
Console.WriteLine("Exercise 2:");
int maximumValue = nums.Max((x) => x);
Console.Write("The MAXIMUM value in the nums array is ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(maximumValue);
Console.ResetColor();
Console.Write(".");
Console.WriteLine();
Console.WriteLine();

// Find the Maximum value less than 10000
Console.WriteLine("Exercise 3:");
int[] numsLessThan10K = nums.Where((x) => x < 10000).ToArray();
int number = numsLessThan10K.Max();
Console.Write($"The MAXIMUM value in the nums array that is LESS THAN 10K is ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(number);
Console.ResetColor();
Console.Write(".");
Console.WriteLine();
Console.WriteLine();

// Find all of the values between 10 and 100
Console.WriteLine("Exercise 4:");
int[] numsBetween10And100 = nums.Where((x) => (x >= 10) && (x <= 100)).ToArray();
Console.WriteLine("The values in the nums array that are between 10 and 100 are: ");
Console.Write("{ ");
for (int i = 0; i < numsBetween10And100.Length; i++)
{
    if (i == numsBetween10And100.Length - 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsBetween10And100[i]}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsBetween10And100[i]}");
        Console.ResetColor();
        Console.Write(", ");
    }
}
Console.ResetColor();
Console.Write(" }");
Console.WriteLine();
Console.WriteLine();


// Find all the values between 100000 and 999999 inclusive
Console.WriteLine("Exercise 5:");
int[] numsBetween100KAnd999999 = nums.Where((x) => x >= 100000 && x <= 999999).ToArray();
Console.WriteLine("The values in the nums array that are between 100,000 and 999,999 are: ");
Console.Write("{ ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int i = 0; i < numsBetween100KAnd999999.Length; i++)
{
    if (i == numsBetween100KAnd999999.Length - 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsBetween100KAnd999999[i]}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsBetween100KAnd999999[i]}");
        Console.ResetColor();
        Console.Write(", ");
    }
}
Console.ResetColor();
Console.Write(" }");
Console.WriteLine();
Console.WriteLine();

// count all of the even numbers
Console.WriteLine("Exercise 6:");
int[] numsAreEven = nums.Where((x) => x %2==0).ToArray();
Console.WriteLine("The even values in the nums array are:");
Console.Write("{ ");
for (int i = 0; i < numsAreEven.Length; i++)
{
    if (i == numsAreEven.Length - 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsAreEven[i]}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"{numsAreEven[i]}");
        Console.ResetColor();
        Console.Write(", ");
    }
}
Console.ResetColor();
Console.Write(" }");
Console.WriteLine();
Console.Write($"There are ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(numsAreEven.Count());
Console.ResetColor();
Console.Write(" total even values in the nums array.");
Console.WriteLine();