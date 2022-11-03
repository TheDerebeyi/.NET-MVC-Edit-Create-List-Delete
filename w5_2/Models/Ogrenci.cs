using System.ComponentModel.DataAnnotations;

namespace w5_2.Models
{
    public class Ogrenci
    {
        [Display(Name ="Öğrenci Ad")]
        public string OgrAd { get; set; }
        [Display(Name = "Öğrenci Soyad")]
        public string OgrSoyad { get; set; }
        [Required]
        [Display(Name = "Öğrenci Numara")]
        public string OgrNumara { get; set; }
        [Display(Name = "Öğrenci Yaş")]
        public int OgrYas { get; set; }
    }
}
