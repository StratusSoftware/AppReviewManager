using System.ComponentModel.DataAnnotations;

namespace AppReview.Shared.Models.Enums;

public enum ReasonType
{
    [Display(Name = "Offensive")]
    Offensive,

    [Display(Name = "False")]
    False,

    [Display(Name = "Bot")]
    Bot
}

