using System.ComponentModel.DataAnnotations;

namespace SIMS.Data
{
    public class Semester
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Semester Name is required")]
        public string Name { get; set; } = string.Empty; // Ví dụ: Spring 2025

        [Required(ErrorMessage = "Semester Code is required")]
        public string Code { get; set; } = string.Empty; // Ví dụ: SP25

        [Required]
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now); // Ngày bắt đầu

        [Required]
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now.AddMonths(4));   // Ngày kết thúc
    }
}