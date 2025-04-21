Console.OutputEncoding = System.Text.Encoding.UTF8;

float sum(float[] myArray, int n)
{
    float sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += myArray[i];
    }
    return sum;
}

Console.Write("Nhập số lượng phần tử của mảng: ");
int n = int.Parse(Console.ReadLine() ?? "0");
float[] myArray = new float[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    myArray[i]= float.Parse(Console.ReadLine() ?? "0.0");
}
float totalSum = sum(myArray, n);
Console.WriteLine($"Tổng các số trong mảng là: {totalSum}");