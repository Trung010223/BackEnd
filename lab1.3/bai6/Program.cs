using bai6;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<HSHocSinh> danhSachHocSinh = new List<HSHocSinh>();

Console.WriteLine("Nhập số lượng học sinh: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhập thông tin sinh viên {i + 1}: ");
    HSHocSinh hocSinh = new HSHocSinh();
    hocSinh.Nhap();
    danhSachHocSinh.Add( hocSinh );
}

Console.WriteLine("/nDanh sách học sinh nữ sinh năm 1985: ");
foreach( var hocSinh in  danhSachHocSinh)
{
    if(hocSinh.thongTinSinhVien.gioiTinh.ToLower() == "nữ" && hocSinh.thongTinSinhVien.namSinh == 1985)
    {
        hocSinh.Xuat();
    }
}

Console.Write("\nNhập quê quán để tìm kiếm: ");
string queQuanTimKiem = Console.ReadLine();
Console.WriteLine($"Danh sách học sinh ở quê quán {queQuanTimKiem}:");
foreach (var hs in danhSachHocSinh)
{
    if (hs.thongTinSinhVien.queQuan.ToLower() == queQuanTimKiem.ToLower())
    {
        hs.Xuat();
    }
}

Console.WriteLine("Thoát khỏi chương trình.");

