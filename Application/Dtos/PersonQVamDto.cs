using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static VamBlazor.Client.Pages.FormMudSample;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonQVamDto
    {
        public string? FullName { set; get; }
        [Display(Name = "شماره تقاضا")]
        [Required(ErrorMessage = "شماره تقاضا اجباری است ")]
        public int ReqNo { get; set; }

        [Display(Name = "کد سپرده گذار")]
        [Required(ErrorMessage = "کدسپرده گذاراجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        public string Pcode { get; set; } = null!;

        [Display(Name = "مبلغ تقاضا")]
        [Required(ErrorMessage = "مبلغ تقاضا اجباری است ")]
       // [Range(1, int.MaxValue, ErrorMessage = "مبلغ تقاضا نمی‌تواند صفر یا منفی باشد.")]
        public long Mblg { get; set; } = 0;
        [Display(Name = "تاریخ تقاضا")]
        [Required(ErrorMessage = "تاریخ تقاضا اجباری است ")]
        public string? Date { get; set; }
        public string? Sabtdate { get; set; }
        public char Status { get; set; } = '0'; 
        public char TypeVam { get; set; } = '1';
        public long? HesabNo { get; set; } = 0;
        public bool? isEditable { get; set; } = false;
        public string? V_isEditableDesc => CodeToStringFunctions.GetTasvibDesc(isEditable ?? false);
        public int V_Day {  get; set; } 
        public int V_Month { get; set; } 
        public int V_Year { get; set; }
        public string?  V_TypeVamDesc { get; set; }  
        public string ReqNoPlaceHolder => " شماره تقاضا را وارد کنید ";

    }
}
