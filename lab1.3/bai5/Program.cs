using bai5;
Console.OutputEncoding = System.Text.Encoding.UTF8;
KhachSan khachSan = new KhachSan();

while (true)
{
    Console.WriteLine("Chương trình quản lý khách thuê phòng");
    Console.WriteLine("1. Nhập thông tin khách trọ");
    Console.WriteLine("2. Hiển thị thông tin khách trọ");
    Console.WriteLine("3. Tìm kiếm khách trọ theo họ và tên");
    Console.WriteLine("4. Tính tiền cho khách hàng");
    Console.WriteLine("5. Thoát khỏi chương trình");
    Console.Write("Chọn chức năng: ");
    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            khachSan.NhapKhach();
            break;
        case 2:
            khachSan.HienThiTatCaKhach();
            break;
        case 3:
            Console.Write("Nhập họ tên cần tìm: ");
            string hoTen = Console.ReadLine();
            khachSan.TimKiemKhach(hoTen);
            break;
        case 4:
            Console.Write("Nhập số CMND của khách để tính tiền: ");
            string soCMND = Console.ReadLine(); 
            KhachHang khach = null; 

            foreach (var item in khachSan.DanhSachKhach)
            {
                if (item.ThongTinCaNhan.CCCD == soCMND)
                {
                    khach = item; 
                    break; 
                }
            }

            if (khach != null)
            {
                float tien = khach.TinhTien();
                Console.WriteLine($"Tổng tiền phải trả cho khách {khach.ThongTinCaNhan.hoTen} là: {tien}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách nào với số CMND này.");
            }
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}
