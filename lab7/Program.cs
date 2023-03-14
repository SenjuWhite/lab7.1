int[,] arr = new int[31,10];
Random rand = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rand.Next(25, 35);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
double Max = 0;
double countf = 0;
int[] result = new int[7];
int c = 0;
for (int i = 0; i < arr.GetLength(0) - 7; i++)//лічильник і максимальне < 31-7(24)
{
    for (int m = i; m < i + 7; m++)// проходимо по 7 рядкам починаючи з рядка i
    {
        c = m-6; // в кінці циклу с= початковій m, першому дню цих 7 днів

        for (int n = 0; n < arr.GetLength(1); n++)
        {
            countf += arr[m, n]; //додаємо всі значення цих 7*10 днів
        }
    }
    if (countf / 70 > Max)
    {
        Max = countf / 70;//якщо середнє більше за max то max=countf
        for (int q = 0; q < result.Length; q++)
        {
            result[q] = c++;//запис в масив 7 днів з найбільшим max починаючи з с(перший день)
        }
    }
    countf = 0;//обнуляємо значення суми 
}
Console.WriteLine(Max);
Console.WriteLine(String.Join(",", result));
int first = result[0] > 16 ? result[0] - 16 : result[0] + 15;//якщо індекс>16 то це серпень оскільки в липні 31 день, 31-15(перший день)=16,якщо ні то липень  
int second = result[6] > 16 ? result[6] - 16 : result[6] + 15;
String frst = first >= 15 ? "З " + first + " липня" : "З " + first + " серпня";
String scnd = second > 15 ? " по " + second + " липня " : " по " + second + " серпня";
Console.WriteLine(frst + " " + scnd);
Console.ReadKey();
Console.Clear();
try
{
    Console.Write("");
    int c1 = int.Parse(Console.ReadLine());
    int[,] arr1 = new int[c1, c1];
    int m1 = 0;
    int n1 = c1 - 1;
    int count = 0;
    for (int i = 0; i <= arr1.GetLength(0); i++)
    {
        m1 = 0;
        n1 -= i;
        do
        {
            arr1[m1++, n1++] = count++;
        }
        while (m1 < c1 && n1 < c1);
    }
    for (int j = 0; j < arr1.GetLength(0) - 1; j++)
    {
        m1 = j + 1;
        n1 = 0;
        do
        {
            arr1[m1++, n1++] = count++;
        }
        while (m1 < c1 && n1 < c1);
    }
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
catch
{
    Console.WriteLine("Введіть коректне значення");
}

