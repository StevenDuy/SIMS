using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.Data
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // --- CẦN CÓ THUỘC TÍNH NÀY ---
        [Required]
        public string Code { get; set; } = string.Empty;
        // -----------------------------

        public int? SubjectId { get; set; } // Cho phép null nếu cần
        public Subject? Subject { get; set; }

        public int? SemesterId { get; set; } // Cho phép null nếu cần
        public Semester? Semester { get; set; }

        public string? LectureId { get; set; } // Cho phép null
        [ForeignKey("LectureId")]
        public ApplicationUser? Lecture { get; set; }
    }
}