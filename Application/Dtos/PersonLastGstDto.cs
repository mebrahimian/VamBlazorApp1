using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonLastGstDto
    {
        public string Code { get; set; } = null!;
        public string? FullName { get; set; }
        public char? Sex { get; set; } = '1';
        public char? City { get; set; } = '1';
        public long? HesabNo { get; set; }
        public long? Moaref { get; set; } = 0;
        public long MonthQty { get; set; } = 0;
        public long Mojodi { get; set; } = 0;
        public int? ReqNo { get; set; }
        public char Type { get; set; }
        public string? DateD { get; set; }
        public long MblgVam { get; set; } = 0;
        public int? PKarmozd { get; set; }
        public int? MKarmozd { get; set; }
        public byte? GstNo { get; set; }
        public int? GstPay { get; set; }
        public string? LastDate { get; set; }
        public long PaidVam { get; set; }
        public byte? CurrentGstNo { get; set; }
        public string? CurrentGstDate { get; set; }
        public string? CurrentPaidDate { get; set; }    
        public long CurrentGstMblg { get; set; }
        public bool CurrentGstSaved { get; set; } = false;
        public string? Mellicode { get; set; }   



    }
}
