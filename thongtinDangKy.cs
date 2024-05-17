using System.ComponentModel.DataAnnotations;
using WebsiteQLHDTN.Models;

namespace WebsiteQLHDTN.ViewModels
{
    public class thongtinDangKy
    {
        public List<string> tenban1 {  get; set; } = new List<string>();
        public int Idhoatdong1 { get; set; }
        public string? Tenhoatdong1 { get; set; }
        public int Idcanhan1 { get; set; }
        public DateOnly? Thoigiandangky1 { get; set; }

        public string? Bandangky1 { get; set; }
        [Required]
        public string? Uudiem1 { get; set; }
        [Required]
        public string? Nhuocdiem1 { get; set; }

        public bool? Trangthaiduyetdon1 { get; set; } = false;
    }
}
