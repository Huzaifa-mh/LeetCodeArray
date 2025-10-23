internal class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] final = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (nums[i] + nums[j] == target)
                {
                    final[0] = i;
                    final[1] = j;
                    break;
                }
            }
        }
        return final;
    }
    private static void Main(string[] args)
    {
        int[] array = { 2, 5, 8, 11, 12 };
        int target = 10;

        int[] result = TwoSum(array, target);
        foreach (var item in result)
        {
            Console.Write($"{item}  ");
        }
    }
}