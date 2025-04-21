Console.OutputEncoding =  System.Text.Encoding.UTF8;

static bool kiemTra(int n)
{
    if (n < 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}
Console.Write("Nhập số lượng phần tử của mảng: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] myArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    myArray[i] = int.Parse(Console.ReadLine() ?? "0");
}

Console.Write("Số âm trong mảng: ");
foreach (int number in myArray)
{
    if (!kiemTra(number))
    {
        Console.Write(" " + number);
    }
}

Console.Write("Số dương trong mảng: ");
foreach (int number in myArray)
{
    if (kiemTra(number))
    {
        Console.Write(" " + number);
    }
}