namespace FitBites.Core.Recipes;

public sealed class Recipe
{
    public Recipe(RecipeDetails details, IEnumerable<RecipeIngredient> recipeIngredients)
    {
        ArgumentNullException.ThrowIfNull(details);
        ArgumentNullException.ThrowIfNull(recipeIngredients);

        if (!recipeIngredients.Any())
        {
            throw new ArgumentException("A recipe must have at least one ingredient.", nameof(recipeIngredients));
        }

        Details = details;
        _recipeIngredients = recipeIngredients.ToList();
        
        // Implement position validation
    }

    public int Id { get; }

    public RecipeDetails Details { get; }

    public ushort Calories
    {
        get
        {
            decimal total = _recipeIngredients.Sum(x => x.Ingredient.Macros.Calories);
            return checked((ushort)total);
        }
    }

    public IReadOnlyCollection<RecipeIngredient> RecipeIngredients => _recipeIngredients.AsReadOnly();

    private readonly List<RecipeIngredient> _recipeIngredients = [];
}
