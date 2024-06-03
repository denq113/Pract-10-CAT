using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp53
{
    internal class Fraction
    {
        public int numerator, denominator, integer ,sing;

        public Fraction(int sing, int integer, int numerator, int denominator )
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.integer = integer;
            this.sing = sing;
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            this.integer = 0;
            this.sing = 1;
        }
        public Fraction Addition (Fraction other)
        {
            Fraction rez = new Fraction();
            rez.denominator = this.denominator*other.denominator;
            rez.numerator = this.numerator*other.denominator+this.denominator*other.numerator;
            return rez;
        }

        public Fraction Correct_Fraction()
        {
            Fraction rez = new Fraction();
            rez.integer = this.numerator/ this.denominator;
            rez.numerator = this.numerator% this.denominator;
            rez.denominator=this.denominator;
            return rez;
        }
        static public Fraction operator +(Fraction d1,Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator *d2.denominator;
            rez.numerator = d1.numerator * d2.denominator + d1.denominator*d2.numerator;
            return rez;
        }
        static public Fraction operator -(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.denominator - d2.numerator * d1.denominator;
            return rez;
        }
        static public Fraction operator *(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.numerator ;
            return rez;
        }
        static public Fraction operator /(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.numerator;
            rez.numerator = d1.numerator * d2.denominator ;
            return rez;
        }
        public static bool operator >(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction() ;
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a>b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a < b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a >= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a <= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            int a = d1.numerator * d2.denominator;
            int b = d1.denominator * d2.numerator;
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Fraction Shorten_Fraction()
        {
            Fraction rez = new Fraction();
            int a  = this.numerator;
            int b = this.denominator;
            while (a!=b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            rez.numerator = this.numerator/a;
            rez.denominator = this.denominator / a;
            return rez;
        }
    }
}
