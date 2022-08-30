using System.Diagnostics;

double a, res;
long p;
Stopwatch stopWatch;


Console.WriteLine("a^p");
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("p = ");
p = Convert.ToInt64(Console.ReadLine());


stopWatch = new Stopwatch();
stopWatch.Start();
res = Pow2(a, p);
stopWatch.Stop();
Console.Write("Pow2: ");
printRes(a, p, res, stopWatch.ElapsedMilliseconds);


stopWatch = new Stopwatch();
stopWatch.Start();
res = PowI(a, p);
stopWatch.Stop();
Console.Write("PowI: ");
printRes(a, p, res, stopWatch.ElapsedMilliseconds);



double PowI(double a, long p)
{
    double res = 1;
    for(long i = 0; i < p; i++)
    {
        res *= a;
    }
    return res;
}

double Pow2(double a, long p)
{
    long N = p;
    //    long i = 0;
    double d = a;
    double res = 1;
    while (N > 1)
    {
        N /= 2;
        d *= d;

        //       Console.WriteLine("i = "+(++i)+"; d= "+d+"; res= "+res);

        if (N % 2 == 1)
        {
            res *= d;

//            Console.Write("N = ");
//            Console.WriteLine(N);

        }
    }

    return res;
}

void printRes(double a, long p, double res, long t)
{
    Console.WriteLine(a + "^" + p + "=" + res + " (" + t + " ms)");

    return;
}