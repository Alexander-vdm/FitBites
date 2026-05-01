using FitBites.Core.Recipes;

namespace FitBites.Core.Ingredients;

public static class NutritionBasisExtensions
{
    public static decimal BaseAmount(this NutritionBasis basis)
    {
        return basis switch
        {
            NutritionBasis.Per100Gram => 100m,
            NutritionBasis.Per100Milliliter => 100m,
            NutritionBasis.PerPiece => 1m,
            _ =>  throw new ArgumentOutOfRangeException(nameof(basis)) //test
        };
    }

    public static Unit RequiredUnit(this NutritionBasis basis)
    {
        return basis switch
        {
            NutritionBasis.Per100Gram => Unit.Gram,
            NutritionBasis.Per100Milliliter => Unit.Milliliter,
            NutritionBasis.PerPiece => Unit.Piece,
            _ => throw new ArgumentOutOfRangeException(nameof(basis))
        };
    }
}
