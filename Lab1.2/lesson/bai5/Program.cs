// Hàm hoán vị
static void Swap(ref int x, ref int y)
{
    int temp = x; 
    x = y;        
    y = temp;     
}

// Nhập số nguyên a và b từ bàn phím
Console.Write("Nhập số nguyên a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhập số nguyên b: ");
int b = Convert.ToInt32(Console.ReadLine());

// Hoán vị hai số
Swap(ref a, ref b);

// In ra kết quả
Console.WriteLine("Sau khi hoán vị:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);