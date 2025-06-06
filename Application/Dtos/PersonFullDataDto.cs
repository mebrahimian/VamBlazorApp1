using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonFullDataDto
    {
        public string Code { get; set; } = null!;
        [Display(Name = "شماره حساب")]
        [Required(ErrorMessage = "شماره حساب اجباری است ")]
        public string? FullName { set; get; }
        public string? FullNameWCode { set; get; }

        [Display(Name = "کد سپرده گذار")]
        [Required(ErrorMessage = "کدسپرده گذاراجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        
        public long? HesabNo { get; set; }
        [Display(Name = "تاریخ افتتاح")]
        [Required(ErrorMessage = "تاریخ افتتاح اجباری است ")]
        public string? HDate { get; set; }
        [Display(Name = "موجودی اولیه")]
        [Required(ErrorMessage = "موجودی اولیه اجباری است ")]
        [Range(1, long.MaxValue, ErrorMessage = "موجودی اولیه نمی‌تواند صفر یا منفی باشد.")]
        public long Firstqty { get; set; } = (long)0;
        public long Mojodi { get; set; } = (long)0;

        [Display(Name = "مبلغ ماهیانه")]
        [Required(ErrorMessage = "مبلغ ماهیانه اجباری است ")]
     //   [Range(1, int.MaxValue, ErrorMessage = "مبلغ ماهیانه نمی‌تواند صفر یا منفی باشد.")]
        public long Monthqty { get; set; } = (long)0;
        public char Status { get; set; } = '0';
        public long Curqty { get; set; } = (long)0;

        public int QReqNo { get; set; }

        public string? QDate { get; set; }
        public long Mblg { get; set; }
        public char Type { get; set; }
        public int PReqNo { get; set; }
        public string? MelliCode { get; set; }

    }
}
