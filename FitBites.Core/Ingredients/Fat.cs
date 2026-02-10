namespace FitBites.Core.Ingredients;

public sealed record Fat
{
    public const decimal KcalPerGram = 9m;

    public Fat(decimal total, decimal saturated)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThan(saturated, total);

        TotalGrams = total;
        SaturatedGrams = saturated;
    }

    public decimal TotalGrams { get; }

    public decimal SaturatedGrams { get; }

    public decimal UnsaturatedGrams => TotalGrams - SaturatedGrams;

    public decimal Calories => TotalGrams * KcalPerGram;
}
