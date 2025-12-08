using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.Data
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public string StudentId { get; set; } = string.Empty;
        public ApplicationUser? Student { get; set; }

        // --- CẬP NHẬT TẠI ĐÂY ---
        [Range(0, 10, ErrorMessage = "Score must be between 0 and 10")]
        public double? Score { get; set; }
    }
}