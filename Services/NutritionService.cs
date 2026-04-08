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
        // 🌟 新增：用來更新餐點資料的方法
        public void UpdateMeal(MealRecord updatedMeal)
        {
            // 1. 先在你的資料庫(或記憶體清單)中，找找看有沒有這筆 Id 的舊資料
            // ⚠️ 注意：這裡的 "meals" 請換成你 Service 裡面宣告的那個 List 變數名稱 (可能是 _meals 或 meals)
            var existingMeal = _meals.FirstOrDefault(m => m.Id == updatedMeal.Id);

            // 2. 如果有找到，就把新的值全部覆蓋過去
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

                // 如果未來你有新增其他可以修改的欄位，也要記得補在這裡喔！
            }
        }
    }
}