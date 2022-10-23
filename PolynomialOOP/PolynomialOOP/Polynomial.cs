using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//https://www.geeksforgeeks.org/program-add-two-polynomials/
//https://www.geeksforgeeks.org/multiply-two-polynomials-2/
namespace PolynomialOOP
{
    public class Polynomial
    {
        private int[] coefficients;
        public Polynomial(int[] coefficients)
        {
            this.coefficients = new int[coefficients.Length];
            this.coefficients = coefficients;
        }

        public static Polynomial operator +(Polynomial a,Polynomial b)
        {
            int size = max(a.getCoefficientsSize(), b.getCoefficientsSize());

            int[] pA = a.getCoefficients();
            int[] pB = b.getCoefficients();

            int[] sum = new int[size];

            for (int i = 0; i < a.getCoefficientsSize(); i++)
            {
                sum[i] = pA[i];
            }

            // Take ever term of first polynomial
            for (int i = 0; i < b.getCoefficientsSize(); i++)
            {
                sum[i] += pB[i];
            }

            return new Polynomial(sum);
        }

        private static int max(int m, int n)
        {
            return (m > n) ? m : n;
        }


        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            int size = max(a.getCoefficientsSize(), b.getCoefficientsSize());

            int[] pA = a.getCoefficients();
            int[] pB = b.getCoefficients();

            //Invert pB values to make subtration
            for(int i = 0; i < pB.Length; i++)
            {
                pB[i] = -pB[i];
            }

            int[] sub = new int[size];

            for (int i = 0; i < a.getCoefficientsSize(); i++)
            {
                sub[i] = pA[i];
            }

            // Take ever term of first polynomial
            for (int i = 0; i < b.getCoefficientsSize(); i++)
            {
                sub[i] += pB[i];
            }

            return new Polynomial(sub);
        }
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            int[] pA = a.getCoefficients();
            int[] pB = b.getCoefficients();

            int aLength = a.getCoefficientsSize();
            int bLength = b.getCoefficientsSize();


            int[] prod = new int[aLength + bLength - 1];

            // Initialize the product polynomial
            for (int i = 0; i < aLength + bLength - 1; i++)
            {
                prod[i] = 0;
            }

            // Multiply two polynomials term by term
            // Take ever term of first polynomial
            for (int i = 0; i < aLength; i++)
            {
                // Multiply the current term of first polynomial
                // with every term of second polynomial.
                for (int j = 0; j < bLength; j++)
                {
                    prod[i + j] += pA[i] * pB[j];
                }
            }
            return new Polynomial(prod);
        }

        public int[] getCoefficients()
        {
            return this.coefficients;
        }

        public int getCoefficientsSize()
        {
            return this.coefficients.Length;
        }


        //Missing not showing power or coefficiant of 0
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            int length = this.coefficients.Length;
            for (int i = 0; i < length; i++)
            {
                if(System.Math.Abs(this.coefficients[i]) > 0)
                {
                    if (this.coefficients[i] < 0 && s.ToString() == "")
                    {
                        Console.WriteLine("first loop if i=" + i);
                        s.Append(" - ");
                    }
                    s.Append(System.Math.Abs(this.coefficients[i]).ToString());

                    if (i != 0)
                    {
                        s.Append("x^" + i);
                    }
                    if (i != length - 1)
                    {
                        if (this.coefficients[i + 1] > 0)
                        {
                            s.Append(" + ");
                        }
                        else
                        {
                            s.Append(" - ");
                        }
                    }
                }
                
            }

            return s.ToString();
        }
    }
}
