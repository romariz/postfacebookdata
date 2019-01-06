using System.ComponentModel.DataAnnotations;

namespace RomarizIT.PostFromFacebookData.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
