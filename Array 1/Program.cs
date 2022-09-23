internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        int mult = 1;
        int minValue = 1;
        int maxValue = 10;

        Random random = new Random();

        Console.Write("Введите количество строк: ");
        int rowNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длину строки: ");
        int rowLenth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите строку для подсчёта суммы: ");
        int userRow = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите столбец для подсчёта произведения: ");
        int userColumn = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rowNumber, rowLenth];

        int rowForSum = userRow - 1;
        int columnForMult = userColumn - 1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(minValue, maxValue);
                Console.Write($"\b{array[i, j]}  ");
            }
            Console.WriteLine();
        }

        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[rowForSum, j];

        for (int i = 0; i < array.GetLength(0); i++)
            mult *= array[i, columnForMult];

        Console.WriteLine($"\nСумма {userRow} строки равна {sum}. Произведение {userColumn} столбца равно {mult}.");
    }
}