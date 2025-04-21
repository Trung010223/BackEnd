Console.OutputEncoding = System.Text.Encoding.UTF8;


int? soNguyen;
Console.Write("Nhập số nguyên: ");
soNguyen = int.Parse(Console.ReadLine());
if (soNguyen % 2 == 0)
{
    Console.WriteLine($"Số {soNguyen} là số nguyên.");
}
else
{
    Console.WriteLine("Đây không phải là số nguyên.");
}