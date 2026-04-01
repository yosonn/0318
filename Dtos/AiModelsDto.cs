using System.Collections.Generic;

namespace API_HSN.Dtos
{
    public class AIVlmRequestDto
    {
        public string? PhotoBase64 { get; set; }
    }

    public class AIVlmResponseDto
    {
        public string? MealName { get; set; }
        public List<string>? Ingredients { get; set; }
        public decimal? TotalCalories { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Carbs { get; set; }
        public decimal? Fat { get; set; }
    }

    public class AIRagRequestDto
    {
        public string? FoodName { get; set; }
        public List<string>? Diseases { get; set; }
    }

    public class AIRagResponseDto
    {
        public string? DietaryAdvice { get; set; }
    }
}