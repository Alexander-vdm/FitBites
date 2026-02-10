namespace FitBites.Core.Ingredients;

public interface IReadOnlyIngredient
{
    int Id { get; }

    string Name { get; }

    NutritionBasis NutritionBasis { get; }

    Macros Macros { get; }
}
