internal class Program
{
    public static void Main(string[] args)
    {
        int[,] array = new int[,] {
            { 555, 125, 645},
            { 565, 815, 995},
            { 515, 235, 665}
        };

        int max = array[0, 0];
        
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col] > max)
                {
                    max = array[row, col];
                }
                
            }
        }
        Console.WriteLine("Gia tri lon nhat trong mang la: " + max);
    }
}