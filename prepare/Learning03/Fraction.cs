using System.Reflection.Metadata;

public class Fraction
{
    private int _top;
    private int _bottom;

    public void SetNumerator(int numerator) {
        this._top = numerator;
    }
    public int GetNumerator() {
        return this._top;
    }
    public void SetDenominator(int denominator) {
        this._bottom = denominator;
    }
    public int GetDenominator() {
        return this._bottom;
    }

    public Fraction(int top, int bottom) {
        this.SetNumerator(top);
        this.SetDenominator(bottom);
    }

    public Fraction(int wholeNumber)
        : this(wholeNumber, 1)
        {}

    public Fraction ()
        : this(1, 1)
        {}

    public string GetFractionString() {
        string representation = string.Empty;
        if (this.GetDenominator() == 1)
            representation = $"{this.GetNumerator()}";
        else
            representation = $"{this.GetNumerator()} / {this.GetDenominator()}";
        return representation;
    }

    public double GetDecimalValue() {
        return (double) this.GetNumerator() /  (double) this.GetDenominator();
    }

}