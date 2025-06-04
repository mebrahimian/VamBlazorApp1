using Microsoft.EntityFrameworkCore;

namespace VamBlazor.Client.Application.Dtos
{
    [Keyless] // خیلی مهم!
    public class PersonStatusUpToDto
    {
        public string Code { set; get; }
        public string Fam { get; set; }
        public Char Sex { get; set; } 
        public long Hesab_No { get; set; }
        public string? Date_D { get; set; }
        public long? Mblgvam { get; set; }
        public int? Mblgmain { get; set; }
        public int? Gst_No { get; set; }
        public long Gst1 { get; set; }
        public long Gst2 { get; set; }
        public long MblgPaid { get; set; }
        public long VamRemain { get; set; } 
        public long Mojodi { get; set; }
        public int? DelayAghsat { get; set; }
        public long MonthQty { get; set; }

    }

}
