using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionConsoleApp
{
    public class Fraction
    {
        private int numerator, denominator; //licznik i mianownik

        #region propetisy
        public int Numerator
        {
           get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value!= 0)
                    denominator = value;
                else
                    throw new ArgumentException("Nie mozna ustawic 0");
            }
        }
        #endregion

        #region konstruktory
        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        #endregion

        #region metody
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        public void Mul(Fraction firstFraction, Fraction secondFraction)
        {
            Numerator = firstFraction.Numerator * secondFraction.Numerator;
            Denominator = firstFraction.Denominator * secondFraction.Denominator;
        }

        public Fraction Mul(Fraction secondFraction)
        {
            Fraction fraction = new Fraction();
            fraction.Mul(this, secondFraction);
            return fraction;
        }
        #endregion
    }
}