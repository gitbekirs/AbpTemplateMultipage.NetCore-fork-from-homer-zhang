using System.ComponentModel.DataAnnotations;

namespace X.Dev.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}