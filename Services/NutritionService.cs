using HNM.Models;

namespace HNM.Services
{
    public class NutritionService
    {
        private readonly List<MealRecord> _meals = new();
        private readonly object _syncLock = new();

        public NutritionService()
        {
        }

        public List<MealRecord> GetAllMeals()
        {
            lock (_syncLock)
            {
                return _meals.Select(CloneMeal).ToList();
            }
        }

        public MealRecord GetMealById(int id)
        {
            lock (_syncLock)
            {
                var meal = _meals.FirstOrDefault(m => m.Id == id);
                return meal is null ? new MealRecord() : CloneMeal(meal);
            }
        }

        public void AddMeal(MealRecord meal)
        {
            lock (_syncLock)
            {
                var mealToAdd = CloneMeal(meal);
                mealToAdd.Id = _meals.Any() ? _meals.Max(m => m.Id) + 1 : 1;
                NormalizeMeal(mealToAdd);
                _meals.Add(mealToAdd);
            }
        }

        public void DeleteMeal(int id)
        {
            lock (_syncLock)
            {
                var mealToRemove = _meals.FirstOrDefault(m => m.Id == id);
                if (mealToRemove != null)
                {
                    _meals.Remove(mealToRemove);
                }
            }
        }

        public void UpdateMeal(MealRecord updatedMeal)
        {
            lock (_syncLock)
            {
                var existingMeal = _meals.FirstOrDefault(m => m.Id == updatedMeal.Id);
                if (existingMeal != null)
                {
                    existingMeal.Name = updatedMeal.Name;
                    existingMeal.MealType = updatedMeal.MealType;
                    existingMeal.Calories = updatedMeal.Calories;
                    existingMeal.Protein = updatedMeal.Protein;
                    existingMeal.Carbs = updatedMeal.Carbs;
                    existingMeal.Fat = updatedMeal.Fat;
                    existingMeal.Ingredients = updatedMeal.Ingredients;
                    existingMeal.Notes = updatedMeal.Notes;
                    NormalizeMeal(existingMeal);
                }
            }
        }

        private static MealRecord CloneMeal(MealRecord meal) =>
            new()
            {
                Id = meal.Id,
                Date = meal.Date,
                Time = meal.Time,
                MealType = meal.MealType,
                Name = meal.Name,
                Image = meal.Image,
                Icon = meal.Icon,
                Ingredients = meal.Ingredients,
                Calories = meal.Calories,
                Protein = meal.Protein,
                Carbs = meal.Carbs,
                Fat = meal.Fat,
                Notes = meal.Notes,
                Confidence = meal.Confidence
            };

        private static void NormalizeMeal(MealRecord meal)
        {
            meal.Name = meal.Name?.Trim() ?? string.Empty;
            meal.MealType = meal.MealType?.Trim() ?? string.Empty;
            meal.Ingredients = meal.Ingredients?.Trim() ?? string.Empty;
            meal.Notes = string.IsNullOrWhiteSpace(meal.Notes) ? null : meal.Notes.Trim();

            meal.Calories = Math.Max(0, meal.Calories);
            meal.Protein = Math.Max(0, meal.Protein);
            meal.Carbs = Math.Max(0, meal.Carbs);
            meal.Fat = Math.Max(0, meal.Fat);
            meal.Confidence = Math.Clamp(meal.Confidence, 0, 1);
        }
    }
}
