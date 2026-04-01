using System.Collections.Generic;

namespace API_HSN.Dtos
{
    public class UserProfileDto
    {
        public string? UserName { get; set; }
        public List<string>? Diseases { get; set; }
        public string? BloodPressure { get; set; }
        public decimal? BloodGlucose { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? BMI { get; set; }
    }
}