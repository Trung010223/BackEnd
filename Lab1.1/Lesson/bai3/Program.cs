float? C;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập độ c mà bạn muốn chuyển đổi: ");
C = float.Parse(Console.ReadLine() ?? "0.0");
Console.WriteLine($"Độ C đã chuyển đổi sang độ F là: {(C * 9.5) + 32}");
