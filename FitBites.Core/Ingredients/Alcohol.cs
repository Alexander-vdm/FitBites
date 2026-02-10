namespace FitBites.Core.Ingredients;

public sealed record Alcohol
{
    public const decimal KcalPerGram = 7m;

    public Alcohol(decimal grams) => Grams = grams;

    public decimal Grams { get; }

    public decimal Calories => Grams * KcalPerGram;
}
