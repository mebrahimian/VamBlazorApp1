using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static VamBlazor.Client.Pages.FormMudSample;
using VamBlazor.Client.Application.CommonFunc;


namespace VamBlazor.Client.Application.Dtos
{
    public class PersonPVamDto
    {
        public string? FullName { set; get; }
        [Display(Name = "شماره وام")]
        [Required(ErrorMessage = "شماره وام اجباری است ")]
        public int ReqNo { get; set; }
        public long? HesabNo { get; set; } = 0;
        public string? Pcode { get; set; } = null!;
        public string? Scode { get; set; }
        [Display(Name = "مبلغ وام")]
        [Required(ErrorMessage = "مبلغ وام اجباری است ")]
        //  [Range(1, int.MaxValue, ErrorMessage = "مبلغ وام نمی‌تواند صفر یا منفی باشد.")]
        public long? Mblgvam { get; set; } = 0;

        public long? Gst1 { get; set; }

        public long? Gst2 { get; set; }

        public byte? GstNo { get; set; }
        [Display(Name = "تاریخ وام")]
        [Required(ErrorMessage = "تاریخ وام اجباری است ")]
        public string? DateD { get; set; }

        public string? DateG { get; set; }

        public int? GstPay { get; set; }

        public char? Status { get; set; } = '0';

        public string? Sabtdate { get; set; }

        public int? Pkarmozd { get; set; }

        public int? Mkarmozd { get; set; }

        public string? Lastdate { get; set; }

        public char? Type { get; set; } = '1';

        public int? Mblgmain { get; set; }
        public bool? isEditable { get; set; } = false;
        public string? V_isEditableDesc => CodeToStringFunctions.GetPardakhtDesc(isEditable ?? false);
        public string ReqNoPlaceHolder => " شماره وام را وارد کنید ";
    }

}
