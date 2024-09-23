namespace LeetCodeTests {
    public class RunningSumOf1DArray {
        
        /// <summary>
        /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        //Return the running sum of nums.

        //    Example 1:

        //Input: nums = [1, 2, 3, 4]
        //Output: [1,3,6,10]
        //Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        //Example 2:


        //Input: nums = [1, 1, 1, 1, 1]
        //Output: [1,2,3,4,5]
        //Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
        //Example 3:


        //Input: nums = [3, 1, 2, 10, 1]
        //Output: [3,4,6,16,17]
        /// </summary>

        [Test]
        [TestCase(new int[]{1, 2, 3, 4 }, new int[]{1, 3, 6, 10})]
        [TestCase(new int[]{ 1, 1, 1, 1, 1 }, new int[]{ 1, 2, 3, 4, 5 })]
        [TestCase(new int[]{ 3, 1, 2, 10, 1 }, new int[]{ 3, 4, 6, 16, 17 })]
        public void Test1(int[] input, int[] expected)
        {
            var sut = new Solution();
            var result = sut.RunningSum(input);
            Assert.AreEqual(result, expected);
        }

        internal class Solution {
            internal int[] RunningSum(int[] nums) {
                var currentValue = 0;
                var result = new int[nums.Length];

                for (int i = 0; i < nums.Length; i++) {
                    currentValue += nums[i];
                    result[i] = currentValue;
                }

                return result;
            }
        }
    }
}