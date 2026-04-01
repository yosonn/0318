using System;
using System.Collections.Generic;

namespace API_HSN.Dtos
{
    public class ImageAnalysisRequestDto
    {
        public DateTime? RecordDate { get; set; }
        public string? MealType { get; set; }
        public string? PhotoBase64 { get; set; }
    }

    public class ImageAnalysisResponseDto
    {
        public string? MealName { get; set; }
        public List<string>? Ingredients { get; set; }
        public decimal? TotalCalories { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Carbs { get; set; }
        public decimal? Fat { get; set; }
        public string? DietaryAdvice { get; set; }
    }
}