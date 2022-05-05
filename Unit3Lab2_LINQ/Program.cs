int[] nums = new int[] { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

Console.WriteLine("All of the values in the list are:");
foreach (var item in nums)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//Find Minimum Value
Console.WriteLine("Exercise 1:");
int minimumValue = nums.Min((x) => x);
Console.WriteLine($"The minimum value in the nums array is {minimumValue}");
Console.WriteLine();

// Find Maximum Value
Console.WriteLine("Exercise 2:");
int maximumValue = nums.Max((x) => x);
Console.WriteLine($"The maximum value in the nums array is {maximumValue}");
Console.WriteLine();

// Find the Maximum value less than 10000
Console.WriteLine("Exercise 3:");
int[] numsLessThan10K = nums.Where((x) => x < 10000).ToArray();
int number = numsLessThan10K.Max();
Console.WriteLine($"The maximum value in the nums array that is less than 10K is {number}");
Console.WriteLine();

// Find all of the values between 10 and 100
Console.WriteLine("Exercise 4:");
int[] numsBetween10And100 = nums.Where((x) => x >= 10 && x <= 100).ToArray();
Console.WriteLine("The values in the nums array that are between 10 and 100 are: ");
foreach (var item in numsBetween10And100)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Find all the values between 100000 and 999999 inclusive
Console.WriteLine("Exercise 5:");
int[] numsBetween100KAnd999999 = nums.Where((x) => x >= 100000 && x <= 999999).ToArray();
Console.WriteLine("The values in the nums array that are between 100,000 and 999,999 are: ");
foreach (var item in numsBetween100KAnd999999)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// count all of the even numbers
Console.WriteLine("Exercise 6:");
int[] numsAreEven = nums.Where((x) => x %2==0).ToArray();
Console.WriteLine("The even values in the nums array are:");
foreach (var item in numsAreEven)
{
    Console.WriteLine(item);
}
Console.WriteLine();
