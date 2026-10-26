using System.ComponentModel.DataAnnotations;
using System.Reflection;
 namespace WebApplication7.Models;
public class Student
{
    public int Id { get; set; } // Mã sinh viên

    [Display(Name = "Họ tên")]
    [Required(ErrorMessage = "Họ tên là bắt buộc")]
    [StringLength(100, MinimumLength = 4,
        ErrorMessage = "Họ tên phải từ 4 đến 100 ký tự")]
    public string? Name { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
    [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$",
        ErrorMessage = "Email phải có đuôi @gmail.com")]
    public string? Email { get; set; }

    [Display(Name = "Mật khẩu")]
    [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
    [StringLength(100, MinimumLength = 8,
        ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$",
        ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Ngành học")]
    [Required(ErrorMessage = "Vui lòng chọn ngành học")]
    public Branch? Branch { get; set; }

    [Display(Name = "Giới tính")]
    [Required(ErrorMessage = "Vui lòng chọn giới tính")]
    public Gender? Gender { get; set; }

    [Display(Name = "Hệ chính quy")]
    public bool IsRegular { get; set; }

    [Display(Name = "Địa chỉ")]
    [DataType(DataType.MultilineText)]
    [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
    public string? Address { get; set; }

    [Display(Name = "Ngày sinh")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
    [BirthDateRange("1963-01-01", "2005-12-31",
    ErrorMessage = "Ngày sinh phải từ 01/01/1963 đến 31/12/2005")]
    public DateTime DateOfBorth { get; set; }

    // Trường điểm mới thêm
    [Display(Name = "Điểm")]
    [Required(ErrorMessage = "Điểm là bắt buộc")]
    [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0",
    ConvertValueInInvariantCulture = true)]
    public double? Score { get; set; }
    public string? Image { get; set; }
}