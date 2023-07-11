int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(string.Join(", ", RunningSum(nums)));

int[] RunningSum(int[] nums)
{
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            result[i] += nums[j];
        }
    }
    return result;
}