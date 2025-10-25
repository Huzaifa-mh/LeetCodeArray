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

    public int RemoveDuplicates(int[] nums)
    {
        int newlength = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            bool isduplicate = false;

            for (int j = 0; j < newlength; j++)
            {
                if (nums[i] == nums[j])
                {
                    isduplicate = true;
                    break;
                }
            }

            if (isduplicate == false)
            {
                nums[newlength] = nums[i];
                newlength++;
            }
        }

        return newlength; 
    }

    //error in the function
    //public static int LinearSearch(int[] nums, int target)
    //{
    //    for(int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i] == target)
    //        {
    //            return i;
    //        }
    //        else
    //        {
    //            return -1;
    //        }
    //    }

    //}
    private static void Main(string[] args)
    {
        int[] array = { 4, 5, 2, 8, 11, 12 };
        int target = 10;

        int[] result = TwoSum(array, target);
        foreach (var item in result)
        {
            Console.Write($"{item}  ");
        }
        //int output = LinearSearch(array, 8);
        //Console.WriteLine((output > 0)? $"Found at index {output}": "Target not found");

        int[] arrayNum = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int res = RemoveDuplicates(arrayNum);
        foreach (var item in arrayNum)
        {
            Console.Write($"{item}  ");
        }
        Console.WriteLine(res);


    }
}