using System.Collections.Generic;

namespace API_HSN.Dtos
{
    public class DashboardSummaryDto
    {
        public decimal? TotalCalories { get; set; }
        public string? DailyAdvice { get; set; }
        public List<string>? MealNames { get; set; }
    }
}