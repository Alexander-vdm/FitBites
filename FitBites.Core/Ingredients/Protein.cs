namespace FitBites.Core.Ingredients;

public sealed record Protein(decimal Grams)
{
    public const decimal KcalPerGram = 4m;

    public decimal Calories => Grams * KcalPerGram;
}
