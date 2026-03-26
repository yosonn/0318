namespace HNM.Models
{
    public class MealRecord
    {
        // 基礎辨識資訊
        public int Id { get; set; }
        public string Date { get; set; } = DateTime.Today.ToString("yyyy-MM-dd");
        public string Time { get; set; } = DateTime.Now.ToString("HH:mm");
        public string MealType { get; set; } = "午餐"; // 早餐, 午餐, 晚餐, 點心
        public string Name { get; set; } = ""; // 食物名稱
        public string Image { get; set; } = ""; // 圖片路徑或網址
        public string Icon { get; set; } = ""; // 存放 MudBlazor 的圖示代碼
                                               // Models/MealRecord.cs
            // ... (原本的欄位)
        public string Ingredients { get; set; } = ""; // 🌟 補上這行，用來存辨識出的食材
        
        // 營養成分數據
        public int Calories { get; set; } // 熱量
        public int Protein { get; set; }  // 蛋白質
        public int Carbs { get; set; }    // 碳水
        public int Fat { get; set; }      // 脂肪

        // 額外資訊
        public string? Notes { get; set; } // 備註
        public double Confidence { get; set; } = 0.92; // AI 辨識可信度 [cite: 155]
    }
}