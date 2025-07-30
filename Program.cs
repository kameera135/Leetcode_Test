using Leetcode;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Solution solution = new Solution();

        IList<IList<string>> result = solution.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

        Console.WriteLine(result);

    }
}

