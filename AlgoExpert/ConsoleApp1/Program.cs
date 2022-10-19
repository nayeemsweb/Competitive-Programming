namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 2, 3, 5, 3, 7, 5 };
            var uniqueItems = items.Distinct();

            foreach (var item in uniqueItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}