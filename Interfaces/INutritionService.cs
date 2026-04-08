using HNM.Models;
using ResponseModel;

namespace HNM.Interfaces
{
    public interface INutritionService
    {
        Task<ResponseModel<List<MealRecord>>?> GetAllMealsAsync();
        Task<ResponseModel<MealRecord>?> GetMealByIdAsync(int id);
        Task<ResponseModel<bool>?> AddMealAsync(MealRecord meal);
        Task<ResponseModel<bool>?> UpdateMealAsync(MealRecord meal);
        Task<ResponseModel<bool>?> DeleteMealAsync(int id);
    }
}