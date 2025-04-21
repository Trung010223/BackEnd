Console.OutputEncoding = System.Text.Encoding.UTF8;

int? year;
Console.Write("Nhập năm bạn muốn kiểm tra: ");
year = int.Parse(Console.ReadLine() ?? "0");

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0) {
            Console.WriteLine("Đây là năm nhuận.");
        }
        else
        {
            Console.WriteLine("Không phải năm nhuận");
        }
    }
    else
    {
        Console.WriteLine("Đây là năm nhuận.");
    }
}
else
{
    Console.WriteLine("Không phải năm nhuận.");
}