using PolynomialOOP;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        int[] polis = new int[] { 0, 0, 3, -4 };
        int[] polis2 = new int[] { 0, 0, 7, -4, 3, 9 };
        Polynomial pp = new Polynomial(polis);
        Console.WriteLine(pp.ToString());
        Polynomial pp2 = new Polynomial(polis2);
        Console.WriteLine(pp2.ToString());

        Polynomial ppResult = pp + pp2;  
        Console.WriteLine(ppResult.ToString());

        Polynomial ppResultMulti = pp * pp2;
        Console.WriteLine(ppResultMulti.ToString());
    }
}