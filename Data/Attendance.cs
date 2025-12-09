using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.Data
{
    public class Attendance
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        public string StudentId { get; set; } = string.Empty;
        [ForeignKey("StudentId")]
        public ApplicationUser? Student { get; set; }

        public DateOnly Date { get; set; }

        public bool IsAbsent { get; set; } // True = Absent
        public string? Note { get; set; }
    }
}