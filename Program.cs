
int[] nums = new int[5] { 1, 2, 3, 4, 5 };
static int[] funx(int[] nums)
{
    int target = 9;
    int[] result = new int[2];
    int numsarr = nums.Length;
    for (int i = 0; i < numsarr; i++)
    {
        for (int j = 0; j < numsarr; j++)
        {
            if (i != j)
            {
                if (target == nums[i] + nums[j])
                {
                    result[0] = i;
                    result[1] = j;

                }
            }
        }
    }
    return result;
}


