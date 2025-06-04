using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonDto
    {
        [Display(Name = "کدسپرده گذار")]
        [Required(ErrorMessage = "کدسپرده گذار اجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        public string Code { get; set; } = null!;
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی اجباری است ")]
        [MaxLengthAttribute(30, ErrorMessage = "حداکثر 30 حرف وارد کنید")]
        public string? Family { get; set; }
        [Display(Name = "نـــــام")]
        [Required(ErrorMessage = "نام اجباری است ")]
        [MaxLengthAttribute(20, ErrorMessage = "حداکثر 20 حرف وارد کنید")]
        public string? Name { get; set; }
        [Display(Name = "نــــام پدر")]
        [MaxLengthAttribute(20, ErrorMessage = "حداکثر 20 حرف وارد کنید")]
        public string? Father { get; set; }

        public Char Sex { get; set; } = '1';

        public string? IssueNo { get; set; } 

        public string? Tel { get; set; }
        [MaxLengthAttribute(100, ErrorMessage="حداکثر 100 حرف وارد کنید")] 
        public string? Address { get; set; }

        public Char City { get; set; } = '1';

        public string? Mellicode { get; set; }

        //public long IdDi { get; set; }

        public Char Status { get; set; } = '1';

        public string? CardBank { get; set; }

        public int? BankType { get; set; }

        public string? HesabBank { get; set; }
        public string? V_CityDesc { get; set; } 
        public string? FullName { get; set; }   

        public string CodePlaceHolder => "کدسپرده گذار را وارد کنید "; 
        public string NamePlaceHolder => "نام را وارد کنید ";
        public string FamilyPlaceHolder => "نام خانوادگی را وارد کنید ";
    }
}
