using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Features.Customer.Models;

public class AuthenticateModel
{
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "آدرس ایمیل معتبر نیست")]
    public string Email { get; set; }

}