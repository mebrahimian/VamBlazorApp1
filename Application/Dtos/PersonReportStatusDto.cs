namespace VamBlazor.Client.Application.Dtos
{
    public class PersonReportStatusDto
    {
        public string Pcode { set; get; }
        public long HesabNo { get; set; }
        public string Date { set; get; } = "";
        public string RecordType { get; set; }
        public long Vam { get; set; }
        public long GstPaid { get; set; }
        public long Pasandaz { get; set; }
        public long Karmozd { get; set; }
        public string FullName { get; set; }
        public int ReqNo { get; set; }
        public string VamDate { set; get; }
        public long ColVamGst { get; set; }
        public long ColPasandaz { get; set; }
        public string Sharh { get; set; }
    }

}
