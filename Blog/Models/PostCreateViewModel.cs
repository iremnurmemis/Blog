using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Blog.Models{

    public class PostCreateViewModel{

        public int PostId { get; set; }

        [Required]
        [Display(Name = "Başlık")]
        public string? Title{ get; set; }

        [Required]
        [Display(Name = "Açıklama")]
        public string? Description{ get; set; }


        [Required]
        [Display(Name = "İçerik")]
        public string? Content{ get; set; }

        [Required]
        [Display(Name = "Url")]
        public string? Url{ get; set; }

        public bool IsActive{ get; set; }
    }


}