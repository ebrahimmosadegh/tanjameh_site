using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Features.Customer.Models;

public class LoginModel
{
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "آدرس ایمیل معتبر نیست")]
    public string Email { get; set; }

    [Required(ErrorMessage = "رمز عبور الزامی است")]
    public string Password { get; set; }
}