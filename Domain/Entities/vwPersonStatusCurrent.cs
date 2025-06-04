namespace VamBlazor.Client.Domain.Entities
{
    public class vwPersonStatusCurrent
    {
        public string Code { set; get; }
        public string FullName { get; set; }
        public char Sex { get; set; }
        public string SexDesc { get; set; }
        public char City { get; set; }
        public string CityDesc { get; set; }
        public long HesabNo { get; set; }
        public long Moaref { get; set; }
        public long Mojodi { get; set; }
        public long MonthQty { get; set; }
        public int ReqNo { get; set; }  
        public string DateVam { set; get; } = "";
        public long MblgVam { get; set; }
        public byte GstNo { get; set; }
        public long Gst1 { get; set; }
        public long Gst2 { get; set; }
        public char Type { get; set; }  
        public int GstPay {  get; set; }     
        public int PKarmozd { get; set; }   
        public int MKarmozd { get; set; }   
        public long PaidVam { get; set; }
        public byte CurrentGstNo { get; set; }
        public long CurrentGstMblg { get; set; }
        public string CurrentGstDate { get; set; }
        public int DelayGst { get; set; }
        public long RemainVam { get; set; }

    }
}
