using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonAccountDto
    {
        public string? FullName { set; get; }
        public string? Family { get; set; }
        public string? Name { get; set; }
        public string? Father { get; set; }
        public string? MelliCode { get; set; }
        public string? Scode { get; set; }
        [Display(Name = "کد سپرده گذار")]
        [Required(ErrorMessage = "کدسپرده گذاراجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        public string Pcode { get; set; } = null!;

        [Display(Name = "شماره حساب")]
        [Required(ErrorMessage = "شماره حساب اجباری است ")]
        [Range(1, 99999, ErrorMessage = "شماره حساب حداکثر 5 رقمی است.")]
        public long HesabNo { get; set; }

        [Display(Name = "تاریخ افتتاح")]
        [Required(ErrorMessage = "تاریخ افتتاح اجباری است ")]
        public string? Date { get; set; }
        [Display(Name = "مبلغ افتتاحیه")]
        [Required(ErrorMessage = "مبلغ افتتاحیه.. اجباری است ")]
       // [Range(1, int.MaxValue, ErrorMessage = "مبلغ افتتاحیه نمی‌تواند صفر یا منفی باشد.")]
        public long Firstqty { get; set; } = 0;

        [Display(Name = "مبلغ ماهیانه")]
        [Required(ErrorMessage = "مبلغ ماهیانه اجباری است ")]
        [Range(1, int.MaxValue, ErrorMessage = "مبلغ ماهیانه نمی‌تواند صفر یا منفی باشد.")]
        public long? Monthqty { get; set; } = 0;

        public long Curqty { get; set; } = 0;

        public long? P { get; set; } = 0;

        public long? P1 { get; set; } = 0;

        public long? Moaref { get; set; } = 0; // idDi
        public int V_Day {  get; set; } 
        public int V_Month { get; set; } 
        public int V_Year { get; set; } 
        public long V_Mojodi { get; set; } = 0;

        public string PcodePlaceHolder => "کدسپرده گذار را وارد کنید ";
        public string HesabNoPlaceHolder => "شماره حساب را وارد کنید ";
        public string FirstqtyPlaceHolder => "مبلغ افتتاحیه را وارد کنید ";

    }
}
