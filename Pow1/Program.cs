using System.Diagnostics;

double a, res;
long p;
Stopwatch stopWatch = new Stopwatch();


Console.WriteLine("a^p");
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("p = ");
p = Convert.ToInt64(Console.ReadLine());


Console.Write("Pow2: ");
stopWatch.Restart();
res = Pow2(a, p);
stopWatch.Stop();
Console.WriteLine($"{a}^{p}={res} ({stopWatch.ElapsedMilliseconds} ms)");


Console.Write("PowI: ");
stopWatch.Restart();
res = PowI(a, p);
stopWatch.Stop();
Console.WriteLine($"{a}^{p}={res} ({stopWatch.ElapsedMilliseconds} ms)");

Console.ReadKey();



double PowI(double a, long p)
{
    double res = 1;
    for(long i = 0; i < p; i++) res *= a;

    return res;
}

double Pow2(double a, long p)
{
    long N = p;
    double d = a;
    double res = 1;
    while (N > 1)
    {
        N /= 2;
        d *= d;

        if (N % 2 == 1) res *= d;
    }
    if (p % 2 == 1) res *= a;

    return res;
}

