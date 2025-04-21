using bai1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Tạo danh sách list chứa các phân số
List<PhanSo> list = new List<PhanSo>();
// Nhập số lượng phân số
Console.Write("Nhập số lượng phân số: ");
int n = int.Parse(Console.ReadLine());
// Nhập các phân số
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhập phân số thứ {i + 1}:");
    PhanSo ps = new PhanSo();
    ps.Nhap();
    list.Add(ps);
}
//Tính tổng các phân số
PhanSo tong = new PhanSo();
for (int i = 0; i < n; i++)
{
    tong = tong.Tong(list[i]);
}
// Xuất tổng các phân số
Console.Write("Tổng các phân số là: ");
tong.Xuat();
