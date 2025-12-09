using System.ComponentModel.DataAnnotations;

namespace SIMS.Data
{
    public class Notification
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Nội dung không được để trống")]
        public string Content { get; set; } = "";

        public string? LinkUrl { get; set; }        // Link đính kèm
        public string? AttachmentPath { get; set; } // Đường dẫn file
        public string? AttachmentName { get; set; } // Tên file hiển thị

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}