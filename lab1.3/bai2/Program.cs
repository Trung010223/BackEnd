using bai2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
QuanLiTaiLieu qlTaiLieu = new QuanLiTaiLieu();
while (true)
{
    Console.WriteLine("Chương trình quản lý tài liệu");
    Console.WriteLine("1. Nhập thông tin tài liệu");
    Console.WriteLine("2. Hiển thị danh sách tài liệu");
    Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            qlTaiLieu.NhapTaiLieu();
            break;
        case 2:
            qlTaiLieu.HienThi();
            break;
        case 3:
            Console.WriteLine("Nhập loại tài liệu cần tìm (1: Sách, 2: Tạp chí, 3: Báo): ");
            int loai = int.Parse(Console.ReadLine());
            qlTaiLieu.TimKiem(loai);
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}