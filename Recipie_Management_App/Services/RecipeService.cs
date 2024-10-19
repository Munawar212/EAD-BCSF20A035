using Recipie_Management_App.Models;
// Services/RecipeService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipie_Management_App.Services
{
    public class RecipeService
    {
        private List<Recipe> recipes = new List<Recipe>
    {
        new Recipe { Id = 1, Name = "Spaghetti Bolognese", Ingredients = "Spaghetti, Meat, Tomato Sauce", Instructions = "Cook spaghetti. Mix with sauce.", Category = "Dinner", ImageUrl = "/images/spaghetti.jpg" },
        new Recipe { Id = 2, Name = "Pancakes", Ingredients = "Flour, Eggs, Milk", Instructions = "Mix ingredients. Cook on skillet.", Category = "Breakfast", ImageUrl = "/images/pancakes.jpg" },
        new Recipe { Id = 3, Name = "Chicken Salad", Ingredients = "Chicken, Lettuce, Dressing", Instructions = "Mix all ingredients.", Category = "Lunch", ImageUrl = "/images/salad.jpg" },
    };

        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await Task.FromResult(recipes);
        }
        public async Task<List<Recipe>> GetRecipesByCategory(string category)
        {
            return await Task.FromResult(recipes.Where(r => r.Category == category).ToList());
        }
        public async Task<Recipe> GetRecipeById(int id)
        {
            return await Task.FromResult(recipes.FirstOrDefault(r => r.Id == id));  // Assuming 'recipes' is the list of recipes
        }


        public async Task DeleteRecipe(int id)
        {
            var recipeToRemove = recipes.FirstOrDefault(r => r.Id == id);
            if (recipeToRemove != null)
            {
                recipes.Remove(recipeToRemove);
            }
            await Task.CompletedTask;
        }

        public async Task AddRecipe(Recipe recipe)
        {
            recipe.Id = recipes.Max(r => r.Id) + 1; // Assuming you use an in-memory list, generate an ID
            recipes.Add(recipe);
            await Task.CompletedTask; // Simulate async operation
        }


    }

}
