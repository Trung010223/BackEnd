Console.OutputEncoding = System.Text.Encoding.UTF8;


float? first;
float? second;

Console.Write("Nhập số thứ nhất: ");
first = float.Parse(Console.ReadLine() ?? "0.0");
Console.Write("Nhập số thứ hai: ");
second = float.Parse(Console.ReadLine() ?? "0.0");

Console.WriteLine($"Tổng của 2 số là: {first + second} \nTích của 2 số là: {first * second}");
