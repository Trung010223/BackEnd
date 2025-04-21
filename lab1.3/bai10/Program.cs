
using bai10;
Console.OutputEncoding = System.Text.Encoding.UTF8;
VanBan vb = new VanBan();
vb.Nhap();
Console.WriteLine("Nhập lựa chọn của bạn(1: đếm từ, 2: đếm số kí tự H)");
int luaChon= int.Parse(Console.ReadLine());
switch (luaChon)
{
    case 1:
        vb.DemSoTu();
        Console.WriteLine("Số từ trong xâu là: " + vb.DemSoTu());
        break;
    case 2:
        vb.DemKyTuH();
        Console.WriteLine("Số kí tự H trong xâu là: " + vb.DemKyTuH());
        break;
    default:
        Console.WriteLine("Lựa chọn không hợp lệ");
        break;
}

