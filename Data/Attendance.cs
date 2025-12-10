using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.Data
{
    public class Attendance
    {
        public int Id { get; set; }

        public int ScheduleId { get; set; } // Liên kết với buổi học cụ thể
        [ForeignKey("ScheduleId")]
        public Schedule? Schedule { get; set; }

        public string StudentId { get; set; } = string.Empty;
        [ForeignKey("StudentId")]
        public ApplicationUser? Student { get; set; }

        public bool IsAbsent { get; set; } = true;
        public string? Note { get; set; }
    }
}