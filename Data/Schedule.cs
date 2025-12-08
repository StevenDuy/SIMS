using System.ComponentModel.DataAnnotations;

namespace SIMS.Data
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; } // Đã đổi từ TimeSpan sang TimeOnly

        [Required]
        public TimeOnly EndTime { get; set; }   // Đã đổi từ TimeSpan sang TimeOnly

        [Required]
        public string Room { get; set; } = string.Empty;
    }
}