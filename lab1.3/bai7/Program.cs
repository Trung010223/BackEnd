using bai7;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<CBGV> danhSachGiaoVien = new List<CBGV>();

Console.WriteLine("Nhập số lượng giáo viên: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhập thông tin giáo viên thứ {i + 1}: ");
    CBGV giaoVien = new CBGV();
    giaoVien.Nhap();
    danhSachGiaoVien.Add(giaoVien);
}

Console.WriteLine("Thông tin giáo viên có lương thực lĩnh lớn hơn 5 triệu: ");
foreach (var giaoVien in danhSachGiaoVien)
{
    giaoVien.TinhLuongThucLinh();
    if (giaoVien.luongThucLinh > 5000000)
    {
        giaoVien.xuat();
    }
}



