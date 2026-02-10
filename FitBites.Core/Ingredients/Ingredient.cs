namespace FitBites.Core.Ingredients;

public sealed class Ingredient : IReadOnlyIngredient
{
    public Ingredient(string name, NutritionBasis nutritionBasis, Macros macros)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentNullException.ThrowIfNull(macros);

        Name = name;
        Macros = macros;
        NutritionBasis = nutritionBasis;
    }

    public int Id { get; }

    public string Name { get; }

    public Macros Macros { get; }

    public NutritionBasis NutritionBasis { get; }
}
