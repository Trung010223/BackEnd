Console.OutputEncoding = System.Text.Encoding.UTF8;

int? number ;
Console.WriteLine("Nhập số muốn kiểm tra: ");
number = int.Parse(Console.ReadLine() ?? "0");
bool isPrime = true;
if(number <= 1)
{
    Console.WriteLine("Số nguyên tố phải lớn hơn 0");
}
else if(number == 2)
{
    isPrime = true ;
}
else if (number % 2 == 0)
{
    isPrime = false ;
}
else
{
    for(int i = 3;i < Math.Sqrt(number.Value); i += 2)
    {
        if (i % 3 == 0)
        {
            isPrime = false;
            break ;
        }
    }
}

if (isPrime == true)
{
    Console.WriteLine("Đây là số nguyên tố.");
}
else
{
    Console.WriteLine("Đây không phải là số nguyên tố.");
}
    

