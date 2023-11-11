using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен 0", "denominator");
        }

        this.numerator = numerator;

        
        if (this.numerator == 0)
        {
            throw new ArgumentException("Числитель не может быть равен 0", "numerator");
        }

        this.denominator = denominator;
    }

    public int Numerator
    {
        get { return numerator; }
    }

    public int Denominator
    {
        get { return denominator; }
    }

    public static Fraction operator ++(Fraction fraction)
    {
        fraction.numerator *= fraction.denominator;
        return fraction;
    }

    public static Fraction operator --(Fraction fraction)
    {
        fraction.numerator *= fraction.denominator;
        return fraction;
    }

    public static Fraction operator !(Fraction fraction)
    {
        fraction.numerator = -fraction.numerator;
        return fraction;
    }

    public static bool operator true(Fraction fraction)
    {
        return fraction.numerator != 0;
    }

    public static bool operator false(Fraction fraction)
    {
        return fraction.numerator == 0;
    }

    public static implicit operator double(Fraction fraction)
    {
        return (double)fraction.numerator / fraction.denominator;
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static void Main()
    {
        Fraction fraction = new Fraction(1, 2);
        Console.WriteLine($"Initial Fraction: {fraction}");

        
        fraction++;
        Console.WriteLine($"After Increment: {fraction}");

       
        fraction--;
        Console.WriteLine($"After Decrement: {fraction}");

        
        fraction = !fraction;
        Console.WriteLine($"After Negation: {fraction}");

       
        if (fraction)
        {
            Console.WriteLine("Fraction is not zero");
        }
        else
        {
            Console.WriteLine("Fraction is zero");
        }
    }
}
