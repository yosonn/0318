using System;

namespace API_HSN.Dtos
{
    public class DietLogDetailDto
    {
        public DateTime? RecordDate { get; set; }
        public string? PhotoBase64 { get; set; }
        public string? MealName { get; set; }
        public decimal? TotalCalories { get; set; }
        public string? RecipeContent { get; set; }
        public string? DietaryAdvice { get; set; }
    }
}