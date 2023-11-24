#region Question with Graph URL
// Url for graph diagram to understand better - https://leetcode.com/problems/trapping-rain-water/?envType=study-plan-v2&envId=top-interview-150

//Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

//Example 1:

//    Input: height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
//    Output: 6
//Explanation: The above elevation map(black section) is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1].In this case, 6 units of rain water(blue section) are being trapped.

//Example 2:

//    Input: height = [4, 2, 0, 3, 2, 5]
//    Output: 9

//Constraints:

//    n == height.length
//1 <= n <= 2 * 104
//0 <= height[i] <= 105
#endregion

#region Example

//Example 1:

//    Input: height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
//    Output: 6
//Explanation: The above elevation map(black section) is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1].In this case, 6 units of rain water(blue section) are being trapped.


//Example 2:

//    Input: height = [4, 2, 0, 3, 2, 5]
//    Output: 9
#endregion

#region Solution
class Solution
{
    public static void Main(String[] args)
    {
        Solution s = new Solution();
        var op = s.trap([5,2,0,6,4,3]);
        Console.WriteLine(op);
    }
    public int trap(int[] height)
    {
        int firstBigNum = 0;
        int secondBigNum = 0;
        int firstBigNumIndex = 0;
        int secondBigNumIndex = 0;
        int water = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > firstBigNum)
            {
                firstBigNum = height[i];
                firstBigNumIndex = i;
            }
        }
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] >= secondBigNum && firstBigNumIndex != i)
            {
                secondBigNum = height[i];
                secondBigNumIndex = i;
            }
        }
            
        for(int i = secondBigNumIndex + 1 ; i < firstBigNumIndex; i++)
        {
            Console.WriteLine(i);
        }


            //if (i != bigNumIndex)
            //{
            //    nextBigNum = height[i];
            //}
        
        Console.WriteLine("firstBigNum : " + firstBigNum);
        Console.WriteLine("firstBigNumIndex : " + firstBigNumIndex);
        Console.WriteLine("secondBigNum : " + secondBigNum);
        Console.WriteLine("secondBigNumIndex : " + secondBigNumIndex);
        Console.WriteLine("water : " + water);
        return firstBigNum;



        //Console.WriteLine("BigNum : " + bigNum);
        //Console.WriteLine("BigNumIndex : " + bigNumIndex);
        //Console.WriteLine("I : " + i);
        //Console.WriteLine();
        //var water = 0;
        //for (int i = 0; i < height.Length;i++)
        //{
        //    var init = height[i];
        //    for(int j = i + 1; j < height.Length;j++)
        //    {
        //        if(init < height[j])
        //        {
        //            water = water + init - height[j];
        //        }
        //        else
        //        {
        //            water = 0;
        //        }
        //    }
        //}
        //return water;
        return 0;
    }
}
#endregion
