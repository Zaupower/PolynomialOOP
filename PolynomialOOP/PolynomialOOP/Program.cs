using PolynomialOOP;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        int[] polis = new int[] { 0, 0, 3, -4 };
        int[] polis2 = new int[] { 0, 0, 7, -4, 3, 9 };
        Polynomial poly1 = new Polynomial(polis);
        Console.WriteLine("poly1: "+poly1.ToString());
        Polynomial poly2 = new Polynomial(polis2);
        Console.WriteLine("poly2: "+poly2.ToString());
        
        Console.WriteLine("");
        
        Console.WriteLine("Sum");
        Polynomial ppResult = poly1 + poly2;  
        Console.WriteLine(ppResult.ToString());

        Console.WriteLine("");

        Console.WriteLine("Multiply");
        Polynomial ppResultMulti = poly1 * poly2;
        Console.WriteLine(ppResultMulti.ToString());

        Console.WriteLine("");

        Console.WriteLine("Subtract");
        Polynomial ppResultSub = poly1 - poly2;
        Console.WriteLine(ppResultSub.ToString());
    }
}