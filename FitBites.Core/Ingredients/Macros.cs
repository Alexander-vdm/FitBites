namespace FitBites.Core.Ingredients;

public sealed record Macros
{
    public Macros(
        decimal proteinGrams, 
        decimal carboHydrateGrams, 
        decimal fiberGrams, 
        decimal sugarGrams, 
        decimal fatGrams, 
        decimal saturatedFatGrams, 
        decimal alcoholGrams)
    {
        Protein = new(proteinGrams);
        Carbs = new(carboHydrateGrams, sugarGrams, fiberGrams);
        Fat = new(fatGrams, saturatedFatGrams);
        Alcohol = new(alcoholGrams);
    }

    public decimal Calories => Protein.Calories + Carbs.Calories + Fat.Calories + Alcohol.Calories;

    public Protein Protein { get; }

    public Carbs Carbs { get; }

    public Fat Fat { get; }

    public Alcohol Alcohol { get; }
}