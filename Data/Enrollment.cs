using System.ComponentModel.DataAnnotations;

namespace SIMS.Data
{
    public class Enrollment
    {
        public int Id { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        
        public string StudentId { get; set; } = null!;
        public ApplicationUser Student { get; set; } = null!;

        // Thêm trường điểm số (0 - 10)
        [Range(0, 10, ErrorMessage = "Score must be between 0 and 10")]
        public double? Score { get; set; }
    }
}