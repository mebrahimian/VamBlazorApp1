using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonTotalGstDto
    {
        public string Code { get; set; } = null!;
        public string? FullName { get; set; }
        public long? HesabNo { get; set; }
        public long? Moaref { get; set; } = 0;
        public long MonthQty { get; set; } = 0;
        public long Mojodi { get; set; } = 0;
        public int? ReqNo { get; set; }
        public char Type { get; set; }
        public string? DateD { get; set; }
        public long MblgVam { get; set; } = 0;
        public byte? GstNo { get; set; }
        public string? GstDate { get; set; }
        public string? PaidDate { get; set; }    
        public long Pasandaz { get; set; }
        public long GstMblg { get; set; } = 0;
        public bool CurrentGstSaved { get; set; } = false;


    }
}
