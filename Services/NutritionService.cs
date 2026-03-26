using HNM.Models;

namespace HNM.Services
{
    public class NutritionService
    {
        private List<MealRecord> _meals = new();

        public NutritionService()
        {
            // 🌟 把你原本的測試資料搬進來
            _meals.AddRange(new List<MealRecord>
            {
                new MealRecord { Id = 4, Date = "2026-03-14", Time = "08:00", MealType = "早餐", Name = "無糖豆漿與地瓜", Image = "https://images.unsplash.com/photo-1596040033229-a9821ebd058d?q=80&w=800&auto=format&fit=crop", Calories = 250, Protein = 15, Carbs = 40, Fat = 5 },
                new MealRecord { Id = 1, Date = "2026-03-14", Time = "12:30", MealType = "午餐", Name = "煎鮭魚穀物飯", Image = "https://images.unsplash.com/photo-1467003909585-2f8a72700288?q=80&w=800&auto=format&fit=crop", Calories = 540, Protein = 32, Carbs = 55, Fat = 17 },
                new MealRecord { Id = 5, Date = "2026-03-14", Time = "15:30", MealType = "點心", Name = "原味優格", Image = "https://images.unsplash.com/photo-1488477181946-6428a0291777?q=80&w=800&auto=format&fit=crop", Calories = 120, Protein = 10, Carbs = 15, Fat = 3 },
                new MealRecord { Id = 2, Date = "2026-03-14", Time = "19:00", MealType = "晚餐", Name = "雞肉堅果沙拉", Image = "https://images.unsplash.com/photo-1512621776951-a57141f2eefd?q=80&w=800&auto=format&fit=crop", Calories = 420, Protein = 28, Carbs = 20, Fat = 15 },
                new MealRecord { Id = 3, Date = "2026-03-13", Time = "18:30", MealType = "晚餐", Name = "牛肉漢堡", Image = "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?q=80&w=800&auto=format&fit=crop", Calories = 650, Protein = 35, Carbs = 40, Fat = 30 },
                new MealRecord { Id = 6, Date = "2026-03-12", Time = "12:00", MealType = "午餐", Name = "健康餐盒", Image = "https://images.unsplash.com/photo-1546069901-ba9599a7e63c?q=80&w=800&auto=format&fit=crop", Calories = 450, Protein = 25, Carbs = 30, Fat = 10 }
            });
        }

        public List<MealRecord> GetAllMeals() => _meals;

        public MealRecord GetMealById(int id) => _meals.FirstOrDefault(m => m.Id == id) ?? new MealRecord();

        public void AddMeal(MealRecord meal)
        {
            meal.Id = _meals.Any() ? _meals.Max(m => m.Id) + 1 : 1;
            _meals.Add(meal);
        }
    }
}