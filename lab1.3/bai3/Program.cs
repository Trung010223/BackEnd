using bai3;
Console.OutputEncoding = System.Text.Encoding.UTF8;
TuyenSinh tuyenSinh = new TuyenSinh();
while (true)
{
    Console.WriteLine("Chương trình quản lý thí sinh dự thi đại học");
    Console.WriteLine("1. Nhập thông tin thí sinh");
    Console.WriteLine("2. Hiển thị thông tin thí sinh trúng tuyển");
    Console.WriteLine("3. Tìm kiếm thí sinh theo số báo danh");
    Console.WriteLine("4. Kết thúc chương trình");
    Console.Write("Chọn chức năng: ");
    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            tuyenSinh.NhapThongTin();
            break;
        case 2:
            tuyenSinh.HienThi();
            break;
        case 3:
            Console.Write("Nhập số báo danh cần tìm: ");
            string soBaoDanh = Console.ReadLine();
            tuyenSinh.TimKiem(soBaoDanh);
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}