using bai9;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<BienLai> danhSachBienLai = new List<BienLai>();

//Nhập thông tin cho hộ gia đình
Console.Write("Nhập số hộ gia đình: ");
int soHoGiaDinh = int.Parse(Console.ReadLine());
for (int i = 0; i < soHoGiaDinh; i++)
{
    Console.WriteLine($"Nhập thông tin cho hộ gia đình thứ {i + 1}: ");
    BienLai bienLai = new BienLai();
    bienLai.Nhap();
    bienLai.TinhTien();
    danhSachBienLai.Add(bienLai);
}

//Hiện thị các biên lai đã nhập
Console.WriteLine("Danh sách biên lai đã nhập: ");
foreach (var bienLai in danhSachBienLai)
{
    bienLai.Xuat();
    Console.WriteLine();
}
//Tính tổng số tiền phải trả của tất cả các hộ gia đình
double tongSoTienPhaiTra = 0;
foreach (var bienLai in danhSachBienLai)
{
    tongSoTienPhaiTra += bienLai.soTienPhaiTra;
}
Console.WriteLine($"Tổng số tiền phải trả của tất cả các hộ gia đình: {tongSoTienPhaiTra} VNĐ");
Console.WriteLine("Nhấn phím bất kỳ để thoát...");
Console.ReadKey();


