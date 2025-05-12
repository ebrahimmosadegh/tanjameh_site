namespace Tanjameh.Features.Customer.Models;

using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "آدرس ایمیل معتبر نیست")]
    public string Email { get; set; }

    [Required(ErrorMessage = "رمز عبور الزامی است")]
    [StringLength(100, ErrorMessage = "رمز عبور باید حداقل {2} و حداکثر {1} کاراکتر باشد", MinimumLength = 6)]
    public string Password { get; set; }

    //[Compare("Password", ErrorMessage = "رمز عبور و تکرار آن مطابقت ندارند")]
    //public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "نام الزامی است")]
    [StringLength(50, ErrorMessage = "نام نباید بیشتر از 50 کاراکتر باشد")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "نام خانوادگی الزامی است")]
    [StringLength(50, ErrorMessage = "نام خانوادگی نباید بیشتر از 50 کاراکتر باشد")]
    public string LastName { get; set; }


}