class Fractions
{
    private int _top;
    private int _bottom;

    public void Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public void FractionTop(int wholeNumber)
    {   
        _top = wholeNumber;
        _bottom = 1;
         Console.WriteLine($"{_top}/{_bottom}");
    }
    public void FractionTopBottom(int top, int bottom)
    {   
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double fraction = (double)_top / _bottom;
        return Math.Round(fraction, 2);
    }
}