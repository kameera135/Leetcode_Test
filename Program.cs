using Leetcode;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Solution solution = new Solution();

        int[] result = solution.TwoSum([2, 7, 11, 15], 9);

        Console.WriteLine(string.Join(", ", result));

    }
}

