using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//https://www.geeksforgeeks.org/program-add-two-polynomials/
namespace PolynomialOOP
{
    public class Polynomial
    {
        string[] coefficients;
        Polynomial(string[] coefficients)
        {
            this.coefficients = new string[coefficients.Length];
            this.coefficients = coefficients;
        }

        public static Polynomial operator +(Polynomial a,Polynomial b)
        {
            string[] l = new string[] {"a", "b"};
            return new Polynomial(l);
        }


        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            string[] l = new string[] { "a", "b" };
            return new Polynomial(l);
        }
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            string[] l = new string[] { "a", "b" };
            return new Polynomial(l);
        }


        public override string ToString()
        {
            return "Person: ";
        }
    }
}
