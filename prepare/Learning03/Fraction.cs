using System;

public class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        _top = 1;
        _bot = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bot = 1;

    }

    public Fraction(int top, int bot)
    {
        _top = top;
        _bot = bot;

    }
    

    public string GetFractionString()
    {

        string  fraction_string = $"{_top}/{_bot}";
        return fraction_string;
    }

    public double GetDecimalValue()
    {

        return (double)_top / (double)_bot;
    }




}