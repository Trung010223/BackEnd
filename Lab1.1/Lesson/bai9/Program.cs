Console.OutputEncoding = System.Text.Encoding.UTF8;

int? number;
Console.Write("Nhập số bạn muốn tính giai thừa: ");
number = int.Parse(Console.ReadLine() ?? "0");
int? temp = 1;
for (int i = number.Value; i >= 1; i--)
{
    temp *= i;
}
Console.WriteLine($"Giai thừa {number} là: {temp}");

