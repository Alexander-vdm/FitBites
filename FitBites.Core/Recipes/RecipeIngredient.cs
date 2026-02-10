using FitBites.Core.Ingredients;

namespace FitBites.Core.Recipes;

public sealed class RecipeIngredient
{
    private readonly Ingredient _ingredient;

    public RecipeIngredient(Ingredient ingredient, Quantity quantity, ushort position)
    {
        ArgumentNullException.ThrowIfNull(ingredient);
        ArgumentNullException.ThrowIfNull(quantity);

        if (Quantity!.Unit != Ingredient.NutritionBasis.RequiredUnit())
        {
            throw new InvalidOperationException($"Quantity unit {Quantity.Unit} is not valid for basis {Ingredient.NutritionBasis}");
        }

        _ingredient = ingredient;
        Quantity = quantity;
        Position = position;
    }

    public IReadOnlyIngredient Ingredient => _ingredient;

    public Quantity Quantity { get; }

    public ushort Position { get; }

    public decimal Calories => Ingredient.Macros.Calories * Quantity.Amount / Ingredient.NutritionBasis.BaseAmount();
}
