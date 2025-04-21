float? width;
float? height;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập chiều dài: ");
height = float.Parse(Console.ReadLine() ?? "0.0");

Console.Write("Nhập chiều rộng: ");
width = float.Parse(Console.ReadLine() ?? "0.0");

Console.WriteLine($"Diện tích hình chữ nhật là : {width * height}");