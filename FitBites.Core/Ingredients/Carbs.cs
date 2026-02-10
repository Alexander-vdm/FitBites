namespace FitBites.Core.Ingredients;

public sealed record Carbs
{
    public const decimal KcalPerGram = 4m;

    public Carbs(decimal total, decimal sugar, decimal fiber)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThan(sugar, total);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(fiber, total);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(sugar + fiber, total);

        TotalGrams = total;
        SugarGrams = sugar;
        FiberGrams = fiber;
    }

    public decimal TotalGrams { get; }

    public decimal SugarGrams { get; }

    public decimal FiberGrams { get; }

    public decimal Calories => TotalGrams * KcalPerGram;
}
