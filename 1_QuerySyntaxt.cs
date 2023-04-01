public static class QuerySyntaxt
{
    public static void Run()
    {
        // Create a data source.
        int[] scores = new int[] { 10, 15, 27, 97, 92, 81, 60 };

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where (score % 2) == 0
            select score;

        Console.WriteLine("Even scores in the array: ");

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}