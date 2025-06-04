namespace VamBlazor.Client.Domain.Entities
{
    public class sp_PersonStatusUpTo
    {
        public string Code { set; get; }
        public string Fam { get; set; }
        public Char Sex { get; set; }
        public long Hesab_No { get; set; }
        public string? Date_D { get; set; }
        public long? Mblgvam { get; set; }
        public int? Mblgmain { get; set; }
        public byte? Gst_No { get; set; }
        public long? Gst1 { get; set; }
        public long? Gst2 { get; set; }
        public long MblgPaid { get; set; }
        public long Mojodi { get; set; }
        public byte? DelayAghsat { get; set; }
    }
}
