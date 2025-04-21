String? name;
int? age;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập tên của bạn: ");
name = System.Console.ReadLine();

Console.Write("Nhập tuổi của bạn: ");
age = int.Parse(System.Console.ReadLine() ?? "0");

Console.WriteLine($"Xin chào {name} bạn {age} tuổi.");