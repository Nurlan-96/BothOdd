int Numbers (int n, int m)
{
    if ((n % 2 == 0) && (m % 2 == 0))
    { return n + m;
    }
    return 0;
}
Console.WriteLine(Numbers(7,10));