using bai8;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Tạo danh sách thẻ mượn    
List<TheMuon> dsTheMuon = new List<TheMuon>();
//Tạo vòng lặp để nhập thông tin thẻ mượn
while (true)
{
    TheMuon theMuon = new TheMuon();
    theMuon.Nhap();
    dsTheMuon.Add(theMuon);
    Console.Write("Bạn có muốn nhập tiếp không? (y/n): ");
    string chon = Console.ReadLine();
    if (chon.ToLower() != "y")
        break;
}

//Tìm kiếm thông tin sinh viên theo mã số sinh viên
Console.Write("Nhập mã số sinh viên cần tìm: ");
string maSoSV = Console.ReadLine();
bool timThay = false;
foreach (TheMuon tm in dsTheMuon)
{
    if (tm.sinhVien.maSoSV == maSoSV)
    {
        Console.WriteLine("Thông tin thẻ mượn:");
        tm.Xuat();
        timThay = true;
        break;
    }
}
if (!timThay)
{
    Console.WriteLine("Không tìm thấy thông tin thẻ mượn của sinh viên có mã số " + maSoSV);
}

//Hiện thị thông tin sinh viên đã đến hạn trả sách  
DateTime today = DateTime.Now;
Console.WriteLine("Thông tin sinh viên đã đến hạn trả sách:");
bool coSinhVienDenHan = false;
foreach (TheMuon tm in dsTheMuon)
{
    if (tm.hanTra < today)
    {
        Console.WriteLine("Thông tin thẻ mượn:");
        tm.Xuat();
        coSinhVienDenHan = true;
    }
}
//Thoát khỏi chương trình
if (!coSinhVienDenHan)
{
    Console.WriteLine("Không có sinh viên nào đã đến hạn trả sách.");
}