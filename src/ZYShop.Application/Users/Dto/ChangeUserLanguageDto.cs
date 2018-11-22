using System.ComponentModel.DataAnnotations;

namespace ZYShop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}