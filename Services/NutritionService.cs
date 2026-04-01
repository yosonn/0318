using HNM.Models;
using static MudBlazor.Colors;

namespace HNM.Services
{
    public class NutritionService
    {
        // 🌟 1. 這裡初始化一個真正乾淨的空串列
        private List<MealRecord> _meals = new();

        public NutritionService()
        {
            // 🌟 2. 這裡已經清空了！不再塞入任何預設的假資料
        }

        public List<MealRecord> GetAllMeals() => _meals;

        public MealRecord GetMealById(int id) => _meals.FirstOrDefault(m => m.Id == id) ?? new MealRecord();

        public void AddMeal(MealRecord meal)
        {
            meal.Id = _meals.Any() ? _meals.Max(m => m.Id) + 1 : 1;
            _meals.Add(meal);
        }

        public void DeleteMeal(int id)
        {
            var mealToRemove = _meals.FirstOrDefault(m => m.Id == id);
            if (mealToRemove != null)
            {
                _meals.Remove(mealToRemove);
            }
        }
    }
}