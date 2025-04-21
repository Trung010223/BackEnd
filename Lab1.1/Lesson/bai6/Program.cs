Console.OutputEncoding = System.Text.Encoding.UTF8;


int? number;
Console.Write("Nhập số bạn muốn kiểm tra: ");
number = int.Parse(Console.ReadLine() ?? "0");
if (number >= 0)
{
    Console.WriteLine("Đây là số nguyên dương.");
}
else
{
    Console.WriteLine("Đây là số nguyên âm.");
}