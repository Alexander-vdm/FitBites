namespace FitBites.Core.Recipes;

public sealed record RecipeDetails
{
    private const int _minLengthName = 4;
    private const int _maxLengthName = 20;

    private const int _minLengthDescription = 10;
    private const int _maxLengthDescription = 50;

    private const int _minLengthPreparation= 10;
    private const int _maxLengthPreparation = 1_000;

    public RecipeDetails(string name, string description, string preparation)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(description);
        ArgumentException.ThrowIfNullOrWhiteSpace(preparation);

        var trimmedName = name.Trim();
        var trimmedDescription = description.Trim();
        var trimmedPreparation = preparation.Trim();

        ArgumentOutOfRangeException.ThrowIfLessThan(trimmedName.Length, _minLengthName);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(trimmedName.Length, _maxLengthName);
        ArgumentOutOfRangeException.ThrowIfLessThan(trimmedDescription.Length, _minLengthDescription);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(trimmedDescription.Length, _maxLengthDescription);
        ArgumentOutOfRangeException.ThrowIfLessThan(trimmedPreparation.Length, _minLengthPreparation);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(trimmedPreparation.Length, _maxLengthPreparation);

        Name = name;
        Description = description;
        Preparation = preparation;
    }

    public string Name { get; }

    public string Description { get; }

    public string Preparation { get; }
}
