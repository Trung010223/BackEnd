using bai4;
Console.OutputEncoding = System.Text.Encoding.UTF8;
KhuPho khuPho = new KhuPho();

while (true)
{
    Console.WriteLine("Chương trình quản lý hộ dân trong khu phố");
    Console.WriteLine("1. Nhập thông tin hộ dân");
    Console.WriteLine("2. Tìm kiếm thông tin hộ dân theo họ tên hoặc số nhà");
    Console.WriteLine("3. Hiển thị thông tin toàn bộ hộ dân");
    Console.WriteLine("4. Thoát khỏi chương trình");
    Console.Write("Chọn chức năng: ");
    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            khuPho.Nhap();
            break;
        case 2:
            Console.Write("Nhập họ tên hoặc số nhà cần tìm: ");
            string tuKhoa = Console.ReadLine();
            khuPho.TimKiem(tuKhoa);
            break;
        case 3:
            khuPho.Xuat();
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}