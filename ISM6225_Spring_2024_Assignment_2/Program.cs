using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Question 1: Find Missing Numbers in Array
             Console.WriteLine("Question 1:");
             int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
             IList<int> missingNumbers = FindMissingNumbers(nums1);
             Console.WriteLine(string.Join(",", missingNumbers));*/

            /* // Question 2: Sort Array by Parity
             Console.WriteLine("Question 2:");
             int[] nums2 = { 3, 1, 2, 4 };
             int[] sortedArray = SortArrayByParity(nums2);
             Console.WriteLine(string.Join(",", sortedArray));*/

            /*// Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));*/

            /* // Question 4: Find Maximum Product of Three Numbers
             Console.WriteLine("Question 4:");
             int[] nums4 = { 1, 2, 3, 4 };
             int maxProduct = MaximumProduct(nums4);
             Console.WriteLine(maxProduct);*/

            /* // Question 5: Decimal to Binary Conversion
             Console.WriteLine("Question 5:");
             int decimalNumber = 42;
             string binary = DecimalToBinary(decimalNumber);
             Console.WriteLine(binary);*/

            /* // Question 6: Find Minimum in Rotated Sorted Array
             Console.WriteLine("Question 6:");
             int[] nums5 = { 3, 4, 5, 1, 2 };
             int minElement = FindMin(nums5);
             Console.WriteLine(minElement);*/

            /*// Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);*/

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                IList<int> result = new List<int>();

                //Mark each number corresponding index by negative
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1; // Getting the index
                    if (nums[index] > 0) 
                    {
                        nums[index] = -nums[index];
                    }
                }

                //Collecting the indices that are not marked as visited
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1);
                    }
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Create a new array for the result
                int[] result = new int[nums.Length];
                int evenIndex = 0, oddIndex = nums.Length - 1;

                // Iterate over the original array
                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        result[evenIndex++] = num; // Place even numbers at the beginning
                    }
                    else
                    {
                        result[oddIndex--] = num; // Place odd numbers at the end
                    }
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Create a dictionary to store numbers and their indices
                Dictionary<int, int> map = new Dictionary<int, int>();

                // Iterate through the array
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];

                    // If the complement exists in the map, return the indices
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }

                    // Or add the current number and its index to the map
                    if (!map.ContainsKey(nums[i]))
                    {
                        map[nums[i]] = i;
                    }
                }

                // Return empty array if no solution
                return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Sort the array
                Array.Sort(nums);
                int n = nums.Length;
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                return Convert.ToString(decimalNumber, 2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0;
                int right = nums.Length - 1;

                // If the array is not rotated (already sorted), return the first element
                if (nums[left] < nums[right])
                {
                    return nums[left];
                }

                // Binary search to find the minimum element
                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    // If mid element is greater than the rightmost element, the minimum is to the right
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        // Otherwise, the minimum is to the left (including mid)
                        right = mid;
                    }
                }

                // At the end of the loop, left will point to the minimum element
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Negative numbers are not palindromes
                if (x < 0) return false;

                int original = x;
                int reversed = 0;

                // Reverse the integer
                while (x > 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;
                }

                // Check whether original number is equal to the reversed number
                return original == reversed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Handling base cases
                if (n == 0) return 0;
                if (n == 1) return 1;

                int a = 0, b = 1, fib = 0;

                // compute the Fibonacci sequence
                for (int i = 2; i <= n; i++)
                {
                    fib = a + b;
                    a = b;
                    b = fib;
                }

                return fib;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
