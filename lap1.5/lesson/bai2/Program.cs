using bai2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Hinh> hinhList = new List<Hinh>
        {
            new HinhTron(5),
            new HinhVuong(4),
            new HinhTamGiac(3, 4, 5),
            new HinhChuNhat(3, 6)
        };

double tongChuVi = 0;
double tongDienTich = 0;

foreach (var hinh in hinhList)
{
    tongChuVi += hinh.TinhChuVi();
    tongDienTich += hinh.TinhDienTich();
}

Console.WriteLine($"Tổng chu vi: {tongChuVi:F2}");
Console.WriteLine($"Tổng diện tích: {tongDienTich:F2}");