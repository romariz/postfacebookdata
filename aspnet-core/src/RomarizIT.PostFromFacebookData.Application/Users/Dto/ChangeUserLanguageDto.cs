using System.ComponentModel.DataAnnotations;

namespace RomarizIT.PostFromFacebookData.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}