int[] array = { 3,2,4 };
Console.WriteLine($"[{String.Join(",",TwoSum(array,6))}]");
int[] TwoSum(int[] nums, int target)
{
    int[] indexes = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                indexes[0] = i > j ? j : i;
                indexes[1] = i > j ? i : j;
                return indexes;
            }
        }
    }
    return new int[] {} ;
}