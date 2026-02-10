namespace FitBites.Core.Recipes;

public sealed record Quantity(decimal Amount, Unit Unit)
{
    public static Quantity Grams(decimal grams)
    {
        ArgumentOutOfRangeException.ThrowIfZero(grams);
        return new Quantity(grams, Unit.Gram);
    }

    public static Quantity Milliliters(decimal ml)
    {
        ArgumentOutOfRangeException.ThrowIfZero(ml);
        return new Quantity(ml, Unit.Milliliter);
    }

    public static Quantity Pieces(decimal pieces)
    {
        ArgumentOutOfRangeException.ThrowIfZero(pieces);
        return new Quantity(pieces, Unit.Piece);
    }
}
