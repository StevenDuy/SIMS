using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.Data
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        // --- QUAN TRỌNG: Lưu ngày học cụ thể (VD: 12/10/2025) ---
        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        [Required]
        public string Room { get; set; } = string.Empty;

        // Đánh dấu: Giáo viên đã chốt điểm danh buổi này chưa?
        public bool IsAttendanceTaken { get; set; } = false;

        // Property phụ trợ để lấy Thứ (Không lưu DB)
        [NotMapped]
        public DayOfWeek DayOfWeek => Date.DayOfWeek;
    }
}