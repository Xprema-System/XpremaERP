using System.ComponentModel.DataAnnotations;

namespace Xprema.ERP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}