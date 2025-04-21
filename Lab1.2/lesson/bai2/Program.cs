Console.OutputEncoding = System.Text.Encoding.UTF8;

//Hàm kiểm tra số nguyên tố
static bool IsPrime(int n)
{
    if (n <= 1) return false; // Số nguyên tố phải lớn hơn 1
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0) return false; 
    }
    return true; 
}

Console.Write("Nhập số lượng phần tử của mảng: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] myArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    myArray[i] = int.Parse(Console.ReadLine() ?? "0.0");
}
// Kiểm tra từng số trong mảng
Console.Write("Các số nguyên tố trong mảng là:");
foreach (int number in myArray)
{
    if (IsPrime(number))
    {
        Console.Write( " " + number);
    }
}
