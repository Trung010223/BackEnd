using bai1;

QuanLiCanBo canBo = new QuanLiCanBo();
Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
    Console.WriteLine("Chương trình quản lý cán bộ");
    Console.WriteLine("1. Nhập thông tin cán bộ");
    Console.WriteLine("2. Tìm kiếm cán bộ theo họ tên");
    Console.WriteLine("3. Hiển thị danh sách cán bộ");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            canBo.NhapCanBo();
            break;
        case 2:
            Console.Write("Nhập họ tên cần tìm: ");
            string hoTen = Console.ReadLine();
            canBo.TimKiem(hoTen);
            break;
        case 3:
            canBo.HienThiDanhSach();
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}