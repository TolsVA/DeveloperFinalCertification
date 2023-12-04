internal class Program
{
    static int Init(string[] arr)
    {
        int caunt = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) caunt++;
        }
        return caunt;
    }
    static void FullArray(string[] arr, string[] arrNew)
    {
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) arrNew[index++] = arr[i];
        }
        System.Console.WriteLine($"[{string.Join(", ", arr)}] -> [{string.Join(", ", arrNew)}]");
    }

    private static void Main(string[] args)
    {
        string[][] arr = {
             new[] { "Hello", "2", "world", ":-)" }, 
             new[] { "1234", "1567", "-2", "computer science" }, 
             new[] { "Russia", "Denmark", "Kazan" } 
             };

        for (int i = 0; i < arr.Length; i++)
        {
            string[] arrNew = new string[Init(arr[i])];
            FullArray(arr[i], arrNew);
        }
    }
}