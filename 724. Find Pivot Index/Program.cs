int[] array = { 1, 7, 3, 6, 5, 6 };
Console.WriteLine(PivotIndex(array));

int PivotIndex(int[] nums)
{
    int leftSum = 0;
    int rightSum = nums.Sum();
    for (int i = 0; i < nums.Length; i++)
    {
        rightSum -= nums[i];

        if (leftSum == rightSum)
        {
            return i;
        }

        leftSum += nums[i];
    }
    return -1;
}